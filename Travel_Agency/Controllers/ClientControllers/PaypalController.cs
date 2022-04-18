using Entities.Models;
using MyDatabase;
using PayPal.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Item = Entities.Models.Item;
using System.Globalization;

namespace Travel_Agency.Controllers
{
    public class PaypalController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Paypal
        public ActionResult PaymentWithPaypal(string Cancel = null)
        {
            //getting the apiContext
            APIContext apiContext = PaypalConfiguration.GetAPIContext();
            try
            {
                //A resource representing a Payer that funds a payment Payment Method as paypal
                //Payer Id will be returned when payment proceeds or click to pay
                string payerId = Request.Params["PayerID"];
                if (string.IsNullOrEmpty(payerId))
                {
                    //this section will be executed first because PayerID doesn't exist
                    //it is returned by the create function call of the payment class
                    // Creating a payment
                    // baseURL is the url on which paypal sendsback the data.
                    string baseURI = Request.Url.Scheme + "://" + Request.Url.Authority + "/Paypal/PaymentWithPayPal?";
                    //here we are generating guid for storing the paymentID received in session
                    //which will be used in the payment execution
                    var guid = Convert.ToString((new Random()).Next(100000));
                    //CreatePayment function gives us the payment approval url
                    //on which payer is redirected for paypal account payment
                    var createdPayment = this.CreatePayment(apiContext, baseURI + "guid=" + guid);
                    //get links returned from paypal in response to Create function call
                    var links = createdPayment.links.GetEnumerator();
                    string paypalRedirectUrl = null;
                    while (links.MoveNext())
                    {
                        Links lnk = links.Current;
                        if (lnk.rel.ToLower().Trim().Equals("approval_url"))
                        {
                            //saving the payapalredirect URL to which user will be redirected for payment
                            paypalRedirectUrl = lnk.href;
                        }
                    }
                    // saving the paymentID in the key guid
                    Session.Add(guid, createdPayment.id);
                    return Redirect(paypalRedirectUrl);
                }
                else
                {

                    // This function exectues after receving all parameters for the payment
                    var guid = Request.Params["guid"];
                    var executedPayment = ExecutePayment(apiContext, payerId, Session[guid] as string);
                    //If executed payment failed then we will show payment failure message to user
                    if (executedPayment.state.ToLower() != "approved")
                    {
                    }
                }
            }
            catch (Exception ex)
            {
                var failureUrl = "/Booking/Create?cancel=true";
                return Redirect(failureUrl);
            }
            //Create and add booking at database
            var booking = (Booking)Session["lastBooking"];
            if (booking != null)
            {
                var user=  db.Users.Find(booking.ApplicationUser?.Id);
                if (user != null)
                {
                    booking.ApplicationUser = user;
                }
                db.Entry(booking).State = EntityState.Added;
                db.SaveChanges();
            }
            
            //on successful payment, show success page to user.
            return View("SuccessView", booking);
        }
        private PayPal.Api.Payment payment;
        private Payment ExecutePayment(APIContext apiContext, string payerId, string paymentId)
        {
            var paymentExecution = new PaymentExecution()
            {
                payer_id = payerId
            };
            this.payment = new Payment()
            {
                id = paymentId
            };
            return this.payment.Execute(apiContext, paymentExecution);
        }
        private Payment CreatePayment(APIContext apiContext, string redirectUrl)
        {
            //create itemlist and add item objects to it
            var itemList = new ItemList()
            {
                items = new List<PayPal.Api.Item>()
            };
            //Adding Item Details like name, currency, price etc
            var cart = (List<Item>)Session["cart"];
            decimal paypalTotal = 0;
            foreach (var item in cart)
            {
                var itemPrice = Math.Round(item.Package.FinalPrice() / 1.11M, 2, MidpointRounding.ToEven);

                paypalTotal += item.Package.FinalPrice() * item.Quantity;

                itemList.items.Add(new PayPal.Api.Item()
                {
                    name = item.Package.Title,
                    currency = "EUR",
                    price = itemPrice.ToString("N2", CultureInfo.InvariantCulture),
                    quantity = item.Quantity.ToString(),
                    sku = "sku"
                });
            }
            ViewBag.PackagesCost = paypalTotal;
            var payer = new Payer()
            {
                payment_method = "paypal"
            };
            // Configure Redirect Urls here with RedirectUrls object
            var redirUrls = new RedirectUrls()
            {
                cancel_url = redirectUrl + "&Cancel=true",
                return_url = redirectUrl
            };
            // Adding Tax, shipping and Subtotal details
            var paypalSubtotal = Math.Round(paypalTotal / 1.11M, 2, MidpointRounding.ToEven);
            var details = new Details()
            {
                tax = (paypalTotal - paypalSubtotal).ToString("N2", CultureInfo.InvariantCulture),
                //shipping = "1",
                subtotal = paypalSubtotal.ToString("N2", CultureInfo.InvariantCulture)
            };
            //Final amount with details
            var amount = new Amount()
            {
                currency = "EUR",
                total = paypalTotal.ToString("N2", CultureInfo.InvariantCulture), // Total must be equal to sum of tax, shipping and subtotal.
                details = details
            };
            var transactionList = new List<Transaction>();
            // Adding description about the transaction
            transactionList.Add(new Transaction()
            {
                description = "Transaction description",
                invoice_number = Guid.NewGuid().ToString(), //Generate an Invoice No
                amount = amount,
                item_list = itemList
            });
            this.payment = new Payment()
            {
                intent = "sale",
                payer = payer,
                transactions = transactionList,
                redirect_urls = redirUrls
            };
            // Create a payment using a APIContext
            return this.payment.Create(apiContext);

        }
    }
}