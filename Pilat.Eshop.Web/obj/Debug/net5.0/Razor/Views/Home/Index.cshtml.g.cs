#pragma checksum "/Users/kristianpilat/Downloads/Pilat.Eshop.Web - kopie/Pilat.Eshop.Web/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f35bc457d0ed40f4e9c9c20f4011e1cdc8baae67"
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
#line 1 "/Users/kristianpilat/Downloads/Pilat.Eshop.Web - kopie/Pilat.Eshop.Web/Views/_ViewImports.cshtml"
using Pilat.Eshop.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/kristianpilat/Downloads/Pilat.Eshop.Web - kopie/Pilat.Eshop.Web/Views/_ViewImports.cshtml"
using Pilat.Eshop.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/kristianpilat/Downloads/Pilat.Eshop.Web - kopie/Pilat.Eshop.Web/Views/_ViewImports.cshtml"
using Pilat.Eshop.Web.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f35bc457d0ed40f4e9c9c20f4011e1cdc8baae67", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"458b2dd0c398aa2097fe595e90d395d50866e022", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IndexViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/Users/kristianpilat/Downloads/Pilat.Eshop.Web - kopie/Pilat.Eshop.Web/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"text-center\">\n    <h1 class=\"display-4\">Welcome</h1>\n    <p>Learn about <a href=\"https://docs.microsoft.com/aspnet/core\">building Web apps with ASP.NET Core</a>.</p>\n\n\n");
#nullable restore
#line 11 "/Users/kristianpilat/Downloads/Pilat.Eshop.Web - kopie/Pilat.Eshop.Web/Views/Home/Index.cshtml"
      
        if (Model != null && Model.CarouselItems != null && Model.CarouselItems.Count > 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div id=\"carousel\" class=\"carousel slide\" data-ride=\"carousel\">\n                <ol class=\"carousel-indicators\">\n");
#nullable restore
#line 16 "/Users/kristianpilat/Downloads/Pilat.Eshop.Web - kopie/Pilat.Eshop.Web/Views/Home/Index.cshtml"
                      

                        for (int i = 0; i < Model.CarouselItems.Count; i++)
                        {
                            if (i == 0)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li data-target=\"#carousel\" data-slide-to=\"");
#nullable restore
#line 22 "/Users/kristianpilat/Downloads/Pilat.Eshop.Web - kopie/Pilat.Eshop.Web/Views/Home/Index.cshtml"
                                                                      Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"active\"></li>\n");
#nullable restore
#line 23 "/Users/kristianpilat/Downloads/Pilat.Eshop.Web - kopie/Pilat.Eshop.Web/Views/Home/Index.cshtml"

                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li data-target=\"#carousel\" data-slide-to=\"");
#nullable restore
#line 27 "/Users/kristianpilat/Downloads/Pilat.Eshop.Web - kopie/Pilat.Eshop.Web/Views/Home/Index.cshtml"
                                                                      Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"></li>\n");
#nullable restore
#line 28 "/Users/kristianpilat/Downloads/Pilat.Eshop.Web - kopie/Pilat.Eshop.Web/Views/Home/Index.cshtml"

                            }
                        }

                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                </ol>\n                <div class=\"carousel-inner\">\n");
#nullable restore
#line 35 "/Users/kristianpilat/Downloads/Pilat.Eshop.Web - kopie/Pilat.Eshop.Web/Views/Home/Index.cshtml"
                      

                        for (int i = 0; i < Model.CarouselItems.Count; i++)
                        {
                            if (i == 0)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"carousel-item active\">\n                                    <img class=\"d-block w-100\"");
            BeginWriteAttribute("src", " src=\"", 1425, "\"", 1466, 1);
