#pragma checksum "/Users/Guest/Desktop/Places.Solutions/Places/Views/Items/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ae2399864e9ca2535a0f329a8acd607ed1bee1ec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Items_Index), @"mvc.1.0.view", @"/Views/Items/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Items/Index.cshtml", typeof(AspNetCore.Views_Items_Index))]
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
#line 1 "/Users/Guest/Desktop/Places.Solutions/Places/Views/Items/Index.cshtml"
using Places.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae2399864e9ca2535a0f329a8acd607ed1bee1ec", @"/Views/Items/Index.cshtml")]
    public class Views_Items_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(22, 29, true);
            WriteLiteral("\n<h1>Places we\'ve been:</h1>\n");
            EndContext();
#line 4 "/Users/Guest/Desktop/Places.Solutions/Places/Views/Items/Index.cshtml"
 if (Model.Count == 0)
{

#line default
#line hidden
            BeginContext(76, 41, true);
            WriteLiteral("  <p>There are no items in the list.</p>\n");
            EndContext();
#line 7 "/Users/Guest/Desktop/Places.Solutions/Places/Views/Items/Index.cshtml"
}

#line default
#line hidden
            BeginContext(119, 5, true);
            WriteLiteral("<ul>\n");
            EndContext();
#line 9 "/Users/Guest/Desktop/Places.Solutions/Places/Views/Items/Index.cshtml"
   foreach (Item item in Model)
  {

#line default
#line hidden
            BeginContext(160, 10, true);
            WriteLiteral("    <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 170, "\'", 192, 2);
            WriteAttributeValue("", 177, "/items/", 177, 7, true);
#line 11 "/Users/Guest/Desktop/Places.Solutions/Places/Views/Items/Index.cshtml"
WriteAttributeValue("", 184, item.Id, 184, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(193, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(195, 16, false);
#line 11 "/Users/Guest/Desktop/Places.Solutions/Places/Views/Items/Index.cshtml"
                             Write(item.Description);

#line default
#line hidden
            EndContext();
            BeginContext(211, 10, true);
            WriteLiteral("</a></li>\n");
            EndContext();
#line 12 "/Users/Guest/Desktop/Places.Solutions/Places/Views/Items/Index.cshtml"
  }

#line default
#line hidden
            BeginContext(225, 163, true);
            WriteLiteral("</ul>\n\n<a href=\"/items/new\">Add a new item.</a>\n\n<form action=\"/items/delete\" method=\"post\">\n  <button type=\"submit\" name=\"button\">Clear All Items</button>\n</form>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591