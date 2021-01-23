using System;
using System.Collections.Generic;
using System.Text;

namespace BreakinIn.Messages
{
    public class SviwIn : AbstractMessage
    {
        public override string _Name { get => "sviw"; }

        public string VIEW { get; set; }

        public override void Process(AbstractEAServer context, EAClient client)
        {
            client.SendMessage(new SviwOut());
        }
    }
}