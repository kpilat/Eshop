#pragma checksum "/Users/kristianpilat/Desktop/ASP.NET CORE/Eshop/Pilat.Eshop.Web/Views/Product/Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a830e4da95404423c4fa589ae7eaec2c80511f54"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Detail), @"mvc.1.0.view", @"/Views/Product/Detail.cshtml")]
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
#line 1 "/Users/kristianpilat/Desktop/ASP.NET CORE/Eshop/Pilat.Eshop.Web/Views/_ViewImports.cshtml"
using Pilat.Eshop.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/kristianpilat/Desktop/ASP.NET CORE/Eshop/Pilat.Eshop.Web/Views/_ViewImports.cshtml"
using Pilat.Eshop.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/kristianpilat/Desktop/ASP.NET CORE/Eshop/Pilat.Eshop.Web/Views/_ViewImports.cshtml"
using Pilat.Eshop.Web.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/kristianpilat/Desktop/ASP.NET CORE/Eshop/Pilat.Eshop.Web/Views/_ViewImports.cshtml"
using Pilat.Eshop.Web.Models.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/kristianpilat/Desktop/ASP.NET CORE/Eshop/Pilat.Eshop.Web/Views/_ViewImports.cshtml"
using Pilat.Eshop.Web.Models.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/kristianpilat/Desktop/ASP.NET CORE/Eshop/Pilat.Eshop.Web/Views/_ViewImports.cshtml"
using Pilat.Eshop.Web.Controllers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a830e4da95404423c4fa589ae7eaec2c80511f54", @"/Views/Product/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a63c7119cfa96d84bad0cfd75705e866f8f9a175", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Tuple<Product, List<Product>>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/Users/kristianpilat/Desktop/ASP.NET CORE/Eshop/Pilat.Eshop.Web/Views/Product/Detail.cshtml"
  
    ViewData["Title"] = "Carousel Create";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<section class=\"py-5\">\n    <div class=\"container px-4 px-lg-5 my-5\">\n        <div class=\"row gx-4 gx-lg-5 align-items-center\">\n            <div class=\"col-md-6\"><img class=\"card-img-top mb-5 mb-md-0\"");
            BeginWriteAttribute("src", " src=\"", 285, "\"", 315, 1);
#nullable restore
#line 9 "/Users/kristianpilat/Desktop/ASP.NET CORE/Eshop/Pilat.Eshop.Web/Views/Product/Detail.cshtml"
WriteAttributeValue("", 291, Model.Item1.ImageSource, 291, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"...\" /></div>\n            <div class=\"col-md-6\">\n                <div class=\"small mb-1\">SKU: BST-498</div>\n                <h1 class=\"display-5 fw-bolder\">");
#nullable restore
#line 12 "/Users/kristianpilat/Desktop/ASP.NET CORE/Eshop/Pilat.Eshop.Web/Views/Product/Detail.cshtml"
                                           Write(Model.Item1.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n                <div class=\"fs-5 mb-5\">\n                    <span>");
#nullable restore
#line 14 "/Users/kristianpilat/Desktop/ASP.NET CORE/Eshop/Pilat.Eshop.Web/Views/Product/Detail.cshtml"
                     Write(Model.Item1.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" Kč</span>
                </div>
                <p class=""lead"">Lorem ipsum dolor sit amet consectetur adipisicing elit. Praesentium at dolorem quidem modi. Nam sequi consequatur obcaecati excepturi alias magni, accusamus eius blanditiis delectus ipsam minima ea iste laborum vero?</p>
                <div class=""d-flex"">
                    <input class=""form-control text-center me-3"" id=""inputQuantity"" type=""number"" value=""1"" style=""max-width: 3rem"" />
                    <button class=""btn btn-outline-dark flex-shrink-0"" type=""button"">
                        <i class=""bi-cart-fill me-1""></i>
                        Add to cart
                    </button>
                </div>
            </div>
        </div>
        <div class=""row"">

");
#nullable restore
#line 28 "/Users/kristianpilat/Desktop/ASP.NET CORE/Eshop/Pilat.Eshop.Web/Views/Product/Detail.cshtml"
             foreach (var product in Model.Item2)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-5\">\n                    <div class=\"card\" style=\"width: 18rem;\">\n                      <img");
            BeginWriteAttribute("src", " src=\"", 1526, "\"", 1552, 1);
#nullable restore
#line 32 "/Users/kristianpilat/Desktop/ASP.NET CORE/Eshop/Pilat.Eshop.Web/Views/Product/Detail.cshtml"
WriteAttributeValue("", 1532, product.ImageSource, 1532, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top\" alt=\"...\">\n                      <div class=\"card-body\">\n                        <h5 class=\"card-title\">");
#nullable restore
#line 34 "/Users/kristianpilat/Desktop/ASP.NET CORE/Eshop/Pilat.Eshop.Web/Views/Product/Detail.cshtml"
                                          Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n                        <p class=\"card-text\">Lorem ipsum dolor sit amet, consectetur adipisicing elit. Eius, nihil?</p>\n");
            WriteLiteral("                      </div>\n                    </div>\n                </div>\n");
#nullable restore
#line 40 "/Users/kristianpilat/Desktop/ASP.NET CORE/Eshop/Pilat.Eshop.Web/Views/Product/Detail.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n    </div>\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Tuple<Product, List<Product>>> Html { get; private set; }
    }
}
#pragma warning restore 1591