#pragma checksum "C:\C#.NET_codes\udemy-course\mvc\PassingData\PassingData\Views\Customer\UseViewModel.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3dfe55a0be5ef51cb3a42fa171e25c785279af6dd9189b40669ed84b10cc686a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_UseViewModel), @"mvc.1.0.view", @"/Views/Customer/UseViewModel.cshtml")]
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
#line 1 "C:\C#.NET_codes\udemy-course\mvc\PassingData\PassingData\Views\Customer\UseViewModel.cshtml"
 using PassingData.Models

#nullable disable
    ;
#nullable restore
#line 2 "C:\C#.NET_codes\udemy-course\mvc\PassingData\PassingData\Views\Customer\UseViewModel.cshtml"
 using PassingData.Models.ViewModel

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"3dfe55a0be5ef51cb3a42fa171e25c785279af6dd9189b40669ed84b10cc686a", @"/Views/Customer/UseViewModel.cshtml")]
    #nullable restore
    public class Views_Customer_UseViewModel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CustomerAndProductVM>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n<p>\r\n\r\n    Müşeteriler \r\n\r\n</p>\r\n\r\n\r\n<ul>\r\n");
#nullable restore
#line 15 "C:\C#.NET_codes\udemy-course\mvc\PassingData\PassingData\Views\Customer\UseViewModel.cshtml"
     foreach (Customer item in Model.customers)
    {

#line default
#line hidden
#nullable disable

            WriteLiteral("        <li>");
            Write(
#nullable restore
#line 17 "C:\C#.NET_codes\udemy-course\mvc\PassingData\PassingData\Views\Customer\UseViewModel.cshtml"
             item.FirstName

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</li>\r\n");
#nullable restore
#line 18 "C:\C#.NET_codes\udemy-course\mvc\PassingData\PassingData\Views\Customer\UseViewModel.cshtml"
    }

#line default
#line hidden
#nullable disable

            WriteLiteral("</ul>\r\n\r\n<p>\r\n\r\n    ");
            Write(
#nullable restore
#line 23 "C:\C#.NET_codes\udemy-course\mvc\PassingData\PassingData\Views\Customer\UseViewModel.cshtml"
     Model.product.ProductName

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n\r\n</p>\r\n\r\n<p>\r\n    Tarih: ");
            Write(
#nullable restore
#line 28 "C:\C#.NET_codes\udemy-course\mvc\PassingData\PassingData\Views\Customer\UseViewModel.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CustomerAndProductVM> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
