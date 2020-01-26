
  <tamplate>
    <table id="example3" class="table table-bordered table-striped table-hover text-center">
      <thead>
        <tr>
          <th>ردیف</th>
          <th>عنوان</th>
          <th>عملیات</th>

        </tr>
      </thead>
      <tbody>
      </tbody>

    </table>

  </tamplate>
<script>
  export default {
    name: 'datatable',
    data() {

    },
    data: {

      CatTitle: ''
    },
    created() {

    },
    methods: {
 

    },
    mounted() {
      window.mtable = $('#example3').DataTable({
        "language": {
          "paginate": {
            "next": "بعدی",
            "previous": "قبلی"
          },
          "search": 'جستجو:',
        },

        "ajax": {
          "url": '/Admin/category/loadAjax',
          "type": "Post",
          "dataType": "json",

        },

        "columns": [
          { "data": "row", name: "row" },
          { "data": "onvan", name: "onvan" },
          { "data": "opr", name: "opr" },

        ],
        "serverSide": "true",
        "processing": "true",
        "info": false,
        "paging": true,
        "lengthChange": false,
        "searching": true,
        "ordering": true,
        "autoWidth": false,
        "pageLength": 5,
      })
    },

  }
</script>
