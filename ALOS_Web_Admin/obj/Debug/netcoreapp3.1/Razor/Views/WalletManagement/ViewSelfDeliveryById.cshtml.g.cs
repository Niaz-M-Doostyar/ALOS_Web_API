#pragma checksum "C:\Users\Niaz-PC\source\repos\ALOS_Web_API\ALOS_Web_Admin\Views\WalletManagement\ViewSelfDeliveryById.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "26c61b2ca0084be098117afd50eb5433b762981b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_WalletManagement_ViewSelfDeliveryById), @"mvc.1.0.view", @"/Views/WalletManagement/ViewSelfDeliveryById.cshtml")]
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
#line 1 "C:\Users\Niaz-PC\source\repos\ALOS_Web_API\ALOS_Web_Admin\Views\_ViewImports.cshtml"
using ALOS_Web_Admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Niaz-PC\source\repos\ALOS_Web_API\ALOS_Web_Admin\Views\_ViewImports.cshtml"
using ALOS_Web_Admin.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Niaz-PC\source\repos\ALOS_Web_API\ALOS_Web_Admin\Views\WalletManagement\ViewSelfDeliveryById.cshtml"
using ALOS_Web_Admin.Helpers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26c61b2ca0084be098117afd50eb5433b762981b", @"/Views/WalletManagement/ViewSelfDeliveryById.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5fd62b964d76cc667954a39adebc40b01569649a", @"/Views/_ViewImports.cshtml")]
    public class Views_WalletManagement_ViewSelfDeliveryById : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<object>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Niaz-PC\source\repos\ALOS_Web_API\ALOS_Web_Admin\Views\WalletManagement\ViewSelfDeliveryById.cshtml"
  
    ViewBag.Title = "Self Delivery Details";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""content-wrapper"">

    <!-- Main content -->
    <section class=""content"">
        <div class=""container-fluid"">
            <!-- Small boxes (Stat box) -->
            <div class=""row"">

                <div class=""col-sm-12"">
                    <div class=""card card-primary"">
                        <div class=""card-header"">
                            <h3 class=""card-title"">Self Delivery Information</h3>
                        </div>

                        <div class=""card-body col-sm-6"">
