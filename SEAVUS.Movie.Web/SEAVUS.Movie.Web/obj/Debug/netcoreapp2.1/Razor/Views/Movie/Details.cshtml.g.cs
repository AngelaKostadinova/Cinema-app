#pragma checksum "C:\Users\Angela\Desktop\SEDC 2019-20\Cinestar\SEAVUS.Movie.Web\SEAVUS.Movie.Web\Views\Movie\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fedabedcdb6b2140f33d0d6a0785b92def340cdb"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fedabedcdb6b2140f33d0d6a0785b92def340cdb", @"/Views/Movie/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4fd01871b49494fcc789a9e0ba6e756cc067869d", @"/Views/_ViewImports.cshtml")]
    public class Views_Movie_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MovieViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Movie image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("pull-left details-img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Hall", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Hall", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(66, 61, true);
            WriteLiteral("\r\n<div>\r\n    <div class=\"thumbnail movies-details\">\r\n        ");
            EndContext();
            BeginContext(127, 83, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3cb3bf9128f94a10bb494d72236a57bd", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 137, "~/images/", 137, 9, true);
#line 8 "C:\Users\Angela\Desktop\SEDC 2019-20\Cinestar\SEAVUS.Movie.Web\SEAVUS.Movie.Web\Views\Movie\Details.cshtml"
AddHtmlAttributeValue("", 146, Model.Image, 146, 12, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(210, 56, true);
            WriteLiteral("\r\n        <div class=\"caption\">\r\n            <h3>Title: ");
            EndContext();
            BeginContext(267, 16, false);
#line 10 "C:\Users\Angela\Desktop\SEDC 2019-20\Cinestar\SEAVUS.Movie.Web\SEAVUS.Movie.Web\Views\Movie\Details.cshtml"
                  Write(Model.MovieTitle);

#line default
#line hidden
            EndContext();
            BeginContext(283, 36, true);
            WriteLiteral("</h3>\r\n            <p> Description: ");
            EndContext();
            BeginContext(320, 17, false);
#line 11 "C:\Users\Angela\Desktop\SEDC 2019-20\Cinestar\SEAVUS.Movie.Web\SEAVUS.Movie.Web\Views\Movie\Details.cshtml"
                        Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(337, 29, true);
            WriteLiteral("</p>\r\n            <h5>Genre: ");
            EndContext();
            BeginContext(367, 11, false);
#line 12 "C:\Users\Angela\Desktop\SEDC 2019-20\Cinestar\SEAVUS.Movie.Web\SEAVUS.Movie.Web\Views\Movie\Details.cshtml"
                  Write(Model.Genre);

#line default
#line hidden
            EndContext();
            BeginContext(378, 32, true);
            WriteLiteral("</h5>\r\n            <p>Director: ");
            EndContext();
            BeginContext(411, 14, false);
#line 13 "C:\Users\Angela\Desktop\SEDC 2019-20\Cinestar\SEAVUS.Movie.Web\SEAVUS.Movie.Web\Views\Movie\Details.cshtml"
                    Write(Model.Director);

#line default
#line hidden
            EndContext();
            BeginContext(425, 31, true);
            WriteLiteral("</p>\r\n            <p>Language: ");
            EndContext();
            BeginContext(457, 14, false);
#line 14 "C:\Users\Angela\Desktop\SEDC 2019-20\Cinestar\SEAVUS.Movie.Web\SEAVUS.Movie.Web\Views\Movie\Details.cshtml"
                    Write(Model.Language);

#line default
#line hidden
            EndContext();
            BeginContext(471, 32, true);
            WriteLiteral("</p>\r\n            <p>Tehnology: ");
            EndContext();
            BeginContext(504, 16, false);
#line 15 "C:\Users\Angela\Desktop\SEDC 2019-20\Cinestar\SEAVUS.Movie.Web\SEAVUS.Movie.Web\Views\Movie\Details.cshtml"
                     Write(Model.Technology);

#line default
#line hidden
            EndContext();
            BeginContext(520, 35, true);
            WriteLiteral("</p>\r\n            <p>Release date: ");
            EndContext();
            BeginContext(556, 17, false);
#line 16 "C:\Users\Angela\Desktop\SEDC 2019-20\Cinestar\SEAVUS.Movie.Web\SEAVUS.Movie.Web\Views\Movie\Details.cshtml"
                        Write(Model.ReleaseDate);

#line default
#line hidden
            EndContext();
            BeginContext(573, 70, true);
            WriteLiteral("</p>\r\n            <hr />\r\n            <p>Cast:</p>\r\n            <ul>\r\n");
            EndContext();
#line 20 "C:\Users\Angela\Desktop\SEDC 2019-20\Cinestar\SEAVUS.Movie.Web\SEAVUS.Movie.Web\Views\Movie\Details.cshtml"
                 foreach (var actor in Model.Actors)
                {

#line default
#line hidden
            BeginContext(716, 24, true);
            WriteLiteral("                    <li>");
            EndContext();
            BeginContext(741, 15, false);
#line 22 "C:\Users\Angela\Desktop\SEDC 2019-20\Cinestar\SEAVUS.Movie.Web\SEAVUS.Movie.Web\Views\Movie\Details.cshtml"
                   Write(actor.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(756, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(758, 14, false);
#line 22 "C:\Users\Angela\Desktop\SEDC 2019-20\Cinestar\SEAVUS.Movie.Web\SEAVUS.Movie.Web\Views\Movie\Details.cshtml"
                                    Write(actor.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(772, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 23 "C:\Users\Angela\Desktop\SEDC 2019-20\Cinestar\SEAVUS.Movie.Web\SEAVUS.Movie.Web\Views\Movie\Details.cshtml"
                }

#line default
#line hidden
            BeginContext(798, 868, true);
            WriteLiteral(@"            </ul>
            <hr />
            <p>Shows:</p>
            <div class=""table-responsive"">
                <table class=""table table-hover"">
                    <thead>
                        <tr>
                            <th>
                                Days of week
                            </th>
                            <th>
                                Hall
                            </th>
                            <th>
                                Start Date
                            </th>
                            <th>
                                End Date
                            </th>
                            <th>
                                Show Time
                            </th>
                        </tr>
                    </thead>
                    <tbody>
");
            EndContext();
#line 49 "C:\Users\Angela\Desktop\SEDC 2019-20\Cinestar\SEAVUS.Movie.Web\SEAVUS.Movie.Web\Views\Movie\Details.cshtml"
                         foreach (var item in Model.Shows)
                        {

#line default
#line hidden
            BeginContext(1753, 108, true);
            WriteLiteral("                            <tr>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(1862, 54, false);
#line 53 "C:\Users\Angela\Desktop\SEDC 2019-20\Cinestar\SEAVUS.Movie.Web\SEAVUS.Movie.Web\Views\Movie\Details.cshtml"
                               Write(Html.DisplayFor(modelItem => item.StartDate.DayOfWeek));

#line default
#line hidden
            EndContext();
            BeginContext(1916, 39, true);
            WriteLiteral(",\r\n                                    ");
            EndContext();
            BeginContext(1956, 52, false);
#line 54 "C:\Users\Angela\Desktop\SEDC 2019-20\Cinestar\SEAVUS.Movie.Web\SEAVUS.Movie.Web\Views\Movie\Details.cshtml"
                               Write(Html.DisplayFor(modelItem => item.EndDate.DayOfWeek));

#line default
#line hidden
            EndContext();
            BeginContext(2008, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(2124, 44, false);
#line 57 "C:\Users\Angela\Desktop\SEDC 2019-20\Cinestar\SEAVUS.Movie.Web\SEAVUS.Movie.Web\Views\Movie\Details.cshtml"
                               Write(Html.DisplayFor(modelItem => item.HallTitle));

#line default
#line hidden
            EndContext();
            BeginContext(2168, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(2284, 62, false);
#line 60 "C:\Users\Angela\Desktop\SEDC 2019-20\Cinestar\SEAVUS.Movie.Web\SEAVUS.Movie.Web\Views\Movie\Details.cshtml"
                               Write(Html.DisplayFor(modelItem => item.StartDate, "{0:dd/MM/yyyy}"));

#line default
#line hidden
            EndContext();
            BeginContext(2346, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(2462, 60, false);
#line 63 "C:\Users\Angela\Desktop\SEDC 2019-20\Cinestar\SEAVUS.Movie.Web\SEAVUS.Movie.Web\Views\Movie\Details.cshtml"
                               Write(Html.DisplayFor(modelItem => item.EndDate, "{0:dd/MM/yyyy}"));

#line default
#line hidden
            EndContext();
            BeginContext(2522, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(2638, 53, false);
#line 66 "C:\Users\Angela\Desktop\SEDC 2019-20\Cinestar\SEAVUS.Movie.Web\SEAVUS.Movie.Web\Views\Movie\Details.cshtml"
                               Write(Html.DisplayFor(modelItem => item.ShowTime.TimeOfDay));

#line default
#line hidden
            EndContext();
            BeginContext(2691, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(2806, 131, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5d1987717d0c4e1dbdc9415e6f4e13ac", async() => {
                BeginContext(2877, 56, true);
                WriteLiteral("<span class=\"glyphicon glyphicon glyphicon-tags\"></span>");
                EndContext();
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
#line 69 "C:\Users\Angela\Desktop\SEDC 2019-20\Cinestar\SEAVUS.Movie.Web\SEAVUS.Movie.Web\Views\Movie\Details.cshtml"
                                                                                 WriteLiteral(item.HallId);

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
            BeginContext(2937, 76, true);
            WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n");
            EndContext();
#line 72 "C:\Users\Angela\Desktop\SEDC 2019-20\Cinestar\SEAVUS.Movie.Web\SEAVUS.Movie.Web\Views\Movie\Details.cshtml"
                        }

#line default
#line hidden
            BeginContext(3040, 76, true);
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n");
            EndContext();
            BeginContext(3320, 34, true);
            WriteLiteral("        </div>\r\n    </div>\r\n</div>");
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
