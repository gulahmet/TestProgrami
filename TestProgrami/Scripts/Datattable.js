$(document).ready(function () {
    $('#datatable').DataTable(
        {

            "bJQueryUI": true,
            "sPaginationType": "full_numbers",
            "language": {
                "decimal": "",
                "emptyTable": "Tabloda mevcut kayıt yok",
                "info": " _TOTAL_ Kayıttan _START_ - _END_ Arası Kayıtlar",
                "infoEmpty": "Kayıt Yok",
                "infoFiltered": "( _MAX_ kayıt arasından filtrelendi)",
                "infoPostFix": "",
                "thousands": ",",
                "lengthMenu": "İlk _MENU_ kaydı göster ",
                "loadingRecords": "Yükleniyor...",
                "processing": "Arama yapılıyor, lütfen bekleyiniz",
                "search": "Arama:",
                "zeroRecords": "Aradığınız Kayıt Yok",
                "paginate":
                    {
                        "first": "ilk",
                        "last": "son",
                        "next": "sonraki",
                        "previous": "önceki"
                    },
                "aria": {
                    "sortAscending": ": activate to sort column ascending",
                    "sortDescending": ": activate to sort column descending"
                }


            }


        });
});