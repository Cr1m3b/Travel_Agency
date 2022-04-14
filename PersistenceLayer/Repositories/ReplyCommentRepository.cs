using MyDatabase;
using PersistenceLayer.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Entities.Models;

namespace PersistenceLayer.Repositories
{
    public class ReplyCommentRepository : GenericRepository<ReplyComment>, IReplyCommentRepository
    {
        public ReplyCommentRepository(ApplicationDbContext context) : base(context)
        {
        }

        public IEnumerable<ReplyComment> GetAllWithRelatedTables()
        {
            return Context.ReplyComments.Include(r => r.ApplicationUser)
                                        .Include(r => r.Comment);
        }

        public ReplyComment GetByIdWithRelatedTables(int? id)
        {
            if (id == null)
            {
                throw new ArgumentException("Bad Request");
            }
            var replycomment = Context.ReplyComments.Include(r => r.ApplicationUser)
                                          .Include(r => r.Comment)
                                         .ToList().Find(r => r.ReplyCommentId == id);
            return replycomment;
        }

    }
}
