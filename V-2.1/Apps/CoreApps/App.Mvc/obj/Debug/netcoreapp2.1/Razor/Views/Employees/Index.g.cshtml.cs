#pragma checksum "D:\GIT Repos\ASP.NET-Core-2.1\Apps\Api-Mvc-Razor-RepositoryPattern\CoreApps\App.Mvc\Views\Employees\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ecabf38b6f0adc05375a40e6673db514bd5ea2bd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employees_Index), @"mvc.1.0.view", @"/Views/Employees/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Employees/Index.cshtml", typeof(AspNetCore.Views_Employees_Index))]
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
#line 1 "D:\GIT Repos\ASP.NET-Core-2.1\Apps\Api-Mvc-Razor-RepositoryPattern\CoreApps\App.Mvc\Views\_ViewImports.cshtml"
using App.Mvc;

#line default
#line hidden
#line 2 "D:\GIT Repos\ASP.NET-Core-2.1\Apps\Api-Mvc-Razor-RepositoryPattern\CoreApps\App.Mvc\Views\_ViewImports.cshtml"
using App.Mvc.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ecabf38b6f0adc05375a40e6673db514bd5ea2bd", @"/Views/Employees/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f913fbab0cf1e758040d2318d78478bdf7b6ce1d", @"/Views/_ViewImports.cshtml")]
    public class Views_Employees_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<App.Mvc.Models.Employee>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddOrEdit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(45, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\GIT Repos\ASP.NET-Core-2.1\Apps\Api-Mvc-Razor-RepositoryPattern\CoreApps\App.Mvc\Views\Employees\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(88, 29, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(117, 105, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "37bf2c04057a405f83f3968b35eec0f9", async() => {
                BeginContext(167, 51, true);
                WriteLiteral("<i class=\"glyphicon glyphicon-plus\"></i> Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(222, 121, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table table-bordered table-striped\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(344, 40, false);
#line 16 "D:\GIT Repos\ASP.NET-Core-2.1\Apps\Api-Mvc-Razor-RepositoryPattern\CoreApps\App.Mvc\Views\Employees\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(384, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(440, 44, false);
#line 19 "D:\GIT Repos\ASP.NET-Core-2.1\Apps\Api-Mvc-Razor-RepositoryPattern\CoreApps\App.Mvc\Views\Employees\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Position));

#line default
#line hidden
            EndContext();
            BeginContext(484, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(540, 39, false);
#line 22 "D:\GIT Repos\ASP.NET-Core-2.1\Apps\Api-Mvc-Razor-RepositoryPattern\CoreApps\App.Mvc\Views\Employees\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Age));

#line default
#line hidden
            EndContext();
            BeginContext(579, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(635, 42, false);
#line 25 "D:\GIT Repos\ASP.NET-Core-2.1\Apps\Api-Mvc-Razor-RepositoryPattern\CoreApps\App.Mvc\Views\Employees\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Salary));

#line default
#line hidden
            EndContext();
            BeginContext(677, 93, true);
            WriteLiteral("\r\n            </th>\r\n            <th>Actions</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 31 "D:\GIT Repos\ASP.NET-Core-2.1\Apps\Api-Mvc-Razor-RepositoryPattern\CoreApps\App.Mvc\Views\Employees\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(819, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(868, 39, false);
#line 35 "D:\GIT Repos\ASP.NET-Core-2.1\Apps\Api-Mvc-Razor-RepositoryPattern\CoreApps\App.Mvc\Views\Employees\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(907, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(963, 43, false);
#line 38 "D:\GIT Repos\ASP.NET-Core-2.1\Apps\Api-Mvc-Razor-RepositoryPattern\CoreApps\App.Mvc\Views\Employees\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Position));

#line default
#line hidden
            EndContext();
            BeginContext(1006, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1062, 38, false);
#line 41 "D:\GIT Repos\ASP.NET-Core-2.1\Apps\Api-Mvc-Razor-RepositoryPattern\CoreApps\App.Mvc\Views\Employees\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Age));

#line default
#line hidden
            EndContext();
            BeginContext(1100, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1156, 41, false);
#line 44 "D:\GIT Repos\ASP.NET-Core-2.1\Apps\Api-Mvc-Razor-RepositoryPattern\CoreApps\App.Mvc\Views\Employees\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Salary));

#line default
#line hidden
            EndContext();
            BeginContext(1197, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1252, 126, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0ca76b36762d4f97a064b0ea291b6998", async() => {
                BeginContext(1326, 48, true);
                WriteLiteral("<i class=\"glyphicon glyphicon-pencil\"></i>  Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 47 "D:\GIT Repos\ASP.NET-Core-2.1\Apps\Api-Mvc-Razor-RepositoryPattern\CoreApps\App.Mvc\Views\Employees\Index.cshtml"
                                            WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1378, 20, true);
            WriteLiteral("\r\n                <a");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1398, "\"", 1424, 3);
            WriteAttributeValue("", 1408, "Delete(", 1408, 7, true);
#line 48 "D:\GIT Repos\ASP.NET-Core-2.1\Apps\Api-Mvc-Razor-RepositoryPattern\CoreApps\App.Mvc\Views\Employees\Index.cshtml"
WriteAttributeValue("", 1415, item.Id, 1415, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 1423, ")", 1423, 1, true);
            EndWriteAttribute();
            BeginContext(1425, 114, true);
            WriteLiteral(" class=\"btn btn-default\"><i class=\"glyphicon glyphicon-trash\"></i>  Delete</a>\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 51 "D:\GIT Repos\ASP.NET-Core-2.1\Apps\Api-Mvc-Razor-RepositoryPattern\CoreApps\App.Mvc\Views\Employees\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1550, 26, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(1593, 93, true);
                WriteLiteral("\r\n    <script type=\"text/javascript\">\r\n        $(function(){\r\n            var alertifyMsg = \'");
                EndContext();
                BeginContext(1688, 23, false);
#line 58 "D:\GIT Repos\ASP.NET-Core-2.1\Apps\Api-Mvc-Razor-RepositoryPattern\CoreApps\App.Mvc\Views\Employees\Index.cshtml"
                           Write(TempData["AlertifyMsg"]);

#line default
#line hidden
                EndContext();
                BeginContext(1712, 375, true);
                WriteLiteral(@"';
            if(alertifyMsg!=="""")
            {
                alertify.notify(alertifyMsg, 'success', 5, function () { console.log('dismissed'); });
            }
        });

        function Delete(id) {
            alertify.confirm('Please confirm:', 'Are you sure to delete this employee?',
            function () {
                window.location.href = '");
                EndContext();
                BeginContext(2088, 32, false);
#line 68 "D:\GIT Repos\ASP.NET-Core-2.1\Apps\Api-Mvc-Razor-RepositoryPattern\CoreApps\App.Mvc\Views\Employees\Index.cshtml"
                                   Write(Url.Action("Delete","Employees"));

#line default
#line hidden
                EndContext();
                BeginContext(2120, 58, true);
                WriteLiteral("/\' + id;\r\n            },null);\r\n        }\r\n    </script>\r\n");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<App.Mvc.Models.Employee>> Html { get; private set; }
    }
}
#pragma warning restore 1591
