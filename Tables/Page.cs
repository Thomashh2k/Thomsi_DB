using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Headless.DB.Tables
{
    public class Page
    {
        [Key]
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Route { get; set; }

    }
}
