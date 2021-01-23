using System;
using System.Collections.Generic;
using System.Text;

namespace BreakinIn.Messages
{
    public class UatrOut : AbstractMessage
    {
        public override string _Name { get => "uatr"; }

        public string HWFLAG { get; set; } = "0";
        public string HWMASK { get; set; } = "0";
    }
}
