#pragma checksum "C:\C#.NET_codes\udemy-course\mvc\PassingData\PassingData\Views\User\TempDataTest.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "486b1ed00ae2c2ca6264edc6902e41f30ab6b7e75921b44f0d9a6c72af1ea4f4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_TempDataTest), @"mvc.1.0.view", @"/Views/User/TempDataTest.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"486b1ed00ae2c2ca6264edc6902e41f30ab6b7e75921b44f0d9a6c72af1ea4f4", @"/Views/User/TempDataTest.cshtml")]
    #nullable restore
    public class Views_User_TempDataTest : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<p>\r\n\r\n    Ben TempDataTest viewıyım.\r\n\r\n</p>\r\n\r\n\r\n\r\n<p>\r\n\r\n    Merhaba ");
            Write(
#nullable restore
#line 11 "C:\C#.NET_codes\udemy-course\mvc\PassingData\PassingData\Views\User\TempDataTest.cshtml"
             TempData["name"].ToString()

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n\r\n</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
