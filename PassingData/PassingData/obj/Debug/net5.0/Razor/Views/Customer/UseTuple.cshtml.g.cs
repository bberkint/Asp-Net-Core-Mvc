#pragma checksum "C:\C#.NET_codes\udemy-course\mvc\PassingData\PassingData\Views\Customer\UseTuple.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "171566144ea64c61b9e034b57ea1e801eb8ca47ce798638b91e809fb1098cf0f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_UseTuple), @"mvc.1.0.view", @"/Views/Customer/UseTuple.cshtml")]
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
#nullable restore
#line 1 "C:\C#.NET_codes\udemy-course\mvc\PassingData\PassingData\Views\Customer\UseTuple.cshtml"
 using PassingData.Models

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"171566144ea64c61b9e034b57ea1e801eb8ca47ce798638b91e809fb1098cf0f", @"/Views/Customer/UseTuple.cshtml")]
    #nullable restore
    public class Views_Customer_UseTuple : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<(List<Customer> customers, Product product, string date)>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<p>\r\n    Ürün: ");
            Write(
#nullable restore
#line 6 "C:\C#.NET_codes\udemy-course\mvc\PassingData\PassingData\Views\Customer\UseTuple.cshtml"
           Model.product.ProductName

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n</p>\r\n\r\n<ul>\r\n\r\n");
#nullable restore
#line 11 "C:\C#.NET_codes\udemy-course\mvc\PassingData\PassingData\Views\Customer\UseTuple.cshtml"
     foreach (Customer item in Model.customers)
    {

#line default
#line hidden
#nullable disable

            WriteLiteral("        <li>");
            Write(
#nullable restore
#line 13 "C:\C#.NET_codes\udemy-course\mvc\PassingData\PassingData\Views\Customer\UseTuple.cshtml"
             item.FirstName

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</li>\r\n");
#nullable restore
#line 14 "C:\C#.NET_codes\udemy-course\mvc\PassingData\PassingData\Views\Customer\UseTuple.cshtml"
    }

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n</ul>\r\n\r\n<p>\r\n    Tarih: ");
            Write(
#nullable restore
#line 19 "C:\C#.NET_codes\udemy-course\mvc\PassingData\PassingData\Views\Customer\UseTuple.cshtml"
            Model.date

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<(List<Customer> customers, Product product, string date)> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
