#pragma checksum "C:\Users\Angela\Desktop\SEDC 2019-20\Cinestar\SEAVUS.Movie.Web\SEAVUS.Movie.Web\Views\Movie\Movies.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "28777083e159107f87bf4bc4224c1747899917be"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movie_Movies), @"mvc.1.0.view", @"/Views/Movie/Movies.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Movie/Movies.cshtml", typeof(AspNetCore.Views_Movie_Movies))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28777083e159107f87bf4bc4224c1747899917be", @"/Views/Movie/Movies.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4fd01871b49494fcc789a9e0ba6e756cc067869d", @"/Views/_ViewImports.cshtml")]
    public class Views_Movie_Movies : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<MovieViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Movie image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Angela\Desktop\SEDC 2019-20\Cinestar\SEAVUS.Movie.Web\SEAVUS.Movie.Web\Views\Movie\Movies.cshtml"
  
    ViewData["Title"] = "Movies";

#line default
#line hidden
            BeginContext(71, 51, true);
            WriteLiteral("\r\n<h1>Movies</h1>\r\n<div class=\"header-right\">\r\n    ");
            EndContext();
            BeginContext(122, 473, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b887cef9e4b4410e9c68f14e014b02e8", async() => {
                BeginContext(141, 115, true);
                WriteLiteral("\r\n        <div class=\"input-group\">\r\n            <input class=\"form-control\" type=\"text\" placeholder=\"Search movie\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 256, "\"", 283, 1);
#line 10 "C:\Users\Angela\Desktop\SEDC 2019-20\Cinestar\SEAVUS.Movie.Web\SEAVUS.Movie.Web\Views\Movie\Movies.cshtml"
WriteAttributeValue("", 264, ViewData["Search"], 264, 19, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(284, 304, true);
                WriteLiteral(@" name=""searchTerm"" />
            <span class=""input-group-addon"" id=""basic-addon1""><span class=""glyphicon glyphicon-search""></span></span>
        </div>
        <br />
        <div class=""input-group"">
            <button type=""submit"" class=""btn btn-success"">Search</button>
        </div>
    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(595, 40, true);
            WriteLiteral("\r\n</div>\r\n<br />\r\n<div class=\"movies\">\r\n");
            EndContext();
#line 21 "C:\Users\Angela\Desktop\SEDC 2019-20\Cinestar\SEAVUS.Movie.Web\SEAVUS.Movie.Web\Views\Movie\Movies.cshtml"
     foreach (var movie in Model)
    {

#line default
#line hidden
            BeginContext(677, 45, true);
            WriteLiteral("        <div class=\"thumbnail\">\r\n            ");
            EndContext();
            BeginContext(722, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "86d1d5218f324fb394e8c38b6f0d0e93", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 732, "~/images/Movies/", 732, 16, true);
#line 24 "C:\Users\Angela\Desktop\SEDC 2019-20\Cinestar\SEAVUS.Movie.Web\SEAVUS.Movie.Web\Views\Movie\Movies.cshtml"
AddHtmlAttributeValue("", 748, movie.Id, 748, 11, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 759, ".png", 759, 4, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(785, 57, true);
            WriteLiteral("\r\n            <div class=\"caption\">\r\n                <h3>");
            EndContext();
            BeginContext(843, 16, false);
#line 26 "C:\Users\Angela\Desktop\SEDC 2019-20\Cinestar\SEAVUS.Movie.Web\SEAVUS.Movie.Web\Views\Movie\Movies.cshtml"
               Write(movie.MovieTitle);

#line default
#line hidden
            EndContext();
            BeginContext(859, 27, true);
            WriteLiteral("</h3>\r\n                <h4>");
            EndContext();
            BeginContext(887, 17, false);
#line 27 "C:\Users\Angela\Desktop\SEDC 2019-20\Cinestar\SEAVUS.Movie.Web\SEAVUS.Movie.Web\Views\Movie\Movies.cshtml"
               Write(movie.Description);

#line default
#line hidden
            EndContext();
            BeginContext(904, 27, true);
            WriteLiteral("</h4>\r\n                <h5>");
            EndContext();
            BeginContext(932, 11, false);
#line 28 "C:\Users\Angela\Desktop\SEDC 2019-20\Cinestar\SEAVUS.Movie.Web\SEAVUS.Movie.Web\Views\Movie\Movies.cshtml"
               Write(movie.Genre);

#line default
#line hidden
            EndContext();
            BeginContext(943, 48, true);
            WriteLiteral("</h5>\r\n                <p>\r\n                    ");
            EndContext();
            BeginContext(991, 84, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e70f8de852a40298bf2fbf56e400299", async() => {
                BeginContext(1064, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 30 "C:\Users\Angela\Desktop\SEDC 2019-20\Cinestar\SEAVUS.Movie.Web\SEAVUS.Movie.Web\Views\Movie\Movies.cshtml"
                                              WriteLiteral(movie.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1075, 60, true);
            WriteLiteral("\r\n                </p>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 34 "C:\Users\Angela\Desktop\SEDC 2019-20\Cinestar\SEAVUS.Movie.Web\SEAVUS.Movie.Web\Views\Movie\Movies.cshtml"
    }

#line default
#line hidden
            BeginContext(1142, 6, true);
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<MovieViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
