#pragma checksum "C:\Users\HP\Documents\libro c#\Code\PackagesManagement\PackagesManagement\Views\ManagePackages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8f12359a680ffadf0df45a6f2761501a939fbd2e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ManagePackages_Index), @"mvc.1.0.view", @"/Views/ManagePackages/Index.cshtml")]
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
#line 1 "C:\Users\HP\Documents\libro c#\Code\PackagesManagement\PackagesManagement\Views\_ViewImports.cshtml"
using PackagesManagement;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\Documents\libro c#\Code\PackagesManagement\PackagesManagement\Views\_ViewImports.cshtml"
using PackagesManagement.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\Documents\libro c#\Code\PackagesManagement\PackagesManagement\Views\ManagePackages\Index.cshtml"
using PackagesManagement.Controllers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f12359a680ffadf0df45a6f2761501a939fbd2e", @"/Views/ManagePackages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91a5aeedf1e4740888083aa8b81ed9d60788c9c5", @"/Views/_ViewImports.cshtml")]
    public class Views_ManagePackages_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PackagesManagement.Models.Packages.PackagesListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ManagePackages", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\HP\Documents\libro c#\Code\PackagesManagement\PackagesManagement\Views\ManagePackages\Index.cshtml"
  
    ViewData["Title"] = "Manage packages";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div class=\"container\">\r\n        <h2>");
#nullable restore
#line 8 "C:\Users\HP\Documents\libro c#\Code\PackagesManagement\PackagesManagement\Views\ManagePackages\Index.cshtml"
       Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
        <div class=""table-responsive"">
            <table class=""table"">
                <thead>
                    <tr>
                        <th scope=""col"">Delete</th>
                        <th scope=""col"">Edit</th>
                        <th scope=""col"">Destination</th>
                        <th scope=""col"">Name</th>
                        <th scope=""col"">Duration/days</th>
                        <th scope=""col"">Price</th>
                        <th scope=""col"">Availble from</th>
                        <th scope=""col"">Availble to</th>

                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 25 "C:\Users\HP\Documents\libro c#\Code\PackagesManagement\PackagesManagement\Views\ManagePackages\Index.cshtml"
                     foreach(var package in Model.Items)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8f12359a680ffadf0df45a6f2761501a939fbd2e5731", async() => {
                WriteLiteral("\r\n                                delete\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 30 "C:\Users\HP\Documents\libro c#\Code\PackagesManagement\PackagesManagement\Views\ManagePackages\Index.cshtml"
                               WriteLiteral(nameof(ManagePackagesController.Delete));

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-action", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 31 "C:\Users\HP\Documents\libro c#\Code\PackagesManagement\PackagesManagement\Views\ManagePackages\Index.cshtml"
                                 WriteLiteral(package.Id);

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
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8f12359a680ffadf0df45a6f2761501a939fbd2e8795", async() => {
                WriteLiteral("\r\n                                edit\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 37 "C:\Users\HP\Documents\libro c#\Code\PackagesManagement\PackagesManagement\Views\ManagePackages\Index.cshtml"
                               WriteLiteral(nameof(ManagePackagesController.Edit));

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-action", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 38 "C:\Users\HP\Documents\libro c#\Code\PackagesManagement\PackagesManagement\Views\ManagePackages\Index.cshtml"
                                 WriteLiteral(package.Id);

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
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 43 "C:\Users\HP\Documents\libro c#\Code\PackagesManagement\PackagesManagement\Views\ManagePackages\Index.cshtml"
                       Write(package.DestinationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 46 "C:\Users\HP\Documents\libro c#\Code\PackagesManagement\PackagesManagement\Views\ManagePackages\Index.cshtml"
                       Write(package.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 49 "C:\Users\HP\Documents\libro c#\Code\PackagesManagement\PackagesManagement\Views\ManagePackages\Index.cshtml"
                       Write(package.DuratioInDays);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 52 "C:\Users\HP\Documents\libro c#\Code\PackagesManagement\PackagesManagement\Views\ManagePackages\Index.cshtml"
                       Write(package.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 55 "C:\Users\HP\Documents\libro c#\Code\PackagesManagement\PackagesManagement\Views\ManagePackages\Index.cshtml"
                        Write(package.StartValidityDate.HasValue ?
                                package.StartValidityDate.Value.ToString("d")
                                :
                                String.Empty);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 61 "C:\Users\HP\Documents\libro c#\Code\PackagesManagement\PackagesManagement\Views\ManagePackages\Index.cshtml"
                        Write(package.EndValidityDate.HasValue ?
                                package.EndValidityDate.Value.ToString("d")
                                :
                                String.Empty);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n\r\n                    </tr>\r\n");
#nullable restore
#line 68 "C:\Users\HP\Documents\libro c#\Code\PackagesManagement\PackagesManagement\Views\ManagePackages\Index.cshtml"

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8f12359a680ffadf0df45a6f2761501a939fbd2e14710", async() => {
                WriteLiteral("\r\n            New package\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 74 "C:\Users\HP\Documents\libro c#\Code\PackagesManagement\PackagesManagement\Views\ManagePackages\Index.cshtml"
              WriteLiteral(nameof(ManagePackagesController.Create));

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-action", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PackagesManagement.Models.Packages.PackagesListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591