using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace homework18
{
    public class MyList<T> : IEnumerable
    {
        public T[] body = new T[0];
        public int count
        {
            get
            {
                return body.Length;
            }
        }

        public void Add(object obj)
        {
            T new_el = (T)obj;
            int n = (int)count;
            T[] newbody = new T[n + 1];

            for (int i = 0; i <= n; i++)
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
    public class MyDictionary<Tkey, Tvalue>
    {
        public Tkey[] keylist { get; set; }
        public Tvalue[] valuelist { get; set; }
        public Pair<Tkey, Tvalue>[] item { get; set; }
        public int count { get { return keylist.Length; } }

        public MyDictionary()
        {
            Tkey[] klist = new Tkey[0];
            Tvalue[] vlist = new Tvalue[0];
            keylist = klist;
            valuelist = vlist;
        }
        public void Add(object obj1, object obj2)
        {
            int n = (int)count;
            Tkey newkey = (Tkey)obj1;
            Tvalue newvalue = (Tvalue)obj2;

            Tkey[] newkeylist = new Tkey[n + 1];
            Tvalue[] newvaluelist = new Tvalue[n + 1];
            for (int i = 0; i <= n; i++)
            {
                newkeylist[i] = (i != n) ? keylist[i] : newkey;
                newvaluelist[i] = (i != n) ? valuelist[i] : newvalue;
            }
            this.keylist = newkeylist;
            this.valuelist = newvaluelist;
        }
        //индексатор
        public Tvalue this[Tkey key]
        {
            get
            {
                for (int i = 0; i < count; i++)
                {
                    if (keylist[i] == (dynamic)key)
                        return valuelist[i];
                }
                throw new NullReferenceException();
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
        //реализация интервейса IEnumerable
        public IEnumerator GetEnumerator()
        {
            return new DictionaryEnumerator<Tkey, Tvalue>(keylist, valuelist);
        }

    }
    public class DictionaryEnumerator<Tkey, Tvalue> : IEnumerator
    {
        public Pair<Tkey, Tvalue>[] item;
        public int curposition = -1;
        public int size = 0;
        DictionaryEnumerator(Tkey[] keylist, Tvalue[] valuelist)
        {
            for (int i = 0; i < keylist.Length; i++)
            {
                item[i].key = keylist[i];
                item[i].value = valuelist[i];
            }
        }

        public bool MoveNext()
        {
            if (curposition < size)
            {
                curposition++;
                return true;
            }
            else
                return false;
        }
        /*  public object Current()
          {
              get{
                  if (curposition == -1 || curposition >= size)
                      throw new InvalidOperationException();
                  return (object)item[curposition];
              }
          }*/
        object IEnumerator.Current => throw new NotImplementedException();
        public void Reset()
        {
            curposition = -1;
        }

    }
    public class Pair<Tkey, Tvalue>
    {
        public Tkey key { get; set; }
        public Tvalue value { get; set; }
    }
}
