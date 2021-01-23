using System;
using System.Collections.Generic;
using System.Text;

namespace BreakinIn.Messages
{
    public class SviwOut : AbstractMessage
    {
        public override string _Name { get => "sviw"; }

        public string VIEW { get; set; } = "PS2";
    }
}
