#pragma checksum "C:\Users\ayane\Desktop\work\School\Winter 2022\CS366\repo\w22---cs366-mondoyanez\7_Final_Project\MadLibsSolution\MadLibs\Views\RoadTrip\DisplayMadLibs.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f758f4d81cdf1f8781389e306babc394a899490c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_RoadTrip_DisplayMadLibs), @"mvc.1.0.view", @"/Views/RoadTrip/DisplayMadLibs.cshtml")]
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
#line 1 "C:\Users\ayane\Desktop\work\School\Winter 2022\CS366\repo\w22---cs366-mondoyanez\7_Final_Project\MadLibsSolution\MadLibs\Views\_ViewImports.cshtml"
using MadLibs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ayane\Desktop\work\School\Winter 2022\CS366\repo\w22---cs366-mondoyanez\7_Final_Project\MadLibsSolution\MadLibs\Views\_ViewImports.cshtml"
using MadLibs.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f758f4d81cdf1f8781389e306babc394a899490c", @"/Views/RoadTrip/DisplayMadLibs.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"775ac5bf28d7904219b4842aef8f71c7621ad6f8", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_RoadTrip_DisplayMadLibs : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RoadTripMadLib>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ayane\Desktop\work\School\Winter 2022\CS366\repo\w22---cs366-mondoyanez\7_Final_Project\MadLibsSolution\MadLibs\Views\RoadTrip\DisplayMadLibs.cshtml"
  
    ViewData["Title"] = "Generate Mad Lib";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">
    <div class=""text-center"">
        <h2 class=""display-4"">Road Trip Mad Libs</h2>
    </div>
</div>
<br>

<div class=""row"">
    <p>Story from <a href=""https://www.printablee.com/post_camping-mad-libs-printable_153008/"">https://www.printablee.com/post_camping-mad-libs-printable_153008/</a></p>
</div>

");
#nullable restore
#line 17 "C:\Users\ayane\Desktop\work\School\Winter 2022\CS366\repo\w22---cs366-mondoyanez\7_Final_Project\MadLibsSolution\MadLibs\Views\RoadTrip\DisplayMadLibs.cshtml"
 if (Model != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row\">\r\n        <p>YAY! IT\'S ROAD TRIP DAY! MY FAMILY AND I HOPPED IN THE <span>");
#nullable restore
#line 20 "C:\Users\ayane\Desktop\work\School\Winter 2022\CS366\repo\w22---cs366-mondoyanez\7_Final_Project\MadLibsSolution\MadLibs\Views\RoadTrip\DisplayMadLibs.cshtml"
                                                                   Write(Model.Noun1.ToUpper());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> FOR A <span>");
#nullable restore
#line 20 "C:\Users\ayane\Desktop\work\School\Winter 2022\CS366\repo\w22---cs366-mondoyanez\7_Final_Project\MadLibsSolution\MadLibs\Views\RoadTrip\DisplayMadLibs.cshtml"
                                                                                                             Write(Model.Adjective1.ToUpper());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> WEEK AT THE \r\n        <span>");
#nullable restore
#line 21 "C:\Users\ayane\Desktop\work\School\Winter 2022\CS366\repo\w22---cs366-mondoyanez\7_Final_Project\MadLibsSolution\MadLibs\Views\RoadTrip\DisplayMadLibs.cshtml"
         Write(Model.Noun2.ToUpper());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>! WHEN WE STOPPED TO FILL UP THE <span>");
#nullable restore
#line 21 "C:\Users\ayane\Desktop\work\School\Winter 2022\CS366\repo\w22---cs366-mondoyanez\7_Final_Project\MadLibsSolution\MadLibs\Views\RoadTrip\DisplayMadLibs.cshtml"
                                                                             Write(Model.Adjective2.ToUpper());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> TANK, A <span>");
#nullable restore
#line 21 "C:\Users\ayane\Desktop\work\School\Winter 2022\CS366\repo\w22---cs366-mondoyanez\7_Final_Project\MadLibsSolution\MadLibs\Views\RoadTrip\DisplayMadLibs.cshtml"
                                                                                                                              Write(Model.Adjective3.ToUpper());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> \r\n        FROG <span>");
