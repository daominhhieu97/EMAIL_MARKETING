#pragma checksum "C:\Users\DAO MINH HIEU\source\repos\THESIS_EMAIL_MARKETING_WEB_APPLICATION\EMAIL_MARKETING\EMAIL_MARKETING_THESIS_PROJECT\Views\Campaign\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c7e336981609811360ab7e7df74e9b628cb0750"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Campaign_Create), @"mvc.1.0.view", @"/Views/Campaign/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c7e336981609811360ab7e7df74e9b628cb0750", @"/Views/Campaign/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a8441262f96f86ecee5365768ea35cd879df5554", @"/Views/_ViewImports.cshtml")]
    public class Views_Campaign_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EMAIL_MARKETING_THESIS_PROJECT.Views.ViewModels.Campaigns.CreateCampaignViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\DAO MINH HIEU\source\repos\THESIS_EMAIL_MARKETING_WEB_APPLICATION\EMAIL_MARKETING\EMAIL_MARKETING_THESIS_PROJECT\Views\Campaign\Create.cshtml"
  
    ViewData["Title"] = "Create";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\Users\DAO MINH HIEU\source\repos\THESIS_EMAIL_MARKETING_WEB_APPLICATION\EMAIL_MARKETING\EMAIL_MARKETING_THESIS_PROJECT\Views\Campaign\Create.cshtml"
 using (Html.BeginForm("Create", "Campaign", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""container"">
        <h4>Create a Campaign</h4>
        <div>
            <div class=""row"">
                <div class=""col-md-12"">
                    <div class=""well well-lg form-group"">
                        <label id=""step1"">Title:</label>
                        ");
#nullable restore
#line 17 "C:\Users\DAO MINH HIEU\source\repos\THESIS_EMAIL_MARKETING_WEB_APPLICATION\EMAIL_MARKETING\EMAIL_MARKETING_THESIS_PROJECT\Views\Campaign\Create.cshtml"
                   Write(Html.TextBoxFor(m => m.Campaign.Title, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 18 "C:\Users\DAO MINH HIEU\source\repos\THESIS_EMAIL_MARKETING_WEB_APPLICATION\EMAIL_MARKETING\EMAIL_MARKETING_THESIS_PROJECT\Views\Campaign\Create.cshtml"
                   Write(Html.ValidationMessageFor(m => m.Campaign.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n\r\n                    <div class=\"well well-lg form-group\">\r\n                        <label id=\"step2\">Mailing lists:</label>\r\n                        ");
#nullable restore
#line 23 "C:\Users\DAO MINH HIEU\source\repos\THESIS_EMAIL_MARKETING_WEB_APPLICATION\EMAIL_MARKETING\EMAIL_MARKETING_THESIS_PROJECT\Views\Campaign\Create.cshtml"
                   Write(Html.DropDownListFor(m => m.SelectedMailingListId, Model.GetMailingListItems(), new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n\r\n                    <div class=\"well well-lg form-group\">\r\n                        <div class=\"form-group\" id=\"step3\">\r\n                            <label>Template lists:</label>\r\n                            ");
#nullable restore
#line 29 "C:\Users\DAO MINH HIEU\source\repos\THESIS_EMAIL_MARKETING_WEB_APPLICATION\EMAIL_MARKETING\EMAIL_MARKETING_THESIS_PROJECT\Views\Campaign\Create.cshtml"
                       Write(Html.DropDownListFor(m => m.SelectedTemplateId, Model.GetTemplateItems(), new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </div>
                    </div>

                    <div class=""well well-lg"">
                        <div class=""form-group"">
                            <h4 id=""step4"">Sender email address</h4>
                            ");
#nullable restore
#line 36 "C:\Users\DAO MINH HIEU\source\repos\THESIS_EMAIL_MARKETING_WEB_APPLICATION\EMAIL_MARKETING\EMAIL_MARKETING_THESIS_PROJECT\Views\Campaign\Create.cshtml"
                       Write(Html.TextBoxFor(m => m.Campaign.EmailInfo.Sender, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 37 "C:\Users\DAO MINH HIEU\source\repos\THESIS_EMAIL_MARKETING_WEB_APPLICATION\EMAIL_MARKETING\EMAIL_MARKETING_THESIS_PROJECT\Views\Campaign\Create.cshtml"
                       Write(Html.ValidationMessageFor(m => m.Campaign.EmailInfo.Sender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n\r\n                        <div class=\"form-group\">\r\n                            <label>Name:</label>\r\n                            ");
#nullable restore
#line 42 "C:\Users\DAO MINH HIEU\source\repos\THESIS_EMAIL_MARKETING_WEB_APPLICATION\EMAIL_MARKETING\EMAIL_MARKETING_THESIS_PROJECT\Views\Campaign\Create.cshtml"
                       Write(Html.TextBoxFor(m => m.Campaign.EmailInfo.Name, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 43 "C:\Users\DAO MINH HIEU\source\repos\THESIS_EMAIL_MARKETING_WEB_APPLICATION\EMAIL_MARKETING\EMAIL_MARKETING_THESIS_PROJECT\Views\Campaign\Create.cshtml"
                       Write(Html.ValidationMessageFor(m => m.Campaign.EmailInfo.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n\r\n                        <div class=\"form-group\">\r\n                            <label>Subject line:</label>\r\n                            ");
#nullable restore
#line 48 "C:\Users\DAO MINH HIEU\source\repos\THESIS_EMAIL_MARKETING_WEB_APPLICATION\EMAIL_MARKETING\EMAIL_MARKETING_THESIS_PROJECT\Views\Campaign\Create.cshtml"
                       Write(Html.TextBoxFor(m => m.Campaign.EmailInfo.Subject, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 49 "C:\Users\DAO MINH HIEU\source\repos\THESIS_EMAIL_MARKETING_WEB_APPLICATION\EMAIL_MARKETING\EMAIL_MARKETING_THESIS_PROJECT\Views\Campaign\Create.cshtml"
                       Write(Html.ValidationMessageFor(m => m.Campaign.EmailInfo.Subject));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </div>
                    </div>
                </div>
            </div>
            <div class=""well well-lg form-group"">
                <h4 id=""step5"">Sending the campaign</h4>

                <div class=""form-row"">
                    <div class=""col-md-3"">
                        ");
#nullable restore
#line 59 "C:\Users\DAO MINH HIEU\source\repos\THESIS_EMAIL_MARKETING_WEB_APPLICATION\EMAIL_MARKETING\EMAIL_MARKETING_THESIS_PROJECT\Views\Campaign\Create.cshtml"
                   Write(Html.CheckBoxFor(m => m.Campaign.Scheduler.IsSendNow));

#line default
#line hidden
#nullable disable
            WriteLiteral(" Is Sent Now\r\n                    </div>\r\n                    <div class=\"col-md-3\">\r\n                        <div class=\"input-group\">\r\n                            ");
#nullable restore
#line 63 "C:\Users\DAO MINH HIEU\source\repos\THESIS_EMAIL_MARKETING_WEB_APPLICATION\EMAIL_MARKETING\EMAIL_MARKETING_THESIS_PROJECT\Views\Campaign\Create.cshtml"
                       Write(Html.TextBoxFor(m => m.Campaign.Scheduler.SendOn, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            <span class=""input-group-addon"">
                                <i class=""fa fa-calendar"" aria-hidden=""true"" data-date-format=""dd-mm-yyyy""></i>
                            </span> &nbsp;
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""form-group"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0c7e336981609811360ab7e7df74e9b628cb075011590", async() => {
                WriteLiteral("<i class=\"fa fa-arrow-left\"></i>&nbsp;Back to List");
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
            WriteLiteral("\r\n            &nbsp;\r\n            <button class=\"btn btn-info btn-sm \" type=\"submit\"><i class=\"fa fa-plus\"></i>&nbsp;Create</button>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 78 "C:\Users\DAO MINH HIEU\source\repos\THESIS_EMAIL_MARKETING_WEB_APPLICATION\EMAIL_MARKETING\EMAIL_MARKETING_THESIS_PROJECT\Views\Campaign\Create.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EMAIL_MARKETING_THESIS_PROJECT.Views.ViewModels.Campaigns.CreateCampaignViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
