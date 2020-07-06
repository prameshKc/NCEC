#pragma checksum "C:\Users\ACER\Documents\ranish\gitProj\NCEC\cms\Views\Partner\Master.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e6ccfafd1970dbf3b318c5a74317daebbbd9ca82"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Partner_Master), @"mvc.1.0.view", @"/Views/Partner/Master.cshtml")]
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
#line 1 "C:\Users\ACER\Documents\ranish\gitProj\NCEC\cms\Views\_ViewImports.cshtml"
using CMS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ACER\Documents\ranish\gitProj\NCEC\cms\Views\_ViewImports.cshtml"
using CMS.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6ccfafd1970dbf3b318c5a74317daebbbd9ca82", @"/Views/Partner/Master.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5fda46ac6a24f19109ebb784fda558b061b2e80b", @"/Views/_ViewImports.cshtml")]
    public class Views_Partner_Master : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\ACER\Documents\ranish\gitProj\NCEC\cms\Views\Partner\Master.cshtml"
  
    ViewBag.Title = "Partner Titles";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    .btnAdd {
        margin: 0 0px 0px 40px;
    }
    .modal-content {
        width: 1070px;
        right: 280px;
    }
</style>
<div>
    <div>
        <h3>Partner Titles</h3>
        <hr/>
        <div class=""row"">
            <div class=""col-md-2"">
                <button type=""button"" class=""btn btn-sm btn-outline-primary btnAdd"" data-toggle=""modal"" 
                data-target=""#addPMModal"">Add Title</button>
            </div>
            <div class=""col-md-8"">
                <input type=""text"" id=""searchPM"" class=""form-control form-control-sm"" autocomplete=""off"" placeholder=""Search by Partner Title...""/>
            </div>
        </div>
        <br/>
    </div>
    <div>
        <table class=""table table-bordered table-sm"">
            <thead class=""table-dark"">
                <tr>
                    <th>S.N.</th>
                    <th>Partner Title</th>
                    <th>Action</th>
                </tr>
            </thead>
            <tbody i");
            WriteLiteral(@"d=""bodyPM"">
            </tbody>
        </table>
    </div>
</div>

<!-- Add/update Modal -->
<div class=""modal fade"" id=""addPMModal"" tabindex=""-1"" role=""dialog"" aria-hidden=""true"">
  <div class=""modal-dialog"" role=""document"">
    <div class=""modal-content"">
      <div class=""modal-header"">
        <h5 class=""modal-title"" id=""modalNamePM"">Add Partner Title</h5>
        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
          <span aria-hidden=""true"">&times;</span>
        </button>
      </div>
      <div class=""modal-body"">
           <input id=""idPM"" name=""idPM"" hidden/>
            <div class=""form-group"">
                <label>Title</label>
                <input id=""PMTitle"" type=""text"" class=""form-control form-control-sm"" autocomplete=""off"" placeholder=""Enter Title""/>
            </div>
      </div>
      <div class=""modal-footer"">
        <button type=""button"" class=""btn btn-outline-secondary"" data-dismiss=""modal"">Close</button>
        <input ty");
            WriteLiteral(@"pe=""button"" id=""btnSavePM"" class=""btn btn-outline-success"" value=""Save"" />
      </div>
    </div>
  </div>
</div>


<!-- Delete Modal -->
<div class=""modal fade"" id=""deletePMModal"" tabindex=""-1"" role=""dialog"" aria-hidden=""true"">
  <div class=""modal-dialog"" role=""document"">
    <div class=""modal-content"">
      <div class=""modal-header"">
        <h5 class=""modal-title"">Delete Partner Title</h5>
        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
          <span aria-hidden=""true"">&times;</span>
        </button>
      </div>
      <div class=""modal-body"">
           <input id=""idPMDel"" name=""idPMDel"" hidden/>
            <div class=""row"">
                <div class=""col-md-2""> 
                    <i class=""fa fa-question-circle"" style=""font-size: 50px; color: #4bb349;""></i>
                </div>
                <div class=""col-md-10"">
                    Sure? You want to delete this.
                </div>
            </div>
      </div>
      <d");
            WriteLiteral(@"iv class=""modal-footer"">
        <button type=""button"" class=""btn btn-outline-secondary"" data-dismiss=""modal"">Close</button>
        <input type=""button"" id=""btnDelPM"" class=""btn btn-outline-danger"" value=""Delete"" />
      </div>
    </div>
  </div>
</div>


<script>
    $(function(){
        
        $('#addPMModal').on('shown.bs.modal', function () {
            $('#PMTitle').focus();
        });
        
        $('#addPMModal').on('hidden.bs.modal', function () {
            $('#idPM').val(0);
            $('#PMTitle').val('');
            $('#btnSavePM').val('Save');
            $('#modalNamePM').html('Add Partner Title');
        });

        getPartnerTitles();

        $('#searchPM').keydown(function(e){
            if(e.keyCode === 13)
            {
                getPartnerTitles();
                e.preventDefault();
                return false;
            }
        });

        $('#btnSavePM').click(function(){
            if($('#idPM').val().trim() === '')
 ");
            WriteLiteral(@"           {
                $('#idPM').val(0);
            }
            $.ajax({
                url: '/Partner/PartnerTitle_AddUpdate',
                async: false,
                type: 'post',
                dataType: 'json',
                data: { 
                    PartnerMasterId : $('#idPM').val(),
                    PartnerTitle: $('#PMTitle').val(),
                },
                success: function(data){
                    if(data === 'Success')
                    {
                        if(parseInt($('#idPM').val()) === 0)
                        {
                            alert(""Record Successfully Added!"");
                        }
                        else
                        {
                            alert(""Record Successfully Updated!"");
                        }
                        $('#addPMModal').modal('hide');
                        restForm();
                    }
                    else
                    {
               ");
            WriteLiteral(@"         alert(data);
                    }
                },
                error: function(data){
                    alert(data);
                }
            });
        });

        $('#bodyPM').on('click', '.editPM', function(){
            var id = $(this).attr('data-id');
            if(id > 0)
            {  
                $.ajax({
                    url: '/Partner/GetPartnerTitleById',
                    async: false,
                    type: 'get',
                    dataType: 'json',
                    data: { Id : id },
                    success: function(data){
                        $('#modalNamePM').html('Update Partner Title');
                        $('#btnSavePM').val('Update');
                        $('#idPM').val(id);
                        $('#PMTitle').val(data.partnerTitle);
                        $('#addPMModal').modal('show');
                    },
                    error: function(data){
                        alert(data);
          ");
            WriteLiteral(@"          }
                });
            }
        });

        $('#bodyPM').on('click', '.deletePM', function(){
            $('#deletePMModal').modal('show');
            var id = $(this).attr('data-id');
            $('#idPMDel').val(id);
        });

        $(""#btnDelPM"").click(function(){
            if(parseInt($('#idPMDel').val()) > 0)
            {
                $.ajax({
                    url: '/Partner/PartnerTitle_Delete',
                    async: false,
                    type: 'post',
                    dataType: 'json',
                    data: { 
                        Id : $('#idPMDel').val()
                    },
                    success: function(data){
                        if(data === 'Deleted')
                        {
                            alert(""Record Successfully Deleted!"");
                            $('#deletePMModal').modal('hide');
                            restForm();
                        }
                        else
            WriteLiteral(@"
                        {
                            alert(data);
                        }
                    },
                    error: function(data){
                        alert(data);
                    }
                });
            }
        });
    });

    function getPartnerTitles(){
        $.ajax({
            url: '/Partner/GetPartnerTitle',
            async: false,
            type: 'get',
            dataType: 'json',
            data: { title : $('#searchPM').val().trim() },
            success: function(data){
                var h ='', sn = 1;
                $.each(data, function(i, val){
                    h +='<tr>';
                    h +='<td style=""width:2%;"">'+ sn +'</td>';
                    h +='<td>'+ val.partnerTitle +'</td>';
                    h +='<td style=""width: 13%;""><div class=""row""><div class=""col-md-6""><button type=""button"" data-id=""'+ val.partnerMasterId +'"" class=""editPM btn btn-sm btn-outline-info"">Edit</button></div>'+
     ");
            WriteLiteral(@"               '<div class=""col-md-6""><button type=""button"" data-id=""'+ val.partnerMasterId +'"" class=""deletePM btn btn-sm btn-outline-danger"">Delete</button></td></div>';
                    h +='</tr>';
                    sn++;
                });
                $('#bodyPM').html(h);
            },
            error: function(data){
                alert(data);
            }
        });

    }

    function restForm(){
        getPartnerTitles();
        $('#idPM').val(0);
        $('#PMTitle').val('');
        $('#btnSavePM').val('Save');
        $('#idPMDel').val(0);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591