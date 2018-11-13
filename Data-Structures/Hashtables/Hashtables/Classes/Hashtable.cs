using System;
using System.Text;
namespace Hashtables.Classes
{
    class Hashtable
    {
        public LinkedList[] List { get; set; }

        public Hashtable()
        {
            List = new LinkedList[1024];
        }

        public void Add(object key, object value)
        {
            int sumIdx = (int)key.ToString()[0];
            for (int i = 1; i < key.ToString().Length; i++)
            {
                sumIdx += key.ToString()[i];
            }

            sumIdx = (sumIdx * 599) % 1024;

            if (List[sumIdx] == null)
            {
                List[sumIdx] = new LinkedList(new Node(key, value));
            }
        }
    }
}
