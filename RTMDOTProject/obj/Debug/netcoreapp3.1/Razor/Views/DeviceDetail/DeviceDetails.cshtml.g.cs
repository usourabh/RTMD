#pragma checksum "E:\RTMD\RTMDOTProject\Views\DeviceDetail\DeviceDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ed16ee2113d9117b4b208c16d395ebd27c99c9d8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DeviceDetail_DeviceDetails), @"mvc.1.0.view", @"/Views/DeviceDetail/DeviceDetails.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed16ee2113d9117b4b208c16d395ebd27c99c9d8", @"/Views/DeviceDetail/DeviceDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59e29fbb83af3489d15848054cb410c8b063a753", @"/Views/_ViewImports.cshtml")]
    public class Views_DeviceDetail_DeviceDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/DeviceDetail.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "E:\RTMD\RTMDOTProject\Views\DeviceDetail\DeviceDetails.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/sidemaster.cshtml";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ed16ee2113d9117b4b208c16d395ebd27c99c9d84162", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ed16ee2113d9117b4b208c16d395ebd27c99c9d85201", async() => {
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
<script>
    function showModal() {
        $('#SaleModal').modal('show');
        $('#btnAdd').show();
        $('#btnUpdate').hide();
    }
</script>
<div class=""row"">
    <div class=""col-xl-12 ui-sortable"">
        <div class=""panel panel-inverse"">
            <div class=""panel-heading"">
                <h4 class=""panel-title"">Device Details &nbsp;&nbsp;</h4>
                <div class=""panel-heading-btn"">
                    <a title=""Add New"" onclick=""showModal()"" class=""btn btn-primary btn-icon btn-circle btn-lg""><i class=""fa f");
            WriteLiteral(@"a-plus""></i></a>
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
                            <button class=""btn btn-secondary buttons-copy buttons-html5 btn-sm"" tabindex=""0"" ar");
            WriteLiteral(@"ia-controls=""tlbDataTable"" type=""button"">
                                <span>Copy</span>
                            </button> <button class=""btn btn-secondary buttons-csv buttons-html5 btn-sm"" tabindex=""0"" aria-controls=""tlbDataTable"" type=""button""><span>CSV</span></button>
                            <button class=""btn btn-secondary buttons-excel buttons-html5 btn-sm"" tabindex=""0"" aria-controls=""tlbDataTable"" type=""button""><span>Excel</span></button>
                            <button class=""btn btn-secondary buttons-pdf buttons-html5 btn-sm"" onclick=""PDFExport();"" type=""submit"">
                                <span>PDF</span>
                            </button> <button class=""btn btn-secondary buttons-print btn-sm"" tabindex=""0"" aria-controls=""tlbDataTable"" type=""button""><span>Print</span></button>
                        </div>

                    </div>   <input type=""search"" style=""margin-top:30px;"" id=""searchrec"" placeholder=""Search Data..."" />
                </div>

               ");
            WriteLiteral(@" <div class=""modal"" tabindex=""-1"" id=""SaleModal"" role=""dialog"">
                    <div class=""modal-dialog modal-lg"" role=""document"">
                        <div class=""modal-content"">
                            <div class=""modal-header bg-success"">
                                <h5 class=""modal-title text-white""> Device Details</h5>
                                <button type=""button"" class=""btn-close"" style=""border:none;"" data-bs-dismiss=""modal"" aria-label=""Close"">
                                </button>
                            </div>
                            <div class=""modal-body"">
                                <div class=""row"">
                                    <div class=""col-md-6"">
                                        <div class=""form-group row mb-3 "" style=""display:none;"">
                                            <label class=""col-lg-4 col-form-label form-label "">Device ID</label>
                                            <div class=""col-lg-8 "">
              ");
            WriteLiteral(@"                                  <input class=""form-control"" type=""text"" id=""txtDeviceId"" name=""txtClientName"" data-parsley-required=""true"">
                                            </div>
                                        </div>
                                    </div>
                                    <div class=""col-md-12"">
                                        <div class=""form-group row mb-3"">
                                            <label class=""col-lg-2 col-form-label form-label"">IEMI Number</label>
                                            <div class=""col-lg-10"">
                                                <input type=""hidden""");
            BeginWriteAttribute("value", " value=\"", 4961, "\"", 4969, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                                                <input class=""form-control"" type=""text"" id=""txtIEMINumber"" name=""txtCompanyName"" data-parsley-required=""true"">
                                            </div>
                                        </div>
                                    </div>

                                </div>
                                <div class=""row"">
                                    <div class=""col-md-6"">
                                        <div class=""form-group row mb-3"">
                                            <label class=""col-lg-4 col-form-label form-label"">Device Type </label>
                                            <div class=""col-lg-8"">
                                                <input type=""hidden""");
            BeginWriteAttribute("value", " value=\"", 5759, "\"", 5767, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                                <select class=\"form-control\" id=\"dlDeviceType\">\r\n                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ed16ee2113d9117b4b208c16d395ebd27c99c9d812578", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                                </select>
                                            </div>
                                        </div>
                                    </div>

                                    <div class=""col-md-6"">
                                        <div class=""form-group row mb-3"">
                                            <label class=""col-lg-4 col-form-label form-label"">Device Name</label>
                                            <div class=""col-lg-8 "">
                                                <input class=""form-control"" type=""text"" id=""txtDeviceName"" name=""txtClientName"" data-parsley-required=""true"">
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div class=""row"">
                                    <div class=""col-md-6"">
                                        <div");
            WriteLiteral(@" class=""form-group row mb-3"">
                                            <label class=""col-lg-4 col-form-label form-label"">Minimum Value  </label>
                                            <div class=""col-lg-8"">
                                                <input class=""form-control"" type=""text"" id=""txtMinimumValue"" name=""txtClientName"" data-parsley-required=""true"">

                                            </div>
                                        </div>
                                    </div>

                                    <div class=""col-md-6"">
                                        <div class=""form-group row mb-3"">
                                            <label class=""col-lg-4 col-form-label form-label"">Maximum Value</label>
                                            <div class=""col-lg-8 "">
                                                <input class=""form-control"" type=""text"" id=""txtMaximumValue"" name=""txtClientName"" data-parsley-required=""true"">
               ");
            WriteLiteral(@"                             </div>
                                        </div>
                                    </div>
                                </div>
                                <div class=""row"">
                                    <div class=""col-md-6"">
                                        <div class=""form-group row mb-3"">
                                            <label class=""col-lg-4 col-form-label form-label"">Status</label>
                                            <div class=""col-lg-8"">
                                                <input class=""form-control"" type=""text"" id=""txtStatus"" name=""txtClientName"" data-parsley-required=""true"">

                                            </div>
                                        </div>
                                    </div>

                                    <div class=""col-md-6"">
                                        <div class=""form-group row mb-3"">
                                            <label cl");
            WriteLiteral(@"ass=""col-lg-4 col-form-label form-label"">Description</label>
                                            <div class=""col-lg-8 "">
                                                <input class=""form-control"" type=""text"" id=""txtDescription"" name=""txtClientName"" data-parsley-required=""true"">
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class=""modal-footer"">
                                <button type=""submit"" class=""btn btn-success"" id=""btnAdd"">Save </button>
                                <button type=""submit"" class=""btn btn-success"" id=""btnUpdate"">Update </button>
                            </div>
                        </div>
                    </div>
                </div>  <br /><br /><br />
                <div id=""data-table-buttons_wrapper"" class=""dataTables_wrapper dt-bootstrap5 no-foot");
            WriteLiteral(@"er"">
                    <div class=""table-responsive"">
                        <table id=""DeviceInfo"" class=""table table-striped table-bordered align-middle"">
                            <thead>
                                <tr>
                                    <th>Device ID</th>
                                    <th>IEMI Number</th>
                                    <th>Device Type </th>
                                    <th>Device Name </th>
                                    <th>Status </th>
                                    <th>Minimum Value</th>
                                    <th>Maximum Value</th>
                                    <th>Description</th>
                                    <th>Action</th>
                                </tr>
                            </thead>
                            <tbody id=""table_device"">
                            </tbody>
                        </table>
                    </div>
                </div>
            <");
            WriteLiteral("/div>\r\n        </div>\r\n    </div>\r\n\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n");
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