#nullable restore
#line 22 "C:\Users\ayane\Desktop\work\School\Winter 2022\CS366\repo\w22---cs366-mondoyanez\7_Final_Project\MadLibsSolution\MadLibs\Views\RoadTrip\DisplayMadLibs.cshtml"
              Write(Model.Verb1.ToUpper());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> IN THE CAR WHILE WE <span>");
#nullable restore
#line 22 "C:\Users\ayane\Desktop\work\School\Winter 2022\CS366\repo\w22---cs366-mondoyanez\7_Final_Project\MadLibsSolution\MadLibs\Views\RoadTrip\DisplayMadLibs.cshtml"
                                                                      Write(Model.Verb2.ToUpper());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> OUT TO GET <span>");
#nullable restore
#line 22 "C:\Users\ayane\Desktop\work\School\Winter 2022\CS366\repo\w22---cs366-mondoyanez\7_Final_Project\MadLibsSolution\MadLibs\Views\RoadTrip\DisplayMadLibs.cshtml"
                                                                                                                     Write(Model.Number1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> SNACKS. <span></span></p>\r\n    </div>\r\n");
            WriteLiteral("    <div class=\"row\">\r\n        <p>WE <span>");
#nullable restore
#line 26 "C:\Users\ayane\Desktop\work\School\Winter 2022\CS366\repo\w22---cs366-mondoyanez\7_Final_Project\MadLibsSolution\MadLibs\Views\RoadTrip\DisplayMadLibs.cshtml"
               Write(Model.Verb3.ToUpper());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> BACK IN THE CAR AND <span>");
#nullable restore
#line 26 "C:\Users\ayane\Desktop\work\School\Winter 2022\CS366\repo\w22---cs366-mondoyanez\7_Final_Project\MadLibsSolution\MadLibs\Views\RoadTrip\DisplayMadLibs.cshtml"
                                                                       Write(Model.Adverb1.ToUpper());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> GOT ON THE <span>");
#nullable restore
#line 26 "C:\Users\ayane\Desktop\work\School\Winter 2022\CS366\repo\w22---cs366-mondoyanez\7_Final_Project\MadLibsSolution\MadLibs\Views\RoadTrip\DisplayMadLibs.cshtml"
                                                                                                                        Write(Model.Noun3.ToUpper());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> \r\n        ABOUT 30 MINUTES IN, THE <span>");
#nullable restore
#line 27 "C:\Users\ayane\Desktop\work\School\Winter 2022\CS366\repo\w22---cs366-mondoyanez\7_Final_Project\MadLibsSolution\MadLibs\Views\RoadTrip\DisplayMadLibs.cshtml"
                                  Write(Model.Color1.ToUpper());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> FROG <span>");
#nullable restore
#line 27 "C:\Users\ayane\Desktop\work\School\Winter 2022\CS366\repo\w22---cs366-mondoyanez\7_Final_Project\MadLibsSolution\MadLibs\Views\RoadTrip\DisplayMadLibs.cshtml"
                                                                            Write(Model.Verb4.ToUpper());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> ONTO THE <span>");
#nullable restore
#line 27 "C:\Users\ayane\Desktop\work\School\Winter 2022\CS366\repo\w22---cs366-mondoyanez\7_Final_Project\MadLibsSolution\MadLibs\Views\RoadTrip\DisplayMadLibs.cshtml"
                                                                                                                         Write(Model.Noun4.ToUpper());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> \r\n        MY MOM WAS HOLDING! \"<span>");
#nullable restore
#line 28 "C:\Users\ayane\Desktop\work\School\Winter 2022\CS366\repo\w22---cs366-mondoyanez\7_Final_Project\MadLibsSolution\MadLibs\Views\RoadTrip\DisplayMadLibs.cshtml"
                              Write(Model.Exlamation1.ToUpper());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\" SHE SCREAMED!</p>\r\n    </div>\r\n");
            WriteLiteral("    <div class=\"row\">\r\n        <p>\"GET OFF!\" MY DAD THOUGHT SHE WAS <span>");
