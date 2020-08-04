using System;
using System.Web;
using AspxVuePrototype.Web.services;
using Newtonsoft.Json;

namespace AspxVuePrototype.Web.Services
{

    public abstract class GenericHandler : IHttpHandler
    {
        public virtual void ProcessRequest(HttpContext context)
        {
            throw new NotImplementedException();
        }

        public bool IsReusable => false;


        public virtual bool GetParamString(HttpContext context, string name, out string value)
        {
            value = context.Request[name];
            if (!string.IsNullOrWhiteSpace(value))
                return true;
            this.WriteErrorResponse(context, name + " missing.", (object)null);
            return false;
        }

        public virtual void WriteSuccessResponse(HttpContext context, string message, object data = null)
        {
            JsonResponse jsonResponse = new JsonResponse()
            {
                Success = true,
                Data = data,
                Message = message
            };
            context.Response.Write(JsonConvert.SerializeObject((object)jsonResponse));
        }

        public virtual void WriteErrorResponse(HttpContext context, string message, object data = null)
        {
            JsonResponse jsonResponse = new JsonResponse()
            {
                Success = false,
                Data = data,
                Message = message
            };
            context.Response.Write(JsonConvert.SerializeObject((object)jsonResponse));
        }
    }

}