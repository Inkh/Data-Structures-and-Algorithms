﻿using System;
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

        /// <summary>
        /// Returns the index of a key
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public int GetHash(string key)
        {
            int sumIdx = (int)key[0];

            for (int i = 1; i < key.Length; i++)
            {
                sumIdx += key[i];
            }

            return (sumIdx * 599) / 1024;
        }

        /// <summary>
        /// Takes in key value pair and adds to hash table
        /// </summary>
        /// <param name="key">Key</param>
        /// <param name="value">Value</param>
        public void Add(object key, object value)
        {
            int idx = GetHash(key.ToString());
            Console.WriteLine(idx);
            if (List[idx] == null)
            {
                List[idx] = new LinkedList(new Node(key, value));
            }
            else
            {
                Node curr = List[idx].Head;
                while (curr.Next != null)
                {
                    curr = curr.Next;
                }
                curr.Next = new Node(key, value);
            }
        }

        /// <summary>
        /// Takes in a key and checks whether the key exists in Hashtable.
        /// </summary>
        /// <param name="key">Key</param>
        /// <returns>True or False</returns>
        public bool Contains(string key)
        {
            int idx = GetHash(key);
            if (List[idx] == null)
            {
                return false;
            }

            Node curr = List[idx].Head;
            while (curr != null)
            {
                if ((string)curr.Key == key)
                {
                    return true;
                }
                curr = curr.Next;
            }
            return false;
        }

        /// <summary>
        /// Takes in a key and returns the value associated with the key.
        /// Returns error message instead if no such key exists.
        /// </summary>
        /// <param name="key">Key</param>
        /// <returns>Value associated with Key, or Error message</returns>
        public string Find(string key)
        {
            int idx = GetHash(key);
            if (List[idx] == null)
            {
                return "Key does not exist";
            }
            Node curr = List[idx].Head;
            while (curr != null)
            {
                if ((string)curr.Key == key)
                {
                    return (string)curr.Value;
                }
                curr = curr.Next;
            }
            return "Key does not exist";
        }
    }
}