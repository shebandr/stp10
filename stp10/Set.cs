using System;
using System.Collections.Generic;
using System.Text;

namespace stp10
{
    public class Set<T> : TSet<T> where T : new()
    {
        public Set() : base()
        {

        }
        public Set<T> Union(TSet<T> ts)
        {
            Set<T> newtset = new Set<T>();
            foreach (T t in this.hashset)
            {
                newtset.Add(t);
            }
            foreach (T t in ts.hashset)
            {
                newtset.Add(t);
            }
            return newtset;
        }
        public Set<T> Except(Set<T> ts)
        {
            Set<T> newtset = new Set<T>();
            foreach (T t in this.hashset)
            {
                newtset.Add(t);
            }
            foreach (T t in ts.hashset)
            {
                newtset.Remove(t);
            }
            return newtset;
        }
        public Set<T> Intersect(Set<T> ts)
        {
            Set<T> newtset = new Set<T>();
            foreach (T t in this.hashset)
            {
                if (ts.Contains(t))
                    newtset.Add(t);
            }
            return newtset;
        }
    }
}
