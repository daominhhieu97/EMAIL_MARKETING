#pragma checksum "C:\Users\DAO MINH HIEU\source\repos\THESIS_EMAIL_MARKETING_WEB_APPLICATION\EMAIL_MARKETING\EMAIL_MARKETING_THESIS_PROJECT\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e52882c5e8d95eb611e1a86dcffd4f67a029bdb4"
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
#line 1 "C:\Users\DAO MINH HIEU\source\repos\THESIS_EMAIL_MARKETING_WEB_APPLICATION\EMAIL_MARKETING\EMAIL_MARKETING_THESIS_PROJECT\Views\_ViewImports.cshtml"
using EMAIL_MARKETING_THESIS_PROJECT;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\DAO MINH HIEU\source\repos\THESIS_EMAIL_MARKETING_WEB_APPLICATION\EMAIL_MARKETING\EMAIL_MARKETING_THESIS_PROJECT\Views\_ViewImports.cshtml"
using EMAIL_MARKETING_THESIS_PROJECT.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e52882c5e8d95eb611e1a86dcffd4f67a029bdb4", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a8441262f96f86ecee5365768ea35cd879df5554", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\DAO MINH HIEU\source\repos\THESIS_EMAIL_MARKETING_WEB_APPLICATION\EMAIL_MARKETING\EMAIL_MARKETING_THESIS_PROJECT\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""container"">
    <div class=""row"">
        <div class=""col-md-4"">
            <div class=""row"">
                <div class=""col-md-12"">
                    <a href=""#"" class=""btn btn-success"" role=""button"">New Campaign</a>
                </div>
            </div>
            <div class=""row"">
                <div class=""col-md-12"">
                    <a href=""#"" class=""btn btn-primary"" role=""button"">Mailing List</a>
                </div>
            </div>
            <div class=""row"">
                <div class=""col-md-12"">
                    <a href=""#"" class=""btn btn-primary"" role=""button"">My Campaigns</a>
                </div>
            </div>
            <div class=""row"">
                <div class=""col-md-12"">
                    <a href=""#"" class=""btn btn-primary"" role=""button"">Email Templates</a>
                </div>
            </div>
        </div>
        <div class=""col-md-8"">
            ");
#nullable restore
#line 29 "C:\Users\DAO MINH HIEU\source\repos\THESIS_EMAIL_MARKETING_WEB_APPLICATION\EMAIL_MARKETING\EMAIL_MARKETING_THESIS_PROJECT\Views\Home\Index.cshtml"
       Write(Html.Partial("_MailingLists"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
