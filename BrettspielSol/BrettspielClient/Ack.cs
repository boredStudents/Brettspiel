using System;
using System.Collections.Generic;
using System.Text;

namespace BrettspielClient
{
    public class Ack
    {
        public string GUID;

        public Ack()
        {

        }
        public Ack(string gUID)
        {
            GUID = gUID;
        }
    }
}
