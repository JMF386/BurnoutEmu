using System;
using System.Collections.Generic;
using System.Text;

namespace BreakinIn.Messages
{
    public class NewsOut : AbstractMessage
    {
        public override string _Name { get => "newsnew0"; }

        public string NEWS { get; set; } = "VTSTECH.WAS.HERE\n";
    }
}
