#pragma checksum "C:\Users\msi\Desktop\Yeni klasör (3)\BlogProject_5175.WEB\Views\Article\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c9fb3ba9c0f163d2a25163039b08d00047505d7c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Article_Detail), @"mvc.1.0.view", @"/Views/Article/Detail.cshtml")]
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
#line 1 "C:\Users\msi\Desktop\Yeni klasör (3)\BlogProject_5175.WEB\Views\_ViewImports.cshtml"
using BlogProject_5175.WEB;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\msi\Desktop\Yeni klasör (3)\BlogProject_5175.WEB\Views\_ViewImports.cshtml"
using BlogProject_5175.WEB.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\msi\Desktop\Yeni klasör (3)\BlogProject_5175.WEB\Views\_ViewImports.cshtml"
using BlogProject_5175.Models.Entities.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\msi\Desktop\Yeni klasör (3)\BlogProject_5175.WEB\Views\_ViewImports.cshtml"
using BlogProject_5175.WEB.Models.DTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\msi\Desktop\Yeni klasör (3)\BlogProject_5175.WEB\Views\_ViewImports.cshtml"
using BlogProject_5175.WEB.Models.VMs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\msi\Desktop\Yeni klasör (3)\BlogProject_5175.WEB\Views\_ViewImports.cshtml"
using BlogProject_5175.WEB.Areas.Member.Models.VMs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\msi\Desktop\Yeni klasör (3)\BlogProject_5175.WEB\Views\_ViewImports.cshtml"
using BlogProject_5175.WEB.Areas.Member.Models.DTOs;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9fb3ba9c0f163d2a25163039b08d00047505d7c", @"/Views/Article/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"941513bd44b61eb3b613036986f9b5cdeaf187bb", @"/Views/_ViewImports.cshtml")]
    public class Views_Article_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BlogProject_5175.Models.Entities.Concrete.Article>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "AppUser", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UserDetail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color:inherit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Filter", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Article", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\msi\Desktop\Yeni klasör (3)\BlogProject_5175.WEB\Views\Article\Detail.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col-md-10\" style=\"text-align:center\">\r\n            <br />\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c9fb3ba9c0f163d2a25163039b08d00047505d7c7503", async() => {
                WriteLiteral("\r\n                <p style=\"text-align:center\"><strong>Yazar: </strong><img");
                BeginWriteAttribute("src", " src=\"", 426, "\"", 452, 1);
#nullable restore
#line 13 "C:\Users\msi\Desktop\Yeni klasör (3)\BlogProject_5175.WEB\Views\Article\Detail.cshtml"
WriteAttributeValue("", 432, Model.AppUser.Image, 432, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" width=\"40\" height=\"40\" />  ");
#nullable restore
#line 13 "C:\Users\msi\Desktop\Yeni klasör (3)\BlogProject_5175.WEB\Views\Article\Detail.cshtml"
                                                                                                                           Write(Model.AppUser.FirstName);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 13 "C:\Users\msi\Desktop\Yeni klasör (3)\BlogProject_5175.WEB\Views\Article\Detail.cshtml"
                                                                                                                                                    Write(Model.AppUser.LastName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 12 "C:\Users\msi\Desktop\Yeni klasör (3)\BlogProject_5175.WEB\Views\Article\Detail.cshtml"
                                                                  WriteLiteral(Model.AppUserID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            <p>Oluşturulma Tarihi : ");
#nullable restore
#line 16 "C:\Users\msi\Desktop\Yeni klasör (3)\BlogProject_5175.WEB\Views\Article\Detail.cshtml"
                               Write(Model.CreateDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 17 "C:\Users\msi\Desktop\Yeni klasör (3)\BlogProject_5175.WEB\Views\Article\Detail.cshtml"
             if (Model.ReadTime == 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p>Tahmini Okuma Süresi: 1 dk</p>\r\n");
#nullable restore
#line 20 "C:\Users\msi\Desktop\Yeni klasör (3)\BlogProject_5175.WEB\Views\Article\Detail.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p>Tahmini Okuma Süresi: ");
#nullable restore
#line 23 "C:\Users\msi\Desktop\Yeni klasör (3)\BlogProject_5175.WEB\Views\Article\Detail.cshtml"
                                    Write(Model.ReadTime);

#line default
#line hidden
#nullable disable
            WriteLiteral(" dk</p>\r\n");
#nullable restore
#line 24 "C:\Users\msi\Desktop\Yeni klasör (3)\BlogProject_5175.WEB\Views\Article\Detail.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p>Okunma Sayısı : ");
#nullable restore
#line 25 "C:\Users\msi\Desktop\Yeni klasör (3)\BlogProject_5175.WEB\Views\Article\Detail.cshtml"
                          Write(Model.ReadCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <div class=\"col-md-10\">\r\n                <div class=\"row\">\r\n");
#nullable restore
#line 28 "C:\Users\msi\Desktop\Yeni klasör (3)\BlogProject_5175.WEB\Views\Article\Detail.cshtml"
                     if (Model.ArticleCategories.Count != 0)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <strong>Kategoriler : </strong>\r\n");
#nullable restore
#line 31 "C:\Users\msi\Desktop\Yeni klasör (3)\BlogProject_5175.WEB\Views\Article\Detail.cshtml"
                         foreach (var item in Model.ArticleCategories)
                        {
                            if (item.Category.Statu != BlogProject_5175.Models.Enums.Statu.Passive)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"position-relative p-2\">\r\n                                    <h3>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c9fb3ba9c0f163d2a25163039b08d00047505d7c13880", async() => {
#nullable restore
#line 36 "C:\Users\msi\Desktop\Yeni klasör (3)\BlogProject_5175.WEB\Views\Article\Detail.cshtml"
                                                                                                                                                     Write(item.Category.Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 36 "C:\Users\msi\Desktop\Yeni klasör (3)\BlogProject_5175.WEB\Views\Article\Detail.cshtml"
                                                                                                                            WriteLiteral(item.CategoryID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</h3>\r\n                                </div>\r\n");
#nullable restore
#line 38 "C:\Users\msi\Desktop\Yeni klasör (3)\BlogProject_5175.WEB\Views\Article\Detail.cshtml"
                            }
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "C:\Users\msi\Desktop\Yeni klasör (3)\BlogProject_5175.WEB\Views\Article\Detail.cshtml"
                         
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n            <h1>");
#nullable restore
#line 43 "C:\Users\msi\Desktop\Yeni klasör (3)\BlogProject_5175.WEB\Views\Article\Detail.cshtml"
           Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n            <br />\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 1854, "\"", 1872, 1);
#nullable restore
#line 45 "C:\Users\msi\Desktop\Yeni klasör (3)\BlogProject_5175.WEB\Views\Article\Detail.cshtml"
WriteAttributeValue("", 1860, Model.Image, 1860, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"900\" height=\"300\" />\r\n\r\n            <br /> <br /> <br />\r\n\r\n            <p style=\"word-wrap:break-word\">");
#nullable restore
#line 49 "C:\Users\msi\Desktop\Yeni klasör (3)\BlogProject_5175.WEB\Views\Article\Detail.cshtml"
                                       Write(Model.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n            <div class=\"text-left\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c9fb3ba9c0f163d2a25163039b08d00047505d7c18404", async() => {
                WriteLiteral("Beğen");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                <p>Beğenilme Sayısı: ");
#nullable restore
#line 53 "C:\Users\msi\Desktop\Yeni klasör (3)\BlogProject_5175.WEB\Views\Article\Detail.cshtml"
                                Write(Model.Likes.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <br />\r\n            </div>\r\n\r\n");
#nullable restore
#line 57 "C:\Users\msi\Desktop\Yeni klasör (3)\BlogProject_5175.WEB\Views\Article\Detail.cshtml"
             foreach (var item in Model.Comments.OrderByDescending(a => a.CreateDate))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""container mt-3"">
                    <div class=""d-flex justify-content-center row"">
                        <div class=""col-md-10"">
                            <div class=""d-flex flex-column comment-section"">
                                <div class=""bg-white p-2"">

                                    <div class=""d-flex flex-row user-info"">

                                        <img class=""rounded-circle""");
            BeginWriteAttribute("src", " src=\"", 2796, "\"", 2822, 1);
#nullable restore
#line 67 "C:\Users\msi\Desktop\Yeni klasör (3)\BlogProject_5175.WEB\Views\Article\Detail.cshtml"
WriteAttributeValue("", 2802, Model.AppUser.Image, 2802, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"40\">\r\n                                        <div class=\"d-flex flex-column justify-content-start ml-2\">\r\n                                            <span class=\"d-block font-weight-bold name\">\r\n\r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c9fb3ba9c0f163d2a25163039b08d00047505d7c21612", async() => {
#nullable restore
#line 71 "C:\Users\msi\Desktop\Yeni klasör (3)\BlogProject_5175.WEB\Views\Article\Detail.cshtml"
                                                                                                                              Write(item.AppUser.UserName);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 71 "C:\Users\msi\Desktop\Yeni klasör (3)\BlogProject_5175.WEB\Views\Article\Detail.cshtml"
                                                                                                      WriteLiteral(item.AppUserID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                            </span>\r\n                                            <span class=\"date text-black-50\">");
#nullable restore
#line 73 "C:\Users\msi\Desktop\Yeni klasör (3)\BlogProject_5175.WEB\Views\Article\Detail.cshtml"
                                                                        Write(item.CreateDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                        </div>\r\n                                    </div>\r\n                                    <div class=\"mt-2\">\r\n                                        <p class=\"comment-text\">");
#nullable restore
#line 77 "C:\Users\msi\Desktop\Yeni klasör (3)\BlogProject_5175.WEB\Views\Article\Detail.cshtml"
                                                           Write(item.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 84 "C:\Users\msi\Desktop\Yeni klasör (3)\BlogProject_5175.WEB\Views\Article\Detail.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BlogProject_5175.Models.Entities.Concrete.Article> Html { get; private set; }
    }
}
#pragma warning restore 1591
