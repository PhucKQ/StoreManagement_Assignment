#pragma checksum "G:\DoAn_LTHDT_2021_12\QuanLyCuaHang\QuanLyCuaHang\Pages\MH_HoaDonNhap\SuaHoaDonNhap.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "46195248dab5b3570df82b676fbab1ad2f8fa033"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(QuanLyCuaHang.Pages.MH_HoaDonNhap.Pages_MH_HoaDonNhap_SuaHoaDonNhap), @"mvc.1.0.razor-page", @"/Pages/MH_HoaDonNhap/SuaHoaDonNhap.cshtml")]
namespace QuanLyCuaHang.Pages.MH_HoaDonNhap
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
#line 1 "G:\DoAn_LTHDT_2021_12\QuanLyCuaHang\QuanLyCuaHang\Pages\_ViewImports.cshtml"
using QuanLyCuaHang;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46195248dab5b3570df82b676fbab1ad2f8fa033", @"/Pages/MH_HoaDonNhap/SuaHoaDonNhap.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19eb323fe5fcc16b6d2fe1de9864a53f95a6caf4", @"/Pages/_ViewImports.cshtml")]
    public class Pages_MH_HoaDonNhap_SuaHoaDonNhap : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>Sửa thông tin Hóa Đơn Nhập hàng</h1>\r\n");
#nullable restore
#line 7 "G:\DoAn_LTHDT_2021_12\QuanLyCuaHang\QuanLyCuaHang\Pages\MH_HoaDonNhap\SuaHoaDonNhap.cshtml"
 if (Model.coDuLieu)
{

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "46195248dab5b3570df82b676fbab1ad2f8fa0333815", async() => {
                WriteLiteral("\r\n    <div class=\"row my-2\">\r\n        <div class=\"col-4\">\r\n            <label>Tên Mặt Hàng</label>\r\n");
                WriteLiteral("            <select class=\"form-control\" name=\"TenMH\">\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "46195248dab5b3570df82b676fbab1ad2f8fa0334294", async() => {
#nullable restore
#line 15 "G:\DoAn_LTHDT_2021_12\QuanLyCuaHang\QuanLyCuaHang\Pages\MH_HoaDonNhap\SuaHoaDonNhap.cshtml"
                                                        Write(Model.thongTinHD.TenMatHang);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 15 "G:\DoAn_LTHDT_2021_12\QuanLyCuaHang\QuanLyCuaHang\Pages\MH_HoaDonNhap\SuaHoaDonNhap.cshtml"
                   WriteLiteral(Model.thongTinHD.TenMatHang);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 16 "G:\DoAn_LTHDT_2021_12\QuanLyCuaHang\QuanLyCuaHang\Pages\MH_HoaDonNhap\SuaHoaDonNhap.cshtml"
                 foreach (string item in Model.dsTenMH)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "46195248dab5b3570df82b676fbab1ad2f8fa0336524", async() => {
#nullable restore
#line 18 "G:\DoAn_LTHDT_2021_12\QuanLyCuaHang\QuanLyCuaHang\Pages\MH_HoaDonNhap\SuaHoaDonNhap.cshtml"
                                     Write(item);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 18 "G:\DoAn_LTHDT_2021_12\QuanLyCuaHang\QuanLyCuaHang\Pages\MH_HoaDonNhap\SuaHoaDonNhap.cshtml"
                       WriteLiteral(item);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 19 "G:\DoAn_LTHDT_2021_12\QuanLyCuaHang\QuanLyCuaHang\Pages\MH_HoaDonNhap\SuaHoaDonNhap.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </select>\r\n        </div>\r\n    </div>\r\n    <div class=\"row my-2\">\r\n        <div class=\"col-4\">\r\n            <label>Ngày Tạo (dd/mm/yyyy)</label>\r\n            <input class=\"form-control\" name=\"NgayTao\"");
                BeginWriteAttribute("value", " value=\"", 882, "\"", 915, 1);
#nullable restore
#line 26 "G:\DoAn_LTHDT_2021_12\QuanLyCuaHang\QuanLyCuaHang\Pages\MH_HoaDonNhap\SuaHoaDonNhap.cshtml"
WriteAttributeValue("", 890, Model.thongTinHD.NgayTao, 890, 25, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\r\n        </div>\r\n    </div>\r\n    <div class=\"row my-2\">\r\n        <div class=\"col-4\">\r\n            <label>Số Lượng</label>\r\n            <input class=\"form-control\" name=\"SoLuong\"");
                BeginWriteAttribute("value", " value=\"", 1096, "\"", 1129, 1);
#nullable restore
#line 32 "G:\DoAn_LTHDT_2021_12\QuanLyCuaHang\QuanLyCuaHang\Pages\MH_HoaDonNhap\SuaHoaDonNhap.cshtml"
WriteAttributeValue("", 1104, Model.thongTinHD.SoLuong, 1104, 25, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\r\n        </div>\r\n    </div>\r\n    <br />\r\n\r\n    <button class=\"btn btn-success\">Xác nhận</button>\r\n    <a class=\"btn btn-dark\" href=\"./DanhSachHoaDonNhap\">Hủy</a>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
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
#line 40 "G:\DoAn_LTHDT_2021_12\QuanLyCuaHang\QuanLyCuaHang\Pages\MH_HoaDonNhap\SuaHoaDonNhap.cshtml"
}
else 
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"text-danger\">");
#nullable restore
#line 43 "G:\DoAn_LTHDT_2021_12\QuanLyCuaHang\QuanLyCuaHang\Pages\MH_HoaDonNhap\SuaHoaDonNhap.cshtml"
                        Write(Model.Chuoi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 44 "G:\DoAn_LTHDT_2021_12\QuanLyCuaHang\QuanLyCuaHang\Pages\MH_HoaDonNhap\SuaHoaDonNhap.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<QuanLyCuaHang.Pages.MH_HoaDonNhap.SuaHoaDonNhapModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<QuanLyCuaHang.Pages.MH_HoaDonNhap.SuaHoaDonNhapModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<QuanLyCuaHang.Pages.MH_HoaDonNhap.SuaHoaDonNhapModel>)PageContext?.ViewData;
        public QuanLyCuaHang.Pages.MH_HoaDonNhap.SuaHoaDonNhapModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
