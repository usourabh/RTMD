#pragma checksum "D:\Project\RTMD\RTMDOTProject\Views\Location\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f6eada05ca4e29178110e0c063fcd2a2336c853e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Location_Index), @"mvc.1.0.view", @"/Views/Location/Index.cshtml")]
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
#line 1 "D:\Project\RTMD\RTMDOTProject\Views\_ViewImports.cshtml"
using RTMDOTProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Project\RTMD\RTMDOTProject\Views\_ViewImports.cshtml"
using RTMDOTProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f6eada05ca4e29178110e0c063fcd2a2336c853e", @"/Views/Location/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59e29fbb83af3489d15848054cb410c8b063a753", @"/Views/_ViewImports.cshtml")]
    public class Views_Location_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/LocationDetail.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 1 "D:\Project\RTMD\RTMDOTProject\Views\Location\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/sidemaster.cshtml";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f6eada05ca4e29178110e0c063fcd2a2336c853e3957", async() => {
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f6eada05ca4e29178110e0c063fcd2a2336c853e4996", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<script type=""text/javascript"" src=""https://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js""></script>
<script type=""text/javascript"" src=""https://cdnjs.cloudflare.com/ajax/libs/pdfmake/0.1.22/pdfmake.min.js""></script>
<script type=""text/javascript"" src=""https://cdnjs.cloudflare.com/ajax/libs/html2canvas/0.4.1/html2canvas.min.js""></script>
<script src=""https://cdnjs.cloudflare.com/ajax/libs/jspdf-autotable/2.3.5/jspdf.plugin.autotable.min.js""></script>
<script type=""text/javascript"">
    function showModal() {
        $('#SaleModal').modal('show');
        $('#btnAdd1').show();
        $('#btnUpdate1').hide();
    }
 

