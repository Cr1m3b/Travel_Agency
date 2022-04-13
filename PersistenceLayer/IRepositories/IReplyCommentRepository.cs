using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersistenceLayer.IRepositories
{
    public interface IReplyCommentRepository
    {
        IEnumerable<ReplyComment> GetAllWithRelatedTables();
        ReplyComment GetByIdWithRelatedTables(int? id);
    }
}
