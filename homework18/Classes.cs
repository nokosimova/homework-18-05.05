using System;
using System.Collections;
using System.Text;

namespace homework18
{
    public class MyList<T> : IEnumerable
    {
        public T[] body { get; set; }
        public int count { get { return body.Length; } }

        public void Add(T new_el)
        {
            T[] newbody = new T[count + 1];

            for (int i = 0; i <= count + 1; i++)
            {
                newbody[i] = (i == count) ? new_el : body[i];
            }
            this.body = newbody;
        }
        //индексатор
        public T this[int index]
        {
            get { return body[index]; }
            set { body[index] = value; }
        }

        //реализация foreach
        public IEnumerator GetEnumerator()
        {
            return body.GetEnumerator();
        }
    }
    public class MyDictionary<Tkey,Tvalue>
    {
        Tkey[] keylist { get; set; }
        Tvalue[] valuelist { get; set; }
        int count { get { return keylist.Length; } }
        public void Add(Tkey newkey, Tvalue newvalue)
        {
            Tkey[] newkeylist = new Tkey[count + 1];
            Tvalue[] newvaluelist = new Tvalue[count + 1];
            for (int i = 0; i <= count + 1; i++)
            {
                newkeylist[i] = (i == count) ? newkey : keylist[i];
                newvaluelist[i] = (i == count) ? newvalue : valuelist[i];
                keylist = newkeylist;
                valuelist = newvaluelist;
            }
        }
        //индексатор
        public Tvalue this[Tkey key]
        {
            get
            {
                Tvalue v = new Tvalue();
                for(i = 0; i < count; i++)
                    if (keylist[i] == key)
                    {
                        return valuelist[i];
                    }
                Console.Writeline("Error, no element with such key");
                retun v;
            }
            set { 
                for(i = 0; i < count; i++)
                    if (keylist[i] == key)
                    {
                        valuelist[i] = value;
                    }
            }
        }
    }
}
