#pragma checksum "/Users/creative/Documents/Development/coding_dojo/c_sharp_stack/CRUDelicious/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "beaa02aae3f5c34c74d11e9a3b875df31d24a991"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "/Users/creative/Documents/Development/coding_dojo/c_sharp_stack/CRUDelicious/Views/_ViewImports.cshtml"
using CRUDelicious;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/creative/Documents/Development/coding_dojo/c_sharp_stack/CRUDelicious/Views/Home/Index.cshtml"
using CRUDelicious.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"beaa02aae3f5c34c74d11e9a3b875df31d24a991", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"815eae4269ab1eac71e8261ccfa9294c33285639", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Dish>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/creative/Documents/Development/coding_dojo/c_sharp_stack/CRUDelicious/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <div class=""row"">
        <h2>Welcome to CRUDelicious</h2>
    </div>
    <div class=""text-center d-flex justify-content-between"">
        <table>
            <thead>
                <th>Dishes</th>
            </thead>
            <tbody>
");
#nullable restore
#line 17 "/Users/creative/Documents/Development/coding_dojo/c_sharp_stack/CRUDelicious/Views/Home/Index.cshtml"
             foreach(Dish d in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 20 "/Users/creative/Documents/Development/coding_dojo/c_sharp_stack/CRUDelicious/Views/Home/Index.cshtml"
                   Write(d.DishName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                    <td><a");
            BeginWriteAttribute("href", " href=\"", 519, "\"", 540, 2);
            WriteAttributeValue("", 526, "edit/", 526, 5, true);
#nullable restore
#line 21 "/Users/creative/Documents/Development/coding_dojo/c_sharp_stack/CRUDelicious/Views/Home/Index.cshtml"
WriteAttributeValue("", 531, d.DishId, 531, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a></td>\r\n                    <td><a");
            BeginWriteAttribute("href", " href=\"", 583, "\"", 606, 2);
            WriteAttributeValue("", 590, "delete/", 590, 7, true);
#nullable restore
#line 22 "/Users/creative/Documents/Development/coding_dojo/c_sharp_stack/CRUDelicious/Views/Home/Index.cshtml"
WriteAttributeValue("", 597, d.DishId, 597, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a></td>\r\n                </tr>\r\n");
#nullable restore
#line 24 "/Users/creative/Documents/Development/coding_dojo/c_sharp_stack/CRUDelicious/Views/Home/Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </tbody>
        </table>
        <ul class=""d-flex justify-context-evenly"" >

        </ul>
            <div class=""myDIV"">
                <div class=""hide"">
                    <a class=""hide"" href=""/new"">Add a Dish</a>
                </div>
            </div>
    </div>
    <div class=""row"">
        <p>Display Recent Dishes</p>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Dish>> Html { get; private set; }
    }
}
#pragma warning restore 1591