</script>
<div class=""row"">
    <div class=""col-xl-12 ui-sortable"">
        <div class=""panel panel-inverse"">
            <div class=""panel-heading"">
                <h4 class=""panel-title"">Location Details &nbsp;&nbsp;</h4>
                <div class=""panel-heading-btn"">
                    <a title=""Add New"" onclick=""showModal()"" class=""btn btn-primary btn-icon b");
            WriteLiteral(@"tn-circle btn-lg""><i class=""fa fa-plus""></i></a>
                    <a href=""javascript:;"" class=""btn btn-xs btn-icon btn-default"" data-toggle=""panel-expand""><i class=""fa fa-expand""></i></a>
                    <a href=""javascript:;"" class=""btn btn-xs btn-icon btn-success"" data-toggle=""panel-reload""><i class=""fa fa-redo""></i></a>
                    <a href=""javascript:;"" class=""btn btn-xs btn-icon btn-warning"" data-toggle=""panel-collapse""><i class=""fa fa-minus""></i></a>
                    <a href=""javascript:;"" class=""btn btn-xs btn-icon btn-danger"" data-toggle=""panel-remove""><i class=""fa fa-times""></i></a>
                </div>
            </div>
            <div class=""row"">
                <div class=""d-block d-lg-inline-flex me-0 me-md-3"">
                    <div class=""d-block d-lg-inline-flex"">
                        <div class=""dt-buttons btn-group flex-wrap"" style=""padding-left:20px;padding-top:20px;"">
                            <button class=""btn btn-secondary buttons-copy buttons-h");
            WriteLiteral(@"tml5 btn-sm"" tabindex=""0"" aria-controls=""tlbDataTable"" type=""button"">
                                <span>Copy</span>
                            </button> <button class=""btn btn-secondary buttons-csv buttons-html5 btn-sm"" tabindex=""0"" aria-controls=""tlbDataTable"" type=""button""><span>CSV</span></button>
                            <button class=""btn btn-secondary buttons-excel buttons-html5 btn-sm"" tabindex=""0"" aria-controls=""tlbDataTable"" type=""button""><span>Excel</span></button>
                            <button class=""btn btn-secondary buttons-pdf buttons-html5 btn-sm"" onclick=""PDFExport();"" type=""submit"">
                                <span>PDF</span>
                            </button> <button class=""btn btn-secondary buttons-print btn-sm"" tabindex=""0"" aria-controls=""tlbDataTable"" type=""button""><span>Print</span></button>
                        </div>
                    </div>
                    <input type=""search"" style=""margin-top:30px;"" id=""searchrec"" placeholder=""Search Data..."" ");
            WriteLiteral(@"/>
                </div>
                <div class=""modal"" tabindex=""-1"" id=""SaleModal"" role=""dialog"">
                    <div class=""modal-dialog modal-lg"" role=""document"">
                        <div class=""modal-content"">
                            <div class=""modal-header bg-success"">
                                <h5 class=""modal-title text-white""> Location Details</h5>
                                <button type=""button"" class=""btn-close"" style=""border:none;"" data-bs-dismiss=""modal"" aria-label=""Close"">
                                </button>
                            </div>
                            <div class=""modal-body"">
                                <div class=""row"">
                                    <div class=""col-md-6"">
                                        <div class=""form-group row mb-3 "" style=""display:none;"">
                                            <label class=""col-lg-4 col-form-label form-label "">Contact ID</label>
                                     ");
            WriteLiteral(@"       <div class=""col-lg-8 "">
                                                <input class=""form-control"" type=""text"" id=""txtContactId"" name=""txtClientName"" data-parsley-required=""true"">
                                            </div>
                                        </div>
                                    </div>
                                    <div class=""col-md-12"">
                                        <div class=""form-group row mb-3"">
                                            <label class=""col-lg-2 col-form-label form-label"">Contact Person Name</label>
                                            <div class=""col-lg-10"">
                                                <input type=""hidden""");
            BeginWriteAttribute("value", " value=\"", 5016, "\"", 5024, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                                                <input class=""form-control"" type=""text"" id=""txtContactPersonName"" name=""txtCompanyName"" data-parsley-required=""true"">
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div class=""row"">
                                    <div class=""col-md-6"">
                                        <div class=""form-group row mb-3"">
                                            <label class=""col-lg-4 col-form-label form-label"">Contact Person Number </label>
                                            <div class=""col-lg-8"">
                                                <input class=""form-control"" type=""text"" id=""txtContactPersonNumber"" name=""txtCompanyName"" data-parsley-required=""true"">
                                            </div>
                                        </div>
                   ");
            WriteLiteral(@"                 </div>
                                    <div class=""col-md-6"">
                                        <div class=""form-group row mb-3"">
                                            <label class=""col-lg-4 col-form-label form-label"">Address1</label>
                                            <div class=""col-lg-8 "">
                                                <input class=""form-control"" type=""text"" id=""txtAddress1"" name=""txtClientName"" data-parsley-required=""true"">
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div class=""row"">
                                    <div class=""col-md-6"">
                                        <div class=""form-group row mb-3"">
                                            <label class=""col-lg-4 col-form-label form-label"">Address2</label>
                                            ");
            WriteLiteral(@"<div class=""col-lg-8"">
                                                <input class=""form-control"" type=""text"" id=""txtAddress2"" name=""txtClientName"" data-parsley-required=""true"">
                                            </div>
                                        </div>
                                    </div>
                                    <div class=""col-md-6"">
                                        <div class=""form-group row mb-3"">
                                            <label class=""col-lg-4 col-form-label form-label"">Longitude</label>
                                            <div class=""col-lg-8 "">
                                                <input class=""form-control"" type=""text"" id=""txtLongitude"" name=""txtClientName"" data-parsley-required=""true"">
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div cla");
            WriteLiteral(@"ss=""row"">
                                    <div class=""col-md-6"">
                                        <div class=""form-group row mb-3"">
                                            <label class=""col-lg-4 col-form-label form-label"">Latitude</label>
                                            <div class=""col-lg-8"">
                                                <input class=""form-control"" type=""text"" id=""txtLatitude"" name=""txtClientName"" data-parsley-required=""true"">
                                            </div>
                                        </div>
                                    </div>
                                    <div class=""col-md-6"">
                                        <div class=""form-group row mb-3"">
                                            <label class=""col-lg-4 col-form-label form-label"">City</label>
                                            <div class=""col-lg-8 "">
                                                <input class=""form-control"" type=""tex");
            WriteLiteral(@"t"" id=""txtCity"" name=""txtClientName"" data-parsley-required=""true"">
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div class=""row"">
                                    <div class=""col-md-6"">
                                        <div class=""form-group row mb-3"">
                                            <label class=""col-lg-4 col-form-label form-label"">State</label>
                                            <div class=""col-lg-8"">
                                                <input class=""form-control"" type=""text"" id=""txtState"" name=""txtClientName"" data-parsley-required=""true"">
                                            </div>
                                        </div>
                                    </div>
                                    <div class=""col-md-6"">
                                        <div class=");
            WriteLiteral(@"""form-group row mb-3"">
                                            <label class=""col-lg-4 col-form-label form-label"">Pin</label>
                                            <div class=""col-lg-8 "">
                                                <input class=""form-control"" type=""text"" id=""txtPin"" name=""txtClientName"" data-parsley-required=""true"">
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div class=""row"">
                                    <div class=""col-md-6"">
                                        <div class=""form-group row mb-3"">
                                            <label class=""col-lg-4 col-form-label form-label"">Country</label>
                                            <div class=""col-lg-8 "">
                                                <input class=""form-control"" type=""text"" id=""txtCountry"" name=""txtClientNam");
            WriteLiteral(@"e"" data-parsley-required=""true"">
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class=""modal-footer"">
                                <button type=""submit"" class=""btn btn-success""  onclick=""AddLocation()"" id=""btnAdd1"">Save </button>
                                <button type=""submit"" class=""btn btn-success"" onclick=""UpdateLocation()"" id=""btnUpdate1"">Update </button>
                            </div>
                        </div>
                    </div>
                </div>  <br /><br /><br />
                <div id=""data-table-buttons_wrapper"" class=""dataTables_wrapper dt-bootstrap5 no-footer"">
                    <div class=""table-responsive"">
                        <table id=""DeviceInfo"" class=""table table-striped table-bordered align-middle"">
                            <thead>
   ");
            WriteLiteral(@"                             <tr>
                                    <th>Contact ID</th>
                                    <th>Contact Person Name</th>
                                    <th>Contact Phone Number </th>
                                    <th>Address1 </th>
                                    <th>Address2 </th>
                                    <th>Longitude </th>
                                    <th>Latitude </th>
                                    <th>City</th>
                                    <th>State</th>
                                    <th>Pin</th>
                                    <th>Country</th>
                                    <th>Action</th>
                                </tr>
                            </thead>
                            <tbody id=""table_location"">
                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>");
            WriteLiteral("\n\r\n");
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
