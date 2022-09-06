﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Headless.DB.Tables
{
    public class File
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public bool isVideo { get; set; }
        public string FilePath { get; set; }
    }
}
