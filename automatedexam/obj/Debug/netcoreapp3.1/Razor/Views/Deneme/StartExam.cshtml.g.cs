#pragma checksum "C:\Users\can2\Desktop\automatedexam\automatedexam\Views\Deneme\StartExam.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fa633205c2391fe0cd28436cd04660f9f0d296fa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Deneme_StartExam), @"mvc.1.0.view", @"/Views/Deneme/StartExam.cshtml")]
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
#line 1 "C:\Users\can2\Desktop\automatedexam\automatedexam\Views\_ViewImports.cshtml"
using automatedexam;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\can2\Desktop\automatedexam\automatedexam\Views\_ViewImports.cshtml"
using automatedexam.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa633205c2391fe0cd28436cd04660f9f0d296fa", @"/Views/Deneme/StartExam.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cac7938c7fd12504fee9f9cf939180789eda9b07", @"/Views/_ViewImports.cshtml")]
    public class Views_Deneme_StartExam : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Exam>
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div>\r\n    <div class=\"card\">\r\n        <div class=\"card-body\">\r\n            ");
#nullable restore
#line 10 "C:\Users\can2\Desktop\automatedexam\automatedexam\Views\Deneme\StartExam.cshtml"
       Write(Model.examArticle);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <br />\r\n\r\n\r\n    <div class=\"row\">\r\n        <div class=\"col-5\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fa633205c2391fe0cd28436cd04660f9f0d296fa3670", async() => {
                WriteLiteral("\r\n            <div class=\"card m-2 border-dark\">\r\n                <div class=\"card-body\">\r\n                    ");
#nullable restore
#line 21 "C:\Users\can2\Desktop\automatedexam\automatedexam\Views\Deneme\StartExam.cshtml"
               Write(Model.question1);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                </div>
            </div>
            <div class=""border border-secondary m-1"" onclick=""question1AnswerA.click()"">
                <input type=""radio"" name=""q"" id=""question1AnswerA"" value=""A"">
                <label for=""question1AnswerA"">
                    ");
#nullable restore
#line 27 "C:\Users\can2\Desktop\automatedexam\automatedexam\Views\Deneme\StartExam.cshtml"
               Write(Model.question1AnswerA);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                </label>
            </div>

            <div class=""border border-secondary m-1"" onclick=""question1AnswerB.click()"">
                <input type=""radio"" name=""q"" id=""question1AnswerB"" value=""B"">
                <label for=""question1AnswerB"">
                    ");
#nullable restore
#line 34 "C:\Users\can2\Desktop\automatedexam\automatedexam\Views\Deneme\StartExam.cshtml"
               Write(Model.question1AnswerB);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                </label>
            </div>
            <div class=""border border-secondary m-1"" onclick=""question1AnswerC.click()"">
                <input type=""radio"" name=""q"" id=""question1AnswerC"" value=""C"">
                <label for=""question1AnswerC"">
                    ");
#nullable restore
#line 40 "C:\Users\can2\Desktop\automatedexam\automatedexam\Views\Deneme\StartExam.cshtml"
               Write(Model.question1AnswerC);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                </label>
            </div>
            <div class=""border border-secondary m-1"" onclick=""question1AnswerD.click()"">
                <input type=""radio"" name=""q"" id=""question1AnswerD"" value=""D"">
                <label for=""question1AnswerD"">
                    ");
#nullable restore
#line 46 "C:\Users\can2\Desktop\automatedexam\automatedexam\Views\Deneme\StartExam.cshtml"
               Write(Model.question1AnswerD);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </label>\r\n            </div>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col-1\"></div>\r\n        <div class=\"col-5\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fa633205c2391fe0cd28436cd04660f9f0d296fa7594", async() => {
                WriteLiteral("\r\n            <div class=\"card m-2 border-dark\">\r\n                <div class=\"card-body\">\r\n                    ");
#nullable restore
#line 56 "C:\Users\can2\Desktop\automatedexam\automatedexam\Views\Deneme\StartExam.cshtml"
               Write(Model.question2);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                </div>
            </div>
            <div class=""border border-secondary m-1"" onclick=""question2AnswerA.click()"">
                <input type=""radio"" name=""q"" id=""question2AnswerA"" value=""A"">
                <label for=""question2AnswerA"">
                    ");
#nullable restore
#line 62 "C:\Users\can2\Desktop\automatedexam\automatedexam\Views\Deneme\StartExam.cshtml"
               Write(Model.question2AnswerA);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                </label>
            </div>
            <div class=""border border-secondary m-1"" onclick=""question2AnswerB.click()"">
                <input type=""radio"" name=""q"" id=""question2AnswerB"" value=""B"">
                <label for=""question2AnswerB"">
                    ");
#nullable restore
#line 68 "C:\Users\can2\Desktop\automatedexam\automatedexam\Views\Deneme\StartExam.cshtml"
               Write(Model.question2AnswerB);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                </label>
            </div>
            <div class=""border border-secondary m-1"" onclick=""question2AnswerC.click()"">
                <input type=""radio"" name=""q"" id=""question2AnswerC"" value=""C"">
                <label for=""question2AnswerC"">
                    ");
#nullable restore
#line 74 "C:\Users\can2\Desktop\automatedexam\automatedexam\Views\Deneme\StartExam.cshtml"
               Write(Model.question2AnswerC);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                </label>
            </div>

            <div class=""border border-secondary m-1"" onclick=""question2AnswerD.click()"">
                <input type=""radio"" name=""q"" id=""question2AnswerD"" value=""D"">
                <label for=""question2AnswerD"">
                    ");
#nullable restore
#line 81 "C:\Users\can2\Desktop\automatedexam\automatedexam\Views\Deneme\StartExam.cshtml"
               Write(Model.question2AnswerD);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </label>\r\n            </div>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <br />\r\n    <div class=\"row\">\r\n        <div class=\"col-5\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fa633205c2391fe0cd28436cd04660f9f0d296fa11534", async() => {
                WriteLiteral("\r\n            <div class=\"card m-2 border-dark\">\r\n                <div class=\"card-body\">\r\n                    ");
#nullable restore
#line 93 "C:\Users\can2\Desktop\automatedexam\automatedexam\Views\Deneme\StartExam.cshtml"
               Write(Model.question3);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                </div>
            </div>
            <div class=""border border-secondary m-1"" onclick=""question3AnswerA.click()"">
                <input type=""radio"" name=""q"" id=""question3AnswerA"" value=""A"">
                <label for=""question3AnswerA"">
                    ");
#nullable restore
#line 99 "C:\Users\can2\Desktop\automatedexam\automatedexam\Views\Deneme\StartExam.cshtml"
               Write(Model.question3AnswerA);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                </label>
            </div>
            <div class=""border border-secondary m-1"" onclick=""question3AnswerB.click()"">
                <input type=""radio"" name=""q"" id=""question3AnswerB"" value=""B"">
                <label for=""question3AnswerB"">
                    ");
#nullable restore
#line 105 "C:\Users\can2\Desktop\automatedexam\automatedexam\Views\Deneme\StartExam.cshtml"
               Write(Model.question3AnswerB);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                </label>
            </div>
            <div class=""border border-secondary m-1"" onclick=""question3AnswerC.click()"">
                <input type=""radio"" name=""q"" id=""question3AnswerC"" value=""C"">
                <label for=""question3AnswerC"">
                    ");
#nullable restore
#line 111 "C:\Users\can2\Desktop\automatedexam\automatedexam\Views\Deneme\StartExam.cshtml"
               Write(Model.question3AnswerC);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                </label>
            </div>
            <div class=""border border-secondary m-1"" onclick=""question3AnswerD.click()"">
                <input type=""radio"" name=""q"" id=""question3AnswerD"" value=""D"">
                <label for=""question3AnswerD"">
                    ");
#nullable restore
#line 117 "C:\Users\can2\Desktop\automatedexam\automatedexam\Views\Deneme\StartExam.cshtml"
               Write(Model.question3AnswerD);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </label>\r\n            </div>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col-1\"></div>\r\n        <div class=\"col-5\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fa633205c2391fe0cd28436cd04660f9f0d296fa15460", async() => {
                WriteLiteral("\r\n            <div class=\"card m-2 border-dark\">\r\n                <div class=\"card-body\">\r\n                    ");
#nullable restore
#line 127 "C:\Users\can2\Desktop\automatedexam\automatedexam\Views\Deneme\StartExam.cshtml"
               Write(Model.question4);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                </div>
            </div>
            
            <div class=""border border-secondary m-1"" onclick=""question4AnswerA.click()"">
                <input type=""radio"" name=""q"" id=""question4AnswerA"" value=""A"">
                <label for=""question4AnswerA"">
                    ");
#nullable restore
#line 134 "C:\Users\can2\Desktop\automatedexam\automatedexam\Views\Deneme\StartExam.cshtml"
               Write(Model.question4AnswerA);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                </label>
            </div>
            <div class=""border border-secondary m-1"" onclick=""question4AnswerB.click()"">
                <input type=""radio"" name=""q"" id=""question4AnswerB"" value=""B"">
                <label for=""question4AnswerB"">
                    ");
#nullable restore
#line 140 "C:\Users\can2\Desktop\automatedexam\automatedexam\Views\Deneme\StartExam.cshtml"
               Write(Model.question4AnswerB);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                </label>
            </div>

            <div class=""border border-secondary m-1"" onclick=""question4AnswerC.click()"">
                <input type=""radio"" name=""q"" id=""question4AnswerC"" value=""C"">
                <label for=""question4AnswerC"">
                    ");
#nullable restore
#line 147 "C:\Users\can2\Desktop\automatedexam\automatedexam\Views\Deneme\StartExam.cshtml"
               Write(Model.question4AnswerC);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                </label>
            </div>
            
                <div class=""border border-secondary m-1"" onclick=""question4AnswerD.click()"">
                    <input type=""radio"" name=""q"" id=""question4AnswerD"" value=""D"">
                    <label for=""question4AnswerD"">
                        ");
#nullable restore
#line 154 "C:\Users\can2\Desktop\automatedexam\automatedexam\Views\Deneme\StartExam.cshtml"
                   Write(Model.question4AnswerD);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </label>\r\n                </div>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            \r\n        </div>\r\n    </div>\r\n    <div class=\"row mt-2\">\r\n        <div class=\"col-4\"></div>\r\n        <input type=\"button\" class=\"btn btn-sm btn-primary col-4\" value=\"SINAVI BİTİR\"");
            BeginWriteAttribute("onclick", "\r\n               onclick=\"", 6612, "\"", 6675, 3);
            WriteAttributeValue("", 6638, "getCorrectAnswersUsingAjax(", 6638, 27, true);
#nullable restore
#line 164 "C:\Users\can2\Desktop\automatedexam\automatedexam\Views\Deneme\StartExam.cshtml"
WriteAttributeValue("", 6665, Model.Id, 6665, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6674, ")", 6674, 1, true);
            EndWriteAttribute();
            WriteLiteral(@" />
        <div class=""col-4""></div>
    </div>
    
</div>
<p id=""doldur""></p>
<script type=""text/javascript"">
    function compareAnswer(correctAnswerString) {
        console.log(correctAnswerString)
        var counter = 0
        var responseObjectCounter = 0
        var answers = document.getElementsByName(""q"")
        if (answers != null) {
            for (var i = 0; i < answers.length; i++) {
                if (i % 4 == 0 && i != 0)
                    responseObjectCounter += 1
                if (answers[i].checked) {
                    if (answers[i].value == correctAnswerString[responseObjectCounter]) {
                        answers[i].parentElement.style.backgroundColor = ""green""
                    }
                    else {
                        answers[i].parentElement.style.backgroundColor = ""red""
                    }
                }
                
            }
        }
    }
    function getCorrectAnswersUsingAjax(examId) {
        $.ajax({
    ");
            WriteLiteral("        url: \'");
#nullable restore
#line 194 "C:\Users\can2\Desktop\automatedexam\automatedexam\Views\Deneme\StartExam.cshtml"
             Write(Url.Action("GetCorrectAnswers"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
            type: ""POST"",
            data: { ExamId: examId },
            dataType: ""json"",
            success: function (response) {
                compareAnswer(response)
                
            }
        })
        
    }

    

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Exam> Html { get; private set; }
    }
}
#pragma warning restore 1591
