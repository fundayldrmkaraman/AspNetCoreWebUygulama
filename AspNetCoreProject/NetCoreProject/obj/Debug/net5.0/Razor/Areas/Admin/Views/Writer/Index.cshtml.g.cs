#pragma checksum "C:\Users\Lenovo\source\repos\AspNetCoreProject\NetCoreProject\Areas\Admin\Views\Writer\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b369d9024ad826e01210298cd6d6cd889ee8bd94"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Writer_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Writer/Index.cshtml")]
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
#line 1 "C:\Users\Lenovo\source\repos\AspNetCoreProject\NetCoreProject\Areas\Admin\Views\_ViewImports.cshtml"
using NetCoreProject.Areas.Admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lenovo\source\repos\AspNetCoreProject\NetCoreProject\Areas\Admin\Views\_ViewImports.cshtml"
using NetCoreProject.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b369d9024ad826e01210298cd6d6cd889ee8bd94", @"/Areas/Admin/Views/Writer/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8873d1699c63e4cab35000896f45c983c2ea0274", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Writer_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Lenovo\source\repos\AspNetCoreProject\NetCoreProject\Areas\Admin\Views\Writer\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Yazar Ajax İşlemleri</h1>
<br/>
<button type=""button"" id=""btngetlist"" class=""btn btn-outline-primary"">Yazar Listesi </button>
<button type=""button"" id=""btngetbyid"" class=""btn btn-outline-success"">Yazar Getir </button>
<button type=""button"" id=""btnaddwriter"" class=""btn btn-outline-info"">Yazar Ekle </button>
<button type=""button"" id=""btndeletewriter"" class=""btn btn-outline-danger"">Yazar Sil </button>
<button type=""button"" id=""btnupdatewriter"" class=""btn btn-outline-warning"">Yazar Güncelle </button>
<br />
<br />
<div id=""writerlist"">
    Buraya Yazarlar Gelecek.
</div>
<br/>
<div id=""writerget"">

</div>
<br/>
<div>
    <input type=""text"" id=""writerid"" placeholder=""Yazar ID değerini girin"" class=""form-control""/>
</div>
<br />
<div>
    <input type=""text"" class=""form-control"" id=""txtwriterid"" placeholder=""Yazar ID "" />
    <input type=""text"" class=""form-control"" id=""txtwritername"" placeholder=""Yazar Adı "" />
</div>
<br/>
<div>
    <input type=""text"" class=""form-control"" id=""txtid""");
            WriteLiteral(@" placeholder=""Silinecek Yazar ID "" />
</div>
<br />
<div>
    <input type=""text"" class=""form-control"" id=""txtid1"" placeholder=""Güncellenecek ID "" />
    <input type=""text"" class=""form-control"" id=""txtwritername1"" placeholder=""Güncellenecek İsim "" />
</div>

");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>

        $(""#btngetlist"").click(function (){
            $.ajax({
                contentType:""application/json"",
                dataType:""json"",
                type:""GET"",
                url:""/Admin/Writer/WriterList/"",
                success:function(func){
                    let w = jQuery.parseJSON(func);
                    console.log(w);
                    let tablehtml = ""<table class=table table-bordered> <tr> <th> Yazar ID </th> <th> Yazar Adı </th></tr>"";
                    $.each(w,(index,value) => {
                        tablehtml += `<tr> <td> ${value.Id}</td> <td> ${value.Name}</td></tr>`
                    });
                    tablehtml += ""</table>"";
                    $(""#writerlist"").html(tablehtml);
                }
            });
        });

        $(""#btngetbyid"").click(x => {
            let id = $(""#writerid"").val();
            $.ajax({
                contentType: ""application/json"",
                dataType: ""json"",
        ");
                WriteLiteral(@"        type: ""GET"",
                url: ""/Admin/Writer/GetWriterByID/"",
                data: { writerid : id},
                success:function(func){
                    let w = jQuery.parseJSON(func); 
                    console.log(w);

                    let getvalue = `<table class=table table-bordered> <tr><th>Yazar ID</th> <th>Yazar Adı</th></tr>  <tr><td>${w.Id}</td> <td>${w.Name}</td></tr> </table>`;
                    $(""#writerget"").html(getvalue);
                }
            })
        });

        $(""#btnaddwriter"").click(function(){
            let writer={
                Id: $(""#txtwriterid"").val(),
                Name: $(""#txtwritername"").val()
            };
            $.ajax({
                type: ""Post"",
                url: ""/Admin/Writer/AddWriter/"",
                data:writer,
                success:function(func){
                    let result = jQuery.parseJSON(func);
                    alert(""Yazar Ekleme İşlemi Başarıyla Gerçekleştirilmiştir"");");
                WriteLiteral(@"
                }
            })
        })

        $(""#btndeletewriter"").click(x=>{
            let id = $(""#txtid"").val();
            $.ajax({
                url: ""/Admin/Writer/DeleteWriter/"" + id,
                type:""Post"",
                dataType:""json"",
                success: function (func) {
                    alert(""Yazar Silme İşlemi Başarıyla Gerçekleştirilmiştir"");
                }
            });
        });

        $(""#btnupdatewriter"").click(function(){
            let writer={
                Id: $(""#txtid1"").val(),
                Name: $(""#txtwritername1"").val()
            };
            $.ajax({
                type:""Post"",
                url: ""/Admin/Writer/UpdateWriter/"",
                data:writer,
                success:function(func){
                    alert(""Güncelleme Yapıldı."");
                }
            })
        })

    </script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
