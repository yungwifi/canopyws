#pragma checksum "/Users/spencermerryman/canopyws/Views/PayFrequencies/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "90576128c37109f57a47d74f16c679ce8ebedbb0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PayFrequencies_Index), @"mvc.1.0.view", @"/Views/PayFrequencies/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/PayFrequencies/Index.cshtml", typeof(AspNetCore.Views_PayFrequencies_Index))]
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
#line 1 "/Users/spencermerryman/canopyws/Views/_ViewImports.cshtml"
using canopyws;

#line default
#line hidden
#line 2 "/Users/spencermerryman/canopyws/Views/_ViewImports.cshtml"
using canopyws.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90576128c37109f57a47d74f16c679ce8ebedbb0", @"/Views/PayFrequencies/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d6730c73aeb998eb55b7c540b7a4eb9bcfe9122", @"/Views/_ViewImports.cshtml")]
    public class Views_PayFrequencies_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<canopyws.Models.PayFrequencyModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "/Users/spencermerryman/canopyws/Views/PayFrequencies/Index.cshtml"
  
    ViewData["Title"] = "Pay Frequencies";

#line default
#line hidden
            BeginContext(93, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(98, 17, false);
#line 5 "/Users/spencermerryman/canopyws/Views/PayFrequencies/Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(115, 11, true);
            WriteLiteral("</h2>\r\n<h3>");
            EndContext();
            BeginContext(127, 19, false);
#line 6 "/Users/spencermerryman/canopyws/Views/PayFrequencies/Index.cshtml"
Write(ViewData["Message"]);

#line default
#line hidden
            EndContext();
            BeginContext(146, 50, true);
            WriteLiteral("</h3>\r\n<p>Your Pay Frequencies</p>\r\n<ul>\r\n    <li>");
            EndContext();
            BeginContext(197, 8, false);
#line 9 "/Users/spencermerryman/canopyws/Views/PayFrequencies/Index.cshtml"
   Write(Model.Id);

#line default
#line hidden
            EndContext();
            BeginContext(205, 15, true);
            WriteLiteral("</li>\r\n    <li>");
            EndContext();
            BeginContext(221, 10, false);
#line 10 "/Users/spencermerryman/canopyws/Views/PayFrequencies/Index.cshtml"
   Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(231, 15, true);
            WriteLiteral("</li>\r\n    <li>");
            EndContext();
            BeginContext(247, 17, false);
#line 11 "/Users/spencermerryman/canopyws/Views/PayFrequencies/Index.cshtml"
   Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(264, 15, true);
            WriteLiteral("</li>\r\n    <li>");
            EndContext();
            BeginContext(280, 12, false);
#line 12 "/Users/spencermerryman/canopyws/Views/PayFrequencies/Index.cshtml"
   Write(Model.GlCode);

#line default
#line hidden
            EndContext();
            BeginContext(292, 15, true);
            WriteLiteral("</li>\r\n    <li>");
            EndContext();
            BeginContext(308, 19, false);
#line 13 "/Users/spencermerryman/canopyws/Views/PayFrequencies/Index.cshtml"
   Write(Model.StandardHours);

#line default
#line hidden
            EndContext();
            BeginContext(327, 15, true);
            WriteLiteral("</li>\r\n    <li>");
            EndContext();
            BeginContext(343, 24, false);
#line 14 "/Users/spencermerryman/canopyws/Views/PayFrequencies/Index.cshtml"
   Write(Model.PayFrequencyFactor);

#line default
#line hidden
            EndContext();
            BeginContext(367, 15, true);
            WriteLiteral("</li>\r\n    <li>");
            EndContext();
            BeginContext(383, 14, false);
#line 15 "/Users/spencermerryman/canopyws/Views/PayFrequencies/Index.cshtml"
   Write(Model.LagValue);

#line default
#line hidden
            EndContext();
            BeginContext(397, 14, true);
            WriteLiteral("</li>\r\n</ul>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<canopyws.Models.PayFrequencyModel> Html { get; private set; }
    }
}
#pragma warning restore 1591