<%@ WebHandler Language="C#" Class="TestHandler" %>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AspxVuePrototype.Web.App_Code.Processors;
using AspxVuePrototype.Web.Services;


public class TestHandler : GenericHandler
{
    public override void ProcessRequest(HttpContext context)
    {
        context.Response.ContentType = "application/json";
        string action;
        if (!GetParamString(context, "Action", out action))
        {
            return;
        }

        action = action.Trim().ToLower();

        if (action == "test")
        {
            new TestProcessor().Test(context);
            return;
        }
    }
}