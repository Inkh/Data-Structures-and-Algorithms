using System;
using System.Text;
using LinkedList.Classes;

namespace Hashtables.Classes
{
    class Hashtable
    {
        public LList[] List { get; set; }

        public Hashtable()
        {
            List = new LList[1024];
        }
    }
}
