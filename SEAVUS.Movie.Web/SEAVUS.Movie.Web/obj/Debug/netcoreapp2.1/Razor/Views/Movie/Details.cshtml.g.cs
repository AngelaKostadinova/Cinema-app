#pragma checksum "C:\Users\Angela\Desktop\SEDC 2019-20\Cinestar\SEAVUS.Movie.Web\SEAVUS.Movie.Web\Views\Movie\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4f0ad13c988c2beffc78cefe982dc3d02fb06b9e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movie_Details), @"mvc.1.0.view", @"/Views/Movie/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Movie/Details.cshtml", typeof(AspNetCore.Views_Movie_Details))]
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
#line 1 "C:\Users\Angela\Desktop\SEDC 2019-20\Cinestar\SEAVUS.Movie.Web\SEAVUS.Movie.Web\Views\_ViewImports.cshtml"
using SEAVUS.Movie.Web;

#line default
#line hidden
#line 2 "C:\Users\Angela\Desktop\SEDC 2019-20\Cinestar\SEAVUS.Movie.Web\SEAVUS.Movie.Web\Views\_ViewImports.cshtml"
using SEAVUS.Movie.Web.Models;

#line default
#line hidden
#line 3 "C:\Users\Angela\Desktop\SEDC 2019-20\Cinestar\SEAVUS.Movie.Web\SEAVUS.Movie.Web\Views\_ViewImports.cshtml"
using SEAVUS.Movie.WebModels.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f0ad13c988c2beffc78cefe982dc3d02fb06b9e", @"/Views/Movie/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4fd01871b49494fcc789a9e0ba6e756cc067869d", @"/Views/_ViewImports.cshtml")]
    public class Views_Movie_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MovieViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Movie image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display:block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("pull-left"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "LogIn", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "User", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Angela\Desktop\SEDC 2019-20\Cinestar\SEAVUS.Movie.Web\SEAVUS.Movie.Web\Views\Movie\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(66, 89, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div class=\"movies\">\r\n        <div class=\"thumbnail\">\r\n            ");
            EndContext();
            BeginContext(155, 105, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "cf7ea8ff61694c50b26cfc03d2d1faa9", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 165, "~/images/", 165, 9, true);
#line 10 "C:\Users\Angela\Desktop\SEDC 2019-20\Cinestar\SEAVUS.Movie.Web\SEAVUS.Movie.Web\Views\Movie\Details.cshtml"
AddHtmlAttributeValue("", 174, Model.Image, 174, 12, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(260, 64, true);
            WriteLiteral("\r\n            <div class=\"caption\">\r\n                <h3>Title: ");
            EndContext();
            BeginContext(325, 16, false);
#line 12 "C:\Users\Angela\Desktop\SEDC 2019-20\Cinestar\SEAVUS.Movie.Web\SEAVUS.Movie.Web\Views\Movie\Details.cshtml"
                      Write(Model.MovieTitle);

#line default
#line hidden
            EndContext();
            BeginContext(341, 40, true);
            WriteLiteral("</h3>\r\n                <p> Description: ");
            EndContext();
            BeginContext(382, 17, false);
#line 13 "C:\Users\Angela\Desktop\SEDC 2019-20\Cinestar\SEAVUS.Movie.Web\SEAVUS.Movie.Web\Views\Movie\Details.cshtml"
                            Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(399, 33, true);
            WriteLiteral("</p>\r\n                <h5>Genre: ");
            EndContext();
            BeginContext(433, 11, false);
#line 14 "C:\Users\Angela\Desktop\SEDC 2019-20\Cinestar\SEAVUS.Movie.Web\SEAVUS.Movie.Web\Views\Movie\Details.cshtml"
                      Write(Model.Genre);

#line default
#line hidden
            EndContext();
            BeginContext(444, 36, true);
            WriteLiteral("</h5>\r\n                <p>Director: ");
            EndContext();
            BeginContext(481, 14, false);
#line 15 "C:\Users\Angela\Desktop\SEDC 2019-20\Cinestar\SEAVUS.Movie.Web\SEAVUS.Movie.Web\Views\Movie\Details.cshtml"
                        Write(Model.Director);

#line default
#line hidden
            EndContext();
            BeginContext(495, 35, true);
            WriteLiteral("</p>\r\n                <p>Language: ");
            EndContext();
            BeginContext(531, 14, false);
#line 16 "C:\Users\Angela\Desktop\SEDC 2019-20\Cinestar\SEAVUS.Movie.Web\SEAVUS.Movie.Web\Views\Movie\Details.cshtml"
                        Write(Model.Language);

#line default
#line hidden
            EndContext();
            BeginContext(545, 36, true);
            WriteLiteral("</p>\r\n                <p>Tehnology: ");
            EndContext();
            BeginContext(582, 16, false);
#line 17 "C:\Users\Angela\Desktop\SEDC 2019-20\Cinestar\SEAVUS.Movie.Web\SEAVUS.Movie.Web\Views\Movie\Details.cshtml"
                         Write(Model.Technology);

#line default
#line hidden
            EndContext();
            BeginContext(598, 39, true);
            WriteLiteral("</p>\r\n                <p>Release date: ");
            EndContext();
            BeginContext(638, 17, false);
#line 18 "C:\Users\Angela\Desktop\SEDC 2019-20\Cinestar\SEAVUS.Movie.Web\SEAVUS.Movie.Web\Views\Movie\Details.cshtml"
                            Write(Model.ReleaseDate);

#line default
#line hidden
            EndContext();
            BeginContext(655, 82, true);
            WriteLiteral("</p>\r\n                <hr />\r\n                <p>Cast:</p>\r\n                <ul>\r\n");
            EndContext();
#line 22 "C:\Users\Angela\Desktop\SEDC 2019-20\Cinestar\SEAVUS.Movie.Web\SEAVUS.Movie.Web\Views\Movie\Details.cshtml"
                     foreach (var actor in Model.Actors)
                    {

#line default
#line hidden
            BeginContext(818, 28, true);
            WriteLiteral("                        <li>");
            EndContext();
            BeginContext(847, 15, false);
#line 24 "C:\Users\Angela\Desktop\SEDC 2019-20\Cinestar\SEAVUS.Movie.Web\SEAVUS.Movie.Web\Views\Movie\Details.cshtml"
                       Write(actor.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(862, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(864, 14, false);
#line 24 "C:\Users\Angela\Desktop\SEDC 2019-20\Cinestar\SEAVUS.Movie.Web\SEAVUS.Movie.Web\Views\Movie\Details.cshtml"
                                        Write(actor.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(878, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 25 "C:\Users\Angela\Desktop\SEDC 2019-20\Cinestar\SEAVUS.Movie.Web\SEAVUS.Movie.Web\Views\Movie\Details.cshtml"
                    }

#line default
#line hidden
            BeginContext(908, 66, true);
            WriteLiteral("                </ul>\r\n\r\n                <p>\r\n                    ");
            EndContext();
            BeginContext(974, 82, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e8faf1069c27407e844f13624aa2c814", async() => {
                BeginContext(1042, 10, true);
                WriteLiteral("Buy ticket");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1056, 66, true);
            WriteLiteral("\r\n                </p>\r\n            </div>\r\n        </div>\r\n</div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MovieViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
