#pragma checksum "D:\Hackaton\UniHackStart\Views\Home\_partialStudentDeadline.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b27d0c7163f1b72774b007ef48fb2acbbab11eaf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home__partialStudentDeadline), @"mvc.1.0.view", @"/Views/Home/_partialStudentDeadline.cshtml")]
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
#line 1 "D:\Hackaton\UniHackStart\Views\_ViewImports.cshtml"
using UniHackStart;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Hackaton\UniHackStart\Views\_ViewImports.cshtml"
using UniHackStart.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b27d0c7163f1b72774b007ef48fb2acbbab11eaf", @"/Views/Home/_partialStudentDeadline.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df0feea0a0b029f6fcb285c9eea66f28206a4019", @"/Views/_ViewImports.cshtml")]
    public class Views_Home__partialStudentDeadline : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h3 class=\"block-title\">Задолжности</h3>\r\n<div class=\"timetable slider\">\r\n");
#nullable restore
#line 3 "D:\Hackaton\UniHackStart\Views\Home\_partialStudentDeadline.cshtml"
     for (int i = 0; i < 3; i++)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card timetable-card\">\r\n            <div class=\"timetable-date\">Предмет ");
#nullable restore
#line 6 "D:\Hackaton\UniHackStart\Views\Home\_partialStudentDeadline.cshtml"
                                            Write(i+1);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"  </div>
            <div class=""timetable-lesson-wrapper"">
                <div class=""timetable-lesson-item"">
                    <div class=""timetable-lesson-time"">Время</div>
                    <div class=""timetable-lesson-text"">Предмет</div>
                </div>
                <div class=""timetable-lesson-item"">
                    <div class=""timetable-lesson-time"">Время</div>
                    <div class=""timetable-lesson-text"">Предмет</div>
                </div>
                <div class=""timetable-lesson-item"">
                    <div class=""timetable-lesson-time"">Время</div>
                    <div class=""timetable-lesson-text"">Предмет</div>
                </div>
                
            </div>
        </div>
");
#nullable restore
#line 23 "D:\Hackaton\UniHackStart\Views\Home\_partialStudentDeadline.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
