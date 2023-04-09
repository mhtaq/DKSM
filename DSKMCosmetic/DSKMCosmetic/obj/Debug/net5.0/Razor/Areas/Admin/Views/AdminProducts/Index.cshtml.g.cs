#pragma checksum "D:\NET project\DKSM-Comestic\DSKMCosmetic\DSKMCosmetic\Areas\Admin\Views\AdminProducts\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "12a625ba9326a6a1ee05226b9026490547025dad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AdminProducts_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/AdminProducts/Index.cshtml")]
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
#line 1 "D:\NET project\DKSM-Comestic\DSKMCosmetic\DSKMCosmetic\Areas\Admin\Views\_ViewImports.cshtml"
using DSKMCosmetic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\NET project\DKSM-Comestic\DSKMCosmetic\DSKMCosmetic\Areas\Admin\Views\_ViewImports.cshtml"
using DSKMCosmetic.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\NET project\DKSM-Comestic\DSKMCosmetic\DSKMCosmetic\Areas\Admin\Views\AdminProducts\Index.cshtml"
using PagedList.Core.Mvc;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12a625ba9326a6a1ee05226b9026490547025dad", @"/Areas/Admin/Views/AdminProducts/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45b63f8b80b08156480c2bac10a4d9ca85591ebf", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_AdminProducts_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PagedList.Core.IPagedList<DSKMCosmetic.Models.Product>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "AdminProducts", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("breadcrumb-item"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\NET project\DKSM-Comestic\DSKMCosmetic\DSKMCosmetic\Areas\Admin\Views\AdminProducts\Index.cshtml"
  
    int currentPage = ViewBag.CurrentPage;
    ViewData["Title"] = "List of Products " + currentPage;
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"page-header\">\r\n    <h2 class=\"header-title\">Product Management</h2>\r\n    <div class=\"header-sub-title\">\r\n        <nav class=\"breadcrumb breadcrumb-dash\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "12a625ba9326a6a1ee05226b9026490547025dad6612", async() => {
                WriteLiteral("<i class=\"anticon anticon-home m-r-5\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            <span class=\"breadcrumb-item active\">Product List: page ");
#nullable restore
#line 15 "D:\NET project\DKSM-Comestic\DSKMCosmetic\DSKMCosmetic\Areas\Admin\Views\AdminProducts\Index.cshtml"
                                                               Write(currentPage);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
        </nav>
    </div>
</div>
<div class=""card"">
    <div class=""card-body"">
        <div class=""row m-b-30"">
            <div class=""col-lg-8"">
                <div class=""d-md-flex"">
                    <div class=""input-group m-b-10 m-r-15"">
                        <span class=""input-group-prepend"">
                            <span class=""input-group-text border-0"" id=""search-addon"">
                                <i class=""fas fa-search""></i>
                            </span>
                        </span>
                        <input id=""keyword"" name=""keyword"" type=""search"" class=""form-control rounded"" placeholder=""Search Products"" aria-label=""Search"" aria-describedby=""search-addon"" />
                    </div>
                </div>
            </div>
            <div class=""col-lg-4 text-right"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "12a625ba9326a6a1ee05226b9026490547025dad9567", async() => {
                WriteLiteral(" <i class=\"anticon anticon-plus-circle m-r-5\"></i>Add Product");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
        </div>
        <div class=""table-responsive"">
            <table class=""table table-hover e-commerce-table"" >
                <thead>
                    <tr>
                        <th>ID</th>
                        <th>Name</th>
                        <th>Category</th>
                        <th>Brand name</th>
                        <th>Description</th>
                        <th>Price</th>
                        <th>Size</th>
");
            WriteLiteral("                        <th>Status</th>\r\n                        <th>Action</th>\r\n                    </tr>\r\n                </thead>\r\n                <tbody id=\"records_table\">\r\n");
