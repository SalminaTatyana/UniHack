#pragma checksum "D:\Hackaton\UniHackStart\Views\Timetable\_partialTimetable.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8001ccad7b47df4c1343bb8ff6e1514f53538040"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Timetable__partialTimetable), @"mvc.1.0.view", @"/Views/Timetable/_partialTimetable.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8001ccad7b47df4c1343bb8ff6e1514f53538040", @"/Views/Timetable/_partialTimetable.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df0feea0a0b029f6fcb285c9eea66f28206a4019", @"/Views/_ViewImports.cshtml")]
    public class Views_Timetable__partialTimetable : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<UniHackStart.Models.StudentTimeTableModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h3 class=\"block-title\">Расписание</h3>\r\n\r\n<div class=\"timetable slider\">\r\n");
#nullable restore
#line 5 "D:\Hackaton\UniHackStart\Views\Timetable\_partialTimetable.cshtml"
     foreach (var day in @Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card timetable-card\">\r\n            <div class=\"timetable-date\"> ");
#nullable restore
#line 8 "D:\Hackaton\UniHackStart\Views\Timetable\_partialTimetable.cshtml"
                                    Write(day.DayOfWeek);

#line default
#line hidden
#nullable disable
            WriteLiteral("  </div>\r\n");
#nullable restore
#line 9 "D:\Hackaton\UniHackStart\Views\Timetable\_partialTimetable.cshtml"
             foreach (var item in day.ParaList)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"timetable-lesson\">\r\n                    <div class=\"timetable-lesson-item\">\r\n                    <div class=\"timetable-lesson-para\">");
#nullable restore
#line 13 "D:\Hackaton\UniHackStart\Views\Timetable\_partialTimetable.cshtml"
                                                  Write(item.paraNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    <div class=\"timetable-lesson-time\">\r\n                        ");
#nullable restore
#line 15 "D:\Hackaton\UniHackStart\Views\Timetable\_partialTimetable.cshtml"
                   Write(item.TimeStart_1);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 15 "D:\Hackaton\UniHackStart\Views\Timetable\_partialTimetable.cshtml"
                                       Write(item.TimeEnd_1);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <br />\r\n                        ");
#nullable restore
#line 17 "D:\Hackaton\UniHackStart\Views\Timetable\_partialTimetable.cshtml"
                   Write(item.TimeStart_2);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 17 "D:\Hackaton\UniHackStart\Views\Timetable\_partialTimetable.cshtml"
                                       Write(item.TimeEnd_2);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"timetable-lesson-teacher-wrapper\">\r\n                        <div class=\"timetable-lesson-text\">");
#nullable restore
#line 20 "D:\Hackaton\UniHackStart\Views\Timetable\_partialTimetable.cshtml"
                                                      Write(item.LessonName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 20 "D:\Hackaton\UniHackStart\Views\Timetable\_partialTimetable.cshtml"
                                                                       Write(item.LessonShortType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                        <div class=\"timetable-lesson-place\">");
#nullable restore
#line 21 "D:\Hackaton\UniHackStart\Views\Timetable\_partialTimetable.cshtml"
                                                       Write(item.CorpClassRoom);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                        <div class=\"timetable-lesson-teacher\">");
#nullable restore
#line 22 "D:\Hackaton\UniHackStart\Views\Timetable\_partialTimetable.cshtml"
                                                         Write(item.TeacherName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    </div>\r\n                </div>\r\n                    </div>\r\n");
#nullable restore
#line 26 "D:\Hackaton\UniHackStart\Views\Timetable\_partialTimetable.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n");
#nullable restore
#line 28 "D:\Hackaton\UniHackStart\Views\Timetable\_partialTimetable.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<script>$(\'.slider\').slick({ dots: true });</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<UniHackStart.Models.StudentTimeTableModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
