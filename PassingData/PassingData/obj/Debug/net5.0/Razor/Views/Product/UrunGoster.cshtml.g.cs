#pragma checksum "C:\C#.NET_codes\udemy-course\mvc\PassingData\PassingData\Views\Product\UrunGoster.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "2a5643f6d19cdf0f2de2d9f23ebec098139bbbda7b2cbcc42d78baf12c4c7d9e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_UrunGoster), @"mvc.1.0.view", @"/Views/Product/UrunGoster.cshtml")]
namespace AspNetCore
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
    #line default
    #line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"2a5643f6d19cdf0f2de2d9f23ebec098139bbbda7b2cbcc42d78baf12c4c7d9e", @"/Views/Product/UrunGoster.cshtml")]
    #nullable restore
    public class Views_Product_UrunGoster : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PassingData.Models.Product>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<p>Ürün İsmi : ");
            Write(
#nullable restore
#line 4 "C:\C#.NET_codes\udemy-course\mvc\PassingData\PassingData\Views\Product\UrunGoster.cshtml"
                Model.ProductName

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</p>\r\n<p>Ürün Fiyatı : ");
            Write(
#nullable restore
#line 5 "C:\C#.NET_codes\udemy-course\mvc\PassingData\PassingData\Views\Product\UrunGoster.cshtml"
                  Model.UnitPrice

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</p>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PassingData.Models.Product> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
