#pragma checksum "C:\Users\luizg\source\repos\NetflixClone\NetflixClone\Views\Home\_MovieList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c250b26c5e5b4e5d9f26bfc802708c2b058e597"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home__MovieList), @"mvc.1.0.view", @"/Views/Home/_MovieList.cshtml")]
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
#line 1 "C:\Users\luizg\source\repos\NetflixClone\NetflixClone\Views\_ViewImports.cshtml"
using NetflixClone;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\luizg\source\repos\NetflixClone\NetflixClone\Views\_ViewImports.cshtml"
using NetflixClone.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c250b26c5e5b4e5d9f26bfc802708c2b058e597", @"/Views/Home/_MovieList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1c46bda70dbb66a68accd5ee5cfd2e5b5a27276", @"/Views/_ViewImports.cshtml")]
    public class Views_Home__MovieList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NetflixClone.Models.Movie>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\luizg\source\repos\NetflixClone\NetflixClone\Views\Home\_MovieList.cshtml"
 if(Model.results.Count > 0)
{
    
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\luizg\source\repos\NetflixClone\NetflixClone\Views\Home\_MovieList.cshtml"
         foreach(var title in Model.results)
        {
            var src = "https://image.tmdb.org/t/p/w300" + title.poster_path;

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"movieRow--item\">\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 272, "\"", 282, 1);
#nullable restore
#line 10 "C:\Users\luizg\source\repos\NetflixClone\NetflixClone\Views\Home\_MovieList.cshtml"
WriteAttributeValue("", 278, src, 278, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 283, "\"", 309, 1);
#nullable restore
#line 10 "C:\Users\luizg\source\repos\NetflixClone\NetflixClone\Views\Home\_MovieList.cshtml"
WriteAttributeValue("", 289, title.original_name, 289, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </div>\r\n");
#nullable restore
#line 12 "C:\Users\luizg\source\repos\NetflixClone\NetflixClone\Views\Home\_MovieList.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\luizg\source\repos\NetflixClone\NetflixClone\Views\Home\_MovieList.cshtml"
         
    
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NetflixClone.Models.Movie> Html { get; private set; }
    }
}
#pragma warning restore 1591
