#pragma checksum "G:\DoAn_LTHDT_2021_12\QuanLyCuaHang\QuanLyCuaHang\Pages\MH_LoaiHang\XoaLH.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "874c1461bfb80018a13c56e8b0538f5a12d91a2e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(QuanLyCuaHang.Pages.MH_LoaiHang.Pages_MH_LoaiHang_XoaLH), @"mvc.1.0.razor-page", @"/Pages/MH_LoaiHang/XoaLH.cshtml")]
namespace QuanLyCuaHang.Pages.MH_LoaiHang
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
#nullable restore
#line 3 "G:\DoAn_LTHDT_2021_12\QuanLyCuaHang\QuanLyCuaHang\Pages\MH_LoaiHang\XoaLH.cshtml"
using Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"874c1461bfb80018a13c56e8b0538f5a12d91a2e", @"/Pages/MH_LoaiHang/XoaLH.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19eb323fe5fcc16b6d2fe1de9864a53f95a6caf4", @"/Pages/_ViewImports.cshtml")]
    public class Pages_MH_LoaiHang_XoaLH : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
#line 7 "G:\DoAn_LTHDT_2021_12\QuanLyCuaHang\QuanLyCuaHang\Pages\MH_LoaiHang\XoaLH.cshtml"
 if (Model.coSanPham)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>Xóa Loại Hàng</h1>\r\n    <br />\r\n    <h5>Bạn có muốn xóa \"Loại Hàng\" có mã là \"");
#nullable restore
#line 11 "G:\DoAn_LTHDT_2021_12\QuanLyCuaHang\QuanLyCuaHang\Pages\MH_LoaiHang\XoaLH.cshtml"
                                         Write(Model.truyXuatLH.MaLoaiHang);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"""</h5>
    <br />
    <table class=""table table-striped"">
        <thead>
            <tr>
                <th>Mã Loại Hàng</th>
                <th>Tên Loại Hàng</th>
            </tr>
        </thead>
        <tbody>
            <tr>
                <td>");
#nullable restore
#line 22 "G:\DoAn_LTHDT_2021_12\QuanLyCuaHang\QuanLyCuaHang\Pages\MH_LoaiHang\XoaLH.cshtml"
               Write(Model.truyXuatLH.MaLoaiHang);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 23 "G:\DoAn_LTHDT_2021_12\QuanLyCuaHang\QuanLyCuaHang\Pages\MH_LoaiHang\XoaLH.cshtml"
               Write(Model.truyXuatLH.TenLoaiHang);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n        </tbody>\r\n    </table>\r\n    <br />\r\n");
#nullable restore
#line 29 "G:\DoAn_LTHDT_2021_12\QuanLyCuaHang\QuanLyCuaHang\Pages\MH_LoaiHang\XoaLH.cshtml"
     if (Model.dsMHLienQuan.Count > 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div>Xóa \"Loại hàng\" <b>");
#nullable restore
#line 31 "G:\DoAn_LTHDT_2021_12\QuanLyCuaHang\QuanLyCuaHang\Pages\MH_LoaiHang\XoaLH.cshtml"
                           Write(Model.truyXuatLH.TenLoaiHang);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</b> sẽ <b>xóa luôn</b> các <b>Mặt hàng liên quan</b> gồm:</div>
        <br />
        <table class=""table table-striped"">
            <thead>
                <tr>
                    <th>Mã Mặt Hàng</th>
                    <th>Tên Mặt Hàng</th>
                    <th>Loại Hàng</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 42 "G:\DoAn_LTHDT_2021_12\QuanLyCuaHang\QuanLyCuaHang\Pages\MH_LoaiHang\XoaLH.cshtml"
                 foreach (MatHang item in Model.dsMHLienQuan)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 45 "G:\DoAn_LTHDT_2021_12\QuanLyCuaHang\QuanLyCuaHang\Pages\MH_LoaiHang\XoaLH.cshtml"
                       Write(item.MaMatHang);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 46 "G:\DoAn_LTHDT_2021_12\QuanLyCuaHang\QuanLyCuaHang\Pages\MH_LoaiHang\XoaLH.cshtml"
                       Write(item.TenMatHang);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>\r\n");
#nullable restore
#line 48 "G:\DoAn_LTHDT_2021_12\QuanLyCuaHang\QuanLyCuaHang\Pages\MH_LoaiHang\XoaLH.cshtml"
                             foreach (LoaiHang lh in Model.dsLH)
                            {
                                if (lh.MaLoaiHang == item.MaLoaiHang)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "G:\DoAn_LTHDT_2021_12\QuanLyCuaHang\QuanLyCuaHang\Pages\MH_LoaiHang\XoaLH.cshtml"
                               Write(lh.TenLoaiHang);

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "G:\DoAn_LTHDT_2021_12\QuanLyCuaHang\QuanLyCuaHang\Pages\MH_LoaiHang\XoaLH.cshtml"
                                                   
                                }
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 57 "G:\DoAn_LTHDT_2021_12\QuanLyCuaHang\QuanLyCuaHang\Pages\MH_LoaiHang\XoaLH.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n");
#nullable restore
#line 60 "G:\DoAn_LTHDT_2021_12\QuanLyCuaHang\QuanLyCuaHang\Pages\MH_LoaiHang\XoaLH.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "874c1461bfb80018a13c56e8b0538f5a12d91a2e8305", async() => {
                WriteLiteral("\r\n        <button type=\"submit\" class=\"btn btn-danger\">Xác nhận</button>\r\n        <a href=\"/MH_LoaiHang/DanhSachLH\" class=\"btn btn-dark\">Hủy</a>\r\n    ");
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
#line 67 "G:\DoAn_LTHDT_2021_12\QuanLyCuaHang\QuanLyCuaHang\Pages\MH_LoaiHang\XoaLH.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div style=\"color: red;\">");
#nullable restore
#line 70 "G:\DoAn_LTHDT_2021_12\QuanLyCuaHang\QuanLyCuaHang\Pages\MH_LoaiHang\XoaLH.cshtml"
                        Write(Model.Chuoi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 71 "G:\DoAn_LTHDT_2021_12\QuanLyCuaHang\QuanLyCuaHang\Pages\MH_LoaiHang\XoaLH.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<QuanLyCuaHang.Pages.MH_LoaiHang.XoaLHModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<QuanLyCuaHang.Pages.MH_LoaiHang.XoaLHModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<QuanLyCuaHang.Pages.MH_LoaiHang.XoaLHModel>)PageContext?.ViewData;
        public QuanLyCuaHang.Pages.MH_LoaiHang.XoaLHModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
