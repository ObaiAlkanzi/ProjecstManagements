#pragma checksum "C:\Users\Dell\source\repos\ProjectsManagements\Alkanzi\Views\Home\Users.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e102f77086f3d21ea1d74a8d45ea38aed5cb6dfb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Users), @"mvc.1.0.view", @"/Views/Home/Users.cshtml")]
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
#line 1 "C:\Users\Dell\source\repos\ProjectsManagements\Alkanzi\Views\_ViewImports.cshtml"
using Alkanzi;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Dell\source\repos\ProjectsManagements\Alkanzi\Views\_ViewImports.cshtml"
using Alkanzi.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Dell\source\repos\ProjectsManagements\Alkanzi\Views\_ViewImports.cshtml"
using Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e102f77086f3d21ea1d74a8d45ea38aed5cb6dfb", @"/Views/Home/Users.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4017d887375ffe168d761aa89b126f074d023cd0", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Users : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Dell\source\repos\ProjectsManagements\Alkanzi\Views\Home\Users.cshtml"
  
    Layout = "";
    ViewBag.Title = "Users";    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""row"">
    <div class=""col-12"">
        <table class=""table table-responsive-lg table-bordered"">
            <thead>
                <tr>
                    <td>name</td>
                    <td>Email</td>
                    <td class=""text-center"">State</td>
                </tr>
            </thead>
            <tbody ng-repeat=""user in UsersCtrl.users"">
                 <tr><td>{{user.name}}</td><td>{{user.email}}</td><td ng-class=""UsersCtrl.setClass(user.accountState)"">{{user.accountState | userState}}</td></tr>
            </tbody>
        </table>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591