#pragma checksum "C:\WorkingDirectory\портфолио\EngineersOffice\EngineersOffice_Site\Views\Library\BendingCoefficients.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fb5f50303bee9e629d64cab33c7a5f3399e067ac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Library_BendingCoefficients), @"mvc.1.0.view", @"/Views/Library/BendingCoefficients.cshtml")]
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
#line 1 "C:\WorkingDirectory\портфолио\EngineersOffice\EngineersOffice_Site\Views\_ViewImports.cshtml"
using EngineersOffice_Site;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\WorkingDirectory\портфолио\EngineersOffice\EngineersOffice_Site\Views\_ViewImports.cshtml"
using EngineersOffice_Site.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb5f50303bee9e629d64cab33c7a5f3399e067ac", @"/Views/Library/BendingCoefficients.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d699a9cde417a4ffaf19cdf349e1bcded789a4dd", @"/Views/_ViewImports.cshtml")]
    public class Views_Library_BendingCoefficients : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EngineersOffice_Library.Models.BendingCoefficient>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\WorkingDirectory\портфолио\EngineersOffice\EngineersOffice_Site\Views\Library\BendingCoefficients.cshtml"
  
    Layout = "_LayoutLibrary";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Коэффициенты φ продольного изгиба центрально-сжатых элементов (Значения φ увеличены в 1000 раз)</h1>
<div class=""library-table"">
    <table border=""1"" class=""table"">
        <thead>
            <tr>
                <td rowspan=""2"">Гибкость λ</td>
                <td colspan=""14"">Коэффициенты φ для элементов с расчетным сопротивлением Ry, МПа</td>
            </tr>
            <tr>
                <td>200</td>
                <td>220</td>
                <td>240</td>
                <td>260</td>
                <td>280</td>
                <td>300</td>
                <td>320</td>
                <td>340</td>
                <td>360</td>
                <td>380</td>
                <td>400</td>
                <td>440</td>
                <td>480</td>
                <td>520</td>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 33 "C:\WorkingDirectory\портфолио\EngineersOffice\EngineersOffice_Site\Views\Library\BendingCoefficients.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td width=\"50\">");
#nullable restore
#line 36 "C:\WorkingDirectory\портфолио\EngineersOffice\EngineersOffice_Site\Views\Library\BendingCoefficients.cshtml"
                              Write(item.Flexibility);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td width=\"50\">");
#nullable restore
#line 37 "C:\WorkingDirectory\портфолио\EngineersOffice\EngineersOffice_Site\Views\Library\BendingCoefficients.cshtml"
                              Write(item.R_200);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td width=\"50\">");
#nullable restore
#line 38 "C:\WorkingDirectory\портфолио\EngineersOffice\EngineersOffice_Site\Views\Library\BendingCoefficients.cshtml"
                              Write(item.R_220);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td width=\"50\">");
#nullable restore
#line 39 "C:\WorkingDirectory\портфолио\EngineersOffice\EngineersOffice_Site\Views\Library\BendingCoefficients.cshtml"
                              Write(item.R_240);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td width=\"50\">");
#nullable restore
#line 40 "C:\WorkingDirectory\портфолио\EngineersOffice\EngineersOffice_Site\Views\Library\BendingCoefficients.cshtml"
                              Write(item.R_260);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td width=\"50\">");
#nullable restore
#line 41 "C:\WorkingDirectory\портфолио\EngineersOffice\EngineersOffice_Site\Views\Library\BendingCoefficients.cshtml"
                              Write(item.R_280);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td width=\"50\">");
#nullable restore
#line 42 "C:\WorkingDirectory\портфолио\EngineersOffice\EngineersOffice_Site\Views\Library\BendingCoefficients.cshtml"
                              Write(item.R_300);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td width=\"50\">");
#nullable restore
#line 43 "C:\WorkingDirectory\портфолио\EngineersOffice\EngineersOffice_Site\Views\Library\BendingCoefficients.cshtml"
                              Write(item.R_320);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td width=\"50\">");
#nullable restore
#line 44 "C:\WorkingDirectory\портфолио\EngineersOffice\EngineersOffice_Site\Views\Library\BendingCoefficients.cshtml"
                              Write(item.R_340);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td width=\"50\">");
#nullable restore
#line 45 "C:\WorkingDirectory\портфолио\EngineersOffice\EngineersOffice_Site\Views\Library\BendingCoefficients.cshtml"
                              Write(item.R_360);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td width=\"50\">");
#nullable restore
#line 46 "C:\WorkingDirectory\портфолио\EngineersOffice\EngineersOffice_Site\Views\Library\BendingCoefficients.cshtml"
                              Write(item.R_380);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td width=\"50\">");
#nullable restore
#line 47 "C:\WorkingDirectory\портфолио\EngineersOffice\EngineersOffice_Site\Views\Library\BendingCoefficients.cshtml"
                              Write(item.R_400);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td width=\"50\">");
#nullable restore
#line 48 "C:\WorkingDirectory\портфолио\EngineersOffice\EngineersOffice_Site\Views\Library\BendingCoefficients.cshtml"
                              Write(item.R_440);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td width=\"50\">");
#nullable restore
#line 49 "C:\WorkingDirectory\портфолио\EngineersOffice\EngineersOffice_Site\Views\Library\BendingCoefficients.cshtml"
                              Write(item.R_480);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td width=\"50\">");
#nullable restore
#line 50 "C:\WorkingDirectory\портфолио\EngineersOffice\EngineersOffice_Site\Views\Library\BendingCoefficients.cshtml"
                              Write(item.R_520);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 52 "C:\WorkingDirectory\портфолио\EngineersOffice\EngineersOffice_Site\Views\Library\BendingCoefficients.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EngineersOffice_Library.Models.BendingCoefficient>> Html { get; private set; }
    }
}
#pragma warning restore 1591
