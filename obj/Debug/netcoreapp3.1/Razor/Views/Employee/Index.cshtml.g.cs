#pragma checksum "C:\Users\MarcinCieloch\Documents\Employee\Views\Employee\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c81f35faba5d64e0827227053b87e4a99f433821"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Index), @"mvc.1.0.view", @"/Views/Employee/Index.cshtml")]
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
#line 1 "C:\Users\MarcinCieloch\Documents\Employee\Views\_ViewImports.cshtml"
using Pracownicy;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\MarcinCieloch\Documents\Employee\Views\_ViewImports.cshtml"
using Pracownicy.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c81f35faba5d64e0827227053b87e4a99f433821", @"/Views/Employee/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a8e8b6293d62b8280f6f6720af3cf1189b0e370", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Pracownicy.Models.Employee>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\MarcinCieloch\Documents\Employee\Views\Employee\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 class=\"display-4\">Dashboard</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c81f35faba5d64e0827227053b87e4a99f4338213658", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</p>
<div class=""card shadow mb-4"">
    <div class=""card-header py-3"">
        <h6 class=""m-0 font-weight-bold text-primary"">Lista zadań</h6>
    </div>
    <div class=""card-body"">
        <div class=""table-responsive"">
            <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""0"">
                <thead>
                    <tr>
                        <th>
                            ");
#nullable restore
#line 22 "C:\Users\MarcinCieloch\Documents\Employee\Views\Employee\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 25 "C:\Users\MarcinCieloch\Documents\Employee\Views\Employee\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.EmpCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 28 "C:\Users\MarcinCieloch\Documents\Employee\Views\Employee\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.Position));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 31 "C:\Users\MarcinCieloch\Documents\Employee\Views\Employee\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.OfficeLocation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th></th>\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
#nullable restore
#line 37 "C:\Users\MarcinCieloch\Documents\Employee\Views\Employee\Index.cshtml"
                     foreach (var item in ViewBag.Employees)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>\r\n");
            WriteLiteral("                                ");
#nullable restore
#line 42 "C:\Users\MarcinCieloch\Documents\Employee\Views\Employee\Index.cshtml"
                           Write(item.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n");
            WriteLiteral("                                ");
#nullable restore
#line 46 "C:\Users\MarcinCieloch\Documents\Employee\Views\Employee\Index.cshtml"
                           Write(item.EmpCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n");
            WriteLiteral("                                ");
#nullable restore
#line 50 "C:\Users\MarcinCieloch\Documents\Employee\Views\Employee\Index.cshtml"
                           Write(item.Position);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n");
            WriteLiteral("                                ");
#nullable restore
#line 54 "C:\Users\MarcinCieloch\Documents\Employee\Views\Employee\Index.cshtml"
                           Write(item.OfficeLocation);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 2204, "\"", 2272, 1);
#nullable restore
#line 57 "C:\Users\MarcinCieloch\Documents\Employee\Views\Employee\Index.cshtml"
WriteAttributeValue("", 2211, Url.Action("Edit", "Employee", new { id = item.EmployeeId }), 2211, 61, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn  btn-circle\">\r\n                                    <i class=\"fas fa-pen\"></i>\r\n                                </a>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 2436, "\"", 2507, 1);
#nullable restore
#line 60 "C:\Users\MarcinCieloch\Documents\Employee\Views\Employee\Index.cshtml"
WriteAttributeValue("", 2443, Url.Action("Details", "Employee", new { id = item.EmployeeId }), 2443, 64, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn  btn-circle\">\r\n                                    <i class=\"fas fa-info\"></i>\r\n                                </a>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 2672, "\"", 2742, 1);
#nullable restore
#line 63 "C:\Users\MarcinCieloch\Documents\Employee\Views\Employee\Index.cshtml"
WriteAttributeValue("", 2679, Url.Action("Delete", "Employee", new { id = item.EmployeeId }), 2679, 63, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn  btn-circle\">\r\n                                    <i class=\"fas fa-trash\"></i>\r\n                                </a>\r\n                                \r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 69 "C:\Users\MarcinCieloch\Documents\Employee\Views\Employee\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </tbody>
            </table>
        </div>
    </div>
</div>
<div class=""row"">



    <!--Pending Requests Card Example-->
    <div class=""col-xl-3 col-md-6 mb-4"">
        <div class=""card border-left-success shadow h-100 py-2"">
            <div class=""card-body"">
                <div class=""row no-gutters align-items-center"">
                    <div class=""col mr-2"">
                        <div class=""text-xs font-weight-bold text-succcess text-uppercase mb-1"">Zrealizowane</div>
                        <div class=""h5 mb-0 font-weight-bold text-gray-800"">");
#nullable restore
#line 86 "C:\Users\MarcinCieloch\Documents\Employee\Views\Employee\Index.cshtml"
                                                                       Write(ViewBag.EmployeeNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                    </div>
                    <div class=""col-auto"">
                        <i class=""fas fa-tasks fa-2x text-succcess""></i>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Pracownicy.Models.Employee>> Html { get; private set; }
    }
}
#pragma warning restore 1591
