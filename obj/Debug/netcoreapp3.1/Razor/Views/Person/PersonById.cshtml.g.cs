#pragma checksum "D:\gl3\framework\Project\TP 3\Views\Person\PersonById.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bd5b3b74d1bfdc449c5434231a1c4413bca860fb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Person_PersonById), @"mvc.1.0.view", @"/Views/Person/PersonById.cshtml")]
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
#line 1 "D:\gl3\framework\Project\TP 3\Views\_ViewImports.cshtml"
using TP_3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\gl3\framework\Project\TP 3\Views\_ViewImports.cshtml"
using TP_3.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd5b3b74d1bfdc449c5434231a1c4413bca860fb", @"/Views/Person/PersonById.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ab11a2c4e70004bcf5480bbbcb5ab8dbda8d9ea", @"/Views/_ViewImports.cshtml")]
    public class Views_Person_PersonById : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Person>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"container\">\r\n");
#nullable restore
#line 4 "D:\gl3\framework\Project\TP 3\Views\Person\PersonById.cshtml"
     if (Model == null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h1>\r\n            Cet id est invalide\r\n        </h1>\r\n");
#nullable restore
#line 9 "D:\gl3\framework\Project\TP 3\Views\Person\PersonById.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row\">\r\n    <div class=\"col-5\">\r\n        <img");
            BeginWriteAttribute("src", " src=\"", 216, "\"", 234, 1);
#nullable restore
#line 14 "D:\gl3\framework\Project\TP 3\Views\Person\PersonById.cshtml"
WriteAttributeValue("", 222, Model.image, 222, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    </div>\r\n    <div class=\"col-6\">\r\n        <h3>id: </h3> ");
#nullable restore
#line 17 "D:\gl3\framework\Project\TP 3\Views\Person\PersonById.cshtml"
                 Write(Model.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <h3>First Name: </h3> ");
#nullable restore
#line 18 "D:\gl3\framework\Project\TP 3\Views\Person\PersonById.cshtml"
                         Write(Model.first_name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <h3>Last Name: </h3> ");
#nullable restore
#line 19 "D:\gl3\framework\Project\TP 3\Views\Person\PersonById.cshtml"
                        Write(Model.last_name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <h3>Country: </h3> ");
#nullable restore
#line 20 "D:\gl3\framework\Project\TP 3\Views\Person\PersonById.cshtml"
                      Write(Model.country);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <h3>Email: </h3> ");
#nullable restore
#line 21 "D:\gl3\framework\Project\TP 3\Views\Person\PersonById.cshtml"
                    Write(Model.email);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <h3>Date of Birth: </h3> ");
#nullable restore
#line 22 "D:\gl3\framework\Project\TP 3\Views\Person\PersonById.cshtml"
                            Write(Model.date_birth);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n");
#nullable restore
#line 25 "D:\gl3\framework\Project\TP 3\Views\Person\PersonById.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n        </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Person> Html { get; private set; }
    }
}
#pragma warning restore 1591
