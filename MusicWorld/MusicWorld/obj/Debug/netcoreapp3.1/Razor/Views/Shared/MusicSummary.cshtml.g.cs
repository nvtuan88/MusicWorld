#pragma checksum "F:\GithubRepos\MusicWorld\MusicWorld\MusicWorld\Views\Shared\MusicSummary.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e4cbfd911b056da4b14873520ae9914ea1b3c428"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_MusicSummary), @"mvc.1.0.view", @"/Views/Shared/MusicSummary.cshtml")]
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
#line 1 "F:\GithubRepos\MusicWorld\MusicWorld\MusicWorld\Views\_ViewImports.cshtml"
using MusicWorld;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\GithubRepos\MusicWorld\MusicWorld\MusicWorld\Views\_ViewImports.cshtml"
using MusicWorld.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\GithubRepos\MusicWorld\MusicWorld\MusicWorld\Views\_ViewImports.cshtml"
using MusicWorld.Models.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4cbfd911b056da4b14873520ae9914ea1b3c428", @"/Views/Shared/MusicSummary.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0e1e62c87bd61d3bfd32c9768d16615464af90b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_MusicSummary : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Musics>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"card\">\r\n");
            WriteLiteral("    <div class=\"card-body\">\r\n        <h5 class=\"card-title\">");
#nullable restore
#line 5 "F:\GithubRepos\MusicWorld\MusicWorld\MusicWorld\Views\Shared\MusicSummary.cshtml"
                          Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n        <h5 class=\"card-title\">Author: ");
#nullable restore
#line 6 "F:\GithubRepos\MusicWorld\MusicWorld\MusicWorld\Views\Shared\MusicSummary.cshtml"
                                  Write(Model.Author.AuthorName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n        <h5 class=\"card-title\">Singer: ");
#nullable restore
#line 7 "F:\GithubRepos\MusicWorld\MusicWorld\MusicWorld\Views\Shared\MusicSummary.cshtml"
                                  Write(Model.Singer.SingerName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n        <h5 class=\"card-title\">Album:  ");
#nullable restore
#line 8 "F:\GithubRepos\MusicWorld\MusicWorld\MusicWorld\Views\Shared\MusicSummary.cshtml"
                                  Write(Model.Album.AlbumName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Musics> Html { get; private set; }
    }
}
#pragma warning restore 1591