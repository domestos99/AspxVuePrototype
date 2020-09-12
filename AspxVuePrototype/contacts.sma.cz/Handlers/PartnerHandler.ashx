<%@ WebHandler Language="C#" Class="PartnerHandler" %>

using System;
using System.Web;
using Fmm.Helpers;

public class PartnerHandler : GenericHandler
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

        if (action == "search")
        {
            new PartnerHandlerProcessor().Search(context);
            return;
        }



        WriteErrorResponse(context, "Action value not found.");
        return;

    }
}