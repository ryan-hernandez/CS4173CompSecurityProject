<<<<<<< HEAD
#pragma checksum "C:\Users\WilderLaptop\Desktop\School shit\CS 4173 Computer Security\Project\CS4173CompSecurityProject\Keyless_Auth_Web\Keyless_Auth_Web\Views\CarInfo\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f8074a4b07caf835d9f1d77201f91c506ac1bab"
=======
#pragma checksum "/Users/ryanhernandez/Desktop/git/CS4173/CompSecurityProject/Keyless_Auth_Web/Keyless_Auth_Web/Views/CarInfo/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f9d24a52448c86bb86d43849710aed471ce5e6f7"
>>>>>>> master
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CarInfo_Index), @"mvc.1.0.view", @"/Views/CarInfo/Index.cshtml")]
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
<<<<<<< HEAD
#line 1 "C:\Users\WilderLaptop\Desktop\School shit\CS 4173 Computer Security\Project\CS4173CompSecurityProject\Keyless_Auth_Web\Keyless_Auth_Web\Views\_ViewImports.cshtml"
=======
#line 1 "/Users/ryanhernandez/Desktop/git/CS4173/CompSecurityProject/Keyless_Auth_Web/Keyless_Auth_Web/Views/_ViewImports.cshtml"
>>>>>>> master
using Keyless_Auth_Web;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 2 "C:\Users\WilderLaptop\Desktop\School shit\CS 4173 Computer Security\Project\CS4173CompSecurityProject\Keyless_Auth_Web\Keyless_Auth_Web\Views\_ViewImports.cshtml"
=======
#line 2 "/Users/ryanhernandez/Desktop/git/CS4173/CompSecurityProject/Keyless_Auth_Web/Keyless_Auth_Web/Views/_ViewImports.cshtml"
>>>>>>> master
using Keyless_Auth_Web.Models;

#line default
#line hidden
#nullable disable
<<<<<<< HEAD
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f8074a4b07caf835d9f1d77201f91c506ac1bab", @"/Views/CarInfo/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bbe9830792861ce3e67f79f8040b8806a0716ad0", @"/Views/_ViewImports.cshtml")]
=======
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9d24a52448c86bb86d43849710aed471ce5e6f7", @"/Views/CarInfo/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"954475e6dc36b6fa4ed3e49d3e9349698bf4e078", @"/Views/_ViewImports.cshtml")]
>>>>>>> master
    public class Views_CarInfo_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Keyless_Auth_Web.Models.CarInfo>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n");
#nullable restore
<<<<<<< HEAD
#line 3 "C:\Users\WilderLaptop\Desktop\School shit\CS 4173 Computer Security\Project\CS4173CompSecurityProject\Keyless_Auth_Web\Keyless_Auth_Web\Views\CarInfo\Index.cshtml"
=======
#line 3 "/Users/ryanhernandez/Desktop/git/CS4173/CompSecurityProject/Keyless_Auth_Web/Keyless_Auth_Web/Views/CarInfo/Index.cshtml"
>>>>>>> master
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
<<<<<<< HEAD
            WriteLiteral("\r\n<script>\r\n    function alerts() {\r\n        var result = \'");
