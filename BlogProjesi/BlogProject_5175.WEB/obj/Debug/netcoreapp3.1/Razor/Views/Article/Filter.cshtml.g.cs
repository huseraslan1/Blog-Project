#pragma checksum "C:\Users\msi\Desktop\Yeni klasör (3)\BlogProject_5175.WEB\Views\Article\Filter.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2e801ae14924b7baeae0a96e60219fec0759e6ff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Article_Filter), @"mvc.1.0.view", @"/Views/Article/Filter.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e801ae14924b7baeae0a96e60219fec0759e6ff", @"/Views/Article/Filter.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"941513bd44b61eb3b613036986f9b5cdeaf187bb", @"/Views/_ViewImports.cshtml")]
    public class Views_Article_Filter : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<GetArticleVM>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Article", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UserDetail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Appuser", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\msi\Desktop\Yeni klasör (3)\BlogProject_5175.WEB\Views\Article\Filter.cshtml"
  
    ViewData["Title"] = "Filter";

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\msi\Desktop\Yeni klasör (3)\BlogProject_5175.WEB\Views\Article\Filter.cshtml"
 if (Model.Count == 0 || Model == null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-md-10\" style=\"text-align:center\">\r\n                <h1>Henüz Bu Kategori İçin Kimse Makale Oluşturmamış...</h1>\r\n                <h1> ");
#nullable restore
#line 11 "C:\Users\msi\Desktop\Yeni klasör (3)\BlogProject_5175.WEB\Views\Article\Filter.cshtml"
                Write(Html.ActionLink("Ana Sayfaya Dön", "Index", "Home"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 15 "C:\Users\msi\Desktop\Yeni klasör (3)\BlogProject_5175.WEB\Views\Article\Filter.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"text-center\">\r\n    <h1>");
#nullable restore
#line 19 "C:\Users\msi\Desktop\Yeni klasör (3)\BlogProject_5175.WEB\Views\Article\Filter.cshtml"
   Write(ViewBag.kategori);

#line default
#line hidden
#nullable disable
            WriteLiteral(" kategorisine göre listelenmiş son 5 makale</h1>\r\n</div>\r\n");
#nullable restore
#line 21 "C:\Users\msi\Desktop\Yeni klasör (3)\BlogProject_5175.WEB\Views\Article\Filter.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""col-12  d-flex align-items-stretch flex-column mb-4"">
            <div class=""card bg-light d-flex flex-fill"">

                <div class=""card-body pt-0"">
                    <div class=""row"">
                        <div class=""col-7"">
                            <h2 class=""lead""><b>");
#nullable restore
#line 29 "C:\Users\msi\Desktop\Yeni klasör (3)\BlogProject_5175.WEB\Views\Article\Filter.cshtml"
                                           Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></h2>\r\n                            <p class=\"text-muted text-sm\">\r\n");
#nullable restore
#line 31 "C:\Users\msi\Desktop\Yeni klasör (3)\BlogProject_5175.WEB\Views\Article\Filter.cshtml"
                                 if (item.Content.Length >= 30)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\msi\Desktop\Yeni klasör (3)\BlogProject_5175.WEB\Views\Article\Filter.cshtml"
                               Write(item.Content.Substring(0, 30));

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\msi\Desktop\Yeni klasör (3)\BlogProject_5175.WEB\Views\Article\Filter.cshtml"
                                                                  
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Users\msi\Desktop\Yeni klasör (3)\BlogProject_5175.WEB\Views\Article\Filter.cshtml"
                            Write(item.Content);

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Users\msi\Desktop\Yeni klasör (3)\BlogProject_5175.WEB\Views\Article\Filter.cshtml"
                                              }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </p>\r\n                            <ul class=\"ml-4 mb-0 fa-ul text-muted\">\r\n                                <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2e801ae14924b7baeae0a96e60219fec0759e6ff9680", async() => {
                WriteLiteral("devamını okumak için tıklayınız...");
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
#line 39 "C:\Users\msi\Desktop\Yeni klasör (3)\BlogProject_5175.WEB\Views\Article\Filter.cshtml"
                                                                                      WriteLiteral(item.ArticleID);

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
            WriteLiteral("</li>\r\n                            </ul>\r\n                        </div>\r\n                        <div class=\"col-5 text-center\">\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 1705, "\"", 1722, 1);
#nullable restore
#line 43 "C:\Users\msi\Desktop\Yeni klasör (3)\BlogProject_5175.WEB\Views\Article\Filter.cshtml"
WriteAttributeValue("", 1711, item.Image, 1711, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" alt=""user-avatar"" class=""img-circle img-fluid"">
                        </div>
                    </div>
                </div>
                <div class=""card-footer"">
                    <div class=""text-right"">
                        <div class=""text-left"">
                            <p style=""position:absolute""> Oluşma Tarihi: ");
#nullable restore
#line 50 "C:\Users\msi\Desktop\Yeni klasör (3)\BlogProject_5175.WEB\Views\Article\Filter.cshtml"
                                                                    Write(item.CreateDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                        Yazar:\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2e801ae14924b7baeae0a96e60219fec0759e6ff13427", async() => {
                WriteLiteral("\r\n                            ");
#nullable restore
#line 54 "C:\Users\msi\Desktop\Yeni klasör (3)\BlogProject_5175.WEB\Views\Article\Filter.cshtml"
                       Write(item.UserFullName);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 53 "C:\Users\msi\Desktop\Yeni klasör (3)\BlogProject_5175.WEB\Views\Article\Filter.cshtml"
                                                                              WriteLiteral(item.AppUserID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 60 "C:\Users\msi\Desktop\Yeni klasör (3)\BlogProject_5175.WEB\Views\Article\Filter.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "C:\Users\msi\Desktop\Yeni klasör (3)\BlogProject_5175.WEB\Views\Article\Filter.cshtml"
     
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<GetArticleVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591