");
#nullable restore
#line 22 "C:\Users\Niaz-PC\source\repos\ALOS_Web_API\ALOS_Web_Admin\Views\WalletManagement\ViewSelfDeliveryById.cshtml"
                             if (ViewBag.SelfDelivery != null)
                            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "26c61b2ca0084be098117afd50eb5433b762981b5047", async() => {
                WriteLiteral("\r\n                                <table class=\"table table-bordered\">\r\n                                <tr>\r\n                                        <td>Order No</td>\r\n                                        <td");
                BeginWriteAttribute("name", " name=\"", 1054, "\"", 1061, 0);
                EndWriteAttribute();
                WriteLiteral("><label");
                BeginWriteAttribute("for", " for=\"", 1069, "\"", 1075, 0);
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 29 "C:\Users\Niaz-PC\source\repos\ALOS_Web_API\ALOS_Web_Admin\Views\WalletManagement\ViewSelfDeliveryById.cshtml"
                                                             Write(ViewBag.SelfDelivery.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label></td>\r\n                                        <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 1176, "\"", 1208, 1);
#nullable restore
#line 30 "C:\Users\Niaz-PC\source\repos\ALOS_Web_API\ALOS_Web_Admin\Views\WalletManagement\ViewSelfDeliveryById.cshtml"
WriteAttributeValue("", 1184, ViewBag.SelfDelivery.Id, 1184, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"delivery_id\">\r\n                                        <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 1291, "\"", 1328, 1);
#nullable restore
#line 31 "C:\Users\Niaz-PC\source\repos\ALOS_Web_API\ALOS_Web_Admin\Views\WalletManagement\ViewSelfDeliveryById.cshtml"
WriteAttributeValue("", 1299, ViewBag.SelfDelivery.AdminId, 1299, 29, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" name=""user"">
                                        </tr>

                                        <tr>
                                            <td>Order Amount</td>
                                            <td>
                                                <input type=""hidden""");
                BeginWriteAttribute("value", " value=\"", 1624, "\"", 1660, 1);
#nullable restore
#line 37 "C:\Users\Niaz-PC\source\repos\ALOS_Web_API\ALOS_Web_Admin\Views\WalletManagement\ViewSelfDeliveryById.cshtml"
WriteAttributeValue("", 1632, ViewBag.SelfDelivery.Amount, 1632, 28, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"amount\" id=\"amount\">\r\n                                                <label");
                BeginWriteAttribute("for", " for=\"", 1744, "\"", 1750, 0);
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 38 "C:\Users\Niaz-PC\source\repos\ALOS_Web_API\ALOS_Web_Admin\Views\WalletManagement\ViewSelfDeliveryById.cshtml"
                                                         Write(ViewBag.SelfDelivery.Amount);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                                                <label");
                BeginWriteAttribute("for", " for=\"", 1844, "\"", 1850, 0);
                EndWriteAttribute();
                WriteLiteral(@"></label>

                                            </td>
                                        </tr>

                                        <tr>
                                            <td name=""date"">Order Data</td>
                                            <td>
                                                <input type=""hidden""");
                BeginWriteAttribute("value", " value=\"", 2205, "\"", 2244, 1);
#nullable restore
#line 47 "C:\Users\Niaz-PC\source\repos\ALOS_Web_API\ALOS_Web_Admin\Views\WalletManagement\ViewSelfDeliveryById.cshtml"
WriteAttributeValue("", 2213, ViewBag.SelfDelivery.UpdatedAt, 2213, 31, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"updated_at\">\r\n                                                <label");
                BeginWriteAttribute("for", " for=\"", 2320, "\"", 2326, 0);
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 48 "C:\Users\Niaz-PC\source\repos\ALOS_Web_API\ALOS_Web_Admin\Views\WalletManagement\ViewSelfDeliveryById.cshtml"
                                                         Write(ViewBag.SelfDelivery.UpdatedAt);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</label>
                                            </td>
                                        </tr>

                                        <tr>
                                            <td name=""remarks"">Order Remarks</td>
                                            <td>
                                                <input type=""hidden""");
                BeginWriteAttribute("value", " value=\"", 2716, "\"", 2752, 1);
#nullable restore
#line 55 "C:\Users\Niaz-PC\source\repos\ALOS_Web_API\ALOS_Web_Admin\Views\WalletManagement\ViewSelfDeliveryById.cshtml"
WriteAttributeValue("", 2724, ViewBag.SelfDelivery.Remark, 2724, 28, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"remark\">\r\n                                                <label");
                BeginWriteAttribute("for", " for=\"", 2824, "\"", 2830, 0);
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 56 "C:\Users\Niaz-PC\source\repos\ALOS_Web_API\ALOS_Web_Admin\Views\WalletManagement\ViewSelfDeliveryById.cshtml"
                                                         Write(ViewBag.SelfDelivery.Remark);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</label>
                                            </td>
                                        </tr>


                                        <tr>
                                            <td>Status</td>
                                            <input type=""hidden""");
                BeginWriteAttribute("value", " value=\"", 3143, "\"", 3179, 1);
#nullable restore
#line 63 "C:\Users\Niaz-PC\source\repos\ALOS_Web_API\ALOS_Web_Admin\Views\WalletManagement\ViewSelfDeliveryById.cshtml"
WriteAttributeValue("", 3151, ViewBag.SelfDelivery.Status, 3151, 28, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"status\">\r\n                                            <td><label");
                BeginWriteAttribute("for", " for=\"", 3251, "\"", 3257, 0);
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 64 "C:\Users\Niaz-PC\source\repos\ALOS_Web_API\ALOS_Web_Admin\Views\WalletManagement\ViewSelfDeliveryById.cshtml"
                                                         Write(ViewBag.SelfDelivery.Status);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</label></td>
                                        </tr>

                                <tr>
                                    <td>Action</td>
                                    <td>

                                        <input onclick=""return Confirm()"" type=""submit"" class=""btn btn-info"" name=submitbutton value=""Add"">
                                        <input type=""submit"" class=""btn btn-danger"" name=submitbutton value=""Reject"">

                              
                                    </td></tr>
                                
                                </table>
                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 25 "C:\Users\Niaz-PC\source\repos\ALOS_Web_API\ALOS_Web_Admin\Views\WalletManagement\ViewSelfDeliveryById.cshtml"
AddHtmlAttributeValue("", 772, Url.Action("ViewSelfDeliveryById","WalletManagement"), 772, 54, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 79 "C:\Users\Niaz-PC\source\repos\ALOS_Web_API\ALOS_Web_Admin\Views\WalletManagement\ViewSelfDeliveryById.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                        </div>


                        <ul>
                        </ul>

                    </div>
                </div>

            </div>


            <!-- /.row -->
            <!-- Main row -->
            <!-- /.row (main row) -->
        </div><!-- /.container-fluid -->
    </section>
    <!-- /.content -->
</div>v>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<object> Html { get; private set; }
    }
}
#pragma warning restore 1591
