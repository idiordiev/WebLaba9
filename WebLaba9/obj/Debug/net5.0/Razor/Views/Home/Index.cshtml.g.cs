#pragma checksum "C:\Users\Ivan\RiderProjects\WebLaba9\WebLaba9\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "70551f754c1d4319fdf52207876644d23021956a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Ivan\RiderProjects\WebLaba9\WebLaba9\Views\_ViewImports.cshtml"
using WebLaba9;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ivan\RiderProjects\WebLaba9\WebLaba9\Views\_ViewImports.cshtml"
using WebLaba9.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70551f754c1d4319fdf52207876644d23021956a", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d10ccd65960b353fabcee35ce650a466162aa762", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebLaba9.Models.AllEmailsViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Ivan\RiderProjects\WebLaba9\WebLaba9\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\Ivan\RiderProjects\WebLaba9\WebLaba9\Views\Home\Index.cshtml"
 if (!User.Identity.IsAuthenticated)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h2>Please, log in or register</h2>\r\n    <a class=\"btn btn-primary\"");
            BeginWriteAttribute("onclick", " onclick=\"", 204, "\"", 299, 3);
            WriteAttributeValue("", 214, "showPopup(\'", 214, 11, true);
#nullable restore
#line 10 "C:\Users\Ivan\RiderProjects\WebLaba9\WebLaba9\Views\Home\Index.cshtml"
WriteAttributeValue("", 225, Url.Action("Register", "Home", null, Context.Request.Scheme), 225, 61, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 286, "\',\'Register\')", 286, 13, true);
            EndWriteAttribute();
            WriteLiteral(">Register</a>\r\n    <a class=\"btn btn-primary\"");
            BeginWriteAttribute("onclick", " onclick=\"", 345, "\"", 434, 3);
            WriteAttributeValue("", 355, "showPopup(\'", 355, 11, true);
#nullable restore
#line 11 "C:\Users\Ivan\RiderProjects\WebLaba9\WebLaba9\Views\Home\Index.cshtml"
WriteAttributeValue("", 366, Url.Action("Login", "Home", null, Context.Request.Scheme), 366, 58, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 424, "\',\'Login\')", 424, 10, true);
            EndWriteAttribute();
            WriteLiteral(">Login</a>\r\n");
#nullable restore
#line 12 "C:\Users\Ivan\RiderProjects\WebLaba9\WebLaba9\Views\Home\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div id=\"email-tables\">\r\n        ");
#nullable restore
#line 16 "C:\Users\Ivan\RiderProjects\WebLaba9\WebLaba9\Views\Home\Index.cshtml"
   Write(await Html.PartialAsync("_EmailTables", Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 18 "C:\Users\Ivan\RiderProjects\WebLaba9\WebLaba9\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebLaba9.Models.AllEmailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