#nullable restore
#line 55 "D:\NET project\DKSM-Comestic\DSKMCosmetic\DSKMCosmetic\Areas\Admin\Views\AdminProducts\Index.cshtml"
                     if (Model != null){
                        foreach (var item in Model){

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 58 "D:\NET project\DKSM-Comestic\DSKMCosmetic\DSKMCosmetic\Areas\Admin\Views\AdminProducts\Index.cshtml"
                               Write(item.ProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>\r\n                                    <div class=\"d-flex align-items-center\">\r\n                                        <h6 class=\"m-b-0 m-l-10\">");
#nullable restore
#line 61 "D:\NET project\DKSM-Comestic\DSKMCosmetic\DSKMCosmetic\Areas\Admin\Views\AdminProducts\Index.cshtml"
                                                            Write(item.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                    </div>\r\n                                </td>\r\n                                <td>");
#nullable restore
#line 64 "D:\NET project\DKSM-Comestic\DSKMCosmetic\DSKMCosmetic\Areas\Admin\Views\AdminProducts\Index.cshtml"
                               Write(item.Category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 65 "D:\NET project\DKSM-Comestic\DSKMCosmetic\DSKMCosmetic\Areas\Admin\Views\AdminProducts\Index.cshtml"
                               Write(item.BrandName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 66 "D:\NET project\DKSM-Comestic\DSKMCosmetic\DSKMCosmetic\Areas\Admin\Views\AdminProducts\Index.cshtml"
                               Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 67 "D:\NET project\DKSM-Comestic\DSKMCosmetic\DSKMCosmetic\Areas\Admin\Views\AdminProducts\Index.cshtml"
                               Write(item.Price.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral(" vnđ</td>\r\n                                <td>");
#nullable restore
#line 68 "D:\NET project\DKSM-Comestic\DSKMCosmetic\DSKMCosmetic\Areas\Admin\Views\AdminProducts\Index.cshtml"
                               Write(item.Size);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
            WriteLiteral(@"                                <td>
                                    <div class=""d-flex align-items-center"">
                                        <div class=""badge badge-success badge-dot m-r-10""></div>
                                        <div>In Stock</div>
                                    </div>
                                </td>
                                <td class=""text-right"">
                                    <button class=""btn btn-icon btn-hover btn-sm btn-rounded pull-right"">
                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "12a625ba9326a6a1ee05226b9026490547025dad15193", async() => {
                WriteLiteral("<i class=\"anticon anticon-edit\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 78 "D:\NET project\DKSM-Comestic\DSKMCosmetic\DSKMCosmetic\Areas\Admin\Views\AdminProducts\Index.cshtml"
                                                                                                               WriteLiteral(item.ProductId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    </button>\r\n                                    <button class=\"btn btn-icon btn-hover btn-sm btn-rounded\">\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "12a625ba9326a6a1ee05226b9026490547025dad18069", async() => {
                WriteLiteral("<i class=\"anticon anticon-delete\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 81 "D:\NET project\DKSM-Comestic\DSKMCosmetic\DSKMCosmetic\Areas\Admin\Views\AdminProducts\Index.cshtml"
                                                                                                                 WriteLiteral(item.ProductId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    </button>\r\n                                </td>\r\n                            \r\n                            </tr>\r\n");
#nullable restore
#line 86 "D:\NET project\DKSM-Comestic\DSKMCosmetic\DSKMCosmetic\Areas\Admin\Views\AdminProducts\Index.cshtml"
                        }
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n            <div aria-label=\"Page navigation example\">\r\n                <ul class=\"pagination\">\r\n");
#nullable restore
#line 92 "D:\NET project\DKSM-Comestic\DSKMCosmetic\DSKMCosmetic\Areas\Admin\Views\AdminProducts\Index.cshtml"
                     if (Model.HasPreviousPage)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li class=\"page-item\">\r\n                            <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 4815, "\"", 4879, 1);
#nullable restore
#line 95 "D:\NET project\DKSM-Comestic\DSKMCosmetic\DSKMCosmetic\Areas\Admin\Views\AdminProducts\Index.cshtml"
WriteAttributeValue("", 4822, Url.Action("Index", new { page = Model.PageNumber - 1 }), 4822, 57, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-label=\"Previous\">\r\n                                <span aria-hidden=\"true\">&laquo;</span>\r\n                                <span class=\"sr-only\">Previous</span>\r\n                            </a>\r\n                        </li>\r\n");
#nullable restore
#line 100 "D:\NET project\DKSM-Comestic\DSKMCosmetic\DSKMCosmetic\Areas\Admin\Views\AdminProducts\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li class=\"page-item disabled\">\r\n                            <span class=\"page-link\" aria-hidden=\"true\">&laquo;</span>\r\n                            <span class=\"sr-only\">Previous</span>\r\n                        </li>\r\n");
#nullable restore
#line 107 "D:\NET project\DKSM-Comestic\DSKMCosmetic\DSKMCosmetic\Areas\Admin\Views\AdminProducts\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 109 "D:\NET project\DKSM-Comestic\DSKMCosmetic\DSKMCosmetic\Areas\Admin\Views\AdminProducts\Index.cshtml"
                     for (int i = 1; i <= Model.PageCount; i++)
                    {
                        if (i == Model.PageNumber)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li class=\"page-item active\" aria-current=\"page\">\r\n                                <span class=\"page-link\">");
#nullable restore
#line 114 "D:\NET project\DKSM-Comestic\DSKMCosmetic\DSKMCosmetic\Areas\Admin\Views\AdminProducts\Index.cshtml"
                                                   Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span class=\"sr-only\">(current)</span></span>\r\n                            </li>\r\n");
#nullable restore
#line 116 "D:\NET project\DKSM-Comestic\DSKMCosmetic\DSKMCosmetic\Areas\Admin\Views\AdminProducts\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li class=\"page-item\">\r\n                                <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 6028, "\"", 6073, 1);
#nullable restore
#line 120 "D:\NET project\DKSM-Comestic\DSKMCosmetic\DSKMCosmetic\Areas\Admin\Views\AdminProducts\Index.cshtml"
WriteAttributeValue("", 6035, Url.Action("Index", new { page = i }), 6035, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 120 "D:\NET project\DKSM-Comestic\DSKMCosmetic\DSKMCosmetic\Areas\Admin\Views\AdminProducts\Index.cshtml"
                                                                                              Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                            </li>\r\n");
#nullable restore
#line 122 "D:\NET project\DKSM-Comestic\DSKMCosmetic\DSKMCosmetic\Areas\Admin\Views\AdminProducts\Index.cshtml"
                        }
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 125 "D:\NET project\DKSM-Comestic\DSKMCosmetic\DSKMCosmetic\Areas\Admin\Views\AdminProducts\Index.cshtml"
                     if (Model.HasNextPage)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li class=\"page-item\">\r\n                            <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 6334, "\"", 6398, 1);
#nullable restore
#line 128 "D:\NET project\DKSM-Comestic\DSKMCosmetic\DSKMCosmetic\Areas\Admin\Views\AdminProducts\Index.cshtml"
WriteAttributeValue("", 6341, Url.Action("Index", new { page = Model.PageNumber + 1 }), 6341, 57, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-label=\"Next\">\r\n                                <span aria-hidden=\"true\">&raquo;</span>\r\n                                <span class=\"sr-only\">Next</span>\r\n                            </a>\r\n                        </li>\r\n");
#nullable restore
#line 133 "D:\NET project\DKSM-Comestic\DSKMCosmetic\DSKMCosmetic\Areas\Admin\Views\AdminProducts\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li class=\"page-item disabled\">\r\n                            <span class=\"page-link\" aria-hidden=\"true\">&raquo;</span>\r\n                            <span class=\"sr-only\">Next</span>\r\n                        </li>\r\n");
#nullable restore
#line 140 "D:\NET project\DKSM-Comestic\DSKMCosmetic\DSKMCosmetic\Areas\Admin\Views\AdminProducts\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </ul>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<script src=\"https://code.jquery.com/jquery-3.6.0.min.js\"></script>\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            // Listen for the search form submission
            $('#keyword').keyup(function () {

                // Send an Ajax request to the server with the search keyword
                $.ajax({
                    url: '/Admin/Search/FindProduct/',
                    dataType: ""html"",
                    type: ""POST"",
                    data: { keyword: $('#keyword').val() },
                    async: true,
                    success: function (result) {
                        // Replace the search results container with the new content
                        $(""#records_table"").html(result);
                    },
                    error: function () {
                        alert('An error occurred while processing your request.');
                    }
                });
            });
        });

    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PagedList.Core.IPagedList<DSKMCosmetic.Models.Product>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
