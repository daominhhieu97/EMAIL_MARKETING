#pragma checksum "C:\Users\DAO MINH HIEU\source\repos\THESIS_EMAIL_MARKETING_WEB_APPLICATION\EMAIL_MARKETING\EMAIL_MARKETING_THESIS_PROJECT\Views\Campaign\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5149e614de4c046e478e5251791a22b540312542"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Campaign_Index), @"mvc.1.0.view", @"/Views/Campaign/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5149e614de4c046e478e5251791a22b540312542", @"/Views/Campaign/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a8441262f96f86ecee5365768ea35cd879df5554", @"/Views/_ViewImports.cshtml")]
    public class Views_Campaign_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EMAIL_MARKETING_THESIS_PROJECT.Models.Campaigns.Campaign>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\DAO MINH HIEU\source\repos\THESIS_EMAIL_MARKETING_WEB_APPLICATION\EMAIL_MARKETING\EMAIL_MARKETING_THESIS_PROJECT\Views\Campaign\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h4>All Campaigns</h4>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5149e614de4c046e478e5251791a22b5403125424431", async() => {
                WriteLiteral("<i class=\"fa fa-plus\" aria-hidden=\"true\"></i>&nbsp;New Campaign");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n\r\n<table class=\"table table-hover\">\r\n    <thead>\r\n        <tr class=\"table-primary\">\r\n            <th>\r\n                ");
#nullable restore
#line 18 "C:\Users\DAO MINH HIEU\source\repos\THESIS_EMAIL_MARKETING_WEB_APPLICATION\EMAIL_MARKETING\EMAIL_MARKETING_THESIS_PROJECT\Views\Campaign\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                Send Date\r\n            </th>\r\n            <th>\r\n                Subject Line\r\n            </th>\r\n            <th>Action</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 30 "C:\Users\DAO MINH HIEU\source\repos\THESIS_EMAIL_MARKETING_WEB_APPLICATION\EMAIL_MARKETING\EMAIL_MARKETING_THESIS_PROJECT\Views\Campaign\Index.cshtml"
         foreach (var item in Model)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\DAO MINH HIEU\source\repos\THESIS_EMAIL_MARKETING_WEB_APPLICATION\EMAIL_MARKETING\EMAIL_MARKETING_THESIS_PROJECT\Views\Campaign\Index.cshtml"
       Write(Html.Partial("_CampaignItem", item));

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\DAO MINH HIEU\source\repos\THESIS_EMAIL_MARKETING_WEB_APPLICATION\EMAIL_MARKETING\EMAIL_MARKETING_THESIS_PROJECT\Views\Campaign\Index.cshtml"
                                                
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EMAIL_MARKETING_THESIS_PROJECT.Models.Campaigns.Campaign>> Html { get; private set; }
    }
}
#pragma warning restore 1591
