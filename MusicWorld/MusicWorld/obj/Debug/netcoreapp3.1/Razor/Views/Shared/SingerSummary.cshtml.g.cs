#pragma checksum "D:\Work\xampp\htdocs\MusicWorld\MusicWorld\MusicWorld\MusicWorld\Views\Shared\SingerSummary.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "42614b0acda96ed247a54cab3fcac162831af70b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_SingerSummary), @"mvc.1.0.view", @"/Views/Shared/SingerSummary.cshtml")]
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
#line 1 "D:\Work\xampp\htdocs\MusicWorld\MusicWorld\MusicWorld\MusicWorld\Views\_ViewImports.cshtml"
using MusicWorld;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Work\xampp\htdocs\MusicWorld\MusicWorld\MusicWorld\MusicWorld\Views\_ViewImports.cshtml"
using MusicWorld.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Work\xampp\htdocs\MusicWorld\MusicWorld\MusicWorld\MusicWorld\Views\_ViewImports.cshtml"
using MusicWorld.Models.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Work\xampp\htdocs\MusicWorld\MusicWorld\MusicWorld\MusicWorld\Views\_ViewImports.cshtml"
using MusicWorld.Infrastructure;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42614b0acda96ed247a54cab3fcac162831af70b", @"/Views/Shared/SingerSummary.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d335e248654aae28421ffac8070cec39432dfc98", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_SingerSummary : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Singer>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"card\">\r\n    <div class=\"card-body\">\r\n        <h5 class=\"card-title\">");
#nullable restore
#line 4 "D:\Work\xampp\htdocs\MusicWorld\MusicWorld\MusicWorld\MusicWorld\Views\Shared\SingerSummary.cshtml"
                          Write(Model.SingerName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Singer> Html { get; private set; }
    }
}
#pragma warning restore 1591
