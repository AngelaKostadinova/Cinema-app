#pragma checksum "C:\Users\Angela\Desktop\SEDC 2019-20\Cinestar\SEAVUS.Movie.Web\SEAVUS.Movie.Web\Views\Movie\MoviePanel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c19b9f30e500fb73f52e3a0cd6ca9b350af57862"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movie_MoviePanel), @"mvc.1.0.view", @"/Views/Movie/MoviePanel.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Movie/MoviePanel.cshtml", typeof(AspNetCore.Views_Movie_MoviePanel))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c19b9f30e500fb73f52e3a0cd6ca9b350af57862", @"/Views/Movie/MoviePanel.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4fd01871b49494fcc789a9e0ba6e756cc067869d", @"/Views/_ViewImports.cshtml")]
    public class Views_Movie_MoviePanel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MovieViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddOrEdit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onclick", new global::Microsoft.AspNetCore.Html.HtmlString("return confirm(\'Are you sure you want to delete this record?\')"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Angela\Desktop\SEDC 2019-20\Cinestar\SEAVUS.Movie.Web\SEAVUS.Movie.Web\Views\Movie\MoviePanel.cshtml"
  
    ViewData["Title"] = "MoviePanel";

#line default
#line hidden
            BeginContext(82, 122, true);
            WriteLiteral("\r\n<h2>Movie Panel</h2>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n            <tr>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(205, 46, false);
#line 12 "C:\Users\Angela\Desktop\SEDC 2019-20\Cinestar\SEAVUS.Movie.Web\SEAVUS.Movie.Web\Views\Movie\MoviePanel.cshtml"
               Write(Html.DisplayNameFor(model => model.MovieTitle));

#line default
#line hidden
            EndContext();
            BeginContext(251, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(319, 41, false);
#line 15 "C:\Users\Angela\Desktop\SEDC 2019-20\Cinestar\SEAVUS.Movie.Web\SEAVUS.Movie.Web\Views\Movie\MoviePanel.cshtml"
               Write(Html.DisplayNameFor(model => model.Genre));

#line default
#line hidden
            EndContext();
            BeginContext(360, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(428, 44, false);
#line 18 "C:\Users\Angela\Desktop\SEDC 2019-20\Cinestar\SEAVUS.Movie.Web\SEAVUS.Movie.Web\Views\Movie\MoviePanel.cshtml"
               Write(Html.DisplayNameFor(model => model.Director));

#line default
#line hidden
            EndContext();
            BeginContext(472, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(540, 47, false);
#line 21 "C:\Users\Angela\Desktop\SEDC 2019-20\Cinestar\SEAVUS.Movie.Web\SEAVUS.Movie.Web\Views\Movie\MoviePanel.cshtml"
               Write(Html.DisplayNameFor(model => model.ReleaseDate));

#line default
#line hidden
            EndContext();
            BeginContext(587, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(654, 91, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "06e1e2e8a1fa4c499a81d55f19207447", async() => {
                BeginContext(704, 37, true);
                WriteLiteral("<i class=\"far fa-plus-square\"></i>Add");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(745, 73, true);
            WriteLiteral("\r\n                </th>\r\n            </tr>\r\n\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 30 "C:\Users\Angela\Desktop\SEDC 2019-20\Cinestar\SEAVUS.Movie.Web\SEAVUS.Movie.Web\Views\Movie\MoviePanel.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(867, 24, true);
            WriteLiteral("<tr>\r\n    <td>\r\n        ");
            EndContext();
            BeginContext(892, 45, false);
#line 34 "C:\Users\Angela\Desktop\SEDC 2019-20\Cinestar\SEAVUS.Movie.Web\SEAVUS.Movie.Web\Views\Movie\MoviePanel.cshtml"
   Write(Html.DisplayFor(modelItem => item.MovieTitle));

#line default
#line hidden
            EndContext();
            BeginContext(937, 31, true);
            WriteLiteral("\r\n    </td>\r\n    <td>\r\n        ");
            EndContext();
            BeginContext(969, 40, false);
#line 37 "C:\Users\Angela\Desktop\SEDC 2019-20\Cinestar\SEAVUS.Movie.Web\SEAVUS.Movie.Web\Views\Movie\MoviePanel.cshtml"
   Write(Html.DisplayFor(modelItem => item.Genre));

#line default
#line hidden
            EndContext();
            BeginContext(1009, 31, true);
            WriteLiteral("\r\n    </td>\r\n    <td>\r\n        ");
            EndContext();
            BeginContext(1041, 43, false);
#line 40 "C:\Users\Angela\Desktop\SEDC 2019-20\Cinestar\SEAVUS.Movie.Web\SEAVUS.Movie.Web\Views\Movie\MoviePanel.cshtml"
   Write(Html.DisplayFor(modelItem => item.Director));

#line default
#line hidden
            EndContext();
            BeginContext(1084, 31, true);
            WriteLiteral("\r\n    </td>\r\n    <td>\r\n        ");
            EndContext();
            BeginContext(1116, 46, false);
#line 43 "C:\Users\Angela\Desktop\SEDC 2019-20\Cinestar\SEAVUS.Movie.Web\SEAVUS.Movie.Web\Views\Movie\MoviePanel.cshtml"
   Write(Html.DisplayFor(modelItem => item.ReleaseDate));

#line default
#line hidden
            EndContext();
            BeginContext(1162, 31, true);
            WriteLiteral("\r\n    </td>\r\n    <td>\r\n        ");
            EndContext();
            BeginContext(1193, 94, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "860f06dd29ff48a1b3a75c44518959ee", async() => {
                BeginContext(1243, 40, true);
                WriteLiteral("<i class=\"glyphicon glyphicon-edit\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 46 "C:\Users\Angela\Desktop\SEDC 2019-20\Cinestar\SEAVUS.Movie.Web\SEAVUS.Movie.Web\Views\Movie\MoviePanel.cshtml"
                                    WriteLiteral(item.Id);

#line default
#line hidden
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
            EndContext();
            BeginContext(1287, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(1297, 166, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a5474ab6e0a8402fb3fb4f9d9bdd01b7", async() => {
                BeginContext(1417, 42, true);
                WriteLiteral("<i class=\"glyphicon glyphicon-remove\"></i>");
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
#line 47 "C:\Users\Angela\Desktop\SEDC 2019-20\Cinestar\SEAVUS.Movie.Web\SEAVUS.Movie.Web\Views\Movie\MoviePanel.cshtml"
                                 WriteLiteral(item.Id);

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
            BeginContext(1463, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(1473, 79, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aed9e9cc34864daeb8a32fe6b49165bb", async() => {
                BeginContext(1530, 15, false);
#line 48 "C:\Users\Angela\Desktop\SEDC 2019-20\Cinestar\SEAVUS.Movie.Web\SEAVUS.Movie.Web\Views\Movie\MoviePanel.cshtml"
                                                           Write(ViewBag.Message);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#line 48 "C:\Users\Angela\Desktop\SEDC 2019-20\Cinestar\SEAVUS.Movie.Web\SEAVUS.Movie.Web\Views\Movie\MoviePanel.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => item.Id);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1552, 18, true);
            WriteLiteral("\r\n    </td>\r\n</tr>");
            EndContext();
#line 50 "C:\Users\Angela\Desktop\SEDC 2019-20\Cinestar\SEAVUS.Movie.Web\SEAVUS.Movie.Web\Views\Movie\MoviePanel.cshtml"
     }

#line default
#line hidden
            BeginContext(1573, 22, true);
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MovieViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
