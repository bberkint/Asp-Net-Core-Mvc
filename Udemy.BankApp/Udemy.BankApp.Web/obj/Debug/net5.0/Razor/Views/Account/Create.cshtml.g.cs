#pragma checksum "C:\C#.NET_codes\udemy-course\mvc\Udemy.BankApp\Udemy.BankApp.Web\Views\Account\Create.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0b58a35e76982a8a36d4a7587e32b4d8ae9f24dc50309ecb250242155eb271d4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Create), @"mvc.1.0.view", @"/Views/Account/Create.cshtml")]
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
#line 3 "C:\C#.NET_codes\udemy-course\mvc\Udemy.BankApp\Udemy.BankApp.Web\Views\_ViewImports.cshtml"
using Udemy.BankApp.Web.Models

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"0b58a35e76982a8a36d4a7587e32b4d8ae9f24dc50309ecb250242155eb271d4", @"/Views/Account/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"a0e16a72792e1990da3149063b23114e3eb3d7bd4b5b57b14d199594cb3ca17b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Account_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UserListModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Udemy.BankApp.Web.TagHelpers.GetAccountCount __Udemy_BankApp_Web_TagHelpers_GetAccountCount;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\C#.NET_codes\udemy-course\mvc\Udemy.BankApp\Udemy.BankApp.Web\Views\Account\Create.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable

            WriteLiteral("<div class=\"row\">\r\n    <div class=\"col-6\">\r\n        <h3> Hesap Eklenecek Kişinin Bilgileri</h3>\r\n        <p>\r\n            Kullanıcnın Adı :");
            Write(
#nullable restore
#line 9 "C:\C#.NET_codes\udemy-course\mvc\Udemy.BankApp\Udemy.BankApp.Web\Views\Account\Create.cshtml"
                              Model.Name

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        </p>\r\n        <p>\r\n            Kullanıcnın Soyadı :");
            Write(
#nullable restore
#line 12 "C:\C#.NET_codes\udemy-course\mvc\Udemy.BankApp\Udemy.BankApp.Web\Views\Account\Create.cshtml"
                                 Model.Surname

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        </p>\r\n        <p>\r\n            Kullanıcının Aktif Hesap Sayısı : ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("getAccountCount", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0b58a35e76982a8a36d4a7587e32b4d8ae9f24dc50309ecb250242155eb271d45384", async() => {
            }
            );
            __Udemy_BankApp_Web_TagHelpers_GetAccountCount = CreateTagHelper<global::Udemy.BankApp.Web.TagHelpers.GetAccountCount>();
            __tagHelperExecutionContext.Add(__Udemy_BankApp_Web_TagHelpers_GetAccountCount);
            __Udemy_BankApp_Web_TagHelpers_GetAccountCount.ApplicationUserId = 
#nullable restore
#line 15 "C:\C#.NET_codes\udemy-course\mvc\Udemy.BankApp\Udemy.BankApp.Web\Views\Account\Create.cshtml"
                                                                                     Model.Id

#line default
#line hidden
#nullable disable
            ;
            __tagHelperExecutionContext.AddTagHelperAttribute("application-user-id", __Udemy_BankApp_Web_TagHelpers_GetAccountCount.ApplicationUserId, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </p>\r\n    </div>\r\n\r\n    <div class=\"col-6\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0b58a35e76982a8a36d4a7587e32b4d8ae9f24dc50309ecb250242155eb271d46986", async() => {
                WriteLiteral("\r\n            <input type=\"hidden\" name=\"ApplicationUserId\"");
                BeginWriteAttribute("value", " value=\"", 630, "\"", 647, 1);
                WriteAttributeValue("", 638, 
#nullable restore
#line 21 "C:\C#.NET_codes\udemy-course\mvc\Udemy.BankApp\Udemy.BankApp.Web\Views\Account\Create.cshtml"
                                                                  Model.Id

#line default
#line hidden
#nullable disable
                , 638, 9, false);
                EndWriteAttribute();
                WriteLiteral(@" />
            <div class=""mb-3"">
                <label class=""form-label"">Hesap Numarası :</label>
                <input type=""number"" name=""AccountNumber"" class=""form-control"" />
            </div>
            <div class=""mb-3"">
                <label class=""form-label"">Bakiye :</label>
                <input type=""number"" name=""Balance"" class=""form-control"" />
            </div>
            <div class=""mb-3"">
                <button class=""btn btn-primary"">Kaydet</button>
            </div>

        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UserListModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591