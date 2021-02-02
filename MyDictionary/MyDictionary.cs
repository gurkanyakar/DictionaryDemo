using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<Key,Value>
    {
        Key[] keys;
        Value[] values;

        public MyDictionary()
        {
            keys = new Key[0];
            values = new Value[0];
        }
        public void Add(Key key, Value value)
        {
            Key[] tempKeyArray = keys;
            Value[] tempValueArray = values;

            keys = new Key[keys.Length + 1];
            values = new Value[values.Length + 1];

            for (int i = 0; i < tempKeyArray.Length; i++)
            {
                keys[i] = tempKeyArray[i];
                values[i] = tempValueArray[i];
            }
            keys[keys.Length-1] = key;//parametre olarak gelen key son elemana eklenir
            values[values.Length - 1] = value; //parametre olarak gelen value son elemana eklenir

            
        }
        public void Print() {
            for (int i = 0; i < keys.Length; i++)
            {
                Console.WriteLine("Telefon kodu : \t"+keys[i] +"\tÜlke : \t"+values[i]);
            }
        }
        
        
    }
}
