#pragma checksum "D:\Moi dokuments\ИНСТИТУТ\XAKATON\MIFI\UniHackStart\Views\Timetable\_partialWeekTimetable.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "818c61771631fdf4f92d5d0632cdfd2a68988c26"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Timetable__partialWeekTimetable), @"mvc.1.0.view", @"/Views/Timetable/_partialWeekTimetable.cshtml")]
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
#line 1 "D:\Moi dokuments\ИНСТИТУТ\XAKATON\MIFI\UniHackStart\Views\_ViewImports.cshtml"
using UniHackStart;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Moi dokuments\ИНСТИТУТ\XAKATON\MIFI\UniHackStart\Views\_ViewImports.cshtml"
using UniHackStart.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"818c61771631fdf4f92d5d0632cdfd2a68988c26", @"/Views/Timetable/_partialWeekTimetable.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df0feea0a0b029f6fcb285c9eea66f28206a4019", @"/Views/_ViewImports.cshtml")]
    public class Views_Timetable__partialWeekTimetable : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UniHackStart.Models.WeekTimetableModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"card timetable-card\">\r\n    <div class=\"timetable-date\">День ");
#nullable restore
#line 3 "D:\Moi dokuments\ИНСТИТУТ\XAKATON\MIFI\UniHackStart\Views\Timetable\_partialWeekTimetable.cshtml"
                                Write(Model.dateOfWeek);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Неделя ");
#nullable restore
#line 3 "D:\Moi dokuments\ИНСТИТУТ\XAKATON\MIFI\UniHackStart\Views\Timetable\_partialWeekTimetable.cshtml"
                                                         Write(Model.weekNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    <div class=\"timetable-lesson-wrapper\">\r\n");
#nullable restore
#line 5 "D:\Moi dokuments\ИНСТИТУТ\XAKATON\MIFI\UniHackStart\Views\Timetable\_partialWeekTimetable.cshtml"
         for (int i = 0; i < 6; i++)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"timetable-lesson-item\">\r\n                <div class=\"timetable-lesson-time\">");
#nullable restore
#line 8 "D:\Moi dokuments\ИНСТИТУТ\XAKATON\MIFI\UniHackStart\Views\Timetable\_partialWeekTimetable.cshtml"
                                              Write(Model.time);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                <div class=\"timetable-lesson-teacher-place-wrapper\">\r\n                    <div class=\"timetable-lesson-text\">");
#nullable restore
#line 10 "D:\Moi dokuments\ИНСТИТУТ\XAKATON\MIFI\UniHackStart\Views\Timetable\_partialWeekTimetable.cshtml"
                                                  Write(Model.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    <div class=\"timetable-lesson-place\">");
#nullable restore
#line 11 "D:\Moi dokuments\ИНСТИТУТ\XAKATON\MIFI\UniHackStart\Views\Timetable\_partialWeekTimetable.cshtml"
                                                   Write(Model.place);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    <div class=\"timetable-lesson-teacher\">");
#nullable restore
#line 12 "D:\Moi dokuments\ИНСТИТУТ\XAKATON\MIFI\UniHackStart\Views\Timetable\_partialWeekTimetable.cshtml"
                                                     Write(Model.teachername);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 15 "D:\Moi dokuments\ИНСТИТУТ\XAKATON\MIFI\UniHackStart\Views\Timetable\_partialWeekTimetable.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UniHackStart.Models.WeekTimetableModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
