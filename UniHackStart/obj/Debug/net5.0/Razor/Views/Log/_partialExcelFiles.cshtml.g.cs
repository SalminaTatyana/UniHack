#pragma checksum "C:\Институт\Uni\UniHackStart\Views\Log\_partialExcelFiles.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1b918e864c9a004457c9d5bae6a760f51cfd876d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Log__partialExcelFiles), @"mvc.1.0.view", @"/Views/Log/_partialExcelFiles.cshtml")]
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
#line 1 "C:\Институт\Uni\UniHackStart\Views\_ViewImports.cshtml"
using UniHackStart;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Институт\Uni\UniHackStart\Views\_ViewImports.cshtml"
using UniHackStart.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Институт\Uni\UniHackStart\Views\Log\_partialExcelFiles.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b918e864c9a004457c9d5bae6a760f51cfd876d", @"/Views/Log/_partialExcelFiles.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df0feea0a0b029f6fcb285c9eea66f28206a4019", @"/Views/_ViewImports.cshtml")]
    public class Views_Log__partialExcelFiles : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<UniHackStart.Models.TimeTableReestersModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"meter-devices-table-string\">\r\n\r\n");
#nullable restore
#line 5 "C:\Институт\Uni\UniHackStart\Views\Log\_partialExcelFiles.cshtml"
     foreach (var reester in @Model)
    {
        

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""meter-devices-table-string"">
            <div class=""meter-devices-check"">
                <label class=""main-checkbox"">
                    <input name=""isCurrent"" class=""visually-hidden dispatchingFlag"" data-device-id="""" type=""radio"" value=""true""");
            BeginWriteAttribute("checked", " checked=\"", 463, "\"", 507, 1);
#nullable restore
#line 11 "C:\Институт\Uni\UniHackStart\Views\Log\_partialExcelFiles.cshtml"
WriteAttributeValue("", 473, reester.IsCurrent? true : false, 473, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                    <span class=""main-checkbox-text left""></span>
                </label>
            </div>
            <div class=""meter-devices-addres"">
                <span class=""meter-devices-date-label"">Файл</span>
                <span class=""meter-devices-addres-name""> ");
#nullable restore
#line 17 "C:\Институт\Uni\UniHackStart\Views\Log\_partialExcelFiles.cshtml"
                                                    Write(reester.FileName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </div>\r\n\r\n            <div class=\"meter-devices-date\">\r\n                <span class=\"meter-devices-date-label\">Дата создания</span>\r\n                <span class=\"meter-devices-date-item\"> ");
#nullable restore
#line 22 "C:\Институт\Uni\UniHackStart\Views\Log\_partialExcelFiles.cshtml"
                                                  Write(reester.Created.ToString("dd.MM.yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n\r\n            </div>\r\n            <div class=\"meter-devices-date\">\r\n                <span class=\"meter-devices-date-label\">Загрузил</span>\r\n                <span class=\"meter-devices-date-item\"> ");
#nullable restore
#line 27 "C:\Институт\Uni\UniHackStart\Views\Log\_partialExcelFiles.cshtml"
                                                  Write(reester.Login);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
            </div>

            <button class=""modal-close"" type=""button"">
                <svg xmlns=""http://www.w3.org/2000/svg"" width=""21.213"" height=""21.213"" viewbox=""0 0 21.213 21.213""><g transform=""translate(10.607) rotate(45)""><rect class=""a"" width=""15"" height=""15""></rect><path class=""b"" d=""M5.909,1.733a1.626,1.626,0,0,1,3.252,0V5.909h4.176a1.626,1.626,0,1,1,0,3.252H9.161v4.176a1.626,1.626,0,1,1-3.252,0V9.161H1.733a1.626,1.626,0,0,1,0-3.252H5.909Z"" transform=""translate(-0.035 -0.035)""></path></g></svg>
            </button>
        </div>
");
#nullable restore
#line 34 "C:\Институт\Uni\UniHackStart\Views\Log\_partialExcelFiles.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<UniHackStart.Models.TimeTableReestersModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
