using Headless.DB.DataObj;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Headless.DB.Tables
{
    public class CustomForm
    {
        [Key]
        public Guid Id { get; set; }
        public string FormName { get; set; }
        public string[] Inputs { get; set; }

    }
}
