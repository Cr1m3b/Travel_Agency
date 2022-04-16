using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Entities.Models.Enums;
using Entities.Enums;
using Entities.IdentityUsers;

namespace MyDatabase.Seeding
{
    public class SeedingService
    {
        //Dependency Injection
        ApplicationDbContext db;
        public SeedingService(ApplicationDbContext context)
        {
            db = context;
        }

        //Implementation of Seeding Methods ex. public void SeedPackages()
        public void SeedPackages()
        {
            //Package Seeding
            #region Packages
            Package p1 = new Package() { Title = "Discover Barcelona ", 
                Description = "Barcelona is not famous only for its outstanding football team but also for the stunning architecture, lively nightlife, sandy beaches, and world class cuisine. Take the chance to explore the city!",
                Program = "Barcelona offers a large number of tourist attractions and cultural sights. So, for you in order to not miss anything a tour will take place the first two day to guide and tell the stories of the below landmarks:" +
                "- Sagrada Familia, Gaudí’s masterpiece and prime example of Catalan modernism. The Sagrada Familia (Church of the Holy Family) is the most popular sight in Barcelona. This large basilica is striking not only because of its whimsical shapes, but also because it is still under construction. " +
                "- The Hospital de la Santa Creu y de Sant Pau (Hospital of the Holy Cross and Saint Paul) is one of the largest complexes in Catalan modernist architecture. It was built between 1902 and 1930 following the design of architect Lluís Domènec i Montaner, and thanks to a donation made by banker Pau Gil i Serra. " +
                "- Park Güell offers the perfect surroundings to enjoy some modernist architecture and a pleasant stroll through the park at the same time. Designed by Gaudí under the patronage of entrepreneur Eusebi Güell, it was meant initially to be a housing development for Barcelona’s bourgeoisie. " +
                "- Casa Milà, popularly known as «La pedrera» («The Quarry») because of its stone façade resembling a quarry, is one of Gaudí’s most famous buildings." +
                "- Casa Batlló, Of all Gaudí’s works, Casa Batlló is probably the most fanciful one, and the one that impresses most with its play of shapes and colors. "+
                " - The Picasso Museum houses early works by the Spanish artist which show not only his evolution at the beginning of his career, but also his links with the city. "+
                "- The Museu Nacional d’Art de Catalunya is one of the most important art museums in Catalonia. "+
                "- The Church of Santa María del Mar is one of Barcelona’s little gems. "+
                "The next two day you can enjoy them the way you want and we suggest to take advantage of Barcelona's long coastline stretches which offers the tourists a wide variety of excellent beaches. The most popular are Barceloneta, Mar Bella, Nova Icaria and Bogatell. "+
                " Enjoy the local cuisine in small tranditional stores and of course for Barcelona fan you cannot miss the stadium Camp Nou.", 
                MainPhoto= "https://c.pxhere.com/photos/a9/f0/spain_barcelona_triumphal_arch_street_view_spain_landscape_building-642076.jpg!d", 
                TripDate = new DateTime(2022, 6, 12), 
                TripDuration = 4, Price = 476,
                Destinations = Destinations.Barcelona, PackageStatus = Status.Active };
            Package p2 = new Package() { Title = "Paris,the City of Light", 
                Description = "Paris is ideal for a romantic getaway or for those who want to explore the very beautiful french capital with its bustling museums and galleries,top cuisine, beautiful architecture and chic fashion. ", 
                Program = "What would Paris be without its symbolic Eiffel Tower? Built by Gustave Eiffel to commemorate the centenary of the French Revolution, it is presented at the Exposition Universelle in Paris in 1889. "+
                "One of the most enduring symbols of Paris: Notre-Dame de Paris, is widely considered one of the finest examples of French Gothic architecture in France and Europe. "+
                "Louvre Museum, its collection is divided into eight departments:Egyptian antiquities, Oriental antiquities ( Greek,Etruscan and Roman ), Islamic Art "+
                "Sculptures of the Middle Ages, Renaissance and Modern Times, Objects of art, Paintings, Graphic arts. Champs Elysées / Arc of Triumph: under the spell of ancient Roman architecture, "+
                "Napoleon commissioned Jean Chalgrin the design of a triumphal arch dedicated to the glory of imperial armies.Built in the 19th century, it is the largest monument of its kind in the world. "+
                "Cruise on the Seine: Find the best way to visit the 'City of Light' enjoying a cruise on the Seine, especially at night. When the sun sets,the monuments are lit slowly.You get a panoramic view to the forefront so you can enjoy the beauty of Paris: Eiffel Tower, Notre Dame, Pont Alexandre III and many more. "+
                " Montmartre is a hill located in the north of Paris, 130 meters high, having its name to the surrounding neighborhood.It is best known for the white-domed Basilica of the Sacred Heart, at the top. "+
                "Also you cannot miss The Château de Versailles which is the most famous castle in France. According to your preferences you can visit Disneyland, Moulin Rouge and many other monuments. "+
                "Don't miss the opportunity to taste the best quality wine in the world, have a coffee with a delicius french pastry and live a careless 3 days trip.", 
                MainPhoto= "https://fadeceilings.com/wp-content/uploads/2019/08/AdobeStock_65117955-720x460.jpeg", TripDate = new DateTime(2022, 5, 3), TripDuration = 3, Price = 699, Destinations = Destinations.Paris, PackageStatus = Status.Active };
            Package p3 = new Package() { Title = "Athens a historical treasure.", 
                Description = "The Classical Era is still evident in the city, represented by ancient monuments, works of art with the most famous of all being the Parthenon.", 
                Program = "First day is decicated to Acropolis and the area around it. At nine in the morning the group will meet with the tour guide at the entrance of Acropolis. The Acropolis is on an abrupt rocky outcrop above the city and has world-renowned Classical landmarks that people spend whole lifetimes waiting to see in the flesh."+
                "On top of the hill you will see the majestic Parthenon. The Parthenon was dedicated to the goddess Athena and begun in 447 BC, when the Athenian Empire was the dominant force in the Aegean, but of course you will find out more during your visit there. Next to the list is Acropolis Museum, which of course it will amaze."+
                "The afternoon is free for you to have lunch and coffee at Monastiraki square. The second day you decide in which way you want to experience the Athenian city life, even though we suggest you to visit the National Archaeological Museum and the Museum of Cycladic Art. "+
                "Third and last day a trip to 'Sounio' will take place so to visit Poseidon temple and you will have the possibility to admire the view from up there. "+
                "Activities will be organised so to have an amazing time at the area.",
                MainPhoto = "https://c.pxhere.com/photos/a9/a9/temple_athens_greece_architecture_ancient_greek_history_culture-763875.jpg!s1", 
                TripDate = new DateTime(2022, 9, 1),Discount=25, TripDuration = 3, Price = 400, Destinations = Destinations.Athens, PackageStatus = Status.Active
            };
            Package p4 = new Package()
            {
                Title = "London, the city that can give all!",
                Description = "London's vibrant culture is this melting pot of cultures, nationalities, and languages – which makes London so attractive to travelers worldwide.",
                Program = "London is a modern, innovative, and iconic city, steeped in history. It’s famous for its historic palaces and magnificent landmarks, world-class museums, iconic attractions and events, picturesque parks and gardens. " +
                "This city always surprises... From Camden’s punky vibe to leafy Hampstead Heath and historic Big Ben, London’s incomparable blend of influences, traditions and history make it an unmissable destination for travellers. Get your culture fix at world-renowned venues like the Natural History Museum or savour award-winning cuisines in Chinatown, Little Venice and Brick Lane.  Satisfy your inner shopaholic with vintage finds in Portobello Road or catch the latest bands at legendary venues like Wembley Stadium. Whether you want to watch some of the world’s finest acting talent in the West End, spot squirrels in Royal Parks or soak up the scenery in Greenwich with a pint of local ale, Britain’s biggest city has it all – and then some!" +
                "London boasts some truly epic nightlife too, but we’re not just talking about bars and clubs. After dark, Secret Adventures runs moonlit kayaking trips on the River Thames, while the Science Museum and V&A open for exclusive late-night events (selected dates). On summer evenings, the Rooftop Film Club screens outdoor movies at locations in east and south London, while the Open Air Theatre stages everything from West End musicals to Shakespeare plays in the leafy grounds of Regent’s Park.",
                MainPhoto = "https://c.pxhere.com/photos/29/2d/london_parliament_england_ben_ben_westminster_tower_city_british-772846.jpg!d",
                TripDate = new DateTime(2022, 1, 12),
                TripDuration = 4,
                Price = 420,
                Destinations = Destinations.London,
                PackageStatus = Status.Expired
            };
            Package p5 = new Package()
            {
                Title = "Rome, the Eternal City",
                Description = "In Rome you can find not only numerous masterpieces of the world's most influential artists, as well as impressive architecture manifesting the greatness of the Roman Empire.",
                Program = "Four days in Rome are more than enough to experience the italian life style, taste the delicius italian cuisine and party all night long. But don't miss visiting also Rome's famous monuments.  " +
                "Colosseum, Rome’s most internationally recognized symbol. Gaze at the Architectural Marvel That Is the Pantheon. Transport Yourself to Baroque Rome at Piazza Navona. Pay Your Respects to the Vatican and Its Museums " +
"You could easily spend a whole day exploring the area around the Vatican. Start at the Piazza di San Pietro, which Bernini designed to look like arms extended in an embrace. Besides St. Peter’s Basilica, the absolute must-see is the Vatican Museums, which contain Michelangelo’s Sistine Chapel. Climb the Spanish Steps " +
"Fascinating in its contradictions,  the Piazza di Spagna is both democratic and home to the city’s fanciest boutiques on Via dei Condotti, Rome’s legendary shopping street. In Latin, Trastevere means “across the Tiber,” and you’ll notice the difference once you cross the river. The vibe is hip and bohemian, and you’ll find plenty of boutiques selling jewelry, perfumes, and handicrafts in a neighborhood where you can stroll aimlessly along cobblestone streets flanked by ochre-colored buildings. " +
"And of course don't miss the Trevi Fountain and throw a coin in becuase any trip to Rome would be incomplete without a visit to the Trevi Fountain.Nicola Salvi’s inspiring Baroque masterpiece features a marble statue of Neptune at the center, surrounded by tritons. " +
"In conclusion, one of Rome’s great joys is losing yourself in the narrow cobblestone streets that make up Centro Storico. Starting at Piazza del Popolo, three main roads form a trident leading toward Piazza Venezia and the Colosseum. Branching off are countless streets and alleyways where you’ll find churches with Baroque art, boutiques selling everything from carved wooden figurines to precious jewelry, private courtyards where the wealthiest Romans live, enticing gelaterias, cafés, and restaurants. Take your time and do as the Romans do—this is what la dolce vita is all about.",
                MainPhoto = "https://c.pxhere.com/photos/a9/4e/colosseum_rome_italy_roman_architecture_landmark_italian_tourism-744892.jpg!d",
                TripDate = new DateTime(2021, 5, 12),
                TripDuration = 4,
                Price = 529,
                Destinations = Destinations.Rome,
                PackageStatus = Status.Active
            };
            Package p6 = new Package()
            {
                Title = "Enjoy the colorfull Lisbon",
                Description = "Lisbon, the town of sunny weather, great nightlife, colorful buildings, Fado music and friendly locals.",
                Program = "Once in Lisbon you cannot miss the Torre de Belém. Soaring high above the seafront of the Lisbon quays, this great tower displays a veritable fusion of architectural styles from the Mudejar to the Moorish, the Gothic to the Romanesque. It has stood watch over the mouth of the Tagus River since its construction under the patronage of Saint John back in the 16th century. " +
                "Since then, it has risen to become perhaps the most iconic feature of the city, famed as the last sight adventurers like the prodigal Vasco da Gama would have seen as they drifted out into the vast Atlantic Ocean. " +
                "Ride Tram 28, Like San Francisco in the United States, Lisbon is a city famed for its historic, rattling tram lines. None are more iconic than Tram 28 which has been working its way up the steep, cobbled roads and into the old Alfama district for decades. The journey starts below the palm - spotted hills of Graça, and weaves toward the hair - pin alleys of Escolas Gerais, before pulling up to a halt beneath the gorgeous domes of the Estrela Basilica. " +
                "Get lost in the Alfama District, The compact little Alfama District is Lisbon’s answer to the old town centers of Europe’s other ancient capitals. Like the Forum of Rome, it’s hailed as the oldest part of the city, although this one dates back to the Moors of Africa instead of the kings of Latium. Conquer the bulwarks of St George’s Castle. St George’s Castle is unquestionably the most visible landmark of Lisbon’s historic center. " +
"Standing tall and firm above the streets of the old Alfama District, the great citadel was first built more than 2000 years ago by the Romans. Trace glorious history in the Monastery of Jerónimos. Go underwater in the Lisbon Oceanarium. Find your inner explorer at the Padrão dos Descobrimentos, marks the shore of the Tagus Estuary with its grand architecture and beige stone. It’s been here since the early 1960s and is an ornate testimony to the successes of Portuguese exploration during the Age of Discovery. " +
"And of course The Sanctuary of Christ the King (Portuguese: Santuário de Cristo Rei) is a Catholic monument and shrine dedicated to the Sacred Heart of Jesus Christ overlooking the city of Lisbon situated in Almada, in Portugal.",
                MainPhoto = "https://www.nationsonline.org/gallery/Portugal/Praca-do-Comercio-Lisbon.jpg", TripDate = new DateTime(2022, 4, 30), TripDuration = 3, Price = 329, Discount=10, Destinations = Destinations.Lisbon, PackageStatus = Status.Active };
            Package p7 = new Package() { Title = "Cappadocia, a moon-like landscape", 
                Description = "Cappadocia is rich in both history and culture. In a way, it will give you a taste of what its like to be in the Disney's Aladdin film. With a backdrop of pretty pastel hues that you'd only see in paintings – Cappadocia will give you a surreal experience with its jaw-dropping view.",
                Program = "Cappadocia is the land of fairy tales, so if you’re looking for the best things to do in Cappadocia, look no further. You shouldn’t miss ANY!"+
                "Cappadocia is synonumus to an air baloon ride and this activity has to climb up the to do list. But those of you, who are afraid of heights don't worry.You can gaze at them since over 150 balloons go up almost every day. Just relax and watch the Air - Balloons from a rooftop. Visit the Churches of Göreme Open-Air Museum which are just outside the village of Göreme. It is one of  UNESCO' s World Heritage site the Göreme Open-Air Museum, a monastery cluster of rock-cut churches and monk cells that hold fabulous frescoes. "+
                "Hike or Horse Ride in Red and Rose Valleys, Cappadocia's most beautiful intertwining valleys lie between the villages of Göreme and Çavusin. Explore the Village of Göreme. Cappadocia's underground cities first began to be chiseled out of the ground in the Bronze Age Hittite era, but they are most famous for their early Byzantine history (6th and 7th centuries), when the region's Christians took to living underground for long periods to escape from Arab and Persian invaders. "+
                "Hike Ihlara Valley, The narrow, verdant valley at the bottom of this deep (100 meters) gorge in southwest Cappadocia is a nature lover's delight. Hemmed in by rugged, steep cliffs, Ihlara Valley is a lush Eden of tall poplar trees and fertile farming plots beside the babbling Melendiz River, which runs for 14 kilometers from Selime village to Ihlara village. Our advise visit also Kayseri which is a bustling city and has a handful of interesting Seljuk and Ottoman monuments.", 
                MainPhoto = "https://d1hjkbq40fs2x4.cloudfront.net/2020-12-07/files/16072849260.jpg", TripDate = new DateTime(2022, 8, 15), TripDuration = 5, Price = 633, Discount = 20, Destinations = Destinations.Cappadocia, PackageStatus = Status.Active };
            Package p8 = new Package() { Title = "Uzbekistan a trip back in time",
                Description = "Uzbekistan is full of unreal beauty, and it looks exactly the way that it's depicted in the stunning photographs you see of its cities. ",
                Program = "Uzbekistan is not a famous destination, so here are some reasons for you to give to this place a chance. "+
                "WELCOMING PEOPLE It’s rare to find a country full of people who are so excited to befriend foreigners! "+
                "ANCIENT HISTORY Uzbekistan is home to many famous cities along the Silk Road, and it still has remnants of when it was a part of the Soviet Union. "+
                "BEAUTIFUL BLUE TILES The mosques are covered in gorgeous blue tiles, making for lots of great photo ops. And that’s especially true if you get outside before sunrise, when the city is just waking up! " +
                "AMAZING FOOD The national dish 'plov'  is made from rice mixed with veggies and meat, and it’s delicious. So are Lagman noodles, which are similar to ramen but taste better."+
                "INCREDIBLE SHOPPING This is a given, since you’re traveling along the Silk Road itself.You can find carpets, silks, wood carvings; jewelry, and scarves, all of which make for perfect souvenirs"+
                "STUNNING WAYS OF LIFE Everywhere you look, you’ll find something unique! From the way the people dress to what they eat and where they live, there’s plenty to see here."+
                "GORGEOUS (AND DIVERSE) SCENERY Uzbekistan doesn’t just consist of cities and mosques — its borders also contain forests, mountains, deserts, and so much more.",
                MainPhoto = "https://www.wildfrontierstravel.com/media/cache/page_image_large/upload/cc/70f7ab08/PSX_20211119_103834.jpeg", TripDate = new DateTime(2022, 10, 12), TripDuration = 7, Price = 900, Discount = 20, Destinations = Destinations.Cappadocia, PackageStatus = Status.Active };
            Package p9 = new Package() { Title = "Prague, a gothic city.",
            Description= "Luxury Prague Holiday w/ Unlimited access to Sauna & Welcome Drink Inc. Dinner cruise on open top glass boat. ",
                Program = "First day the group will explore the old Town Square, visit the Infant Jesus of Prague and of course watch the Astronomical Clock which strikes every hour. "+
                
                "Second day a nice stroll will take place from the hotel till Charles Bridge after visit Prague Castle and in the end visit St Vitus. "+
                "The afternoon is free for you to enjoy the city. "+
                "Third and last day a Cruise on the Vltava will amaze.",
                MainPhoto = "https://www.thetrainline.com/content/vul/hero-images/city/prague/2x.jpg",
                TripDate = new DateTime(2022, 06, 12),
                TripDuration = 3,
                Price = 567,
                Destinations = Destinations.Prague,
                PackageStatus = Status.Active

            };
            Package p10 = new Package() { Title = "Iceland- Blue Lagoon ",
            Description = "Experience an astonishing getaway in Iceland with a one life experience tour of the blue lagoon",
            Program= "First day hiking to the most beautiful part of Iceland the Kirkjufell mountain (Church Mountain) which is the most photographed place in Iceland and a natural icon on its own."+
            " Second day is dedicated to the blue lagoon relaxation time. There you can enjoy the natural beauty of Iceland experiencing in warm to hot water the views and the lifestyle of locals. Of course at midnight a tour will take place to stare  the Northern Lights , the phenomenon of aurora borealis."+
            "Third and fourth days are free for you to enjoy Reykjavik.",
                MainPhoto = "https://blog.goway.com/globetrotting/wp-content/uploads/2019/10/Blue-Lagoon-at-night-with-Northern-Lights-Iceland-_730839646.jpg",
                TripDate = new DateTime(2022, 09, 30),
                TripDuration = 4,
                Price = 780,
                Destinations = Destinations.Iceland,
                PackageStatus = Status.Active

            };
            Package p11 = new Package()
            {
                Title = "Amsterdam -Light Festival ",
                Description= "Enjoy the Incredible Light Festival with evening Canal Cruise",
                Program= "First day is dedicated to visit the town, spending 3 hours in Van's Gogh Museam and in the evening experience a luxurious Canal Cruise" +
                "Second day a trip to country side will take place to see the windmills and enjoy the countryside and beaches. "+
                "Next day the group will visit the museums & majestic buildings in Museumplein "+
                "and last two days are free for travellers to enjoy Amsterdam on their on pace.",
                MainPhoto = "https://www.inexhibit.com/wp-content/uploads/2019/11/Amsterdam-light-fest-2019-masamichi-shimada-butterfly-870x580.jpg",
                TripDate = new DateTime(2022, 07, 12),
                TripDuration = 5,
                Price = 655,
                Destinations = Destinations.Amsterdam,
                PackageStatus = Status.Active
            };
            Package p12 = new Package()
            {
                Title = "Island Destination: Paros",
                Description = "Summer vacation in  greek aegean island: Paros",
                Program = "This destination has a free style schedule that you costumise it according to your prefferences, we recommend you to visit the beaches Punta beach, Kolibithres and Xrisi Akti " +
                "In the package is included one day  enjoying a cruise around the island and one day visiting the close island Naxos.",
                MainPhoto = "https://www.discovergreece.com/sites/default/files/styles/hd_half/public/2019-12/1alt_naoussas_tiny_harbour_with_restaurants_bars_and_the_old_castle-edited-1.jpg?itok=Sy_wXhyB",
                TripDate = new DateTime(2022, 07, 20),
                TripDuration = 10,
                Price = 800,
                Destinations = Destinations.Paros,
                PackageStatus = Status.Active
            };
            Package p13 = new Package()
            {
                Title = "Island Destination: Kerkura",
                Description = "Summer vacation in  greek Ionian island: Kerkura",
                Program = "In this trip you will have the opportunity to visit princess´s Sissy summer palace Achilleion, Pontikonisi a quite place next to the sea, the Royal Palace: Museum of Asian Art " +
                " the  Old Fortress (Citadel) with amazing view and of course to wander the cosmopolitan city. There is a big variety of beaches to choose accordinrding to your style like  Paleokastritsa a small bay, Kavos a busy place full of people that they want to have an amazing time while listening to party music, Barbati a very natural virgin beauty or Marathias the beach with crystalline waters and golden sand.  ",
                MainPhoto = "https://www.atlantis-hotel-corfu.com/assets/img/corfu/beaches/slideshow.jpg",
                TripDate = new DateTime(2022, 07, 29),
                TripDuration = 6,
                Price = 950,
                Destinations = Destinations.Kerkyra,
                PackageStatus = Status.Active
            };
            Package p14 = new Package()
            {
                Title = "Luxurious holidays in Cancun",
                Description = "Cancun the mexican city known for its spectacular beaches of fine white sand, its fascinating turquoise blue sea and unparalleled weather.",
                Program = "Places that worth a visit in Cancun, Mexico are: the Xcaret amusement park which is one of the largest theme parks in Mexico which holds more than 40 attractions including adventurous aquatic activities, fun, and educational natural and cultural attractions, and impressive live shows." +
                " Climb Coba Ruins so to walk through the ruins and see networks of stone streets, monuments that were carved over 1200 years ago, pyramids, everyday dwellings and even traditional ball courts. " +
                "Relax at Playa Delfines where you will be able to find a quiet spot of your own along the wide stretch of sand and even some shade under one of the many umbrellas. And of course party at Coco Bongo It is not your typical nightclub with a dance floor, although there are plenty of those in the city, but rather a venue that provides high energy entertainment and music and of course flowing drinks. " +
                " If nothing of the above seems appealing don't worry beacause you can enjoy the maximum at the All Inclusive Resort 'Excellence Playa Mujeres - Adults Only All Inclusive'. ",
                MainPhoto = "https://images.trvl-media.com/hotels/2000000/1680000/1672500/1672497/b11e8c54.jpg?impolicy=resizecrop&rw=598&ra=fit",
                TripDate = new DateTime(2022, 12, 15),
                TripDuration = 10,
                Price = 1450,
                Destinations = Destinations.Cancun,
                PackageStatus = Status.Active
            };
            Package p15 = new Package()
            {
                Title = "Ski break in Andorra",
                Description = "The best ski break to ski, party and meet new people.",
                Program = "This trip is ideal for everyone, even for people that never skiied as the resort is beginner & intermediate ski level friendly but also are a few quality advanced pistes & off-piste freeride options for the adventurous. " +
                "For three days very early in the monring till late in the afternoon you can enjoy skiing, have drinks and meals at the small saloon near the pistes party outdoors. The hotel provides also spa day for those who seek a peaceful and relaxing time.",
                MainPhoto = "https://d19tiqumqauva7.cloudfront.net/var/andorra/storage/images/_aliases/intro_slide/www.andorra.ad/multimedia/galeria/esqui/activitats-hivern-estacions/esquiar-a-ordino-arcalis/1906x960_ordino-arcalis/26927200-20-eng-US/1906x960_ordino-arcalis.jpg",
                TripDate = new DateTime(2023, 01, 15),
                TripDuration = 3,
                Price = 300,
                Destinations = Destinations.Andorra,
                PackageStatus = Status.Active
            };
            Package p16 = new Package()
            {
                Title = "Christmas at Mauritius island",
                Description = "Summer vacation in the heart of winter for those who seek relaxation next to sea ",
                Program = "This trip gives you the opportunity for an alternative way to celebrate Christmas. Time spent here is truly relaxing, and a unique experience that you can only have off the coast of Africa. Mauritius has a marvellous blend of cultures, welcoming people and a huge mix of ethnic communities. The local cuisine will not disappoint you since is one of the most diverse in the world, with influences from French, Indian, African and Asian kitchens coming together to create its unique flavours. Don't miss Sega, which is an invigorating traditional dance that originated in Africa and is regularly performed around the island. And last but not least if you are seeking adrenaline-boosting activities you can go zip lining or hiking through the rainforest, try canyoning in the waterfalls or take to the water and explore every kind of ocean-based sport available.",
                MainPhoto = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQgjKZ_mkHzF63grZcbNka2fIdnSio0mYZ_oQ&usqp=CAU",
                TripDate = new DateTime(2022, 12, 23),
                TripDuration = 5,
                Price = 1800,
                Destinations = Destinations.Mauritius,
                PackageStatus = Status.Active
            };
            Package p17 = new Package()
            {
                Title = "Island Destination: Mallorca",
                Description = "Summer vacation in the largest Balearic island of Spain.",
                Program = "First Day since the arrival is late in the evening the group meets in the center of Palma de Mallorca so to have dinner and after according to your prefference you can party in El Arenal or to have a quite drink by the beach.  " +
                " Second day early in the morning a visit to Mirador Es Colomer Formentor is essential and after lunch and coffee in the little village del Sol. " +
                "The rest of the days are about relaxing and enjoying sun at Playa d'Alcudia ",
                MainPhoto = "https://www.galeria-reisen.de/static/cr/412/200/imgpath/temp/fileadmin/style/images/region_big/GKK-urlaub-spanien-inseln-mallorca-1200x360-mallorca-blaue-bucht.jpeg",
                TripDate = new DateTime(2022, 06, 29),
                TripDuration = 5,
                Discount = 22,
                Price = 900,
                Destinations = Destinations.Mallorca,
                PackageStatus = Status.Active
            };
            Package p18 = new Package()
            {
                Title = "Visit cosmopolitan Dubai",
                Description = "Dubai is a destination that offers everything a visitor desires, either that is enjoying a sunny day at the beach, shopping or skiing in the mall.",
                Program = "Dubai is known for its abundant wealth, luxury shopping, lively nightlife, and state of the art architecture, such as the Burj Khalifa.Its blue - green waters, white sandy beaches, and ever changing skyline never fail to impress.Shopaholics visiting Dubai are nearly guaranteed to fall in love with Dubai’s rich shopping experience." +
                 "THE WEALTHY CITY-STATE BOASTS A LIVELY NIGHTLIFE and when it comes to nightlife, Dubai comes out on top.The environment in Dubai is ideal for the night scene, from viewing the incredible city state from the top of the Burj Khalifa to clubbing in the many upscale lounges.",
                MainPhoto = "https://www.travel-time.gr/wp-content/uploads/2021/09/1_2994_02.jpg",
                TripDate = new DateTime(2022, 11, 25),
                TripDuration = 3,
                Price = 450,
                Destinations = Destinations.Dubai,
                PackageStatus = Status.Active
            };
            Package p19 = new Package()
            {
                Title = "Zurich not a boring destination",
                Description = "Zurich is well known as the financial capital of Switzerland but don't underestimate the possibillities this urban center has to offer!",
                Program = "Zürich’s sights, eye-wateringly pricey shops and effortlessly cool nightspots are in the Altstadt, a historic centre cut in two by the Limmat river which flows off the lake. So first stop is the famous lake which curves past the wooded peaks of Pfannenstiel to the east and the Albis chain to the west. A bit further, near to the Schauspielhaus on Heimplatz is Zürich’s phenomenal Museum of Art." +
                "Altstadt the Old Town with the medieval and early modern streets of the Altstadt are where much of the city’s culture, nightlife and shopping is concentrated. It’s one of those places you’re happy to get lost in, to chance upon squares, cafes, quirky one-of-a-kind shops and all manner of historic monuments from the four medieval churches to 17th-century Town Hall. " +
                "Don't miss FIFA’s long-mooted museum, which is in the Enge quarter and opened in 2016. It occupies three floors of a mixed-use development and has a swish layout. And last but no least the Zürich Opera House. The resplendent Neoclassical Opera House at Sechseläutenplatz dates to the 1890s and was conceived by the prolific Viennese architects Fellner & Helmer and definitely worths a visit.",
                MainPhoto = "https://upload.wikimedia.org/wikipedia/commons/7/76/Z%C3%BCrich.jpg",
                TripDate = new DateTime(2022, 08, 5),
                TripDuration = 3,
                Price = 500,
                Destinations = Destinations.Zurich,
                PackageStatus = Status.Active
            };
            Package p20 = new Package()
            {
                Title = "Milan, a city that has it all!",
                Description = "Milan, one of Italy's most fashionable cities and the majestic Duomo Cathedral ",
                Program = "Today Milan offers a sublime mix of historical architecture, modern high-rise skyscrapers, all mingled together with a dash of Italian life. The city is particularly known for its abundance of high end fashion retailers and the beautiful Duomo Cathedral which is famed for its sublime architecture that took over 600 years to complete." +
                "Second stop the Grand Galleria Vittorio Emanuele II, which seems inside like the entrance hall to an opera house or palace but is an extremely opulent and extravagant indoor shopping area." +
                "Castello Sforzesco certainly worths a visit. This 15th century castle has a central location in Milan and is set in extensive grounds and gardens. Leonardo da Vinci National Museum of Science and Technology " +
                "is one of the most important museums in the world. There you can expect to find such collections as a myriad of model cars created from da Vinci drawings, reconstructions of his flying machines, and a plethora of his drawings, blueprints and sketches." +
                "Town has many touristic attractions but don't forget to go to Piazza del Duomo, is an immense open public space that features some impressive architecture and sculptures where you can view the wonderful Duomo and surrounding buildings.",
                MainPhoto = "https://cdn.thecrazytourist.com/wp-content/uploads/2017/03/Milan-Cathedral.jpg",
                TripDate = new DateTime(2022, 06, 5),
                TripDuration = 2,
                Price = 300,
                Destinations = Destinations.Milan,
                PackageStatus = Status.Active
            };
            Package p21 = new Package()
            {
                Title = "Madrid, a magical city for art lovers. ",
                Description = "If you admire and want to see from short distance paintings from Dali, Picasso and other famous painters then Madrid is the perfect city for you!",
                Program = "Madrid a city, known for its historical buildings, food markets, and the royals.It's also known for its renaissance and contemporary art museums, sunny blue skies, unique neighborhoods, and bustling nightlife. Madrid is a city of joy and life." +
               "The Reina Sofía Museum is one of the most important museums in Madrid and offers visitors an extensive collection of Spanish contemporary art. It features paintings by renowned Spanish artists such as Picasso, Salvador Dalí and Joan Miró." +
               "Museo del Prado,an other famous museum, is the most renowned one in the city and one of the most important art museums in the whole world. The building is the work of Juan de Villanueva and was inaugurated in 1819." +
               "Madrid has also many monuments that worth to be seen. Puerta del Sol, literally “door of the sun”, is one of the most famous squares in Madrid and a meeting point for locals and tourists alike. It’s the center of the city and the first stop for most visitors." + "" +
               "Plaza Mayor is located just a few meters from Puerta del Sol and the Royal Palace. Designed by Juan de Herrera and Juan Gómez de Mora in the Baroque style, it is another of Madrid’s must-sees." +
               "The Royal Palace of Madrid was built in the 18th century and is the official residence of the Spanish Royal Family. Gran Vía, the most famous boulevard of Madrid, was built between 1910 and 1929 to connect the Salamanca and Argüelles neighborhoods. It’s filled with shops, restaurants, and some of the city’s most iconic buildings, like the Metropolis or the Carrion building with the famous Schweppes sign. " +
               "Parque del Retiro is Madrid’s most famous park and, since opening to the public in 1868, it has become a backwater of history and peace. " +
               "Templo de Debod (Debod’s Temple) is one of the biggest hidden treasures of Madrid. The temple was originally from Egypt and over 2,200 years old. It was later gifted to Spain as a thank you gift for their help with rescuing the temples of Nubia. " +
               "Puerta de Alcalá is one of the most representative and photographed monuments of Madrid. It’s a neo-classical arch, located at the beginning of Calle Alcalá, in Plaza de la Independencia, close to one of Parque del Retiro’s entrances. " +
               "Santiago Bernabéu is the stadium of Real Madrid, a soccer club loved by some and hated by others. It is one of the most visited places in the city, with more than 1 million visitors per year. " +
               "For those who want to try local cuisine, right next to Plaza Mayor, you’ll find the historic Mercado de San Miguel, is a lovely gastronomic space that preserves its original iron structure of the early 20th century.",
                MainPhoto = "https://www.thomascook.com/.imaging/mte/thomascook-theme/og-image/dam/uk/holidays/city-breaks/madrid-desktop.jpg/jcr:content/madrid-desktop.jpg",
                TripDate = new DateTime(2022, 05, 5),
                TripDuration = 4,
                Price = 580,
                Destinations = Destinations.Madrid,
                PackageStatus = Status.Active
            };
            Package p22 = new Package()
            {
                Title = "Zakinthos, the greek paradise!",
                Description = "The appeal of Zakinthos is the nature, the colours, the dramatic and unspoilt beaches with their white pebbles and electric blue waters. The pristine coast and perfect winds for exploring by various waterborne craft, with several tiny uninhabited islands to explore.",
                Program = "The first beach that crosses the mind of someone listening the word Zakinthos is Navagio (Shipwreck Cove). " +
                "On the white beach there are the rusting remains of the MV Panagiotis, a container ship that ran aground in 1980. " +
                "Kalamaki Beach, one of a few beaches that we’ll mention in the Greek National Marine Park. Kalamaki is on the eastern pocket of Laganas Bay and could be the best on the island. " +
                "Blue Caves, the little harbour at Skinari in the very north of Zakynthos is the point of departure for trips to the Blue Caves, also only accessed by water. " +
                "Porto Limnionas Beach, a newly laid road from the village of Agios Leon weaves down to this fjord on the west coast, bounded on its east side by high white cliffs hollowed with caves. " +
"Resting above the fjord on the western slope is a taverna with tables and sun loungers on terraces where you gaze into the pristine blue water. Marathonisi, this islet in Laganas Bay in the south of Zakythos is often called Turtle Island, as it’s a hatching ground for the loggerhead sea turtle. " +
"For that reason Marathonisi is uninhabited and visitors have to clear the sandy beach to the north before sunset in summer to allow the turtles to come ashore to lay their eggs. " +
"At the villages on the south coast like Limni Keriou, Agios Sostis and Laganas you can book a boat tour along the indented coastline in the far south of the island and see the Keri Caves." +
"In the island there are also many monasteries, Keri Lighthouse, Askos Stone Park and many other places. You can make your one programm according to your preferences and use the private car that we provide. ",
                MainPhoto = "https://www.diplomattravel.gr/wp-content/uploads/2019/03/zakynthos-beach.jpg",
                TripDate = new DateTime(2022, 07, 25),
                TripDuration = 7,
                Price = 850,
                Destinations = Destinations.Zakunthos,
                PackageStatus = Status.Active
            };
            Package p23 = new Package()
            {
                Title = "Discover Barcelona ",
                Description = "Barcelona is not famous only for its outstanding football team but also for the stunning architecture, lively nightlife, sandy beaches, and world class cuisine. Take the chance to explore the city!",
                Program = "Barcelona offers a large number of tourist attractions and cultural sights. So, for you in order to not miss anything a tour will take place the first two day to guide and tell the stories of the below landmarks:" +
               "- Sagrada Familia, Gaudí’s masterpiece and prime example of Catalan modernism. The Sagrada Familia (Church of the Holy Family) is the most popular sight in Barcelona. This large basilica is striking not only because of its whimsical shapes, but also because it is still under construction. " +
               "- The Hospital de la Santa Creu y de Sant Pau (Hospital of the Holy Cross and Saint Paul) is one of the largest complexes in Catalan modernist architecture. It was built between 1902 and 1930 following the design of architect Lluís Domènec i Montaner, and thanks to a donation made by banker Pau Gil i Serra. " +
               "- Park Güell offers the perfect surroundings to enjoy some modernist architecture and a pleasant stroll through the park at the same time. Designed by Gaudí under the patronage of entrepreneur Eusebi Güell, it was meant initially to be a housing development for Barcelona’s bourgeoisie. " +
               "- Casa Milà, popularly known as «La pedrera» («The Quarry») because of its stone façade resembling a quarry, is one of Gaudí’s most famous buildings." +
               "- Casa Batlló, Of all Gaudí’s works, Casa Batlló is probably the most fanciful one, and the one that impresses most with its play of shapes and colors. " +
               " - The Picasso Museum houses early works by the Spanish artist which show not only his evolution at the beginning of his career, but also his links with the city. " +
               "- The Museu Nacional d’Art de Catalunya is one of the most important art museums in Catalonia. " +
               "- The Church of Santa María del Mar is one of Barcelona’s little gems. " +
               "The next two day you can enjoy them the way you want and we suggest to take advantage of Barcelona's long coastline stretches which offers the tourists a wide variety of excellent beaches. The most popular are Barceloneta, Mar Bella, Nova Icaria and Bogatell. " +
               " Enjoy the local cuisine in small tranditional stores and of course for Barcelona fan you cannot miss the stadium Camp Nou.",
                MainPhoto = "https://c.pxhere.com/photos/a9/f0/spain_barcelona_triumphal_arch_street_view_spain_landscape_building-642076.jpg!d",
                TripDate = new DateTime(2021, 6, 12),
                TripDuration = 4,
                Price = 476,
                Destinations = Destinations.Barcelona,
                PackageStatus = Status.Expired
            };
            Package p24 = new Package()
            {
                Title = "Milan, a city that has it all!",
                Description = "Milan, one of Italy's most fashionable cities and the majestic Duomo Cathedral ",
                Program = "Today Milan offers a sublime mix of historical architecture, modern high-rise skyscrapers, all mingled together with a dash of Italian life. The city is particularly known for its abundance of high end fashion retailers and the beautiful Duomo Cathedral which is famed for its sublime architecture that took over 600 years to complete." +
               "Second stop the Grand Galleria Vittorio Emanuele II, which seems inside like the entrance hall to an opera house or palace but is an extremely opulent and extravagant indoor shopping area." +
               "Castello Sforzesco certainly worths a visit. This 15th century castle has a central location in Milan and is set in extensive grounds and gardens. Leonardo da Vinci National Museum of Science and Technology " +
               "is one of the most important museums in the world. There you can expect to find such collections as a myriad of model cars created from da Vinci drawings, reconstructions of his flying machines, and a plethora of his drawings, blueprints and sketches." +
               "Town has many touristic attractions but don't forget to go to Piazza del Duomo, is an immense open public space that features some impressive architecture and sculptures where you can view the wonderful Duomo and surrounding buildings.",
                MainPhoto = "https://cdn.thecrazytourist.com/wp-content/uploads/2017/03/Milan-Cathedral.jpg",
                TripDate = new DateTime(2022, 01, 12),
                TripDuration = 2,
                Price = 300,
                Destinations = Destinations.Milan,
                PackageStatus = Status.Expired
            };
            Package p25 = new Package()
            {
                Title = "Island Destination: Mallorca",
                Description = "Summer vacation in the largest Balearic island of Spain.",
                Program = "First Day since the arrival is late in the evening the group meets in the center of Palma de Mallorca so to have dinner and after according to your prefference you can party in El Arenal or to have a quite drink by the beach.  " +
              " Second day early in the morning a visit to Mirador Es Colomer Formentor is essential and after lunch and coffee in the little village del Sol. " +
              "The rest of the days are about relaxing and enjoying sun at Playa d'Alcudia ",
                MainPhoto = "https://www.galeria-reisen.de/static/cr/412/200/imgpath/temp/fileadmin/style/images/region_big/GKK-urlaub-spanien-inseln-mallorca-1200x360-mallorca-blaue-bucht.jpeg",
                TripDate = new DateTime(2021, 06, 29),
               
                TripDuration = 5,
                Price = 900,
                Destinations = Destinations.Mallorca,
                PackageStatus = Status.Expired
            };
            Package p26 = new Package()
            {
                Title = "London, the city that can give all!",
                Description = "London's vibrant culture is this melting pot of cultures, nationalities, and languages – which makes London so attractive to travelers worldwide.",
                Program = "London is a modern, innovative, and iconic city, steeped in history. It’s famous for its historic palaces and magnificent landmarks, world-class museums, iconic attractions and events, picturesque parks and gardens. " +
              "This city always surprises... From Camden’s punky vibe to leafy Hampstead Heath and historic Big Ben, London’s incomparable blend of influences, traditions and history make it an unmissable destination for travellers. Get your culture fix at world-renowned venues like the Natural History Museum or savour award-winning cuisines in Chinatown, Little Venice and Brick Lane.  Satisfy your inner shopaholic with vintage finds in Portobello Road or catch the latest bands at legendary venues like Wembley Stadium. Whether you want to watch some of the world’s finest acting talent in the West End, spot squirrels in Royal Parks or soak up the scenery in Greenwich with a pint of local ale, Britain’s biggest city has it all – and then some!" +
              "London boasts some truly epic nightlife too, but we’re not just talking about bars and clubs. After dark, Secret Adventures runs moonlit kayaking trips on the River Thames, while the Science Museum and V&A open for exclusive late-night events (selected dates). On summer evenings, the Rooftop Film Club screens outdoor movies at locations in east and south London, while the Open Air Theatre stages everything from West End musicals to Shakespeare plays in the leafy grounds of Regent’s Park.",
                MainPhoto = "https://c.pxhere.com/photos/29/2d/london_parliament_england_ben_ben_westminster_tower_city_british-772846.jpg!d",
                TripDate = new DateTime(2022, 6, 12),
                TripDuration = 4,
                Price = 420,
                Destinations = Destinations.London,
                PackageStatus = Status.Active
            };
            List<Package> packages = new List<Package>() { p1, p2, p3, p4, p5,p6,p7,p8,p9,p10,p11,p12,p13,p14,p15,p16,p17,p18,p19,p20,p21,p22,p23,p24,p25,p26};
            db.Packages.AddRange(packages);
            #endregion

            //ApplicationUser Seeding
            #region registeredUsers
            ApplicationUser ap1 = new ApplicationUser() { UserName = "John11", FirstName = "John", LastName = "Hopkins", PhoneNumber = "+30 6984548965", Email = "john1@yahoo.gr", Birthday = new DateTime(1990, 8, 1), Country = "France", City = "Paris", ZipCode = "75001", Address = "Rue Pierre Guérin 21" };
            ApplicationUser ap2 = new ApplicationUser() { UserName = "Nick22", FirstName = "Nick", LastName = "Hughes", PhoneNumber = "+30 6981236365", Email = "nick1@gmail.com", Birthday = new DateTime(1984, 5, 10), Country = "Greece", City = "Athens", ZipCode = "10431", Address = "Patision 32" };
            ApplicationUser ap3 = new ApplicationUser() { UserName = "Alex123", FirstName = "Alex", LastName = "Ital", PhoneNumber = "+49 1763535596", Email = "alexital@gmail.com", Birthday = new DateTime(1972, 5, 10), Country = "Germany", City = "Stolhofen", ZipCode = "72456", Address = "Winnipeg Avenue" };
            ApplicationUser ap4 = new ApplicationUser() { UserName = "Mellie", FirstName = "Melinda", LastName = "Tsaaok", PhoneNumber = "+45 9873535596", Email = "mellie@gmail.com", Birthday = new DateTime(1982, 5, 10), Country = "Slovakia", City = "Houg", ZipCode = "95456", Address = "Ihgatds" };
            ApplicationUser ap5 = new ApplicationUser() { UserName = "Kelly123", FirstName = "Kalliopi", LastName = "Kapoti", PhoneNumber = "+30 6984548965", Email = "kk@gmail.com", Birthday = new DateTime(1992, 7, 10), Country = "Greece", City = "Lefkada", ZipCode = "20002", Address = "Kapodistria 2" };
            ApplicationUser ap6 = new ApplicationUser() { UserName = "Josephine12", FirstName = "Josephine", LastName = "Braner", PhoneNumber = "+49 1787535596", Email = "josebraner@gmail.com", Birthday = new DateTime(1997, 10, 21), Country = "Germany", City = "Hugelsheim", ZipCode = "89654", Address = "Huge A12" };
            ApplicationUser ap7 = new ApplicationUser() { UserName = "Pietr89", FirstName = "Pietr", LastName = "Zowski", PhoneNumber = "+67 9757535596", Email = "pietr@gmail.com", Birthday = new DateTime(1978, 04, 21), Country = "Poland", City = "Krakow", ZipCode = "83454", Address = "Alive 45" };
            ApplicationUser ap8 = new ApplicationUser() { UserName = "Angel", FirstName = "Aggeliki", LastName = "Zaxaraki", PhoneNumber = "+30 6987535596", Email = "angel@gmail.com", Birthday = new DateTime(2999, 8, 2), Country = "Greece", City = "Athens", ZipCode = "71654", Address = "Aigalew" };
            ApplicationUser ap9 = new ApplicationUser() { UserName = "Ema", FirstName = "Emanuel", LastName = "Sentpeteri", PhoneNumber = "+49 1788745596", Email = "sentem@gmail.com", Birthday = new DateTime(1990, 10, 9), Country = "Germany", City = "Rheinmunster", ZipCode = "79654", Address = "Kopit" };
            ApplicationUser ap10 = new ApplicationUser() { UserName = "girl98", FirstName = "Dana", LastName = "Rekop", PhoneNumber = "+35 9587535596", Email = "dana@gmail.com", Birthday = new DateTime(1998, 4, 21), Country = "Skopia", City = "Ersip", ZipCode = "59651", Address = "Pio" };
            ApplicationUser ap11= new ApplicationUser() { UserName = "Julia12", FirstName = "Ioulia", LastName = "Stathopoulou", PhoneNumber = "+30 6957535596", Email = "jul@gmail.com", Birthday = new DateTime(1997, 07, 12), Country = "Greece", City = "Karpathos", ZipCode = "25654", Address = "Swsti 5" };
            ApplicationUser ap12= new ApplicationUser() { UserName = "KostasGa", FirstName = "Konstantinos", LastName = "Galifianakis", PhoneNumber = "+30 6959735596", Email = "ga@gmail.com", Birthday = new DateTime(1969, 07, 12), Country = "Greece", City = "Peiraias", ZipCode = "73654", Address = "Kriti 7" };

            db.Users.Add(ap1);
            db.Users.Add(ap2);
            db.Users.Add(ap3);
            db.Users.Add(ap4);
            db.Users.Add(ap5);
            db.Users.Add(ap6);
            db.Users.Add(ap7);
            db.Users.Add(ap8);
            db.Users.Add(ap9);
            db.Users.Add(ap10);
            db.Users.Add(ap11);
            db.Users.Add(ap12);
            #endregion

            //Booking Seeding
            #region Bookings
            Booking b1 = new Booking() { FirstName = ap1.FirstName, LastName = ap1.LastName, Email = ap1.Email, PhoneNumber = ap1.PhoneNumber, PurchaseDate = new DateTime(2022, 04, 02), PackagesCost = 476 };
            Booking b2 = new Booking() { FirstName = ap2.FirstName, LastName = ap2.LastName, Email = ap2.Email, PhoneNumber = ap2.PhoneNumber, PurchaseDate = new DateTime(2022, 04, 05), PackagesCost = 699 };
            Booking b3 = new Booking() { FirstName = "John", LastName = "Smith", Email = " j.s@gmail.com", PhoneNumber = "+306547896325", PurchaseDate = new DateTime(2022, 03, 29), PackagesCost = 966 };
            Booking b4 = new Booking() { FirstName = "Tim", LastName = "Correy", Email = " t.c@gmail.com", PhoneNumber = "+306544566325", PurchaseDate = new DateTime(2022, 03, 31), PackagesCost = 800 };
            Booking b5 = new Booking() { FirstName = "Olivia", LastName = "Elem", Email = " olivia.el@gmail.com", PhoneNumber = "+410644566325", PurchaseDate = new DateTime(2021, 10, 04), PackagesCost = 340 };
            Booking b6 = new Booking() { FirstName = "Ema", LastName = "Diana", Email = " em.diana@gmail.com", PhoneNumber = "+416564866325", PurchaseDate = new DateTime(2021, 04, 04), PackagesCost = 529 };
            Booking b7 = new Booking() { FirstName = "Bora", LastName = "Rraja", Email = " bora@rraja@gmail.com", PhoneNumber = "+3553694566325", PurchaseDate = new DateTime(2022, 08, 02), PackagesCost = 300 };
            Booking b8 = new Booking() { FirstName = "Sara", LastName = "Nosedive", Email = " sar.rrota@gmail.com", PhoneNumber = "+906544566325", PurchaseDate = new DateTime(2022, 06, 15), PackagesCost = 300 };
            Booking b9 = new Booking() { FirstName = "Ilda", LastName = "Tufa", Email = " i.tufa@gmail.com", PhoneNumber = "+35565445665695", PurchaseDate = new DateTime(2022, 07, 19), PackagesCost = 300 };
            Booking b10 = new Booking() { FirstName = ap3.FirstName, LastName = ap3.LastName, Email = ap3.Email, PhoneNumber = ap3.PhoneNumber, PurchaseDate = new DateTime(2022, 04, 19), PackagesCost = 567 };
            Booking b11 = new Booking() { FirstName = "Vasiliki", LastName = "Kalantzi", Email = "vicky@gmail.com", PhoneNumber = "+30 6974567821", PurchaseDate = new DateTime(2022, 02, 27), PackagesCost = 567 };
            Booking b12 = new Booking() { FirstName = "Emanuel", LastName = "Sentpeteri", Email = "emansent@gmail.com", PhoneNumber = "+49 1763538965", PurchaseDate = new DateTime(2022, 03, 16), PackagesCost = 567 };
            Booking b13 = new Booking() { FirstName = "Maria", LastName = "Pantazi", Email = "marypan@gmail.com", PhoneNumber = "+30 6973535596", PurchaseDate = new DateTime(2022, 04, 6), PackagesCost = 567 };
            Booking b14 = new Booking() { FirstName = "Massimo", LastName = "La Rossa", Email = "massimino@gmail.com", PhoneNumber = "+30 6973538654", PurchaseDate = new DateTime(2022, 01, 29), PackagesCost = 567 };
            Booking b15 = new Booking() { FirstName = "Iacopo", LastName = "Fantozzi", Email = "fantozzi@gmail.com", PhoneNumber = "+30 6973530000", PurchaseDate = new DateTime(2022, 01, 29), PackagesCost = 567 };
            Booking b16 = new Booking() { FirstName = "Carmela", LastName = "Cataluna", Email = "Cataluna@gmail.com", PhoneNumber = "+39 4579530000", PurchaseDate = new DateTime(2022, 04, 29), PackagesCost = 780 };
            Booking b17 = new Booking() { FirstName = "Dimitra", LastName = "Kalantzi", Email = "mimi@gmail.com", PhoneNumber = "+30 6989530000", PurchaseDate = new DateTime(2022, 03, 2), PackagesCost = 780 };
            Booking b18 = new Booking() { FirstName = "Nikolas", LastName = "Masouras", Email = "nm@gmail.com", PhoneNumber = "+30 6970995300", PurchaseDate = new DateTime(2022, 03, 29), PackagesCost = 780 };
            Booking b19 = new Booking() { FirstName = "Anna", LastName = "Mpakoxristou", Email = "anna@gmail.com", PhoneNumber = "+30 6970995369", PurchaseDate = new DateTime(2022, 04, 15), PackagesCost = 780 };
            Booking b20 = new Booking() { FirstName = ap4.FirstName, LastName = ap4.LastName, Email = ap4.Email, PhoneNumber = ap4.PhoneNumber, PurchaseDate = new DateTime(2022, 04, 15), PackagesCost = 780 };
            Booking b21 = new Booking() { FirstName = ap1.FirstName, LastName = ap1.LastName, Email = ap1.Email, PhoneNumber = ap1.PhoneNumber, PurchaseDate = new DateTime(2022, 04, 15), PackagesCost = 655 };
            Booking b22 = new Booking() { FirstName = "Anna", LastName = "Selva", Email = "annaSel@gmail.com", PhoneNumber = "+38 9531798456", PurchaseDate = new DateTime(2022, 03, 29), PackagesCost = 655 };
            Booking b23 = new Booking() { FirstName = "Aggelos", LastName = "Koutourinis", Email = "angel@gmail.com", PhoneNumber = "+30 6931798456", PurchaseDate = new DateTime(2022, 05, 2), PackagesCost = 655 };
            Booking b24 = new Booking() { FirstName = "Tobias", LastName = "Weber", Email = "webert@gmail.com", PhoneNumber = "+49 1731798456", PurchaseDate = new DateTime(2022, 02, 28), PackagesCost = 655 };
           
            Booking b25 = new Booking() { FirstName = ap12.FirstName, LastName = ap12.LastName, Email = ap12.Email, PhoneNumber = ap12.PhoneNumber, PurchaseDate = new DateTime(2021, 01, 01), PackagesCost = 702 };
            Booking b26 = new Booking() { FirstName = ap1.FirstName, LastName = ap1.LastName, Email = ap1.Email, PhoneNumber = ap1.PhoneNumber, PurchaseDate = new DateTime(2021, 01, 01), PackagesCost = 702 };
            Booking b27 = new Booking() { FirstName = ap10.FirstName, LastName = ap10.LastName, Email = ap10.Email, PhoneNumber = ap10.PhoneNumber, PurchaseDate = new DateTime(2021, 01, 01), PackagesCost = 702 };
            Booking b28 = new Booking() { FirstName = ap3.FirstName, LastName = ap3.LastName, Email = ap3.Email, PhoneNumber = ap3.PhoneNumber, PurchaseDate = new DateTime(2021, 01, 01), PackagesCost = 702 };
            Booking b29 = new Booking() { FirstName = ap4.FirstName, LastName = ap4.LastName, Email = ap4.Email, PhoneNumber = ap4.PhoneNumber, PurchaseDate = new DateTime(2021, 01, 01), PackagesCost = 702 };
            Booking b30 = new Booking() { FirstName = ap9.FirstName, LastName = ap9.LastName, Email = ap9.Email, PhoneNumber = ap9.PhoneNumber, PurchaseDate = new DateTime(2021, 01, 01), PackagesCost = 702 };
            Booking b31 = new Booking() { FirstName = ap5.FirstName, LastName = ap5.LastName, Email = ap5.Email, PhoneNumber = ap5.PhoneNumber, PurchaseDate = new DateTime(2021, 01, 01), PackagesCost = 702 };
            Booking b32 = new Booking() { FirstName = ap7.FirstName, LastName = ap7.LastName, Email = ap7.Email, PhoneNumber = ap7.PhoneNumber, PurchaseDate = new DateTime(2021, 01, 01), PackagesCost = 702 };
            Booking b33 = new Booking() { FirstName = ap2.FirstName, LastName = ap2.LastName, Email = ap2.Email, PhoneNumber = ap2.PhoneNumber, PurchaseDate = new DateTime(2021, 01, 01), PackagesCost = 702 };
            Booking b34 = new Booking() { FirstName = "Vasiliki", LastName = "Kalantzi", Email = "vicky@gmail.com", PhoneNumber = "+30 6974567821", PurchaseDate = new DateTime(2022, 02, 27), PackagesCost = 702 };
            Booking b35 = new Booking() { FirstName = "Emanuel", LastName = "Sentpeteri", Email = "emansent@gmail.com", PhoneNumber = "+49 1763538965", PurchaseDate = new DateTime(2022, 03, 16), PackagesCost = 702 };

            Booking b36 = new Booking() { FirstName = "John", LastName = "Smith", Email = " j.s@gmail.com", PhoneNumber = "+306547896325", PurchaseDate = new DateTime(2022, 03, 29), PackagesCost = 300 };
            Booking b37 = new Booking() { FirstName = "Tim", LastName = "Correy", Email = " t.c@gmail.com", PhoneNumber = "+306544566325", PurchaseDate = new DateTime(2022, 03, 31), PackagesCost = 300 };
            Booking b38 = new Booking() { FirstName = "Olivia", LastName = "Elem", Email = " olivia.el@gmail.com", PhoneNumber = "+410644566325", PurchaseDate = new DateTime(2021, 10, 04), PackagesCost = 300 };
            Booking b39 = new Booking() { FirstName = "Ema", LastName = "Diana", Email = " em.diana@gmail.com", PhoneNumber = "+416564866325", PurchaseDate = new DateTime(2021, 04, 04), PackagesCost = 300 };
            Booking b40 = new Booking() { FirstName = "Bora", LastName = "Rraja", Email = " bora@rraja@gmail.com", PhoneNumber = "+3553694566325", PurchaseDate = new DateTime(2022, 08, 02), PackagesCost = 300 };
            Booking b41 = new Booking() { FirstName = "Sara", LastName = "Nosedive", Email = " sar.rrota@gmail.com", PhoneNumber = "+906544566325", PurchaseDate = new DateTime(2022, 06, 15), PackagesCost = 300 };
            Booking b42 = new Booking() { FirstName = "Ilda", LastName = "Tufa", Email = " i.tufa@gmail.com", PhoneNumber = "+35565445665695", PurchaseDate = new DateTime(2022, 07, 19), PackagesCost = 300 };
            Booking b43 = new Booking() { FirstName = "Anna", LastName = "Selva", Email = "annaSel@gmail.com", PhoneNumber = "+38 9531798456", PurchaseDate = new DateTime(2022, 03, 29), PackagesCost = 300 };
            Booking b44 = new Booking() { FirstName = "Aggelos", LastName = "Koutourinis", Email = "angel@gmail.com", PhoneNumber = "+30 6931798456", PurchaseDate = new DateTime(2022, 05, 2), PackagesCost = 300 };
            Booking b45 = new Booking() { FirstName = "Tobias", LastName = "Weber", Email = "webert@gmail.com", PhoneNumber = "+49 1731798456", PurchaseDate = new DateTime(2022, 02, 28), PackagesCost = 300 };

            Booking b46 = new Booking() { FirstName = "Maria", LastName = "Pantazi", Email = "marypan@gmail.com", PhoneNumber = "+30 6973535596", PurchaseDate = new DateTime(2022, 04, 6), PackagesCost = 476 };
            Booking b47 = new Booking() { FirstName = "Massimo", LastName = "La Rossa", Email = "massimino@gmail.com", PhoneNumber = "+30 6973538654", PurchaseDate = new DateTime(2022, 01, 29), PackagesCost = 476 };
            Booking b48 = new Booking() { FirstName = "Iacopo", LastName = "Fantozzi", Email = "fantozzi@gmail.com", PhoneNumber = "+30 6973530000", PurchaseDate = new DateTime(2022, 01, 29), PackagesCost = 476 };
            Booking b49 = new Booking() { FirstName = "Carmela", LastName = "Cataluna", Email = "Cataluna@gmail.com", PhoneNumber = "+39 4579530000", PurchaseDate = new DateTime(2022, 04, 29), PackagesCost = 476 };
            Booking b50 = new Booking() { FirstName = "Dimitra", LastName = "Kalantzi", Email = "mimi@gmail.com", PhoneNumber = "+30 6989530000", PurchaseDate = new DateTime(2022, 03, 2), PackagesCost = 476 };
            Booking b51 = new Booking() { FirstName = "Nikolas", LastName = "Masouras", Email = "nm@gmail.com", PhoneNumber = "+30 6970995300", PurchaseDate = new DateTime(2022, 03, 29), PackagesCost = 476 };
            Booking b52 = new Booking() { FirstName = "Anna", LastName = "Mpakoxristou", Email = "anna@gmail.com", PhoneNumber = "+30 6970995369", PurchaseDate = new DateTime(2022, 04, 15), PackagesCost = 476 };
            Booking b53 = new Booking() { FirstName = ap4.FirstName, LastName = ap4.LastName, Email = ap4.Email, PhoneNumber = ap4.PhoneNumber, PurchaseDate = new DateTime(2022, 04, 15), PackagesCost = 476 };

            Booking b54 = new Booking() { FirstName = ap1.FirstName, LastName = ap1.LastName, Email = ap1.Email, PhoneNumber = ap1.PhoneNumber, PurchaseDate = new DateTime(2022, 04, 02), PackagesCost = 420 };
            Booking b55 = new Booking() { FirstName = ap2.FirstName, LastName = ap2.LastName, Email = ap2.Email, PhoneNumber = ap2.PhoneNumber, PurchaseDate = new DateTime(2022, 04, 05), PackagesCost = 420 };
            Booking b56 = new Booking() { FirstName = "John", LastName = "Smith", Email = " j.s@gmail.com", PhoneNumber = "+306547896325", PurchaseDate = new DateTime(2022, 03, 29), PackagesCost = 420 };
            Booking b57= new Booking() { FirstName = "Tim", LastName = "Correy", Email = " t.c@gmail.com", PhoneNumber = "+306544566325", PurchaseDate = new DateTime(2022, 03, 31), PackagesCost = 420 };
            Booking b58= new Booking() { FirstName = "Olivia", LastName = "Elem", Email = " olivia.el@gmail.com", PhoneNumber = "+410644566325", PurchaseDate = new DateTime(2021, 10, 04), PackagesCost = 420 };
            Booking b59= new Booking() { FirstName = "Ema", LastName = "Diana", Email = " em.diana@gmail.com", PhoneNumber = "+416564866325", PurchaseDate = new DateTime(2021, 04, 04), PackagesCost = 420 };

            Booking b60 = new Booking() { FirstName = "Vasiliki", LastName = "Kalantzi", Email = "vicky@gmail.com", PhoneNumber = "+30 6974567821", PurchaseDate = new DateTime(2022, 02, 27), PackagesCost = 476 };
            Booking b61 = new Booking() { FirstName = "Emanuel", LastName = "Sentpeteri", Email = "emansent@gmail.com", PhoneNumber = "+49 1763538965", PurchaseDate = new DateTime(2022, 03, 16), PackagesCost = 476 };
            Booking b62 = new Booking() { FirstName = "Maria", LastName = "Pantazi", Email = "marypan@gmail.com", PhoneNumber = "+30 6973535596", PurchaseDate = new DateTime(2022, 04, 6), PackagesCost = 476 };

            Booking b63 = new Booking() { FirstName = ap1.FirstName, LastName = ap1.LastName, Email = ap1.Email, PhoneNumber = ap1.PhoneNumber, PurchaseDate = new DateTime(2022, 04, 02), PackagesCost = 699 };
            Booking b64 = new Booking() { FirstName = ap2.FirstName, LastName = ap2.LastName, Email = ap2.Email, PhoneNumber = ap2.PhoneNumber, PurchaseDate = new DateTime(2022, 04, 05), PackagesCost = 699 };

            Booking b65 = new Booking() { FirstName = "Tobias", LastName = "Weber", Email = "webert@gmail.com", PhoneNumber = "+49 1731798456", PurchaseDate = new DateTime(2022, 02, 28), PackagesCost = 400 };

            Booking b66 = new Booking() { FirstName = "John", LastName = "Smith", Email = " j.s@gmail.com", PhoneNumber = "+306547896325", PurchaseDate = new DateTime(2022, 03, 29), PackagesCost = 529 };
            Booking b67 = new Booking() { FirstName = "Tim", LastName = "Correy", Email = " t.c@gmail.com", PhoneNumber = "+306544566325", PurchaseDate = new DateTime(2022, 03, 31), PackagesCost = 529 };
            Booking b68 = new Booking() { FirstName = "Olivia", LastName = "Elem", Email = " olivia.el@gmail.com", PhoneNumber = "+410644566325", PurchaseDate = new DateTime(2021, 10, 04), PackagesCost = 529 };
            Booking b69 = new Booking() { FirstName = "Ema", LastName = "Diana", Email = " em.diana@gmail.com", PhoneNumber = "+416564866325", PurchaseDate = new DateTime(2021, 04, 04), PackagesCost = 529 };

            Booking b70 = new Booking() { FirstName = "Iacopo", LastName = "Fantozzi", Email = "fantozzi@gmail.com", PhoneNumber = "+30 6973530000", PurchaseDate = new DateTime(2022, 01, 29), PackagesCost = 567 };
            Booking b71 = new Booking() { FirstName = "Carmela", LastName = "Cataluna", Email = "Cataluna@gmail.com", PhoneNumber = "+39 4579530000", PurchaseDate = new DateTime(2022, 04, 29), PackagesCost = 567 };
            Booking b72 = new Booking() { FirstName = "Dimitra", LastName = "Kalantzi", Email = "mimi@gmail.com", PhoneNumber = "+30 6989530000", PurchaseDate = new DateTime(2022, 03, 2), PackagesCost = 567 };
            Booking b73 = new Booking() { FirstName = "Nikolas", LastName = "Masouras", Email = "nm@gmail.com", PhoneNumber = "+30 6970995300", PurchaseDate = new DateTime(2022, 03, 29), PackagesCost = 567 };

            Booking b74 = new Booking() { FirstName = "Ema", LastName = "Diana", Email = " em.diana@gmail.com", PhoneNumber = "+416564866325", PurchaseDate = new DateTime(2021, 04, 04), PackagesCost = 780 };

            Booking b75 = new Booking() { FirstName = "Tim", LastName = "Correy", Email = " t.c@gmail.com", PhoneNumber = "+306544566325", PurchaseDate = new DateTime(2022, 03, 31), PackagesCost = 800 };
            Booking b76 = new Booking() { FirstName = "Olivia", LastName = "Elem", Email = " olivia.el@gmail.com", PhoneNumber = "+410644566325", PurchaseDate = new DateTime(2021, 10, 04), PackagesCost = 800 };
            Booking b77 = new Booking() { FirstName = "Ema", LastName = "Diana", Email = " em.diana@gmail.com", PhoneNumber = "+416564866325", PurchaseDate = new DateTime(2021, 04, 04), PackagesCost = 800 };
            Booking b78 = new Booking() { FirstName = "Bora", LastName = "Rraja", Email = " bora@rraja@gmail.com", PhoneNumber = "+3553694566325", PurchaseDate = new DateTime(2022, 08, 02), PackagesCost = 800 };
            Booking b79 = new Booking() { FirstName = "Sara", LastName = "Nosedive", Email = " sar.rrota@gmail.com", PhoneNumber = "+906544566325", PurchaseDate = new DateTime(2022, 06, 15), PackagesCost = 800 };

            Booking b80 = new Booking() { FirstName = ap10.FirstName, LastName = ap10.LastName, Email = ap10.Email, PhoneNumber = ap10.PhoneNumber, PurchaseDate = new DateTime(2021, 01, 01), PackagesCost = 800 };
            Booking b81 = new Booking() { FirstName = ap3.FirstName, LastName = ap3.LastName, Email = ap3.Email, PhoneNumber = ap3.PhoneNumber, PurchaseDate = new DateTime(2021, 01, 01), PackagesCost = 800 };
            Booking b82 = new Booking() { FirstName = ap4.FirstName, LastName = ap4.LastName, Email = ap4.Email, PhoneNumber = ap4.PhoneNumber, PurchaseDate = new DateTime(2021, 01, 01), PackagesCost = 800 };

            Booking b83 = new Booking() { FirstName = "Iacopo", LastName = "Fantozzi", Email = "fantozzi@gmail.com", PhoneNumber = "+30 6973530000", PurchaseDate = new DateTime(2022, 01, 29), PackagesCost = 1450 };


            Booking b84 = new Booking() { FirstName = "John", LastName = "Smith", Email = " j.s@gmail.com", PhoneNumber = "+306547896325", PurchaseDate = new DateTime(2022, 03, 29), PackagesCost = 1800 };
            Booking b85 = new Booking() { FirstName = "Tim", LastName = "Correy", Email = " t.c@gmail.com", PhoneNumber = "+306544566325", PurchaseDate = new DateTime(2022, 03, 31), PackagesCost = 1800 };

            Booking b86 = new Booking() { FirstName = "Nikolas", LastName = "Masouras", Email = "nm@gmail.com", PhoneNumber = "+30 6970995300", PurchaseDate = new DateTime(2022, 03, 29), PackagesCost = 702 };

            Booking b87 = new Booking() { FirstName = "Nikolas", LastName = "Masouras", Email = "nm@gmail.com", PhoneNumber = "+30 6970995300", PurchaseDate = new DateTime(2022, 03, 29), PackagesCost = 450 };
            Booking b88 = new Booking() { FirstName = "Anna", LastName = "Mpakoxristou", Email = "anna@gmail.com", PhoneNumber = "+30 6970995369", PurchaseDate = new DateTime(2022, 04, 15), PackagesCost = 450 };
           
            Booking b89 = new Booking() { FirstName = "Dimitra", LastName = "Papadopoulou", Email = "papa@gmail.com", PhoneNumber = "+30 6976325369", PurchaseDate = new DateTime(2022, 02, 15), PackagesCost = 500 };
            Booking b90 = new Booking() { FirstName = "Eliza", LastName = "Staurou", Email = "eli@gmail.com", PhoneNumber = "+30 6976325921", PurchaseDate = new DateTime(2022, 06, 15), PackagesCost = 500 };
            
            Booking b91 = new Booking() { FirstName = "Giorgos", LastName = "Kalos", Email = "kalos@gmail.com", PhoneNumber = "+30 6982325921", PurchaseDate = new DateTime(2022, 02, 15), PackagesCost = 300 };
            Booking b92 = new Booking() { FirstName = "Teo", LastName = "Pana", Email = "pana@gmail.com", PhoneNumber = "+40 1876325921", PurchaseDate = new DateTime(2022, 05, 15), PackagesCost = 300 };

            Booking b93 = new Booking() { FirstName = "Dimitra", LastName = "Papadopoulou", Email = "papa@gmail.com", PhoneNumber = "+30 6976325369", PurchaseDate = new DateTime(2022, 02, 15), PackagesCost = 580 };
            
            Booking b94 = new Booking() { FirstName = "Jessica", LastName = "Coelho", Email = "coelho@gmail.com", PhoneNumber = "+65 9176325369", PurchaseDate = new DateTime(2022, 02, 15), PackagesCost = 850 };
            Booking b95 = new Booking() { FirstName = "Giorgos", LastName = "Kalos", Email = "kalos@gmail.com", PhoneNumber = "+30 6982325921", PurchaseDate = new DateTime(2022, 02, 15), PackagesCost = 850 };
            Booking b96 = new Booking() { FirstName = "Teo", LastName = "Pana", Email = "pana@gmail.com", PhoneNumber = "+40 1876325921", PurchaseDate = new DateTime(2022, 05, 15), PackagesCost = 850 };

            Booking b97 = new Booking() { FirstName = "John", LastName = "Smith", Email = " j.s@gmail.com", PhoneNumber = "+306547896325", PurchaseDate = new DateTime(2022, 03, 29), PackagesCost = 420 };
            Booking b98 = new Booking() { FirstName = "Tim", LastName = "Correy", Email = " t.c@gmail.com", PhoneNumber = "+306544566325", PurchaseDate = new DateTime(2022, 03, 31), PackagesCost = 420 };
            Booking b99 = new Booking() { FirstName = "Olivia", LastName = "Elem", Email = " olivia.el@gmail.com", PhoneNumber = "+410644566325", PurchaseDate = new DateTime(2021, 10, 04), PackagesCost = 420 };
            Booking b100 = new Booking() { FirstName = "Ema", LastName = "Diana", Email = " em.diana@gmail.com", PhoneNumber = "+416564866325", PurchaseDate = new DateTime(2021, 04, 04), PackagesCost = 420 };
           
            Booking b101 = new Booking() { FirstName = "Sabrina", LastName = "Theotokatou", Email = " em.diana@gmail.com", PhoneNumber = "+416564866325", PurchaseDate = new DateTime(2021, 04, 04), PackagesCost = 506 };
            Booking b102 = new Booking() { FirstName = "Menelaos", LastName = "Theotokatos", Email = " em.diana@gmail.com", PhoneNumber = "+416564866325", PurchaseDate = new DateTime(2021, 04, 04), PackagesCost = 506 };
           
            Booking b103 = new Booking() { FirstName = "Xaris", LastName = "Lazarou", Email = " em.diana@gmail.com", PhoneNumber = "+416564866325", PurchaseDate = new DateTime(2021, 04, 04), PackagesCost = 720};
            Booking b104 = new Booking() { FirstName = "Selma", LastName = "Lazarou", Email = " em.diana@gmail.com", PhoneNumber = "+416564866325", PurchaseDate = new DateTime(2021, 04, 04), PackagesCost = 720 };
            Booking b105 = new Booking() { FirstName = "Panagiotis", LastName = "Lazarou", Email = " em.diana@gmail.com", PhoneNumber = "+416564866325", PurchaseDate = new DateTime(2021, 04, 04), PackagesCost = 720 };
            Booking b106 = new Booking() { FirstName = "Xara", LastName = "Lazarou", Email = " em.diana@gmail.com", PhoneNumber = "+416564866325", PurchaseDate = new DateTime(2021, 04, 04), PackagesCost = 720 };
           
            Booking b107 = new Booking() { FirstName = "Xara", LastName = "Lazarou", Email = " em.diana@gmail.com", PhoneNumber = "+416564866325", PurchaseDate = new DateTime(2021, 04, 04), PackagesCost = 655 };
            Booking b108 = new Booking() { FirstName = "John", LastName = "Smith", Email = " j.s@gmail.com", PhoneNumber = "+306547896325", PurchaseDate = new DateTime(2022, 03, 29), PackagesCost = 655 };
            Booking b109 = new Booking() { FirstName = "Tim", LastName = "Correy", Email = " t.c@gmail.com", PhoneNumber = "+306544566325", PurchaseDate = new DateTime(2022, 03, 31), PackagesCost = 655 };
            Booking b110 = new Booking() { FirstName = "Olivia", LastName = "Elem", Email = " olivia.el@gmail.com", PhoneNumber = "+410644566325", PurchaseDate = new DateTime(2021, 10, 04), PackagesCost = 655 };
            Booking b111 = new Booking() { FirstName = "Ema", LastName = "Diana", Email = " em.diana@gmail.com", PhoneNumber = "+416564866325", PurchaseDate = new DateTime(2021, 04, 04), PackagesCost = 655 };
            Booking b112 = new Booking() { FirstName = "Bora", LastName = "Rraja", Email = " bora@rraja@gmail.com", PhoneNumber = "+3553694566325", PurchaseDate = new DateTime(2022, 08, 02), PackagesCost = 655 };
            Booking b113 = new Booking() { FirstName = "Sara", LastName = "Nosedive", Email = " sar.rrota@gmail.com", PhoneNumber = "+906544566325", PurchaseDate = new DateTime(2022, 06, 15), PackagesCost = 655 };


            Booking b114 = new Booking() { FirstName = "Nikolas", LastName = "Masouras", Email = "nm@gmail.com", PhoneNumber = "+30 6970995300", PurchaseDate = new DateTime(2022, 03, 29), PackagesCost = 950 };
            Booking b115 = new Booking() { FirstName = "Anna", LastName = "Mpakoxristou", Email = "anna@gmail.com", PhoneNumber = "+30 6970995369", PurchaseDate = new DateTime(2022, 04, 15), PackagesCost = 950 };
            Booking b116 = new Booking() { FirstName = "Dimitra", LastName = "Papadopoulou", Email = "papa@gmail.com", PhoneNumber = "+30 6976325369", PurchaseDate = new DateTime(2022, 02, 15), PackagesCost = 950 };
            Booking b117 = new Booking() { FirstName = "Eliza", LastName = "Staurou", Email = "eli@gmail.com", PhoneNumber = "+30 6976325921", PurchaseDate = new DateTime(2022, 06, 15), PackagesCost = 950 };
            
            Booking b118 = new Booking() { FirstName = "Maria", LastName = "Pantazi", Email = "marypan@gmail.com", PhoneNumber = "+30 6973535596", PurchaseDate = new DateTime(2022, 04, 6), PackagesCost = 300 };
            Booking b119 = new Booking() { FirstName = "Massimo", LastName = "La Rossa", Email = "massimino@gmail.com", PhoneNumber = "+30 6973538654", PurchaseDate = new DateTime(2022, 01, 29), PackagesCost = 300 };
            Booking b120 = new Booking() { FirstName = "Iacopo", LastName = "Fantozzi", Email = "fantozzi@gmail.com", PhoneNumber = "+30 6973530000", PurchaseDate = new DateTime(2022, 01, 29), PackagesCost = 300 };
            Booking b121 = new Booking() { FirstName = "Iacopo", LastName = "Fantozzi", Email = "fantozzi@gmail.com", PhoneNumber = "+30 6973530000", PurchaseDate = new DateTime(2022, 01, 29), PackagesCost = 300 };
            Booking b122 = new Booking() { FirstName = "Carmela", LastName = "Cataluna", Email = "Cataluna@gmail.com", PhoneNumber = "+39 4579530000", PurchaseDate = new DateTime(2022, 04, 29), PackagesCost = 300 };
            Booking b123 = new Booking() { FirstName = "Dimitra", LastName = "Kalantzi", Email = "mimi@gmail.com", PhoneNumber = "+30 6989530000", PurchaseDate = new DateTime(2022, 03, 2), PackagesCost = 300 };
            Booking b124 = new Booking() { FirstName = "Nikolas", LastName = "Masouras", Email = "nm@gmail.com", PhoneNumber = "+30 6970995300", PurchaseDate = new DateTime(2022, 03, 29), PackagesCost = 300 };
            Booking b125 = new Booking() { FirstName = "Anna", LastName = "Mpakoxristou", Email = "anna@gmail.com", PhoneNumber = "+30 6970995369", PurchaseDate = new DateTime(2022, 04, 15), PackagesCost = 300 };
           
            
            List<Booking> bookings = new List<Booking>() { b1, b2, b3, b4, b5, b6, b7, b8, b9,b10,b11,b12,b13,b14,b15,b16,b17,b18,b19,b20,b21,b22,b23,b24,b25,b26,b27,b28,b29,b30,b31,b32,b33,b34,b35,b36,b37,b38,b39,b40,b41,b42,b43,
            b44,b45,b46,b47,b48,b49,b50,b51,b52,b53,b54,b55,b56,b57,b58,b59,b60,b61,b62,b63,b64,b65,b66,b67,b68,b69,b70,b71,b72,b73,b74,b75,b76,b77,b78,b79,b80,b81,b82,b83,b84,b85,b86,b87,b88,b89,b90,b91,b92,b93,b94,b95,b96,b97,b98,b99,b100,
            b101,b102,b103,b104,b105,b106,b107,b108,b109,b110,b111,b112,b113,b114,b115,b116,b117,b118,b119,b120,b121,b122,b123,b124,b125};
           
            db.Bookings.AddRange(bookings);

            b1.Packages.Add(p1);
            b2.Packages.Add(p2);
            b3.Packages.Add(p6);
            b3.Packages.Add(p7);
            b2.Packages.Add(p1);
            b3.Packages.Add(p1);
            b4.Packages.Add(p2);

            b1.ApplicationUser = ap1;
            b2.ApplicationUser = ap2;
            b4.Packages.Add(p4);
            b5.Packages.Add(p4);
            b6.Packages.Add(p5);
            b7.Packages.Add(p3);
            b8.Packages.Add(p3);
            b9.Packages.Add(p3);
            b10.ApplicationUser = ap3;
            b11.Packages.Add(p9);
            b12.Packages.Add(p9);
            b13.Packages.Add(p9);
            b14.Packages.Add(p9);
            b15.Packages.Add(p9);
            b16.Packages.Add(p10);
            b17.Packages.Add(p10);
            b18.Packages.Add(p10);
            b19.Packages.Add(p10);
            b20.Packages.Add(p10);
            b21.Packages.Add(p11);
            b22.Packages.Add(p11);
            b23.Packages.Add(p11);
            b24.Packages.Add(p11);

            b25.ApplicationUser = ap12;
            b26.ApplicationUser = ap1;
            b27.ApplicationUser = ap10;
            b28.ApplicationUser = ap3;
            b29.ApplicationUser = ap4;
            b30.ApplicationUser = ap9;
            b31.ApplicationUser = ap5;
            b32.ApplicationUser = ap7;
            b33.ApplicationUser = ap2;
            b34.Packages.Add(p25);
            b35.Packages.Add(p25);

            b36.Packages.Add(p24);
            b37.Packages.Add(p24);
            b38.Packages.Add(p24);
            b39.Packages.Add(p24);
            b40.Packages.Add(p24);
            b41.Packages.Add(p24);
            b42.Packages.Add(p24);
            b43.Packages.Add(p24);
            b44.Packages.Add(p24);
            b45.Packages.Add(p24);
             
            b46.Packages.Add(p23);
            b47.Packages.Add(p23);
            b48.Packages.Add(p23);
            b49.Packages.Add(p23);
            b50.Packages.Add(p23);
            b51.Packages.Add(p23);
            b52.Packages.Add(p23);
            b53.ApplicationUser = ap4;

            b54.ApplicationUser = ap1;
            b55.ApplicationUser = ap2;
            b56.Packages.Add(p4);
            b57.Packages.Add(p4);
            b57.Packages.Add(p4);
            b57.Packages.Add(p4);

            b60.Packages.Add(p1);
            b61.Packages.Add(p1);
            b62.Packages.Add(p1);

            b63.ApplicationUser = ap1;
            b64.ApplicationUser = ap2;

            b66.Packages.Add(p5);
            b67.Packages.Add(p5);
            b68.Packages.Add(p5);
            b69.Packages.Add(p5);

            b70.Packages.Add(p9);
            b71.Packages.Add(p9);
            b72.Packages.Add(p9);
            b73.Packages.Add(p9);
            
            b74.Packages.Add(p10);
           
            b75.Packages.Add(p12);
            b76.Packages.Add(p12);
            b77.Packages.Add(p12);
            b78.Packages.Add(p12);
            b79.Packages.Add(p12);
           

            b80.ApplicationUser = ap10;
            b81.ApplicationUser = ap3;
            b82.ApplicationUser = ap4;
           
            b83.Packages.Add(p14);
           
            b84.Packages.Add(p16);
            b85.Packages.Add(p16);
           
            b86.Packages.Add(p17);
           
            b87.Packages.Add(p18);
            b88.Packages.Add(p18);
            
            b89.Packages.Add(p19);
            b90.Packages.Add(p19);
            
            b91.Packages.Add(p20);
            b92.Packages.Add(p20);
          
            b93.Packages.Add(p21);
          
            b94.Packages.Add(p22);
            b95.Packages.Add(p22);
            b96.Packages.Add(p22);
           
            b97.Packages.Add(p26);
            b98.Packages.Add(p26);
            b99.Packages.Add(p26);
            b100.Packages.Add(p26);
           
            b101.Packages.Add(p7);
            b102.Packages.Add(p7);
           
            b103.Packages.Add(p8);
            b104.Packages.Add(p8);
            b105.Packages.Add(p8);
            b106.Packages.Add(p8);
           
            b107.Packages.Add(p11);
            b108.Packages.Add(p11);
            b109.Packages.Add(p11);
            b110.Packages.Add(p11);
            b111.Packages.Add(p11);
            b112.Packages.Add(p11);
            b113.Packages.Add(p11);
           
            b114.Packages.Add(p13);
            b115.Packages.Add(p13);
            b116.Packages.Add(p13);
            b117.Packages.Add(p13);
           
            b118.Packages.Add(p15);
            b119.Packages.Add(p15);
            b120.Packages.Add(p15);
            b121.Packages.Add(p15);
            b122.Packages.Add(p15);
            b123.Packages.Add(p15);
            b124.Packages.Add(p15);
            b125.Packages.Add(p15);
            #endregion


            //Photo Seeding
            Photo photosAthens = new Photo() { Destinations = Destinations.Athens, Url = "https://3.bp.blogspot.com/-ZfIVrmoK0HA/XfsiM6oOIkI/AAAAAAABsfI/qwIuU7cz9ukjN2pw0wECSCR48Bulvf8IACK4BGAYYCw/s1600/Screenshot_5.jpg" };
            Photo A1 = new Photo() { Destinations = Destinations.Athens, Url = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSVEGc2TaRKDQNxpN0HBwc2ANjH4So5FqBj6A&usqp=CAU" };
            Photo A2 = new Photo() { Destinations = Destinations.Athens, Url = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSzo2u1gaSyxDLa3aE89nUaopnALf36dT48xg&usqp=CAU" };
            Photo A3 = new Photo() { Destinations = Destinations.Athens, Url = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTobkG1T221r0ZX61dFpkDi_I5-qDI7WJIxLA&usqp=CAU" };
            Photo A4 = new Photo() { Destinations = Destinations.Athens, Url = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRS0oLZqQLOy5wOKdXSW6kyBUW_TSQJac_VOQ&usqp=CAU" };
            Photo A5 = new Photo() { Destinations = Destinations.Athens, Url = "" };
            
            Photo photosBarcelona2 = new Photo() { Destinations = Destinations.Barcelona, Url = "https://c.pxhere.com/photos/d6/f3/national_palace_palau_nacional_palace_abendstimmung_twilight_afterglow_barcelona_sky-950954.jpg!s1" };
            Photo photosBarcelona3 = new Photo() { Destinations = Destinations.Barcelona, Url = "https://c.pxhere.com/photos/91/ac/barcelona_montjuic_sunset_plaza_espa_a-1068204.jpg!s1" };
            Photo B4 = new Photo() { Destinations = Destinations.Barcelona, Url = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQjpjjDx6W7vKXQ0Nli8McuzoiHi7rtXzuaMg&usqp=CAU" };
            Photo B5 = new Photo() { Destinations = Destinations.Barcelona, Url = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ8DmD7BmkCN_5Acpg2G5kkgdERMzDGs5O2EA&usqp=CAU" };
            Photo B6 = new Photo() { Destinations = Destinations.Barcelona, Url = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQzeKpsU6twBnse_2bd-jTImL0KVOWJCut2zw&usqp=CAU" };
            Photo B7 = new Photo() { Destinations = Destinations.Barcelona, Url = "https://www.kevmrc.com/wp-content/uploads/2021/07/parc-guell-is-in-the-famous-landmarks-barcelona-has-to-offer.jpg" };
            Photo B8 = new Photo() { Destinations = Destinations.Barcelona, Url = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTGWaPFhvlRCgHMAUPKXvcTc-S5zjMxsvk-dg&usqp=CAU" };
            
            Photo P1 = new Photo() { Destinations = Destinations.Paris, Url = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT2CmJ6MDZLa1Dm0g0-Qp17JygVBQJnTE0Qmg&usqp=CAU" };
            Photo P2 = new Photo() { Destinations = Destinations.Paris, Url = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRWxzwiUH-Y89VezW6IB0ePHmH5rLmgmIU0yA&usqp=CAU" };
            Photo P3 = new Photo() { Destinations = Destinations.Paris, Url = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSnT9v_1XDo8fRQf8hhzV8CwzLaqHbDRWreYQ&usqp=CAU" };
            Photo P4 = new Photo() { Destinations = Destinations.Paris, Url = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTpux9Fc5Fx6B-8O4UaszngbEs1SbdG37TxSg&usqp=CAU" };
            Photo P5 = new Photo() { Destinations = Destinations.Paris, Url = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ7QUuX1p21yD-R1ePkpCZccUUIZiut2A6mDA&usqp=CAU" };
           
            Photo L1 = new Photo() { Destinations = Destinations.London, Url = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTCsix6MqHS0xVZgPYSu9kbtfL58sIq8JaXtA&usqp=CAU" };
            Photo L2 = new Photo() { Destinations = Destinations.London, Url = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQx2TH0dprgLJx8l3cuUE-2ISRK5oGcamPOlQ&usqp=CAU" };
            Photo L3 = new Photo() { Destinations = Destinations.London, Url = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRC9NaDDcoKb3Cgf8xzwdTi10leMutN__SmVw&usqp=CAU" };
            Photo L4 = new Photo() { Destinations = Destinations.London, Url = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQr5MiTpnWjkiZzfgA3oNGzdJPFaIyx3O8TuQ&usqp=CAU" };
            
            Photo R1 = new Photo() { Destinations = Destinations.Rome, Url = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR3qg-N6nA6CQmGsP-aOfravqmI8TwbDb6pOA&usqp=CAU" };
            Photo R2 = new Photo() { Destinations = Destinations.Rome, Url = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRj_koovL3giS_JZwrejTMeBP96E7QJocPz6A&usqp=CAU" };
            Photo R3 = new Photo() { Destinations = Destinations.Rome, Url = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR2-F9S5aPhR5yy4FxrCJPlaz_dAEF4BwOteA&usqp=CAU" };
            Photo R4 = new Photo() { Destinations = Destinations.Rome, Url = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTdQLyKusjPCN0i5XCrFpAOEiqwMmhxbpQ3AA&usqp=CAU" };
            Photo R5 = new Photo() { Destinations = Destinations.Rome, Url = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTuTB_hHSuIrlMG3nudddhdB2VrjayOIC0wmw&usqp=CAU" };
            Photo R6 = new Photo() { Destinations = Destinations.Rome, Url = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRVIiKGrw29MIhf-hnmuchEqD134AxM9P2CkA&usqp=CAU" };

            Photo P9 = new Photo() { Destinations = Destinations.Paris, Url = "" };
            
            Photo photosLondon = new Photo() { Destinations = Destinations.London, Url = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRvp5BzRDdhtlUNh7CGHYdVp_HFwDs_FOx-Ow&usqp=CAU" };
            Photo photosParis = new Photo() { Destinations = Destinations.Paris, Url = "https://c.pxhere.com/photos/3c/c2/eiffel_tower_paris-159.jpg!s1" };
            Photo photosRome = new Photo() { Destinations = Destinations.Rome, Url = "http://www.cosavisitarearoma.it/images/immagini_articoli/piazza-di-spagna.jpg" };
            Photo photosLisbon = new Photo() { Destinations = Destinations.Lisbon, Url = "https://www.nationsonline.org/gallery/Portugal/Praca-do-Comercio-Lisbon.jpg" };
            Photo photoCappadocia = new Photo() { Destinations = Destinations.Cappadocia, Url = "https://www.acetestravel.com/tour-image/cappadocia-27.webp" };
            Photo photoCappadocia1 = new Photo() { Destinations = Destinations.Cappadocia, Url = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/318992085.jpg?k=5a5214d69215f0998e8b9aaeb42c90330a66c60c64dfd2ee18dbeece0af43c78&o=&hp=1" };


            List<Photo> photos = new List<Photo>() { photosAthens, photosBarcelona2,photosBarcelona3 , photosLondon, photosParis, photosRome, photosLisbon,photoCappadocia,photoCappadocia1,A1,A2,A3,A4,A5,
            B4,B5,B6,B7,B8,P2,P1,P3,P4,P5,L1,L2,L3,L4 };
            db.Photos.AddRange(photos);

           
            p1.Photos.Add(photosBarcelona2);
            p1.Photos.Add(photosBarcelona3);
            p1.Photos.Add(B4);
            p1.Photos.Add(B5);
            p1.Photos.Add(B6);
            p1.Photos.Add(B7);
            p1.Photos.Add(B8);
           
            p2.Photos.Add(photosParis);
            p2.Photos.Add(P1);
            p2.Photos.Add(P2);
            p2.Photos.Add(P3);
            p2.Photos.Add(P4);
            p2.Photos.Add(P5);
           
            p3.Photos.Add(photosAthens);
            p3.Photos.Add(A1);
            p3.Photos.Add(A2);
            p3.Photos.Add(A3);
            p3.Photos.Add(A4);

            p26.Photos.Add(photosLondon);
            p26.Photos.Add(L1);
            p26.Photos.Add(L2);
            p26.Photos.Add(L3);
            p26.Photos.Add(L4);
            p26.Photos.Add(photosLondon);

            p5.Photos.Add(photosRome);
            p6.Photos.Add(photosLisbon);
            p7.Photos.Add(photoCappadocia);
            p7.Photos.Add(photoCappadocia1);
            p8.Photos.Add(photoCappadocia1);

            //Rate Seeding
            Rating r1 = new Rating() { RateScore = 3 };
            Rating r2 = new Rating() { RateScore = 5 };
            Rating r3 = new Rating() { RateScore = 4 };
            List<Rating> ratings = new List<Rating>() { r1, r2, r3 };
            db.Ratings.AddRange(ratings);


            // Comment Seeding
            #region comments and their ratings
            Comment com1 = new Comment() { CommentContent = "Excellent! Very good service from beginning to end", PostTime=new DateTime(2022,01,25) };
            com1.Rating = r2;
            Comment com2 = new Comment() { CommentContent = "Awesome support! Very much appreciated",PostTime=new DateTime(2021,05,29) };
            com2.Rating = r2;
            Comment com3 = new Comment() { CommentContent = "The city was nice and we had amazing time in Athens, but the tour guide was't what we expected. He seemed to be bored and avoided to answer questions.",PostTime=new DateTime(2021,05,29)};
            com3.Rating = r1;
            Comment com4 = new Comment() { CommentContent = "Me and my fiance, we love the city. We had been in Paris before but I wanted to go again everything organised through an agency so everything to be amazing for my marriage proposal. Thank you Travele agency for helping me making this trip an unforgetable mmemory!",PostTime=new DateTime(2022,02,15)};
            com4.Rating = r2;
            Comment com5 = new Comment() { CommentContent = "I love London, I can visit this city again and again. I am so happy that Travele agency organised everything because <i was super stressed with covid regulations. Although I want to confess that the hotel didn't reach my expectations.",PostTime=new DateTime(2022,01,15)};
            com5.Rating = r2;
            Comment com6 = new Comment() { CommentContent = "Travelling was not my thing, but not any more... Thank you for everything, the trip was perfectly organised till the last detail.",PostTime=new DateTime(2021,10,15)};
            com6.Rating = r2;
            Comment com7 = new Comment() { CommentContent = "We haven't been there yet, but we are looking forward. Friends of ours suggested the agency and I hope to fullfill my son's desire to fly high with a ballon.",PostTime=new DateTime(2022,03,1)};
            com7.Rating = r2;
            Comment com8 = new Comment() { CommentContent = "My mind was blown away. Didn't expect the city to be that magical. Was like an Alladin movie....",PostTime=new DateTime(2022,04,1)};
            com8.Rating = r2;
            Comment com9 = new Comment() { CommentContent = "Trip was good, but the city was too dark - gothic from my taste",PostTime=new DateTime(2022,03,10)};
            com9.Rating = r3;
            Comment com10 = new Comment() { CommentContent = "I am really curius about this trip because northen countries are not really my cup of tea. I like the idea of relaxing at a natural pool with tha extraordinary scenery.",PostTime=new DateTime(2022,03,10)};
            com10.Rating = r3;
            Comment com11 = new Comment() { CommentContent = "I loved the vibes of the city. The Light Festival was the best highlight.",PostTime=new DateTime(2021,10,10)};
            com11.Rating = r2;
            Comment com12 = new Comment() { CommentContent = "Travelling to Greece was always my dream. Strongly recommend this offer. PS book a daily cruise.",PostTime=new DateTime(2021,09,10)};
            com12.Rating = r2;
            Comment com13 = new Comment() { CommentContent = "In love with island's wild beauty, fresh fish and the warm locals.",PostTime=new DateTime(2022,02,19)};
            com13.Rating = r2;
            Comment com14 = new Comment() { CommentContent = "Inside the resort was amazing but outside I was scared for my life. A trip for adventurous people.",PostTime=new DateTime(2021,05,30)};
            com14.Rating = r1;
            Comment com15 = new Comment() { CommentContent = "Love love love. Unforgetable memories! I made loads of new friend that we all share the same interests: ski and outdoor parties.",PostTime=new DateTime(2021,12,30)};
            com15.Rating = r2;
            Comment com16 = new Comment() { CommentContent = "A paradise on Earth. First Christmas that didn't have to organise anything. Hope Travele Agency will make similar destinations for Christmas vacay otherwise every year we will travel to Mauritius :P",PostTime=new DateTime(2022,1,2)};
            com16.Rating = r2;
            Comment com17 = new Comment() { CommentContent = "Village Sol, the bearth taking view at Mirador Es Colomer Formentor, party life at Es Arenal... more than good reasons to visit this island.", PostTime=new DateTime(2021,11,2)};
            com17.Rating = r2;
            Comment com18 = new Comment() { CommentContent = "Two days are not enough for Dubai.. This place makes you feel rich without spending a fortune.", PostTime=new DateTime(2021,11,2)};
            com18.Rating = r2;
            Comment com19 = new Comment() { CommentContent = "Booked this trip to show off to a friend. Cute city but nothing special, unless if you like window shopping Rollex, Louis Vuiton... A place that I liked was the waterfalls close to Zurich that was really spectacullar.", PostTime=new DateTime(2022,4,2)};
            com19.Rating = r3;
            Comment com20 = new Comment() { CommentContent = "You have to visit Milan, the cathedral Duomo and the amazing shopping opportunities are more than enough! But in general I adore the italian life style and don't loose the opportunity to visit this country. ", PostTime=new DateTime(2022,2,1)};
            com20.Rating = r2;
            Comment com21 = new Comment() { CommentContent = "For real this trip is for art lovers, I enjoyed so much Reina Sofia Museum plus my husband visited Real Madrid's stadium so was a double win.", PostTime=new DateTime(2022,2,1)};
            com21.Rating = r2;
            Comment com22 = new Comment() { CommentContent = "I enjoyed a lot the food, the view, the hotel.Everything was amazing but not the vans that was trasferring us from place to place... We felt unsafe and we had to rent a car for ourselves.", PostTime=new DateTime(2021,12,1)};
            com22.Rating = r2;
            Comment com23 = new Comment() { CommentContent = "Top destination! Quite expensive but worth the money", PostTime=new DateTime(2021,11,10)};
            com23.Rating = r2;
            Comment com24 = new Comment() { CommentContent = "I had a nice time there but not  an extraordinary place", PostTime=new DateTime(2022,3,28)};
            com2.Rating = r3;
            Comment com25 = new Comment() { CommentContent = "Nice job guys, keep it this way", PostTime=new DateTime(2022,2,28)};
            com25.Rating = r2;
            Comment com26 = new Comment() { CommentContent = "Happy that crossed this capital from my bucket list. Had fun wandering around the city.", PostTime=new DateTime(2021,10,28)};
            com26.Rating = r2;
            Comment com27 = new Comment() { CommentContent = "After so many years of marriage we visited Cancun and renewed our love, better than holiday. We had such an amazing time we didn't left the resort.", PostTime=new DateTime(2021,10,28)};
            com27.Rating = r2;
            Comment com28 = new Comment() { CommentContent = "We had amazing time at exotic Cancun. We loved wandering in the city and we made new friends.", PostTime=new DateTime(2022,1,28)};
            com28.Rating = r2;

            List<Comment> comments = new List<Comment>() { com1, com2,com3,com4,com5,com6,com7,com8,com9,com10,com11,com12,com13,com14,com15,com16,com17,com18,com19,com20,com21,com22,com23,
           com24,com25,com26,com27,com28 };
            db.Comments.AddRange(comments);


            p1.Comments.Add(com2);
            p5.Comments.Add(com1);
            p3.Comments.Add(com3);
            p2.Comments.Add(com4);
            p4.Comments.Add(com5);
            p6.Comments.Add(com6);
            p7.Comments.Add(com7);
            p8.Comments.Add(com8);
            p9.Comments.Add(com9);
            p10.Comments.Add(com10);
            p11.Comments.Add(com11);
            p12.Comments.Add(com12);
            p13.Comments.Add(com13);
            p14.Comments.Add(com14);
            p15.Comments.Add(com15);
            p16.Comments.Add(com16);
            p17.Comments.Add(com17);
            p18.Comments.Add(com18);
            p19.Comments.Add(com19);
            p20.Comments.Add(com20);
            p21.Comments.Add(com21);
            p22.Comments.Add(com22);
            p23.Comments.Add(com23);
            p24.Comments.Add(com24);
            p25.Comments.Add(com25);
            p26.Comments.Add(com26);
            p14.Comments.Add(com27);
            p14.Comments.Add(com28);

            com1.ApplicationUser = ap1;
            com2.ApplicationUser = ap2;
            com3.ApplicationUser = ap12;
            com4.ApplicationUser = ap3;
            com5.ApplicationUser = ap5;
            com6.ApplicationUser = ap9;
            com7.ApplicationUser = ap8;
            com8.ApplicationUser = ap5;
            com9.ApplicationUser = ap9;
            com11.ApplicationUser = ap4;
            com12.ApplicationUser = ap7;
            com13.ApplicationUser = ap6;
            com14.ApplicationUser = ap10;
            com15.ApplicationUser = ap11;
            com16.ApplicationUser = ap12;
            com17.ApplicationUser = ap8;
            com18.ApplicationUser = ap4;
            com19.ApplicationUser = ap1;
            com20.ApplicationUser = ap6;
            com21.ApplicationUser = ap7;
            com22.ApplicationUser = ap3;
            com23.ApplicationUser = ap5;
            com24.ApplicationUser = ap6;
            com25.ApplicationUser = ap8;
            com26.ApplicationUser = ap4;
            com27.ApplicationUser = ap2;
            com28.ApplicationUser = ap8;
            #endregion

            //Flight Seeding
            #region aircompanies
            Flight f1 = new Flight() { CompanyName = "Aegean Airlines" };
            Flight f2 = new Flight() { CompanyName = "Turkish Airlines" };
            Flight f3 = new Flight() { CompanyName = "Lufthansa Airlines" };
            Flight f4 = new Flight() { CompanyName = "Ryanair Airlines" };
            List<Flight> flights = new List<Flight>() { f1, f2, f3, f4 };
            db.Flights.AddRange(flights);

            p1.Flight = f1;
            p2.Flight = f2;
            p3.Flight = f2;
            p4.Flight = f3;
            p5.Flight = f1;
            p6.Flight = f3;
            p7.Flight = f2;
            p8.Flight = f2;
            p9.Flight = f4;
            p10.Flight = f4;
            p11.Flight = f1;
            p12.Flight = f1;
            p13.Flight = f3;
            p14.Flight = f2;
            p15.Flight = f3;
            p16.Flight = f2;
            p17.Flight = f3;
            p18.Flight = f2;
            p19.Flight = f1;
            p20.Flight = f1;
            p21.Flight = f2;
            p22.Flight = f3;
            p23.Flight = f3;
            p24.Flight = f1;
            p25.Flight = f1;
            p26.Flight = f4;
#endregion


            //Hotel Seeding
            #region hotels
            Hotel h1 = new Hotel() { HotelName = "Saint-Roch", MapEmbededUrl = "https://www.google.com/maps/embed?pb=!1m14!1m8!1m3!1d1371578.3464393283!2d0.4517993!3d47.8228538!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x47e66e2fc254a387%3A0x577904b1300e4ac7!2sH%C3%B4tel%20Saint%20Roch!5e0!3m2!1sen!2sgr!4v1647555131144!5m2!1sen!2sgr", HotelStars = 2, Destinations = Destinations.Paris };
            Hotel h2 = new Hotel() { HotelName = "InnAthens", MapEmbededUrl = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3145.1600039324967!2d23.732028314815786!3d37.97339510848113!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14a1bd3e119676e7%3A0x93f811d49b5e927d!2sINNATHENS%20HOTEL!5e0!3m2!1sen!2sgr!4v1647557551859!5m2!1sen!2sgr", HotelStars = 3, Destinations = Destinations.Athens };
            Hotel h3 = new Hotel() { HotelName = "Royal Palace Luxury Hotel", MapEmbededUrl = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d23755.145321876313!2d12.46329223955078!3d41.90590610000001!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x132f6055aa8c9451%3A0x6136f4b5c3fb2d3c!2sRoyal%20Palace%20Luxury%20Hotel!5e0!3m2!1sen!2sgr!4v1647563026489!5m2!1sen!2sgr", HotelStars = 4, Destinations = Destinations.Rome };
            Hotel h4 = new Hotel() { HotelName = "Catalonia Atenas", MapEmbededUrl = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d5984.501640833719!2d2.1822930631818833!3d41.412073656162754!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x12a4a32887f34395%3A0xd83c995bbcadbca8!2sHotel%20Catalonia%20Atenas!5e0!3m2!1sen!2sgr!4v1647557627131!5m2!1sen!2sgr", HotelStars = 3, Destinations = Destinations.Barcelona };
            Hotel h5 = new Hotel() { HotelName = "The California", MapEmbededUrl = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d2482.111756808161!2d-0.12565318469073225!3d51.52951001690808!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x48761b395f8925f1%3A0xb1a49585b93e2b35!2sThe%20California%20Hotel!5e0!3m2!1sen!2sgr!4v1647557761307!5m2!1sen!2sgr", HotelStars = 3, Destinations = Destinations.London };
            Hotel h6 = new Hotel() { HotelName = "Patio São Vicente", MapEmbededUrl = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3113.096701465115!2d-9.1302479851608!3d38.715588765246316!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0xd19338a3d909c55%3A0x583a038c8d45001f!2sPatio%20S%C3%A3o%20Vicente%20Guest%20Houses!5e0!3m2!1sen!2sgr!4v1647557953711!5m2!1sen!2sgr", HotelStars = 4, Destinations = Destinations.Lisbon };
            Hotel h7 = new Hotel() { HotelName = "Artemis Cave Suits", MapEmbededUrl = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3116.350357757421!2d34.8294108148368!3d38.64082366963287!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x152a687723611df9%3A0xf53172bac40e5847!2sArtemis%20Cave%20Suites!5e0!3m2!1sen!2sgr!4v1647558056432!5m2!1sen!2sgr", HotelStars = 2, Destinations = Destinations.Cappadocia };
            Hotel h8 = new Hotel() { HotelName = "Occidental Praha Five", MapEmbededUrl = "https://maps.google.com/maps?q=Occidental%20Praha%20Five&t=&z=13&ie=UTF8&iwloc=&output=embed", HotelStars = 4, Destinations = Destinations.Prague };
            Hotel h9 = new Hotel() { HotelName = "Fosshotel Baron", MapEmbededUrl = "https://maps.google.com/maps?q=Fosshotel%20Baron&t=&z=13&ie=UTF8&iwloc=&output=embed", HotelStars = 3, Destinations = Destinations.Iceland };
            Hotel h10 = new Hotel() { HotelName = " Westcord Fashion Hotel Amsterdam", MapEmbededUrl = "https://maps.google.com/maps?q=Westcord%20Fashion%20Hotel%20Amsterdam&t=&z=13&ie=UTF8&iwloc=&output=embed", HotelStars = 4, Destinations = Destinations.Amsterdam };
            Hotel h11 = new Hotel() { HotelName = "San Antonio Summer House", MapEmbededUrl = "https://maps.google.com/maps?q=San%20Antonio%20Summer%20House&t=&z=13&ie=UTF8&iwloc=&output=embed", HotelStars = 3, Destinations = Destinations.Paros };
            Hotel h12 = new Hotel() { HotelName = "Hipotels Playa de Palma Palace&Spa", MapEmbededUrl = "https://maps.google.com/maps?q=Hipotels%20Playa%20de%20Palma%20Palace&Spa%22&t=&z=13&ie=UTF8&iwloc=&output=embed", HotelStars = 5, Destinations = Destinations.Mallorca};
            Hotel h13 = new Hotel() { HotelName = "Agallis Corfu Residence", MapEmbededUrl = "https://maps.google.com/maps?q=Agallis%20Corfu%20Residence&t=&z=13&ie=UTF8&iwloc=&output=embed", HotelStars = 4, Destinations = Destinations.Kerkyra};
            Hotel h14 = new Hotel() { HotelName = "Excellence Playa Mujeres - Adults Only All Inclusive", MapEmbededUrl = "https://maps.google.com/maps?q=Excellence%20Playa%20Mujeres%20-%20Adults%20Only%20All%20Inclusive&t=&z=13&ie=UTF8&iwloc=&output=embed", HotelStars = 5, Destinations = Destinations.Cancun};
            Hotel h15 = new Hotel() { HotelName = "Patagonia Atiram Hotel", MapEmbededUrl = "https://maps.google.com/maps?q=Patagonia%20Atiram%20Hotel&t=&z=13&ie=UTF8&iwloc=&output=embed", HotelStars = 4, Destinations = Destinations.Andorra};
            Hotel h16 = new Hotel() { HotelName = "Coin de Mire Attitude", MapEmbededUrl = "https://maps.google.com/maps?q=Coin%20de%20Mire%20Attitude&t=&z=13&ie=UTF8&iwloc=&output=embed", HotelStars = 4, Destinations = Destinations.Mauritius};
            Hotel h17 = new Hotel() { HotelName = "Five Jumeirah Village", MapEmbededUrl = "https://maps.google.com/maps?q=Five%20Jumeirah%20Village&t=&z=13&ie=UTF8&iwloc=&output=embed", HotelStars = 5, Destinations = Destinations.Dubai };
            Hotel h19 = new Hotel() { HotelName = "Hotel Felix", MapEmbededUrl = "https://maps.google.com/maps?q=Hotel%20Felix%20zurich&t=&z=13&ie=UTF8&iwloc=&output=embed", HotelStars = 3, Destinations = Destinations.Zurich};
            Hotel h20 = new Hotel() { HotelName = "Hotel Dei Cavalieri Milano Duomo", MapEmbededUrl = "https://maps.google.com/maps?q=Hotel%20Dei%20Cavalieri%20Milano%20Duomo&t=&z=13&ie=UTF8&iwloc=&output=embed", HotelStars = 4, Destinations = Destinations.Milan};
            Hotel h21 = new Hotel() { HotelName = "Casa Santo Angel", MapEmbededUrl = "https://maps.google.com/maps?q=Casa%20Santo%20Angel&t=&z=13&ie=UTF8&iwloc=&output=embed", HotelStars = 3, Destinations = Destinations.Madrid };
            Hotel h22 = new Hotel() { HotelName = "Memories Apartments", MapEmbededUrl = "https://maps.google.com/maps?q=Memories%20Apartments&t=&z=13&ie=UTF8&iwloc=&output=embed", HotelStars = 3, Destinations = Destinations.Zakunthos };
            Hotel h23 = new Hotel() { HotelName = "Aster Hotel Group", MapEmbededUrl = "https://maps.google.com/maps?q=Aster%20Hotel%20Group,%20Uzbe&t=&z=13&ie=UTF8&iwloc=&output=embed", HotelStars = 3, Destinations = Destinations.Uzbekistan };
            List<Hotel> hotels = new List<Hotel>() { h1, h2, h3, h4, h5,h6,h7,h8,h9,h10,h11,h12,h13,h14,h15,h16,h17,h19,h20,h21,h22,h23 };
            db.Hotels.AddRange(hotels);

            p1.Hotel = h4;
            p2.Hotel = h1;
            p3.Hotel = h2;
            p4.Hotel = h5;
            p5.Hotel = h3;
            p6.Hotel = h6;
            p7.Hotel = h7;
            p8.Hotel = h23;
            p9.Hotel = h8;
            p10.Hotel = h9;
            p11.Hotel = h10;
            p12.Hotel = h11;
            p13.Hotel = h13;
            p17.Hotel = h12;
            p14.Hotel = h14;
            p15.Hotel = h15;
            p16.Hotel = h16;
            p18.Hotel = h17;
            p19.Hotel = h19;
            p20.Hotel = h20;
            p21.Hotel = h21;
            p22.Hotel = h22;
            p23.Hotel = h4;
            p24.Hotel = h20;
            p25.Hotel = h12;
            p26.Hotel = h5;
            #endregion


            //Rate Seeding
            //Rating r1 = new Rating() { RateScore = 3};
            //Rating r2 = new Rating() { RateScore = 5};
            //Rating r3 = new Rating() { RateScore = 4};
            //List<Rating> ratings = new List<Rating>() { r1, r2, r3 };
            //db.Ratings.AddRange(ratings);



            //ReplyComment Seeding
            ReplyComment rep1 = new ReplyComment() { ReplyContent = "All recommendations were within our budget. An invaluable service! Thank you", ReplyPostTime = DateTime.Now };
            ReplyComment rep2 = new ReplyComment() { ReplyContent = "The video chat was well worth the fee, and helped us to fell confident about our choices for the trip", ReplyPostTime = DateTime.Now };

            List<ReplyComment> replyComments = new List<ReplyComment>() { rep1, rep2 };
            db.ReplyComments.AddRange(replyComments);

            rep1.ApplicationUser = ap1;
            rep2.ApplicationUser = ap2;

            com1.ReplyComments.Add(rep2);
            com2.ReplyComments.Add(rep1);

            db.SaveChanges();
        }

    }
}
