﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Graph.Classes
{
    //Node
    public class Vertex
    {
        public object Value { get; set; }

        public Vertex(object value)
        {
            Value = value;
        }
    }
}
