#pragma checksum "C:\Институт\Uni\UniHackStart\Views\Log\_partialStudentLog.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6cb555da778376e6494c54947f9b741c21dec538"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Log__partialStudentLog), @"mvc.1.0.view", @"/Views/Log/_partialStudentLog.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6cb555da778376e6494c54947f9b741c21dec538", @"/Views/Log/_partialStudentLog.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df0feea0a0b029f6fcb285c9eea66f28206a4019", @"/Views/_ViewImports.cshtml")]
    public class Views_Log__partialStudentLog : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/arrow-down.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Открыть"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"serviceForm all-payments-drop-form\">\r\n    \r\n    <div class=\"all-payments-drop-wrapper\">\r\n");
#nullable restore
#line 4 "C:\Институт\Uni\UniHackStart\Views\Log\_partialStudentLog.cshtml"
         for (int i = 0; i < 10; i++)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""all-payments-item"">
                <div class=""all-payments-drop-list"">
                    <div class=""all-payments-drop-item"">
                        <div class=""all-payments-drop-accordion-btn"">
                            <div class=""all-payments-body"">
                                <div class=""all-payments-address"">
                                    <p class=""appress-name"">
                                        Предмет
                                    </p>
                                    <p class=""address-number"">Преподаватель</p>
                                </div>
                                <div class=""to-pay-paid"">
                                    Сейчас баллов:
                                </div>
                                <div class=""to-pay-fee"">

                                    Всего возможно баллов:
                                </div>
                                <div class=""to-pay-total"">
                      ");
            WriteLiteral("              Активность\r\n                                </div>\r\n                                <button class=\"all-payments-dropdown-btn\" type=\"button\" onclick=\"dropMenu(this)\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6cb555da778376e6494c54947f9b741c21dec5385419", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                </button>
                            </div>
                        </div>
                        <div class=""all-payments-panel accordion-panel"">
                            <div class=""log-table"">
                                <div class=""log-table-header"">
                                    <div class=""log-data"">
                                        Дата:
                                    </div>
                                    <div class=""log-mark"">
                                        Балл:
                                    </div>
                                    <div class=""log-max-mark"">
                                        Максимальный балл:
                                    </div>
                                    <div class=""log-homework"">
                                        Домашнее задание:
                                    </div>
                                </div>
                            </div>
       ");
            WriteLiteral("                 </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 53 "C:\Институт\Uni\UniHackStart\Views\Log\_partialStudentLog.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
</div>
<script>
    function dropMenu(btn) {
        var panel = $(btn).parents('.all-payments-drop-item').find('.accordion-panel'); //находим открываемую часть в карточке
        var img = $(btn).find('img'); //находим картинку стрелки на кнопке
        if (panel.attr('style')) { //проверяем на наличие атрибута
            panel.removeAttr('style');//если он есть убираем
            img.attr('src', '/img/arrow-down.svg')//меняем картику стрелки на синюю, смотрящую вниз
        }
        else {
            var x = panel[0].scrollHeight + 20;//переменная для определения размера открываемой части
            var p = String('padding-bottom: 20px; max-height:' + x + 'px');//задаем минимальныую высоту открываемой части
            panel.attr('style', p); //передаем в атрибут переменную с высотой открываемой части
            img.attr('src', '/img/arrow-up-orange.svg');//меняем изображение стрелки на оранжевую

        }

    };
</script>
");
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