#nullable restore
#line 32 "C:\Users\ayane\Desktop\work\School\Winter 2022\CS366\repo\w22---cs366-mondoyanez\7_Final_Project\MadLibsSolution\MadLibs\Views\RoadTrip\DisplayMadLibs.cshtml"
                                              Write(Model.Verb5.ToUpper());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> TO HIM SO HE <span>");
#nullable restore
#line 32 "C:\Users\ayane\Desktop\work\School\Winter 2022\CS366\repo\w22---cs366-mondoyanez\7_Final_Project\MadLibsSolution\MadLibs\Views\RoadTrip\DisplayMadLibs.cshtml"
                                                                                               Write(Model.Adverb2.ToUpper());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> SWERVED THE \r\n        <span>");
#nullable restore
#line 33 "C:\Users\ayane\Desktop\work\School\Winter 2022\CS366\repo\w22---cs366-mondoyanez\7_Final_Project\MadLibsSolution\MadLibs\Views\RoadTrip\DisplayMadLibs.cshtml"
         Write(Model.Noun5.ToUpper());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> ONTO THE EXIT RAMP! WE <span>");
#nullable restore
#line 33 "C:\Users\ayane\Desktop\work\School\Winter 2022\CS366\repo\w22---cs366-mondoyanez\7_Final_Project\MadLibsSolution\MadLibs\Views\RoadTrip\DisplayMadLibs.cshtml"
                                                                    Write(Model.Verb6.ToUpper());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> FROM LEFT TO RIGHT. THE FROG \r\n        <span>");
#nullable restore
#line 34 "C:\Users\ayane\Desktop\work\School\Winter 2022\CS366\repo\w22---cs366-mondoyanez\7_Final_Project\MadLibsSolution\MadLibs\Views\RoadTrip\DisplayMadLibs.cshtml"
         Write(Model.Verb7.ToUpper());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> ONTO THE <span>");
#nullable restore
#line 34 "C:\Users\ayane\Desktop\work\School\Winter 2022\CS366\repo\w22---cs366-mondoyanez\7_Final_Project\MadLibsSolution\MadLibs\Views\RoadTrip\DisplayMadLibs.cshtml"
                                                      Write(Model.Noun6.ToUpper());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> CAUSING MY DAD TO SLAM ON THE <span>");
#nullable restore
#line 34 "C:\Users\ayane\Desktop\work\School\Winter 2022\CS366\repo\w22---cs366-mondoyanez\7_Final_Project\MadLibsSolution\MadLibs\Views\RoadTrip\DisplayMadLibs.cshtml"
                                                                                                                        Write(Model.PluralNoun.ToUpper());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>. \r\n        SNACKS WENT EVERYWHERE, MY MOM WAS <span>");
#nullable restore
#line 35 "C:\Users\ayane\Desktop\work\School\Winter 2022\CS366\repo\w22---cs366-mondoyanez\7_Final_Project\MadLibsSolution\MadLibs\Views\RoadTrip\DisplayMadLibs.cshtml"
                                            Write(Model.Verb8.ToUpper());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> AND MY DAD <span>");
#nullable restore
#line 35 "C:\Users\ayane\Desktop\work\School\Winter 2022\CS366\repo\w22---cs366-mondoyanez\7_Final_Project\MadLibsSolution\MadLibs\Views\RoadTrip\DisplayMadLibs.cshtml"
                                                                                           Write(Model.Name.ToUpper());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>, <span>");
#nullable restore
#line 35 "C:\Users\ayane\Desktop\work\School\Winter 2022\CS366\repo\w22---cs366-mondoyanez\7_Final_Project\MadLibsSolution\MadLibs\Views\RoadTrip\DisplayMadLibs.cshtml"
                                                                                                                               Write(Model.Verb9.ToUpper());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> \r\n        OUT OF THE CAR LIKE A <span>");
