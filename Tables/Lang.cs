using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Headless.DB.Tables
{
    public class Lang
    {
        [Key]
        public Guid Id { get; set; }
        public string LanguageName { get; set; }

        public string LanguageIdentifier { get; set; }

    }
}
