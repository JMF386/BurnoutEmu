using System;
using System.Collections.Generic;
using System.Text;

namespace BreakinIn.Messages
{
    public class SeleIn : AbstractMessage
    {
        public override string _Name { get => "sele"; }

        public string MYGAME { get; set; }
        public string ROOMS { get; set; }
        public string USERS { get; set; }
        public string MESGS { get; set; }
        public string STATS { get; set; }
        public string RANKS { get; set; }

        public override void Process(AbstractEAServer context, EAClient client)
        {
            //TODO: provide some actual statistics
            client.SendMessage(new SeleOut());
        }
    }
}
