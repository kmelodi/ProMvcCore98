#pragma checksum "C:\Users\Alireza\source\repos\Session15.ViewAndHelpers\Session15.ViewAndHelpers\Views\Home\_CommentList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "db93c767dbc935d238f2962fd4af9ec4bb833f26"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home__CommentList), @"mvc.1.0.view", @"/Views/Home/_CommentList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/_CommentList.cshtml", typeof(AspNetCore.Views_Home__CommentList))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db93c767dbc935d238f2962fd4af9ec4bb833f26", @"/Views/Home/_CommentList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cce8d1bbe8d975ac20f65c22d41aee78ff83b502", @"/Views/_ViewImports.cshtml")]
    public class Views_Home__CommentList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Session15.ViewAndHelpers.Models.Comment>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(54, 6, true);
            WriteLiteral("<ul>\r\n");
            EndContext();
#line 3 "C:\Users\Alireza\source\repos\Session15.ViewAndHelpers\Session15.ViewAndHelpers\Views\Home\_CommentList.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(101, 12, true);
            WriteLiteral("        <li>");
            EndContext();
            BeginContext(114, 16, false);
#line 5 "C:\Users\Alireza\source\repos\Session15.ViewAndHelpers\Session15.ViewAndHelpers\Views\Home\_CommentList.cshtml"
       Write(item.Description);

#line default
#line hidden
            EndContext();
            BeginContext(130, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 6 "C:\Users\Alireza\source\repos\Session15.ViewAndHelpers\Session15.ViewAndHelpers\Views\Home\_CommentList.cshtml"

    }

#line default
#line hidden
            BeginContext(146, 5, true);
            WriteLiteral("</ul>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Session15.ViewAndHelpers.Models.Comment>> Html { get; private set; }
    }
}
#pragma warning restore 1591
