using Entities.Models;
using MyDatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using PersistenceLayer.IRepositories;

namespace PersistenceLayer.Repositories
{
    public class CommentRepository : GenericRepository<Comment>,ICommentRepository
    {
        public CommentRepository(ApplicationDbContext context) : base(context)
        {

        }

        public IEnumerable<Comment> GetAllWithRelatedTables()
        {
            return Context.Comments.Include(c => c.ApplicationUser)
                                    .Include(c => c.ReplyComments)
                                    .Include(c => c.Package)
                                    .ToList();
        }

        public Comment GetByIdWithRelatedTables(int? id)
        {
            if (id == null)
            {
                throw new ArgumentException("Bad Request");
            }

            var comment = Context.Comments.Include(c => c.ApplicationUser)
                                       .Include(c => c.ReplyComments)
                                       .Include(c => c.Package)
                                       .ToList().Find(c => c.CommentId == id);

            return comment;
        }
    }
}
