using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Fmm.Helpers;

public class PartnerHandlerProcessor : GenericHandler
{
    public void Search(HttpContext context)
    {

        var output = new List<Partner>();

        output.Add(new Partner()
        {
            Name = "Google",
            Street = "XXX"
        });

        output.Add(new Partner()
        {
            Name = "Microsoft",
            Street = "YYY"
        });


        WriteSuccessResponse(context, "", output);
    }
}


public class Partner
{
    public string Name { get; set; }
    public string Street { get; set; }
}