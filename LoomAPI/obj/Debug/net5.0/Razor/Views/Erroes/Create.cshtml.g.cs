#pragma checksum "C:\Projects\API\TearAPI\LoomAPI\Views\Erroes\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ca9d02a74f19f601a408fb6a6fe3b764b4c045d0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Erroes_Create), @"mvc.1.0.view", @"/Views/Erroes/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca9d02a74f19f601a408fb6a6fe3b764b4c045d0", @"/Views/Erroes/Create.cshtml")]
    #nullable restore
    public class Views_Erroes_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LoomAPI.Models.Erro>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Projects\API\TearAPI\LoomAPI\Views\Erroes\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Create</h1>

<h4>Erro</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Create"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""QuantidadeParadas"" class=""control-label""></label>
                <input asp-for=""QuantidadeParadas"" class=""form-control"" />
                <span asp-validation-for=""QuantidadeParadas"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""TempoParadas"" class=""control-label""></label>
                <input asp-for=""TempoParadas"" class=""form-control"" />
                <span asp-validation-for=""TempoParadas"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""PerdaEficienciaParadas"" class=""control-label""></label>
                <input asp-for=""PerdaEficienciaParadas"" class=""form-control"" />
           ");
            WriteLiteral(@"     <span asp-validation-for=""PerdaEficienciaParadas"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""TempoMedio"" class=""control-label""></label>
                <input asp-for=""TempoMedio"" class=""form-control"" />
                <span asp-validation-for=""TempoMedio"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Create"" class=""btn btn-primary"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-action=""Index"">Back to List</a>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 47 "C:\Projects\API\TearAPI\LoomAPI\Views\Erroes\Create.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LoomAPI.Models.Erro> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