#nullable restore
#line 36 "C:\Users\ayane\Desktop\work\School\Winter 2022\CS366\repo\w22---cs366-mondoyanez\7_Final_Project\MadLibsSolution\MadLibs\Views\RoadTrip\DisplayMadLibs.cshtml"
                               Write(Model.Noun7.ToUpper());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>. MY BROTHER AND I <span>");
#nullable restore
#line 36 "C:\Users\ayane\Desktop\work\School\Winter 2022\CS366\repo\w22---cs366-mondoyanez\7_Final_Project\MadLibsSolution\MadLibs\Views\RoadTrip\DisplayMadLibs.cshtml"
                                                                                     Write(Model.Verb10.ToUpper());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>. THE <span>");
#nullable restore
#line 36 "C:\Users\ayane\Desktop\work\School\Winter 2022\CS366\repo\w22---cs366-mondoyanez\7_Final_Project\MadLibsSolution\MadLibs\Views\RoadTrip\DisplayMadLibs.cshtml"
                                                                                                                               Write(Model.Adjective4.ToUpper());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> \r\n        FROG <span>");
#nullable restore
#line 37 "C:\Users\ayane\Desktop\work\School\Winter 2022\CS366\repo\w22---cs366-mondoyanez\7_Final_Project\MadLibsSolution\MadLibs\Views\RoadTrip\DisplayMadLibs.cshtml"
              Write(Model.Adverb3.ToUpper());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> HOPPED OUT OFF INTO THE BRUSH.</p>\r\n    </div>\r\n");
            WriteLiteral("    <div class=\"row\">\r\n        <p>WE <span>");
#nullable restore
#line 41 "C:\Users\ayane\Desktop\work\School\Winter 2022\CS366\repo\w22---cs366-mondoyanez\7_Final_Project\MadLibsSolution\MadLibs\Views\RoadTrip\DisplayMadLibs.cshtml"
               Write(Model.Adverb4.ToUpper());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> CLOSED THE <span>");
#nullable restore
#line 41 "C:\Users\ayane\Desktop\work\School\Winter 2022\CS366\repo\w22---cs366-mondoyanez\7_Final_Project\MadLibsSolution\MadLibs\Views\RoadTrip\DisplayMadLibs.cshtml"
                                                                Write(Model.Noun8.ToUpper());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> DOORS AND HEADED BACK ON THE \r\n        <span>");
#nullable restore
#line 42 "C:\Users\ayane\Desktop\work\School\Winter 2022\CS366\repo\w22---cs366-mondoyanez\7_Final_Project\MadLibsSolution\MadLibs\Views\RoadTrip\DisplayMadLibs.cshtml"
         Write(Model.Adjective5.ToUpper());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> TO THE <span>");
#nullable restore
#line 42 "C:\Users\ayane\Desktop\work\School\Winter 2022\CS366\repo\w22---cs366-mondoyanez\7_Final_Project\MadLibsSolution\MadLibs\Views\RoadTrip\DisplayMadLibs.cshtml"
                                                         Write(Model.Noun9.ToUpper());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>.</p>\r\n    </div>\r\n");
            WriteLiteral("    <div class=\"row\">\r\n        <p>\"WHAT A <span>");
#nullable restore
#line 46 "C:\Users\ayane\Desktop\work\School\Winter 2022\CS366\repo\w22---cs366-mondoyanez\7_Final_Project\MadLibsSolution\MadLibs\Views\RoadTrip\DisplayMadLibs.cshtml"
                    Write(Model.Adjective6.ToUpper());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> ROAD TRIP\" MY MOM SAID!</p>\r\n    </div>\r\n");
#nullable restore
#line 48 "C:\Users\ayane\Desktop\work\School\Winter 2022\CS366\repo\w22---cs366-mondoyanez\7_Final_Project\MadLibsSolution\MadLibs\Views\RoadTrip\DisplayMadLibs.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RoadTripMadLib> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
