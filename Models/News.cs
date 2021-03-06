using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NEWS_SITE.Models
{
    public class News
    {
        public int Id { get; set; }

        public string Title { get; set; }
        public DateTime Date{ get; set; }
        public string Topic { get; set; }

        public string Image { get; set; }
        [ForeignKey("catogery")]
        public int catogeryID { get; set; }
        public Catogery catogery { get; set; }

    }
}
