using System;
using System.Collections.Generic;
using System.Text;

namespace Hashtables.Classes
{
    class Node
    {
        /// <summary>
        /// Key contained within node. Can be different data types.
        /// </summary>
        public object Key { get; set; }

        /// <summary>
        /// Value contained within node. Can be different data types.
        /// </summary>
        public object Value { get; set; }

        /// <summary>
        /// The pointer going towards the next node in sequence.
        /// </summary>
        public Node Next { get; set; }

        //Constructor
        public Node(object key, object value)
        {
            Key = key;
            Value = value;
        }
    }
}
