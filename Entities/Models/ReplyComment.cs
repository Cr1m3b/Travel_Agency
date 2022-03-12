using Entities.IdentityUsers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class ReplyComment
    {
        [Key]
        public int ReplyCommentId { get; set; }

        [Display(Name = "Comments")]
        //[MinLength(5, ErrorMessage = "Comment cannot be less than 5")]
        //[MaxLength(200, ErrorMessage = "Comment cannot be greater than 200")]
        public string ReplyContent { get; set; }
        public DateTime ReplyPostTime { get; set; }

        //TODO: Navigation Properties for ReplyComment
        public ApplicationUser ApplicationUser { get; set; }

        public int CommentId { get; set; }

        public Comment Comment { get; set; }
    }
}