#nullable restore
#line 42 "/Users/kristianpilat/Downloads/Pilat.Eshop.Web - kopie/Pilat.Eshop.Web/Views/Home/Index.cshtml"
WriteAttributeValue("", 1431, Model.CarouselItems[i].ImageSource, 1431, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1467, "\"", 1505, 1);
#nullable restore
#line 42 "/Users/kristianpilat/Downloads/Pilat.Eshop.Web - kopie/Pilat.Eshop.Web/Views/Home/Index.cshtml"
WriteAttributeValue("", 1473, Model.CarouselItems[i].ImageAlt, 1473, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                                </div>\n");
#nullable restore
#line 44 "/Users/kristianpilat/Downloads/Pilat.Eshop.Web - kopie/Pilat.Eshop.Web/Views/Home/Index.cshtml"

                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"carousel-item\">\n                                    <img class=\"d-block w-100\"");
            BeginWriteAttribute("src", " src=\"", 1763, "\"", 1804, 1);
#nullable restore
#line 49 "/Users/kristianpilat/Downloads/Pilat.Eshop.Web - kopie/Pilat.Eshop.Web/Views/Home/Index.cshtml"
WriteAttributeValue("", 1769, Model.CarouselItems[i].ImageSource, 1769, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1805, "\"", 1843, 1);
#nullable restore
#line 49 "/Users/kristianpilat/Downloads/Pilat.Eshop.Web - kopie/Pilat.Eshop.Web/Views/Home/Index.cshtml"
WriteAttributeValue("", 1811, Model.CarouselItems[i].ImageAlt, 1811, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                                </div>\n");
#nullable restore
#line 51 "/Users/kristianpilat/Downloads/Pilat.Eshop.Web - kopie/Pilat.Eshop.Web/Views/Home/Index.cshtml"

                            }
                        }

                    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </div>
                <a class=""carousel-control-prev"" href=""#carousel"" role=""button"" data-slide=""prev"">
                    <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
                    <span class=""sr-only"">Previous</span>
                </a>
                <a class=""carousel-control-next"" href=""#carousel"" role=""button"" data-slide=""next"">
                    <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
                    <span class=""sr-only"">Next</span>
                </a>
            </div>
");
#nullable restore
#line 67 "/Users/kristianpilat/Downloads/Pilat.Eshop.Web - kopie/Pilat.Eshop.Web/Views/Home/Index.cshtml"
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    <h1>Products</h1>\n    \n");
#nullable restore
#line 72 "/Users/kristianpilat/Downloads/Pilat.Eshop.Web - kopie/Pilat.Eshop.Web/Views/Home/Index.cshtml"
      
        if (Model != null && Model.Products != null && Model.Products.Count > 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <table class=""table"">
                <thead>
                    <tr>
                        <th scope=""col"">ID</th>
                        <th scope=""col"">Name</th>
                        <th scope=""col"">Category</th>

                    </tr>
                </thead>
                <tbody>


");
#nullable restore
#line 87 "/Users/kristianpilat/Downloads/Pilat.Eshop.Web - kopie/Pilat.Eshop.Web/Views/Home/Index.cshtml"
                      
                        if (Model != null && Model.Products != null)
                        {
                            for (int i = 0; i < Model.Products.Count; i++)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\n                                    <th scope=\"row\">");
#nullable restore
#line 93 "/Users/kristianpilat/Downloads/Pilat.Eshop.Web - kopie/Pilat.Eshop.Web/Views/Home/Index.cshtml"
                                               Write(Model.Products[i].ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                                    <td>");
#nullable restore
#line 94 "/Users/kristianpilat/Downloads/Pilat.Eshop.Web - kopie/Pilat.Eshop.Web/Views/Home/Index.cshtml"
                                   Write(Model.Products[i].Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                    <td>");
#nullable restore
#line 95 "/Users/kristianpilat/Downloads/Pilat.Eshop.Web - kopie/Pilat.Eshop.Web/Views/Home/Index.cshtml"
                                   Write(Model.Products[i].Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                </tr>\n");
#nullable restore
#line 97 "/Users/kristianpilat/Downloads/Pilat.Eshop.Web - kopie/Pilat.Eshop.Web/Views/Home/Index.cshtml"
                            }
                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\n            </table>\n");
#nullable restore
#line 102 "/Users/kristianpilat/Downloads/Pilat.Eshop.Web - kopie/Pilat.Eshop.Web/Views/Home/Index.cshtml"
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
