using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RelationalDatabase.ViewModels
{
    public class GroupToObject<K,T>
    {
        public K Key;
        public IEnumerable<T> Values;
    }
}