using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CSharp.Test
{
    public class Shared
    {
        public string FormatarErro(string str, string strR)
        {
            return "parametro(s):" + str + " esperado -> " + strR;
        }

        private bool _IsList(Type type)
        {
            return type.IsArray || type.Name.Contains("List");
        }

        public bool EqualsDictionary(Dictionary<string, string> d1, Dictionary<string, string> d2)
        {
            return d1.OrderBy(kvp => kvp.Key).SequenceEqual(d2.OrderBy(kvp => kvp.Key));
        }
        public bool EqualsDictionary(Dictionary<string, object[]> d1, Dictionary<string, object[]> d2)
        {
            if (d1.Count != d2.Count) return false;
            foreach (var item in d1)
            {
                if (!d2.ContainsKey(item.Key)) return false;
                var d2Value = d2[item.Key];
                if (!_EqualsListObjs(item.Value, d2Value)) return false;
            }
            return true;
        }

        private bool _IsPrimitiveType(Type type)
        {
            return
                type.IsPrimitive ||
                new Type[] {
                typeof(int),
                typeof(double),
                typeof(float),
                typeof(string),
                typeof(decimal),
                typeof(DateTime),
                typeof(DateTimeOffset),
                typeof(TimeSpan),
                typeof(Guid)
                }.Contains(type);
        }

        public bool EqualsObj(object obj1, object obj2)
        {
            if (obj1 == null || obj2 == null) return false;

            if (_IsPrimitiveType(obj1.GetType()))
            {
                if (obj1.ToString() != obj2.ToString())
                {
                    return false;
                }
                return true;
            }

            var propsObj1 = obj1.GetType().GetProperties().OrderBy(p => p.Name).ToArray();
            var propsObj2 = obj2.GetType().GetProperties().OrderBy(p => p.Name).ToArray();

            if (propsObj1.Length != propsObj2.Length) return false;
            var isEquals = true;
            for (var index = 0; index < propsObj1.Length; index++)
            {
                var prop1 = propsObj1[index];
                var prop2 = propsObj2[index];

                var val1 = prop1.GetValue(obj1);
                var val2 = prop2.GetValue(obj2);

                if (_IsList(val1.GetType()) && _IsList(val2.GetType()))
                {
                    if (val1.GetType().GetProperties().Length != val2.GetType().GetProperties().Length)
                    {
                        isEquals = false;
                        break;
                    }
                    isEquals = _EqualsListObjs(val1 as IList, val2 as IList);
                    if (!isEquals)
                    {
                        isEquals = false;
                        break;
                    }
                }
                else if (!_IsPrimitiveType(val1.GetType()))
                {
                    isEquals = EqualsObj(val1, val2);
                    if (!isEquals)
                    {
                        isEquals = false;
                        break;
                    }
                }
                else if (!val1.Equals(val2))
                {
                    isEquals = false;
                    break;
                }
            }
            return isEquals;
        }


        private bool _EqualsListObjs(IList lst1, IList lst2)
        {
            if (lst1.Count != lst2.Count) return false;
            var countEquals = 0;
            for (var index1 = 0; index1 < lst1.Count; index1++)
            {
                for (var index2 = 0; index2 < lst2.Count; index2++)
                {
                    if (EqualsObj(lst1[index1], lst2[index2]))
                    {
                        countEquals++;
                    }
                }
            }
            return countEquals == lst1.Count;
        }
    }
}