using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Headless.DB.Tables
{
    public class ActualPage
    {
        [Key]
        public Guid Id { get; set; }
        public string Body { get; set; }



        [ForeignKey("FK_ActualPage_Lang")]
        public Guid LangId { get; set; }
        public Lang? Lang { get; set; }

        [ForeignKey("FK_ActualPage_Page")]
        public Guid PageID { get; set; }
        public Page? Page { get; set; }

    }
}
