#pragma checksum "C:\Users\DAO MINH HIEU\source\repos\THESIS_EMAIL_MARKETING_WEB_APPLICATION\EMAIL_MARKETING\EMAIL_MARKETING_THESIS_PROJECT\Views\MailingList\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "115e9c67be99c70d248db4429e8c64075aac41a4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MailingList_Details), @"mvc.1.0.view", @"/Views/MailingList/Details.cshtml")]
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
#nullable restore
#line 1 "C:\Users\DAO MINH HIEU\source\repos\THESIS_EMAIL_MARKETING_WEB_APPLICATION\EMAIL_MARKETING\EMAIL_MARKETING_THESIS_PROJECT\Views\MailingList\Details.cshtml"
using EMAIL_MARKETING_THESIS_PROJECT.Views.Common;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"115e9c67be99c70d248db4429e8c64075aac41a4", @"/Views/MailingList/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a8441262f96f86ecee5365768ea35cd879df5554", @"/Views/_ViewImports.cshtml")]
    public class Views_MailingList_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EMAIL_MARKETING_THESIS_PROJECT.Views.ViewModels.MailingLists.MailingListDetailsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditSubscriber", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "MailingList", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-toggle", new global::Microsoft.AspNetCore.Html.HtmlString("modal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-target", new global::Microsoft.AspNetCore.Html.HtmlString("#editMailingList"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteSubscriber", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-check-input"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control-file"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "file", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\Users\DAO MINH HIEU\source\repos\THESIS_EMAIL_MARKETING_WEB_APPLICATION\EMAIL_MARKETING\EMAIL_MARKETING_THESIS_PROJECT\Views\MailingList\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h4>");
#nullable restore
#line 13 "C:\Users\DAO MINH HIEU\source\repos\THESIS_EMAIL_MARKETING_WEB_APPLICATION\EMAIL_MARKETING\EMAIL_MARKETING_THESIS_PROJECT\Views\MailingList\Details.cshtml"
Write(Model.MailingList.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4>
<br />
<div>
    <button type=""button"" class=""btn btn-info"" data-toggle=""modal"" data-target=""#addContactModal""><i class=""fa fa-plus""></i>&nbsp;Add Contacts</button>
    <button type=""button"" class=""btn btn-info"" data-toggle=""modal"" data-target=""#segmentModal""><i class=""fa fa-plus""></i>&nbsp;Add Segment</button>
</div>
<br />

<table class=""table table-hover"">
    <thead class=""table-primary"">
        <tr>
            <th>");
#nullable restore
#line 24 "C:\Users\DAO MINH HIEU\source\repos\THESIS_EMAIL_MARKETING_WEB_APPLICATION\EMAIL_MARKETING\EMAIL_MARKETING_THESIS_PROJECT\Views\MailingList\Details.cshtml"
           Write(Html.Label("Name"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th>");
#nullable restore
#line 25 "C:\Users\DAO MINH HIEU\source\repos\THESIS_EMAIL_MARKETING_WEB_APPLICATION\EMAIL_MARKETING\EMAIL_MARKETING_THESIS_PROJECT\Views\MailingList\Details.cshtml"
           Write(Html.Label("Phone"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th>");
#nullable restore
#line 26 "C:\Users\DAO MINH HIEU\source\repos\THESIS_EMAIL_MARKETING_WEB_APPLICATION\EMAIL_MARKETING\EMAIL_MARKETING_THESIS_PROJECT\Views\MailingList\Details.cshtml"
           Write(Html.Label("Email"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n");
#nullable restore
#line 27 "C:\Users\DAO MINH HIEU\source\repos\THESIS_EMAIL_MARKETING_WEB_APPLICATION\EMAIL_MARKETING\EMAIL_MARKETING_THESIS_PROJECT\Views\MailingList\Details.cshtml"
             if (HasRfmSubscribers())
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <th>");
#nullable restore
#line 29 "C:\Users\DAO MINH HIEU\source\repos\THESIS_EMAIL_MARKETING_WEB_APPLICATION\EMAIL_MARKETING\EMAIL_MARKETING_THESIS_PROJECT\Views\MailingList\Details.cshtml"
               Write(Html.Label("Rate"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n");
#nullable restore
#line 30 "C:\Users\DAO MINH HIEU\source\repos\THESIS_EMAIL_MARKETING_WEB_APPLICATION\EMAIL_MARKETING\EMAIL_MARKETING_THESIS_PROJECT\Views\MailingList\Details.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <th>");
#nullable restore
#line 32 "C:\Users\DAO MINH HIEU\source\repos\THESIS_EMAIL_MARKETING_WEB_APPLICATION\EMAIL_MARKETING\EMAIL_MARKETING_THESIS_PROJECT\Views\MailingList\Details.cshtml"
           Write(Html.Label("Action"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 36 "C:\Users\DAO MINH HIEU\source\repos\THESIS_EMAIL_MARKETING_WEB_APPLICATION\EMAIL_MARKETING\EMAIL_MARKETING_THESIS_PROJECT\Views\MailingList\Details.cshtml"
         foreach (var item in Model.Subscribers)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <th scope=\"row\">");
#nullable restore
#line 39 "C:\Users\DAO MINH HIEU\source\repos\THESIS_EMAIL_MARKETING_WEB_APPLICATION\EMAIL_MARKETING\EMAIL_MARKETING_THESIS_PROJECT\Views\MailingList\Details.cshtml"
                           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <td>");
#nullable restore
#line 40 "C:\Users\DAO MINH HIEU\source\repos\THESIS_EMAIL_MARKETING_WEB_APPLICATION\EMAIL_MARKETING\EMAIL_MARKETING_THESIS_PROJECT\Views\MailingList\Details.cshtml"
               Write(item.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 41 "C:\Users\DAO MINH HIEU\source\repos\THESIS_EMAIL_MARKETING_WEB_APPLICATION\EMAIL_MARKETING\EMAIL_MARKETING_THESIS_PROJECT\Views\MailingList\Details.cshtml"
               Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 42 "C:\Users\DAO MINH HIEU\source\repos\THESIS_EMAIL_MARKETING_WEB_APPLICATION\EMAIL_MARKETING\EMAIL_MARKETING_THESIS_PROJECT\Views\MailingList\Details.cshtml"
                 if (HasRfmSubscribers())
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>");
#nullable restore
#line 44 "C:\Users\DAO MINH HIEU\source\repos\THESIS_EMAIL_MARKETING_WEB_APPLICATION\EMAIL_MARKETING\EMAIL_MARKETING_THESIS_PROJECT\Views\MailingList\Details.cshtml"
                   Write(item.RFMClass);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 45 "C:\Users\DAO MINH HIEU\source\repos\THESIS_EMAIL_MARKETING_WEB_APPLICATION\EMAIL_MARKETING\EMAIL_MARKETING_THESIS_PROJECT\Views\MailingList\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "115e9c67be99c70d248db4429e8c64075aac41a412683", async() => {
                WriteLiteral("<i class=\"fa fa-pencil-square-o\" aria-hidden=\"true\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 47 "C:\Users\DAO MINH HIEU\source\repos\THESIS_EMAIL_MARKETING_WEB_APPLICATION\EMAIL_MARKETING\EMAIL_MARKETING_THESIS_PROJECT\Views\MailingList\Details.cshtml"
                                                                                                       WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "115e9c67be99c70d248db4429e8c64075aac41a415501", async() => {
                WriteLiteral("<i class=\"fa fa-trash\" aria-hidden=\"true\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 48 "C:\Users\DAO MINH HIEU\source\repos\THESIS_EMAIL_MARKETING_WEB_APPLICATION\EMAIL_MARKETING\EMAIL_MARKETING_THESIS_PROJECT\Views\MailingList\Details.cshtml"
                                                                                                         WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 48 "C:\Users\DAO MINH HIEU\source\repos\THESIS_EMAIL_MARKETING_WEB_APPLICATION\EMAIL_MARKETING\EMAIL_MARKETING_THESIS_PROJECT\Views\MailingList\Details.cshtml"
                                                                                                                                            WriteLiteral(Model.MailingList.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["mailinglistId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-mailinglistId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["mailinglistId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 51 "C:\Users\DAO MINH HIEU\source\repos\THESIS_EMAIL_MARKETING_WEB_APPLICATION\EMAIL_MARKETING\EMAIL_MARKETING_THESIS_PROJECT\Views\MailingList\Details.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
#nullable restore
#line 55 "C:\Users\DAO MINH HIEU\source\repos\THESIS_EMAIL_MARKETING_WEB_APPLICATION\EMAIL_MARKETING\EMAIL_MARKETING_THESIS_PROJECT\Views\MailingList\Details.cshtml"
 using (@Html.BeginForm("AddSegment", "Segmentation", FormMethod.Post, new { enctype = "multipart/form-data" }))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 57 "C:\Users\DAO MINH HIEU\source\repos\THESIS_EMAIL_MARKETING_WEB_APPLICATION\EMAIL_MARKETING\EMAIL_MARKETING_THESIS_PROJECT\Views\MailingList\Details.cshtml"
Write(Html.HiddenFor(m => m.AddSegmentationViewModel.MailingListId));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div id=""segmentModal"" class=""modal fade"" role=""dialog"">
        <div class=""modal-dialog"">
            <!-- Modal content-->
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h4 class=""modal-title"">Add Segment</h4>
                    <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
                </div>
                <div class=""modal-body"">
                    <p>Segmentation Name: </p>
                    <div class=""form-group""></div>
                    ");
#nullable restore
#line 69 "C:\Users\DAO MINH HIEU\source\repos\THESIS_EMAIL_MARKETING_WEB_APPLICATION\EMAIL_MARKETING\EMAIL_MARKETING_THESIS_PROJECT\Views\MailingList\Details.cshtml"
               Write(Html.TextBoxFor(m => m.AddSegmentationViewModel.NewName, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                    <hr />\r\n\r\n                    <p>Special Filter: </p>\r\n                    <div class=\"col-sm-3 form-check\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "115e9c67be99c70d248db4429e8c64075aac41a421236", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 75 "C:\Users\DAO MINH HIEU\source\repos\THESIS_EMAIL_MARKETING_WEB_APPLICATION\EMAIL_MARKETING\EMAIL_MARKETING_THESIS_PROJECT\Views\MailingList\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.AddSegmentationViewModel.UseRFMFiltering);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        <label class=""form-check-label"">
                            RFM Filter
                        </label>
                    </div>

                    <hr />

                    <div id=""kmeans-block form-group"">
                        <p>Choose Subscriber Rate Class:</p>
                        ");
#nullable restore
#line 85 "C:\Users\DAO MINH HIEU\source\repos\THESIS_EMAIL_MARKETING_WEB_APPLICATION\EMAIL_MARKETING\EMAIL_MARKETING_THESIS_PROJECT\Views\MailingList\Details.cshtml"
                   Write(Html.DropDownListFor(m => m.AddSegmentationViewModel.SubscriberRateClass, RFMSegments.GetRFMSegments, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>

                    <hr />

                    <div id=""filtering-block"">
                        <div class=""container"">
                            <p>Other Attributes</p>
                            <div class=""row"">
                                <div class=""col-md-3 form-group"">
                                    ");
#nullable restore
#line 95 "C:\Users\DAO MINH HIEU\source\repos\THESIS_EMAIL_MARKETING_WEB_APPLICATION\EMAIL_MARKETING\EMAIL_MARKETING_THESIS_PROJECT\Views\MailingList\Details.cshtml"
                               Write(Html.LabelFor(m => m.AddSegmentationViewModel.CriteriaViewModel.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n                                <div class=\"col-md-6 form-group\">\r\n                                    ");
#nullable restore
#line 98 "C:\Users\DAO MINH HIEU\source\repos\THESIS_EMAIL_MARKETING_WEB_APPLICATION\EMAIL_MARKETING\EMAIL_MARKETING_THESIS_PROJECT\Views\MailingList\Details.cshtml"
                               Write(Html.TextBoxFor(m => m.AddSegmentationViewModel.CriteriaViewModel.Name, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                            <div class=\"row\">\r\n                                <div class=\"col-md-3 form-group\">\r\n                                    ");
#nullable restore
#line 103 "C:\Users\DAO MINH HIEU\source\repos\THESIS_EMAIL_MARKETING_WEB_APPLICATION\EMAIL_MARKETING\EMAIL_MARKETING_THESIS_PROJECT\Views\MailingList\Details.cshtml"
                               Write(Html.LabelFor(m => m.AddSegmentationViewModel.CriteriaViewModel.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n                                <div class=\"col-md-6 form-group\">\r\n                                    ");
#nullable restore
#line 106 "C:\Users\DAO MINH HIEU\source\repos\THESIS_EMAIL_MARKETING_WEB_APPLICATION\EMAIL_MARKETING\EMAIL_MARKETING_THESIS_PROJECT\Views\MailingList\Details.cshtml"
                               Write(Html.TextBoxFor(m => m.AddSegmentationViewModel.CriteriaViewModel.Email, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                            <div class=\"row\">\r\n                                <div class=\"col-md-3 form-group\">\r\n                                    ");
#nullable restore
#line 111 "C:\Users\DAO MINH HIEU\source\repos\THESIS_EMAIL_MARKETING_WEB_APPLICATION\EMAIL_MARKETING\EMAIL_MARKETING_THESIS_PROJECT\Views\MailingList\Details.cshtml"
                               Write(Html.LabelFor(m => m.AddSegmentationViewModel.CriteriaViewModel.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n                                <div class=\"col-md-6 form-group\">\r\n                                    ");
#nullable restore
#line 114 "C:\Users\DAO MINH HIEU\source\repos\THESIS_EMAIL_MARKETING_WEB_APPLICATION\EMAIL_MARKETING\EMAIL_MARKETING_THESIS_PROJECT\Views\MailingList\Details.cshtml"
                               Write(Html.TextBoxFor(m => m.AddSegmentationViewModel.CriteriaViewModel.Age, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                            <div class=\"row\">\r\n                                <div class=\"col-md-3 form-group\">\r\n                                    ");
#nullable restore
#line 119 "C:\Users\DAO MINH HIEU\source\repos\THESIS_EMAIL_MARKETING_WEB_APPLICATION\EMAIL_MARKETING\EMAIL_MARKETING_THESIS_PROJECT\Views\MailingList\Details.cshtml"
                               Write(Html.LabelFor(m => m.AddSegmentationViewModel.CriteriaViewModel.Area));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n                                <div class=\"col-md-6 form-group\">\r\n                                    ");
#nullable restore
#line 122 "C:\Users\DAO MINH HIEU\source\repos\THESIS_EMAIL_MARKETING_WEB_APPLICATION\EMAIL_MARKETING\EMAIL_MARKETING_THESIS_PROJECT\Views\MailingList\Details.cshtml"
                               Write(Html.DropDownListFor(m => m.AddSegmentationViewModel.CriteriaViewModel.Area, Model.AddSegmentationViewModel.Areas, "", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                            <div class=\"row\">\r\n                                <div class=\"col-md-3 form-group\">\r\n                                    ");
#nullable restore
#line 127 "C:\Users\DAO MINH HIEU\source\repos\THESIS_EMAIL_MARKETING_WEB_APPLICATION\EMAIL_MARKETING\EMAIL_MARKETING_THESIS_PROJECT\Views\MailingList\Details.cshtml"
                               Write(Html.LabelFor(m => m.AddSegmentationViewModel.CriteriaViewModel.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n                                <div class=\"col-md-6 form-group\">\r\n                                    ");
#nullable restore
#line 130 "C:\Users\DAO MINH HIEU\source\repos\THESIS_EMAIL_MARKETING_WEB_APPLICATION\EMAIL_MARKETING\EMAIL_MARKETING_THESIS_PROJECT\Views\MailingList\Details.cshtml"
                               Write(Html.DropDownListFor(m => m.AddSegmentationViewModel.CriteriaViewModel.City, Model.AddSegmentationViewModel.Cities, "", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-default btn-primary"" data-dismiss=""modal"">Close</button>
                    <button type=""submit"" class=""btn btn-default btn-primary"">Add Segment</button>
                </div>
            </div>
        </div>
    </div>
");
#nullable restore
#line 143 "C:\Users\DAO MINH HIEU\source\repos\THESIS_EMAIL_MARKETING_WEB_APPLICATION\EMAIL_MARKETING\EMAIL_MARKETING_THESIS_PROJECT\Views\MailingList\Details.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 145 "C:\Users\DAO MINH HIEU\source\repos\THESIS_EMAIL_MARKETING_WEB_APPLICATION\EMAIL_MARKETING\EMAIL_MARKETING_THESIS_PROJECT\Views\MailingList\Details.cshtml"
 using (Html.BeginForm("AddContacts", "MailingList", FormMethod.Post, new { enctype = "multipart/form-data" }))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 147 "C:\Users\DAO MINH HIEU\source\repos\THESIS_EMAIL_MARKETING_WEB_APPLICATION\EMAIL_MARKETING\EMAIL_MARKETING_THESIS_PROJECT\Views\MailingList\Details.cshtml"
Write(Html.HiddenFor(m => m.AddContactsViewModel.MailingListId));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div id=""addContactModal"" class=""modal fade"" role=""dialog"">
        <div class=""modal-dialog"">
            <!-- Modal content-->
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h4 class=""modal-title"">Add Contacts</h4>
                    <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
                </div>
                <div class=""modal-body"">

                    <div class=""form-check"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "115e9c67be99c70d248db4429e8c64075aac41a431795", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 159 "C:\Users\DAO MINH HIEU\source\repos\THESIS_EMAIL_MARKETING_WEB_APPLICATION\EMAIL_MARKETING\EMAIL_MARKETING_THESIS_PROJECT\Views\MailingList\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.AddContactsViewModel.RfmModel);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        <label class=""form-check-label"">
                            RFM Model
                        </label>
                    </div>

                    <hr />

                    <div class=""form-group"">
                        ");
#nullable restore
#line 168 "C:\Users\DAO MINH HIEU\source\repos\THESIS_EMAIL_MARKETING_WEB_APPLICATION\EMAIL_MARKETING\EMAIL_MARKETING_THESIS_PROJECT\Views\MailingList\Details.cshtml"
                   Write(Html.LabelFor(m => m.AddContactsViewModel.Subscribers));

#line default
#line hidden
#nullable disable
            WriteLiteral(" (Format: Name, Email, Phone)\r\n                        ");
#nullable restore
#line 169 "C:\Users\DAO MINH HIEU\source\repos\THESIS_EMAIL_MARKETING_WEB_APPLICATION\EMAIL_MARKETING\EMAIL_MARKETING_THESIS_PROJECT\Views\MailingList\Details.cshtml"
                   Write(Html.TextAreaFor(m => m.AddContactsViewModel.Subscribers, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n\r\n                    <div class=\"form-group\">\r\n                        ");
#nullable restore
#line 173 "C:\Users\DAO MINH HIEU\source\repos\THESIS_EMAIL_MARKETING_WEB_APPLICATION\EMAIL_MARKETING\EMAIL_MARKETING_THESIS_PROJECT\Views\MailingList\Details.cshtml"
                   Write(Html.LabelFor(m => m.AddContactsViewModel.File));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "115e9c67be99c70d248db4429e8c64075aac41a434951", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 174 "C:\Users\DAO MINH HIEU\source\repos\THESIS_EMAIL_MARKETING_WEB_APPLICATION\EMAIL_MARKETING\EMAIL_MARKETING_THESIS_PROJECT\Views\MailingList\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.AddContactsViewModel.File);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-default"" data-dismiss=""modal"">Close</button>
                    <button type=""submit"" class=""btn btn-default"">Add Contacts</button>
                </div>
            </div>
        </div>
    </div>
");
#nullable restore
#line 184 "C:\Users\DAO MINH HIEU\source\repos\THESIS_EMAIL_MARKETING_WEB_APPLICATION\EMAIL_MARKETING\EMAIL_MARKETING_THESIS_PROJECT\Views\MailingList\Details.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 4 "C:\Users\DAO MINH HIEU\source\repos\THESIS_EMAIL_MARKETING_WEB_APPLICATION\EMAIL_MARKETING\EMAIL_MARKETING_THESIS_PROJECT\Views\MailingList\Details.cshtml"
            
    private bool HasRfmSubscribers() => Model.Subscribers.Any(s => (s.Frequency != null || s.Monetary != null || s.Recency != null));

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EMAIL_MARKETING_THESIS_PROJECT.Views.ViewModels.MailingLists.MailingListDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