#nullable restore
#line 9 "C:\Users\WilderLaptop\Desktop\School shit\CS 4173 Computer Security\Project\CS4173CompSecurityProject\Keyless_Auth_Web\Keyless_Auth_Web\Views\CarInfo\Index.cshtml"
                 Write(TempData["Message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\';\r\n        if (result.trim() != \"\")\r\n            alert(result);\r\n    }\r\n    alerts();\r\n</script>\r\n\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1f8074a4b07caf835d9f1d77201f91c506ac1bab5121", async() => {
=======
            WriteLiteral("\n<h1>Index</h1>\n\n<p>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f9d24a52448c86bb86d43849710aed471ce5e6f74675", async() => {
>>>>>>> master
                WriteLiteral("Register New Car");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</p>\n<table class=\"table\">\n    <thead>\n        <tr>\n            <th>\n                ");
#nullable restore
<<<<<<< HEAD
#line 25 "C:\Users\WilderLaptop\Desktop\School shit\CS 4173 Computer Security\Project\CS4173CompSecurityProject\Keyless_Auth_Web\Keyless_Auth_Web\Views\CarInfo\Index.cshtml"
=======
#line 16 "/Users/ryanhernandez/Desktop/git/CS4173/CompSecurityProject/Keyless_Auth_Web/Keyless_Auth_Web/Views/CarInfo/Index.cshtml"
>>>>>>> master
           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
<<<<<<< HEAD
#line 28 "C:\Users\WilderLaptop\Desktop\School shit\CS 4173 Computer Security\Project\CS4173CompSecurityProject\Keyless_Auth_Web\Keyless_Auth_Web\Views\CarInfo\Index.cshtml"
=======
#line 19 "/Users/ryanhernandez/Desktop/git/CS4173/CompSecurityProject/Keyless_Auth_Web/Keyless_Auth_Web/Views/CarInfo/Index.cshtml"
>>>>>>> master
           Write(Html.DisplayNameFor(model => model.Owner));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
<<<<<<< HEAD
#line 31 "C:\Users\WilderLaptop\Desktop\School shit\CS 4173 Computer Security\Project\CS4173CompSecurityProject\Keyless_Auth_Web\Keyless_Auth_Web\Views\CarInfo\Index.cshtml"
=======
#line 22 "/Users/ryanhernandez/Desktop/git/CS4173/CompSecurityProject/Keyless_Auth_Web/Keyless_Auth_Web/Views/CarInfo/Index.cshtml"
>>>>>>> master
           Write(Html.DisplayNameFor(model => model.Date_Created));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
<<<<<<< HEAD
#line 34 "C:\Users\WilderLaptop\Desktop\School shit\CS 4173 Computer Security\Project\CS4173CompSecurityProject\Keyless_Auth_Web\Keyless_Auth_Web\Views\CarInfo\Index.cshtml"
=======
#line 25 "/Users/ryanhernandez/Desktop/git/CS4173/CompSecurityProject/Keyless_Auth_Web/Keyless_Auth_Web/Views/CarInfo/Index.cshtml"
>>>>>>> master
           Write(Html.DisplayNameFor(model => model.Make));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
<<<<<<< HEAD
#line 37 "C:\Users\WilderLaptop\Desktop\School shit\CS 4173 Computer Security\Project\CS4173CompSecurityProject\Keyless_Auth_Web\Keyless_Auth_Web\Views\CarInfo\Index.cshtml"
=======
#line 28 "/Users/ryanhernandez/Desktop/git/CS4173/CompSecurityProject/Keyless_Auth_Web/Keyless_Auth_Web/Views/CarInfo/Index.cshtml"
>>>>>>> master
           Write(Html.DisplayNameFor(model => model.Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
<<<<<<< HEAD
#line 40 "C:\Users\WilderLaptop\Desktop\School shit\CS 4173 Computer Security\Project\CS4173CompSecurityProject\Keyless_Auth_Web\Keyless_Auth_Web\Views\CarInfo\Index.cshtml"
=======
#line 31 "/Users/ryanhernandez/Desktop/git/CS4173/CompSecurityProject/Keyless_Auth_Web/Keyless_Auth_Web/Views/CarInfo/Index.cshtml"
>>>>>>> master
           Write(Html.DisplayNameFor(model => model.PhoneNum));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th></th>\n        </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
<<<<<<< HEAD
#line 46 "C:\Users\WilderLaptop\Desktop\School shit\CS 4173 Computer Security\Project\CS4173CompSecurityProject\Keyless_Auth_Web\Keyless_Auth_Web\Views\CarInfo\Index.cshtml"
=======
#line 37 "/Users/ryanhernandez/Desktop/git/CS4173/CompSecurityProject/Keyless_Auth_Web/Keyless_Auth_Web/Views/CarInfo/Index.cshtml"
>>>>>>> master
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td>\n                ");
#nullable restore
<<<<<<< HEAD
#line 49 "C:\Users\WilderLaptop\Desktop\School shit\CS 4173 Computer Security\Project\CS4173CompSecurityProject\Keyless_Auth_Web\Keyless_Auth_Web\Views\CarInfo\Index.cshtml"
=======
#line 40 "/Users/ryanhernandez/Desktop/git/CS4173/CompSecurityProject/Keyless_Auth_Web/Keyless_Auth_Web/Views/CarInfo/Index.cshtml"
>>>>>>> master
           Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
<<<<<<< HEAD
#line 52 "C:\Users\WilderLaptop\Desktop\School shit\CS 4173 Computer Security\Project\CS4173CompSecurityProject\Keyless_Auth_Web\Keyless_Auth_Web\Views\CarInfo\Index.cshtml"
=======
#line 43 "/Users/ryanhernandez/Desktop/git/CS4173/CompSecurityProject/Keyless_Auth_Web/Keyless_Auth_Web/Views/CarInfo/Index.cshtml"
>>>>>>> master
           Write(Html.DisplayFor(modelItem => item.Owner));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
<<<<<<< HEAD
#line 55 "C:\Users\WilderLaptop\Desktop\School shit\CS 4173 Computer Security\Project\CS4173CompSecurityProject\Keyless_Auth_Web\Keyless_Auth_Web\Views\CarInfo\Index.cshtml"
=======
#line 46 "/Users/ryanhernandez/Desktop/git/CS4173/CompSecurityProject/Keyless_Auth_Web/Keyless_Auth_Web/Views/CarInfo/Index.cshtml"
>>>>>>> master
           Write(Html.DisplayFor(modelItem => item.Date_Created));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
<<<<<<< HEAD
#line 58 "C:\Users\WilderLaptop\Desktop\School shit\CS 4173 Computer Security\Project\CS4173CompSecurityProject\Keyless_Auth_Web\Keyless_Auth_Web\Views\CarInfo\Index.cshtml"
=======
#line 49 "/Users/ryanhernandez/Desktop/git/CS4173/CompSecurityProject/Keyless_Auth_Web/Keyless_Auth_Web/Views/CarInfo/Index.cshtml"
>>>>>>> master
           Write(Html.DisplayFor(modelItem => item.Make));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
<<<<<<< HEAD
#line 61 "C:\Users\WilderLaptop\Desktop\School shit\CS 4173 Computer Security\Project\CS4173CompSecurityProject\Keyless_Auth_Web\Keyless_Auth_Web\Views\CarInfo\Index.cshtml"
=======
#line 52 "/Users/ryanhernandez/Desktop/git/CS4173/CompSecurityProject/Keyless_Auth_Web/Keyless_Auth_Web/Views/CarInfo/Index.cshtml"
>>>>>>> master
           Write(Html.DisplayFor(modelItem => item.Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
<<<<<<< HEAD
#line 64 "C:\Users\WilderLaptop\Desktop\School shit\CS 4173 Computer Security\Project\CS4173CompSecurityProject\Keyless_Auth_Web\Keyless_Auth_Web\Views\CarInfo\Index.cshtml"
=======
#line 55 "/Users/ryanhernandez/Desktop/git/CS4173/CompSecurityProject/Keyless_Auth_Web/Keyless_Auth_Web/Views/CarInfo/Index.cshtml"
>>>>>>> master
           Write(Html.DisplayFor(modelItem => item.PhoneNum));

#line default
#line hidden
#nullable disable
<<<<<<< HEAD
            WriteLiteral("\r\n            </td>\r\n\r\n            <td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1f8074a4b07caf835d9f1d77201f91c506ac1bab11570", async() => {
=======
            WriteLiteral("\n            </td>\n\n            <td>\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f9d24a52448c86bb86d43849710aed471ce5e6f710362", async() => {
>>>>>>> master
                WriteLiteral("Register Key");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
<<<<<<< HEAD
#line 68 "C:\Users\WilderLaptop\Desktop\School shit\CS 4173 Computer Security\Project\CS4173CompSecurityProject\Keyless_Auth_Web\Keyless_Auth_Web\Views\CarInfo\Index.cshtml"
=======
#line 59 "/Users/ryanhernandez/Desktop/git/CS4173/CompSecurityProject/Keyless_Auth_Web/Keyless_Auth_Web/Views/CarInfo/Index.cshtml"
>>>>>>> master
                                       WriteLiteral(item.Id);

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
<<<<<<< HEAD
            WriteLiteral(" |\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1f8074a4b07caf835d9f1d77201f91c506ac1bab13827", async() => {
                WriteLiteral("Delete");
=======
            WriteLiteral(" |\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f9d24a52448c86bb86d43849710aed471ce5e6f712544", async() => {
                WriteLiteral("Details");
>>>>>>> master
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
#nullable restore
<<<<<<< HEAD
#line 69 "C:\Users\WilderLaptop\Desktop\School shit\CS 4173 Computer Security\Project\CS4173CompSecurityProject\Keyless_Auth_Web\Keyless_Auth_Web\Views\CarInfo\Index.cshtml"
=======
#line 60 "/Users/ryanhernandez/Desktop/git/CS4173/CompSecurityProject/Keyless_Auth_Web/Keyless_Auth_Web/Views/CarInfo/Index.cshtml"
                                          WriteLiteral(item.Id);

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
            WriteLiteral(" |\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f9d24a52448c86bb86d43849710aed471ce5e6f714724", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 61 "/Users/ryanhernandez/Desktop/git/CS4173/CompSecurityProject/Keyless_Auth_Web/Keyless_Auth_Web/Views/CarInfo/Index.cshtml"
>>>>>>> master
                                         WriteLiteral(item.Id);

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
            WriteLiteral("\n            </td>\n        </tr>\n");
#nullable restore
<<<<<<< HEAD
#line 72 "C:\Users\WilderLaptop\Desktop\School shit\CS 4173 Computer Security\Project\CS4173CompSecurityProject\Keyless_Auth_Web\Keyless_Auth_Web\Views\CarInfo\Index.cshtml"
=======
#line 64 "/Users/ryanhernandez/Desktop/git/CS4173/CompSecurityProject/Keyless_Auth_Web/Keyless_Auth_Web/Views/CarInfo/Index.cshtml"
>>>>>>> master
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Keyless_Auth_Web.Models.CarInfo>> Html { get; private set; }
    }
}
#pragma warning restore 1591
