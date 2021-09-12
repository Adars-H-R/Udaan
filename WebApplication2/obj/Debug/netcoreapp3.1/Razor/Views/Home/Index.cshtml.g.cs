#pragma checksum "C:\Users\Admin\source\repos\WebApplication2\WebApplication2\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c7d771318d2806c53ba8777d88fff4eaf8bf72ee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Admin\source\repos\WebApplication2\WebApplication2\Views\_ViewImports.cshtml"
using WebApplication2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\source\repos\WebApplication2\WebApplication2\Views\_ViewImports.cshtml"
using WebApplication2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7d771318d2806c53ba8777d88fff4eaf8bf72ee", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b36aee4455a440795f240a74431c307640c545e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CarCrashViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Admin\source\repos\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container\">\r\n\r\n    <div>\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 120, "\"", 205, 1);
#nullable restore
#line 8 "C:\Users\Admin\source\repos\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
WriteAttributeValue("", 127, Url.Action("Index","Home", new { pageSize = (Model.PreviousPageIndex + 30) }), 127, 78, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Prev</a>\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 227, "\"", 308, 1);
#nullable restore
#line 9 "C:\Users\Admin\source\repos\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
WriteAttributeValue("", 234, Url.Action("Index","Home", new { pageSize = (Model.PreviousPageIndex ) }), 234, 74, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">Next</a>
    </div>

    
    <div class=""row"" id=""myItems"">
        <div class=""row"">
            <div class=""col-sm-12 mb-3"">
                <input type=""text"" id=""myFilter"" class=""form-control"" onkeyup=""myFunction()"" placeholder=""Search for names.."">
            </div>
        </div>
        <div id=""providersCards"" class=""row p-3"">
");
#nullable restore
#line 20 "C:\Users\Admin\source\repos\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
             foreach (CarCrash carCrash in Model.CarCrashes)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""col-6 providersCardsDiv"">
                    <div class=""card mb-3"">
                        <div class=""p-1 row no-gutters"">
                            <div class=""col-12 align-self-center"">
                                <div class=""card-body "">
                                    <h5 class=""card-title providerdetails"">Vehicle Type 1: ");
#nullable restore
#line 27 "C:\Users\Admin\source\repos\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
                                                                                      Write(carCrash.VehicleTypeCode1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                    <h5 class=\"card-text providerdetails\">Vehicle Type 2: ");
#nullable restore
#line 28 "C:\Users\Admin\source\repos\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
                                                                                     Write(carCrash.VehicleTypeCode1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                    <h5 class=\"card-title providerdetails\">Crash Date: ");
#nullable restore
#line 29 "C:\Users\Admin\source\repos\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
                                                                                  Write(carCrash.CrashDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                    <h5 class=\"card-text providerdetails\">Crash Time: ");
#nullable restore
#line 30 "C:\Users\Admin\source\repos\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
                                                                                 Write(carCrash.CrashTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                    <button onclick=\"return bindModalData(this)\" data-toggle=\"modal\" data-target=\"#seeDeatils\" data-vT1=\"");
#nullable restore
#line 31 "C:\Users\Admin\source\repos\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
                                                                                                                                    Write(carCrash.VehicleTypeCode1);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"");
            BeginWriteAttribute(",data-vT2", " ,data-vT2=\"", 1657, "\"", 1695, 1);
#nullable restore
#line 31 "C:\Users\Admin\source\repos\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
WriteAttributeValue("", 1669, carCrash.VehicleTypeCode2, 1669, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute(",data-CrashDate", " ,data-CrashDate=\"", 1696, "\"", 1733, 1);
#nullable restore
#line 31 "C:\Users\Admin\source\repos\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
WriteAttributeValue("", 1714, carCrash.CrashDate, 1714, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n                                            data-CrashTime=\"");
#nullable restore
#line 32 "C:\Users\Admin\source\repos\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
                                                       Write(carCrash.CrashTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"");
            BeginWriteAttribute(",data-OnStreetName", " ,data-OnStreetName=\"", 1816, "\"", 1859, 1);
#nullable restore
#line 32 "C:\Users\Admin\source\repos\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
WriteAttributeValue("", 1837, carCrash.OnStreetName, 1837, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute(",data-NumberOfPersonsInjured", " ,data-NumberOfPersonsInjured=\"", 1860, "\"", 1923, 1);
#nullable restore
#line 32 "C:\Users\Admin\source\repos\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
WriteAttributeValue("", 1891, carCrash.NumberOfPersonsInjured, 1891, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n                                            data-NumberOfPersonsKilled=\"");
#nullable restore
#line 33 "C:\Users\Admin\source\repos\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
                                                                   Write(carCrash.NumberOfPersonsKilled);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"");
            BeginWriteAttribute(",data-NumberOfPedestriansInjured", " ,data-NumberOfPedestriansInjured=\"", 2030, "\"", 2101, 1);
#nullable restore
#line 33 "C:\Users\Admin\source\repos\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
WriteAttributeValue("", 2065, carCrash.NumberOfPedestriansInjured, 2065, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n                                            data-NumberOfPedestriansKilled=\"");
#nullable restore
#line 34 "C:\Users\Admin\source\repos\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
                                                                       Write(carCrash.NumberOfPedestriansKilled);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"");
            BeginWriteAttribute(",data-ZipCode", " ,data-ZipCode=\"", 2216, "\"", 2249, 1);
#nullable restore
#line 34 "C:\Users\Admin\source\repos\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
WriteAttributeValue("", 2232, carCrash.ZipCode, 2232, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"
                                            class="" mt-1 btn btn-primary providerCheckBox"" type=""button"">
                                        View Complete Details
                                    </button>
                                </div>
                            </div>
                        </div>

                    </div>
                </div>
");
#nullable restore
#line 44 "C:\Users\Admin\source\repos\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
    </div>

    <div class=""modal fade"" id=""seeDeatils"" tabindex=""-1"" role=""dialog"" aria-labelledby=""seeDeatils"" aria-hidden=""true"">
        <div class=""modal-dialog modal-lg modal-dialog-centered"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header border-bottom"">
                    <h5 class=""modal-title"" id=""exampleModalLongTitle"">Car Crash Details</h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>
                <div class=""modal-body p-5"">
                    <div id=""modalBody""");
            BeginWriteAttribute("class", " class=\"", 3378, "\"", 3386, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        
                    </div>
                </div>
                
            </div>
        </div>
    </div>
</div>

<script>
    function bindModalData(e) {
        $('#modalBody').empty();
        var body = '<div class=row>   Vehicle Type 1 ' + e.dataset.vt1 + ' </div>'      + '<div class=row>   Number of pedestrians killed ' + e.dataset.numberofpedestrianskilled + ' </div>'
            + '<div class=row>   Number of persons killed ' + e.dataset.numberofpersonskilled + ' </div>' + '<div class=row>   Number of persons killed ' + e.dataset.numberofpersonskilled + ' </div>'

        $('#modalBody').append(body);
        $('#modalBody').trigger();
    }

    function myFunction() {
        var input, filter, cards, cardContainer, h5, title, i;
        input = document.getElementById(""myFilter"");
        filter = input.value.toUpperCase();
        cardContainer = document.getElementById(""myItems"");
        cards = cardContainer.getElementsByClassName(""card""");
            WriteLiteral(@");
        for (i = 0; i < cards.length; i++) {
            title = cards[i].querySelector("".card-body h5.card-title"");
            if (title.innerText.toUpperCase().indexOf(filter) > -1) {
                cards[i].style.display = """";
            } else {
                cards[i].style.display = ""none"";
            }
        }
    }
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CarCrashViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591