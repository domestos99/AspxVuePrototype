using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Web;
using AspxVuePrototype.Web.services;
using AspxVuePrototype.Web.Services;

namespace AspxVuePrototype.Web.App_Code.Processors
{
    public class TestProcessor : GenericHandler
    {
        public void Test(HttpContext context)
        {
            TestModel model;
            var a = HandlerModelFactory.Create<TestModel>(context, out model);

           


            WriteErrorResponse(context, "", model);
            return;
        }

        private static dynamic DictionaryToObject(IDictionary<String, Object> dictionary)
        {
            var expandoObj = new ExpandoObject();
            var expandoObjCollection = (ICollection<KeyValuePair<String, Object>>)expandoObj;

            foreach (var keyValuePair in dictionary)
            {
                expandoObjCollection.Add(keyValuePair);
            }
            dynamic eoDynamic = expandoObj;
            return eoDynamic;
        }

        private static T DictionaryToObject<T>(IDictionary<String, Object> dictionary) where T : class
        {
            return DictionaryToObject(dictionary) as T;
        }
    }


    
}