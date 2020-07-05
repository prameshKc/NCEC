#pragma checksum "C:\Users\ACER\Documents\ranish\gitProj\NCEC\cms\Views\HeadLine\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2818139ca4a557e07d0660ffbcb20b72f6b8cf94"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HeadLine_Index), @"mvc.1.0.view", @"/Views/HeadLine/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2818139ca4a557e07d0660ffbcb20b72f6b8cf94", @"/Views/HeadLine/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5fda46ac6a24f19109ebb784fda558b061b2e80b", @"/Views/_ViewImports.cshtml")]
    public class Views_HeadLine_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\ACER\Documents\ranish\gitProj\NCEC\cms\Views\HeadLine\Index.cshtml"
  
    ViewBag.Title = "Head Line";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    .btnAdd {
        margin: 0 0px 0px 40px;
    }

</style>
<div>
    <div>
        <h3>Head Lines</h3>
        <hr/>
        <div class=""row"">
            <div class=""col-md-2"">
                <button type=""button"" class=""btn btn-sm btn-outline-primary btnAdd"" data-toggle=""modal"" 
                data-target=""#addHLModal"">Add New</button>
            </div>
            <div class=""col-md-8"">
                <input type=""text"" id=""searchHL"" class=""form-control form-control-sm"" autocomplete=""off"" placeholder=""Search by Title...""/>
            </div>
        </div>
        <br/>
    </div>
    <div>
        <table class=""table table-bordered table-sm"">
            <thead class=""table-dark"">
                <tr>
                    <th>S.N.</th>
                    <th>Title</th>
                    <th>Description</th>
                    <th>Action</th>
                </tr>
            </thead>
            <tbody id=""bodyHL"">
            </tbody>
        </table>
 ");
            WriteLiteral(@"   </div>
</div>

<!-- Add/update Modal -->
<div class=""modal fade"" id=""addHLModal"" tabindex=""-1"" role=""dialog"" aria-hidden=""true"">
  <div class=""modal-dialog"" role=""document"">
    <div class=""modal-content"">
      <div class=""modal-header"">
        <h5 class=""modal-title"" id=""modalNameHL"">Add Head Line</h5>
        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
          <span aria-hidden=""true"">&times;</span>
        </button>
      </div>
      <div class=""modal-body"">
           <input id=""idHL"" name=""idHL"" hidden/>
            <div class=""form-group"">
                <label>Title</label>
                <input id=""HLTitle"" type=""text"" class=""form-control form-control-sm"" autocomplete=""off"" placeholder=""Enter Title""/>
            </div>
            <div class=""form-group"">
                <label>Description</label>
                <textarea id=""HLDes"" type=""text"" class=""form-control form-control-sm"" autocomplete=""off"" placeholder=""Enter Description"" rows=");
            WriteLiteral(@"""3""></textarea>
            </div>
      </div>
      <div class=""modal-footer"">
        <button type=""button"" class=""btn btn-outline-secondary"" data-dismiss=""modal"">Close</button>
        <input type=""button"" id=""btnSaveHL"" class=""btn btn-outline-success"" value=""Save"" />
      </div>
    </div>
  </div>
</div>


<!-- Delete Modal -->
<div class=""modal fade"" id=""deleteHLModal"" tabindex=""-1"" role=""dialog"" aria-hidden=""true"">
  <div class=""modal-dialog"" role=""document"">
    <div class=""modal-content"">
      <div class=""modal-header"">
        <h5 class=""modal-title"">Delete Head Line</h5>
        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
          <span aria-hidden=""true"">&times;</span>
        </button>
      </div>
      <div class=""modal-body"">
           <input id=""idHLDel"" name=""idHLDel"" hidden/>
            <div class=""row"">
                <div class=""col-md-2""> 
                    <i class=""fa fa-question-circle"" style=""font-size: 50px; color: ");
            WriteLiteral(@"#4bb349;""></i>
                </div>
                <div class=""col-md-10"">
                    Sure? You want to delete this.
                </div>
            </div>
      </div>
      <div class=""modal-footer"">
        <button type=""button"" class=""btn btn-outline-secondary"" data-dismiss=""modal"">Close</button>
        <input type=""button"" id=""btnDelHL"" class=""btn btn-outline-danger"" value=""Delete"" />
      </div>
    </div>
  </div>
</div>


<script>
    $(function(){
        $('#HLDes').summernote({
            placeholder: 'Write description here...',
            toolbar: [
                // [groupName, [list of button]]
                ['style', ['bold', 'italic', 'underline', 'clear']],
                ['font', ['strikethrough', 'superscript', 'subscript']],
                ['fontsize', ['fontsize']],
                ['color', ['color']],
                ['fontname', ['fontname']],
                ['para', ['ul', 'ol', 'paragraph']],
                ['height', ['height']]");
            WriteLiteral(@"
            ]
        });
        
        $('#addHLModal').on('shown.bs.modal', function () {
            $('#HLTitle').focus();
        });
        
        $('#addHLModal').on('hidden.bs.modal', function () {
            $('#idHL').val(0);
            $('#HLTitle').val('');
            $('#HLDes').summernote(""code"", '');
            $('#btnSaveHL').val('Save');
            $('#modalNameHL').html('Add Head Line');
        });

        getHeadLines();

        $('#searchHL').keydown(function(e){
            if(e.keyCode === 13)
            {
                getHeadLines();
                e.preventDefault();
                return false;
            }
        });

        $('#btnSaveHL').click(function(){
            if($('#idHL').val().trim() === '')
            {
                $('#idHL').val(0);
            }
            $.ajax({
                url: '/HeadLine/HeadLine_AddUpdate',
                async: false,
                type: 'post',
                dataType: '");
            WriteLiteral(@"json',
                data: { 
                    Id : $('#idHL').val(),
                    HeadLine: $('#HLTitle').val(),
                    Description: $('#HLDes').val(),
                },
                success: function(data){
                    if(data === 'Success')
                    {
                        if(parseInt($('#idHL').val()) === 0)
                        {
                            alert(""Record Successfully Added!"");
                        }
                        else
                        {
                            alert(""Record Successfully Updated!"");
                        }
                        $('#addHLModal').modal('hide');
                        restForm();
                    }
                    else
                    {
                        alert(data);
                    }
                },
                error: function(data){
                    alert(data);
                }
            });
        });

      ");
            WriteLiteral(@"  $('#bodyHL').on('click', '.editHL', function(){
            var id = $(this).attr('data-id');
            if(id > 0)
            {  
                $.ajax({
                    url: '/HeadLine/GetHeadlinesById',
                    async: false,
                    type: 'get',
                    dataType: 'json',
                    data: { Id : id },
                    success: function(data){
                        $('#modalNameHL').html('Update Head Line');
                        $('#btnSaveHL').val('Update');
                        $('#idHL').val(id);
                        $('#HLTitle').val(data.headLine);
                        $('#HLDes').summernote('code', data.description);
                        $('#addHLModal').modal('show');
                    },
                    error: function(data){
                        alert(data);
                    }
                });
            }
        });

        $('#bodyHL').on('click', '.deleteHL', function(){
         ");
            WriteLiteral(@"   $('#deleteHLModal').modal('show');
            var id = $(this).attr('data-id');
            $('#idHLDel').val(id);
        });

        $(""#btnDelHL"").click(function(){
            if(parseInt($('#idHLDel').val()) > 0)
            {
                $.ajax({
                    url: '/HeadLine/HeadLine_Delete',
                    async: false,
                    type: 'post',
                    dataType: 'json',
                    data: { 
                        Id : $('#idHLDel').val()
                    },
                    success: function(data){
                        if(data === 'Deleted')
                        {
                            alert(""Record Successfully Deleted!"");
                            $('#deleteHLModal').modal('hide');
                            restForm();
                        }
                        else
                        {
                            alert(data);
                        }
                    },
              ");
            WriteLiteral(@"      error: function(data){
                        alert(data);
                    }
                });
            }
        });
    });

    function getHeadLines(){
        $.ajax({
            url: '/HeadLine/GetHeadLines',
            async: false,
            type: 'get',
            dataType: 'json',
            data: { title : $('#searchHL').val().trim() },
            success: function(data){
                var h ='', sn = 1;
                $.each(data, function(i, val){
                    h +='<tr>';
                    h +='<td style=""width:2%;"">'+ sn +'</td>';
                    h +='<td>'+ val.headLine +'</td>';
                    h +='<td style=""width:77%;""><div style=""width:100%; max-height:100px; overflow:auto"">'+ val.description +'</div></td>&nbsp;&nbsp;';
                    h +='<td style=""width: 13%;""><div class=""row""><div class=""col-md-6""><button type=""button"" data-id=""'+ val.id +'"" class=""editHL btn btn-sm btn-outline-info"">Edit</button></div>'+
          ");
            WriteLiteral(@"          '<div class=""col-md-6""><button type=""button"" data-id=""'+ val.id +'"" class=""deleteHL btn btn-sm btn-outline-danger"">Delete</button></td></div>';
                    h +='</tr>';
                    sn++;
                });
                $('#bodyHL').html(h);
            },
            error: function(data){
                alert(data);
            }
        });

    }

    function restForm(){
        getHeadLines();
        $('#idHL').val(0);
        $('#HLTitle').val('');
        $('#HLDes').summernote(""code"", '');
        $('#btnSaveHL').val('Save');
        $('#idHLDel').val(0);
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
