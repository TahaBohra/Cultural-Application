﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CultureOfPakistan
{
  public class Gilgitbaltistan
    {
        public Gilgitbaltistan(string regionIDs, string IDs, string Imagess, string descriptions, string largeDescriptions)
        {
            regionID = regionIDs;
            ID = IDs;
            Images = Imagess;
            description = descriptions;
            largeDescription = largeDescriptions;
        }
        public Gilgitbaltistan()
        { }

        public string regionID { get; set; }
        public string ID { get; set; }
        public string Images { get; set; }
        public string description { get; set; }
        public string largeDescription { get; set; }
    }
}
