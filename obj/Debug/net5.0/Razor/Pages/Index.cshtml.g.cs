#pragma checksum "C:\Users\sonus\Downloads\Trios classes\SQL Programming - Remote Learning-started on 14-june-2021\SQL14\Project_SP\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "89110aa528b0062ecbfafd93f93e321f4fa9c8f4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Project_SP.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace Project_SP.Pages
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
#line 1 "C:\Users\sonus\Downloads\Trios classes\SQL Programming - Remote Learning-started on 14-june-2021\SQL14\Project_SP\Pages\_ViewImports.cshtml"
using Project_SP;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89110aa528b0062ecbfafd93f93e321f4fa9c8f4", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e910361307324caf5c0f9ddddfb6e47019ba19ba", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "BookCategory", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "BookSearch", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "SearchBook", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "updateB_Type", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 3 "C:\Users\sonus\Downloads\Trios classes\SQL Programming - Remote Learning-started on 14-june-2021\SQL14\Project_SP\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Book Store</h1>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "89110aa528b0062ecbfafd93f93e321f4fa9c8f44954", async() => {
                WriteLiteral(@"
     <list><h2>Book Categories </h2>
     <ul type=""disc"">business</ul>
     <ul type=""disc"">mod_cook</ul>
     <ul type=""disc"">popular_comp</ul>
     <ul type=""disc"">psycology</ul>
     <ul type=""disc"">trad_cook</ul>
     </list>
    <input type=""text"" name=""sortByCategory"" Placeholder=""Shop by Category..."">
    <input type=""Submit"" value=""Search"">


    <div>
");
#nullable restore
#line 22 "C:\Users\sonus\Downloads\Trios classes\SQL Programming - Remote Learning-started on 14-june-2021\SQL14\Project_SP\Pages\Index.cshtml"
      if(Model.book_Overview.Count > 0){
         
         

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\sonus\Downloads\Trios classes\SQL Programming - Remote Learning-started on 14-june-2021\SQL14\Project_SP\Pages\Index.cshtml"
          for(int i = 0 ; i< Model.book_Overview.Count ; i++){

#line default
#line hidden
#nullable disable
                WriteLiteral("             <h2>List of books on searched Category :</h2>\r\n        <h4>\r\n            <span><h3>Book Name:</h3>");
#nullable restore
#line 27 "C:\Users\sonus\Downloads\Trios classes\SQL Programming - Remote Learning-started on 14-june-2021\SQL14\Project_SP\Pages\Index.cshtml"
                                Write(Model.book_Name[i]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n            <span><h3>Book Overview:</h3>");
#nullable restore
#line 28 "C:\Users\sonus\Downloads\Trios classes\SQL Programming - Remote Learning-started on 14-june-2021\SQL14\Project_SP\Pages\Index.cshtml"
                                    Write(Model.book_Overview[i]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n            \r\n        </h4>\r\n");
#nullable restore
#line 31 "C:\Users\sonus\Downloads\Trios classes\SQL Programming - Remote Learning-started on 14-june-2021\SQL14\Project_SP\Pages\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\sonus\Downloads\Trios classes\SQL Programming - Remote Learning-started on 14-june-2021\SQL14\Project_SP\Pages\Index.cshtml"
         
     }
    else{

#line default
#line hidden
#nullable disable
                WriteLiteral("          <h4>No Records found...</h4>\r\n");
#nullable restore
#line 35 "C:\Users\sonus\Downloads\Trios classes\SQL Programming - Remote Learning-started on 14-june-2021\SQL14\Project_SP\Pages\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("     </div>\r\n\r\n ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.PageHandler = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "89110aa528b0062ecbfafd93f93e321f4fa9c8f49255", async() => {
                WriteLiteral("\r\n    <h2>Enter Bookname or term to find Price : </h2>\r\n    <input type=\"text\" name=\"findBook\" Placeholder=\"Enter Booksearch term...\">\r\n    <input type=\"Submit\" value=\"Price\">\r\n ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.PageHandler = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n \r\n <div>\r\n");
#nullable restore
#line 50 "C:\Users\sonus\Downloads\Trios classes\SQL Programming - Remote Learning-started on 14-june-2021\SQL14\Project_SP\Pages\Index.cshtml"
      if(Model.author_fname.Count > 0){
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "C:\Users\sonus\Downloads\Trios classes\SQL Programming - Remote Learning-started on 14-june-2021\SQL14\Project_SP\Pages\Index.cshtml"
         for(int i = 0 ; i< Model.author_fname.Count ; i++){

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h4>\r\n            <span><h3>Book Name:</h3>");
#nullable restore
#line 53 "C:\Users\sonus\Downloads\Trios classes\SQL Programming - Remote Learning-started on 14-june-2021\SQL14\Project_SP\Pages\Index.cshtml"
                                Write(Model.book_Name[i]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            <span><h3>Author Name:</h3>");
#nullable restore
#line 54 "C:\Users\sonus\Downloads\Trios classes\SQL Programming - Remote Learning-started on 14-june-2021\SQL14\Project_SP\Pages\Index.cshtml"
                                  Write(Model.author_fname[i]);

#line default
#line hidden
#nullable disable
            WriteLiteral(",");
#nullable restore
#line 54 "C:\Users\sonus\Downloads\Trios classes\SQL Programming - Remote Learning-started on 14-june-2021\SQL14\Project_SP\Pages\Index.cshtml"
                                                         Write(Model.author_lname[i]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            <span><h3>Price:</h3>");
#nullable restore
#line 55 "C:\Users\sonus\Downloads\Trios classes\SQL Programming - Remote Learning-started on 14-june-2021\SQL14\Project_SP\Pages\Index.cshtml"
                            Write(Model.book_Price[i]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span><br>\r\n        </h4>\r\n");
#nullable restore
#line 57 "C:\Users\sonus\Downloads\Trios classes\SQL Programming - Remote Learning-started on 14-june-2021\SQL14\Project_SP\Pages\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 57 "C:\Users\sonus\Downloads\Trios classes\SQL Programming - Remote Learning-started on 14-june-2021\SQL14\Project_SP\Pages\Index.cshtml"
         
     }
    else{

#line default
#line hidden
#nullable disable
            WriteLiteral("          <h4>No Records found...</h4>\r\n");
#nullable restore
#line 61 "C:\Users\sonus\Downloads\Trios classes\SQL Programming - Remote Learning-started on 14-june-2021\SQL14\Project_SP\Pages\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(" </div>\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "89110aa528b0062ecbfafd93f93e321f4fa9c8f413917", async() => {
                WriteLiteral("\r\n     <h4>Search Book Name to update :</h4>\r\n    <input type=\"text\" name=\"bookToSearch\" placeholder=\"Type Book Name...\">\r\n    <input type=\"submit\" value=\"Search\">\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.PageHandler = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<div>\r\n");
#nullable restore
#line 71 "C:\Users\sonus\Downloads\Trios classes\SQL Programming - Remote Learning-started on 14-june-2021\SQL14\Project_SP\Pages\Index.cshtml"
 if(Model.title != null) {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <span><h5>Book Name:</h5>");
#nullable restore
#line 72 "C:\Users\sonus\Downloads\Trios classes\SQL Programming - Remote Learning-started on 14-june-2021\SQL14\Project_SP\Pages\Index.cshtml"
                        Write(Model.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n    <span><h5>Book Type:</h5>");
#nullable restore
#line 73 "C:\Users\sonus\Downloads\Trios classes\SQL Programming - Remote Learning-started on 14-june-2021\SQL14\Project_SP\Pages\Index.cshtml"
                        Write(Model.type);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 74 "C:\Users\sonus\Downloads\Trios classes\SQL Programming - Remote Learning-started on 14-june-2021\SQL14\Project_SP\Pages\Index.cshtml"
}else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<span>No Records...</span>\r\n");
#nullable restore
#line 77 "C:\Users\sonus\Downloads\Trios classes\SQL Programming - Remote Learning-started on 14-june-2021\SQL14\Project_SP\Pages\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("  </div> \r\n\r\n\r\n <div>\r\n <h4>Enter Update Data :</h4>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "89110aa528b0062ecbfafd93f93e321f4fa9c8f417271", async() => {
                WriteLiteral("\r\n        <input type=\"text\" name=\"update_bookName\"");
                BeginWriteAttribute("value", " value=\"", 2252, "\"", 2275, 1);
#nullable restore
#line 84 "C:\Users\sonus\Downloads\Trios classes\SQL Programming - Remote Learning-started on 14-june-2021\SQL14\Project_SP\Pages\Index.cshtml"
WriteAttributeValue("", 2260, Model.bookType, 2260, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n        <input type=\"text\" name=\"update_bookType\"");
                BeginWriteAttribute("value", " value=\"", 2328, "\"", 2351, 1);
#nullable restore
#line 85 "C:\Users\sonus\Downloads\Trios classes\SQL Programming - Remote Learning-started on 14-june-2021\SQL14\Project_SP\Pages\Index.cshtml"
WriteAttributeValue("", 2336, Model.bookName, 2336, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n        <input type=\"submit\" value=\"Update\">\r\n        \r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.PageHandler = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div> \r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
