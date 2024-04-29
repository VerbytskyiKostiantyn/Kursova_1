$(document).ready(function () {
    $('#myTable').DataTable({
        language: {
            "decimal": "",
            "emptyTable": "Дані відсутні",
            "info": "",
            "infoEmpty": "",
            "infoFiltered": "(filtered from _MAX_ total entries)",
            "thousands": ",",
            "lengthMenu": "Показати _MENU_ рядків",
            "loadingRecords": "Завантаження...",
            "processing": "",
            "search": "Пошук:",
            "zeroRecords": "Не знайдено записів",
            "paginate": {
                "first": "Перший",
                "last": "Останній",
                "next": "Наступний",
                "previous": "Попередній"
            }
        },
        layout: {
            bottomStart: null,
            bottom: 'paging',
            bottomEnd: null,
            topEnd: {
                search: {
                    placeholder: 'Введіть запит'
                }
            },
        }
    });
});