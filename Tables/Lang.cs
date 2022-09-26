using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Headless.DB.Tables
{
    public class Lang : IEquatable<Lang>
    {
        [Key]
        public Guid Id { get; set; }
        public string LanguageName { get; set; }

        public string LanguageIdentifier { get; set; }

        public bool Equals(Lang? other)
        {
            if(this.Id != other.Id || this.LanguageName != other.LanguageName || this.LanguageIdentifier != other.LanguageIdentifier)
                return false;
            else
                return true;
        }
    }
}
