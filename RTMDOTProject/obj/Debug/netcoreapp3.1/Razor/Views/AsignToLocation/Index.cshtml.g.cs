#pragma checksum "E:\RTMD\RTMDOTProject\Views\AsignToLocation\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "451f90714fb4701f69213af97b4a8822db5880b8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AsignToLocation_Index), @"mvc.1.0.view", @"/Views/AsignToLocation/Index.cshtml")]
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
#line 1 "E:\RTMD\RTMDOTProject\Views\_ViewImports.cshtml"
using RTMDOTProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\RTMD\RTMDOTProject\Views\_ViewImports.cshtml"
using RTMDOTProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"451f90714fb4701f69213af97b4a8822db5880b8", @"/Views/AsignToLocation/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59e29fbb83af3489d15848054cb410c8b063a753", @"/Views/_ViewImports.cshtml")]
    public class Views_AsignToLocation_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<RTMDOTProject.Models.DeviceDetail>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("selected", new global::Microsoft.AspNetCore.Html.HtmlString("selected"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-select form-select-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-parsley-required", new global::Microsoft.AspNetCore.Html.HtmlString("true"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("txtDeviceName"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\RTMD\RTMDOTProject\Views\AsignToLocation\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/sidemaster.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "451f90714fb4701f69213af97b4a8822db5880b85663", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-6\">\r\n        <div class=\"form-group row mb-3\">\r\n            <label class=\"col-lg-4 col-form-label form-label\">Device Name </label>\r\n            <div class=\"col-lg-8\">\r\n                <input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 449, "\"", 457, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "451f90714fb4701f69213af97b4a8822db5880b87137", async() => {
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "451f90714fb4701f69213af97b4a8822db5880b87417", async() => {
                    WriteLiteral("Please select");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
#nullable restore
#line 15 "E:\RTMD\RTMDOTProject\Views\AsignToLocation\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = (new SelectList(@ViewBag.data1,"DeviceId","DeviceNumber"));

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<input type=\"button\" id=\"btnmap\" value=\"Show Map\" />\r\n");
            WriteLiteral(@"<div class=""row"">
    <div class=""col-xl-12 ui-sortable"">
        <div class=""panel panel-inverse"" data-sortable-id=""index-1"">
            <div class=""panel-heading ui-sortable-handle"">
                <h4 class=""panel-title""> Map View  </h4>
                <div class=""panel-heading-btn"">
                    <a href=""javascript:;"" class=""btn btn-xs btn-icon btn-default"" data-toggle=""panel-expand""><i class=""fa fa-expand""></i></a>
                    <a href=""javascript:;"" class=""btn btn-xs btn-icon btn-success"" data-toggle=""panel-reload""><i class=""fa fa-redo""></i></a>
                    <a href=""javascript:;"" class=""btn btn-xs btn-icon btn-warning"" data-toggle=""panel-collapse""><i class=""fa fa-minus""></i></a>
                    <a href=""javascript:;"" class=""btn btn-xs btn-icon btn-danger"" data-toggle=""panel-remove""><i class=""fa fa-times""></i></a>
                </div>
            </div>
            <div class=""panel-body pe-1"">
                <div id=""dvMap"" style=""width:100%; height: 500px"">");
            WriteLiteral(@"
                </div>
            </div>
        </div>
    </div>
</div>
<script type=""text/javascript"" src=""https://maps.googleapis.com/maps/api/js?key=AIzaSyBoskTdUNsjC5KfrbcReq_RgacMWi-r0zU&libraries=places""></script>
<script type=""text/javascript"">

                $(""#btnmap"").click(function () {
                    debugger;
                   // var DeviceId = $('#txtDeviceName').val();
                    var DeviceId = $('select#txtDeviceName option:selected').val();
                    debugger;
                        $.ajax({
                            url: '/AsignToLocation/Locationdata?DeviceId=' + DeviceId,
                            type: 'get',
                            contentType: 'application/json;charset=utf-8;',
                            dataType: 'json',
                            success: function (response) {
                                alert(""done"");
                                var markers = [response]; //");
#nullable restore
#line 59 "E:\RTMD\RTMDOTProject\Views\AsignToLocation\Index.cshtml"
                                                       Write(Html.Raw(ViewBag.Markers));

#line default
#line hidden
#nullable disable
            WriteLiteral(@";

                                debugger;
                                var mapOptions = {
                                    center: new google.maps.LatLng(markers[0].lat, markers[0].lng),
                                    zoom: 10,
                                    mapTypeId: google.maps.MapTypeId.ROADMAP
                                };
                                debugger;
                                var infoWindow = new google.maps.InfoWindow();
                                debugger;
                                var map = new google.maps.Map(document.getElementById(""dvMap""), mapOptions);
                                for (i = 0; i < markers.length; i++) {
                                    var data = markers[i]
                                    var myLatlng = new google.maps.LatLng(data.lat, data.lng);
                                    debugger;
                                    var marker = new google.maps.Marker({
                                     ");
            WriteLiteral(@"   position: myLatlng,
                                        map: map,
                                        title: data.deviceName
                                    });
                                    debugger;
                                    (function (marker, data) {
                                        debugger;
                                        google.maps.event.addListener(marker, ""click"", function (e) {
                                            infoWindow.setContent(data.contactpersonname);
                                            infoWindow.open(map, marker);
                                        });
                                    })(marker, data);
                                }
                            },
                            error: function () {
                                alert('data not found');
                            }
                        })
                });

</script>
<script type=""text/javascript"">


       ");
            WriteLiteral("         var markers = ");
#nullable restore
#line 100 "E:\RTMD\RTMDOTProject\Views\AsignToLocation\Index.cshtml"
                         Write(Html.Raw(ViewBag.Markers));

#line default
#line hidden
#nullable disable
            WriteLiteral(@";
                debugger;
                window.onload = function () {
                    debugger;
            var mapOptions = {
                center: new google.maps.LatLng(markers[0].lat, markers[0].lng),
                zoom: 8,
                mapTypeId: google.maps.MapTypeId.ROADMAP
            };
            var infoWindow = new google.maps.InfoWindow();
            var map = new google.maps.Map(document.getElementById(""dvMap""), mapOptions);
            for (i = 0; i < markers.length; i++) {
                var data = markers[i]
                var myLatlng = new google.maps.LatLng(data.lat, data.lng);
                var marker = new google.maps.Marker({
                    position: myLatlng,
                    map: map,
                    title: data.title
                });
                (function (marker, data) {
                    google.maps.event.addListener(marker, ""click"", function (e) {
                        infoWindow.setContent(data.description);
      ");
            WriteLiteral("                  infoWindow.open(map, marker);\r\n                    });\r\n                })(marker, data);\r\n            }\r\n                }\r\n\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<RTMDOTProject.Models.DeviceDetail>> Html { get; private set; }
    }
}
#pragma warning restore 1591
