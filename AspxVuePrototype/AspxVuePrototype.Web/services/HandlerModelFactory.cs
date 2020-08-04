using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspxVuePrototype.Web.services
{
    public interface IHandlerModel<T>
    {
        bool Create(HttpContext context, out T result);
    }

    public class HandlerModelFactory
    {
        public static bool Create<T>(HttpContext context, out T result) where T : IHandlerModel<T>, new()
        {
            T obj = new T();
            var b = obj.Create(context, out obj);
            result = obj;
            return b;
        }


        public static IDictionary<string, string> GetDictionary(HttpContext context)
        {
            var req = context.Request;

            var forms = req.Form.ToDictionary();
            var qs = req.QueryString.ToDictionary();

            var dic = new Dictionary<string, string>();

            foreach (var a in forms)
            {
                dic.Add(a.Key, a.Value);
            }

            foreach (var a in qs)
            {
                dic.Add(a.Key, a.Value);
            }


            return dic;
        }
    }
}