using System;
using System.Collections;
using System.Text;

namespace homework18
{
    public class MyList<T> : IEnumerable
    {
        public T[] body { get; set; }
        public object count
        {
            get
            {
                object n = 0;
                n = (object)body.Length;
                return n;
            }
        }

        public void Add(object obj)
        {
            T new_el = (T)obj;
            int n = (int)count;
            T[] newbody = new T[n + 1];

            for (int i = 0; i <= n + 1; i++)
            {
                newbody[i] = (i == n) ? new_el : body[i];
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
    public class MyDictionary<Tkey, Tvalue> : IEnumerable
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
                Tvalue v = valuelist[0];
                for (int i = 0; i < count; i++)
                    if ((object)keylist[i] == (object)key)
                    {
                        v = valuelist[i];
                    }
                return v;
            }
            set
            {
                for (int i = 0; i < count; i++)
                    if ((object)keylist[i] == (object)key)
                    {
                        valuelist[i] = value;
                    }
            }
        }
        //реализация foreach
        public IEnumerator GetEnumerator()
        {
            return valuelist.GetEnumerator();
        }
    }
}
