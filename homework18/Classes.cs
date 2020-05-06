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
}
