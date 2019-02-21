

 $(document).ready(function(){
     $('#btnShow').on('click', function () {
         var modelObj = {};
         modelObj.Ad = $("#txtAd").val();
         modelObj.Soyad = $("#txtSoyad").val();
         modelObj.Yas = $('#txtyas').val();
         modelObj.adres = $("#txtadres").val();
        
         $.ajax({
             type: 'POST',
             cache: false,
             url: 'Gonder',
             data: modelObj,

             success: function (data) {
               
                 //function openForm() {
                 //    document.getElementById("datatable").style.display = location.reload();
                 //}

                 alert("Mesajınız Başarılıyla İletilmiştir");
                 $("#txtAd").val('');
                 $("#txtSoyad").val('');
                 $("#txtyas").val('');
                 $("#txtadres").val('');

             },
             error: function (jqXHR, textStatus, errorThrown) {
                alert("Mesajınız Başarısızdır")
             }

         });
     });
 });
