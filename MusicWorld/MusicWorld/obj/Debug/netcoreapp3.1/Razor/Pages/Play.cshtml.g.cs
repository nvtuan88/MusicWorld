#pragma checksum "C:\Users\ADMIN\source\repos\MusicWorld\MusicWorld\MusicWorld\MusicWorld\Pages\Play.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be9e40f2f665a729aed0cd0568f594df8e72bcda"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Play), @"mvc.1.0.razor-page", @"/Pages/Play.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be9e40f2f665a729aed0cd0568f594df8e72bcda", @"/Pages/Play.cshtml")]
    public class Pages_Play : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h2>Your Play List</h2>\r\n<table class=\"table table-bordered table-striped\">\r\n    <thead>\r\n        <tr>\r\n            <th>Name</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 12 "C:\Users\ADMIN\source\repos\MusicWorld\MusicWorld\MusicWorld\MusicWorld\Pages\Play.cshtml"
         foreach (var line in Model.Playlist.Lines)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td class=\"text-center\">");
#nullable restore
#line 15 "C:\Users\ADMIN\source\repos\MusicWorld\MusicWorld\MusicWorld\MusicWorld\Pages\Play.cshtml"
                               Write(line.Musics.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class=\"text-center\">");
#nullable restore
#line 16 "C:\Users\ADMIN\source\repos\MusicWorld\MusicWorld\MusicWorld\MusicWorld\Pages\Play.cshtml"
                               Write(line.Musics.Url);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 18 "C:\Users\ADMIN\source\repos\MusicWorld\MusicWorld\MusicWorld\MusicWorld\Pages\Play.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n<div class=\"text-center\">\r\n    <a class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=\"", 521, "\"", 544, 1);
#nullable restore
#line 22 "C:\Users\ADMIN\source\repos\MusicWorld\MusicWorld\MusicWorld\MusicWorld\Pages\Play.cshtml"
WriteAttributeValue("", 528, Model.ReturnUrl, 528, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Continue shopping</a>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MusicWorld.Pages.PlayModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MusicWorld.Pages.PlayModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MusicWorld.Pages.PlayModel>)PageContext?.ViewData;
        public MusicWorld.Pages.PlayModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
