using System;
using System.Collections.Generic;
using System.Text;

namespace BreakinIn.Messages
{
    public class UatrIn : AbstractMessage
    {
        public override string _Name { get => "uatr"; }

        public string HWFLAG { get; set; }
        public string HWMASK { get; set; }
        
        public override void Process(AbstractEAServer context, EAClient client)
        {
            //var response = new UatrOut();
            //var rc = context as RedirectorServer;
            //if (rc == null) return;
            client.SendMessage(new UatrOut());


        }
    }
}