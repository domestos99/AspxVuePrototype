using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace AspxVuePrototype.Web.services
{
    public class TestModel : IHandlerModel<TestModel>
    {
        
        public string Action { get; set; }

        [Required]
        public string Test { get; set; }

        public int Count { get; set; }

        public bool IsTrue { get; set; }

        public DateTime Created { get; set; }

        public bool Create(HttpContext context, out TestModel result)
        {
            var dic = HandlerModelFactory.GetDictionary(context);

            var json = JsonConvert.SerializeObject(dic, Newtonsoft.Json.Formatting.Indented);
            var myobject = JsonConvert.DeserializeObject<TestModel>(json);

            var con = new ValidationContext(myobject);
            Validator.ValidateObject(myobject,con);

            result = myobject;
            return true;
        }
    }
}