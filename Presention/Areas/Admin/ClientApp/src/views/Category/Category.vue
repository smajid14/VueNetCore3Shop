<template>

  <div class="row">
    <div class="col-lg-4">

      <div class="card card-primary">
        <div class="card-header no-border">
          <div class="d-flex justify-content-between">
            <h4 class="card-title">افزودن دسته جدید</h4>

          </div>
        </div>
        <div class="card-body">
          <form id="frmCat">

            <div class="form-group">
              <label class="control-label">عنوان دسته</label>
              <input class="form-control"
                     v-model.trim="$v.CatTitle.$model"
                     :class="{'is-invalid':$v.CatTitle.$error,'is-valid':!$v.CatTitle.$invalid}"
                     placeholder="عنوان دسته را وارد کنید" />
              <div class="valid-feedback">نام وارد شده معتبراست</div>
              <div class="invalid-feedback">
                <span v-if="!$v.CatTitle.required">  لطفا نام دسته را وارد کنید!  </span>
                <span v-if="!$v.CatTitle.minLength">  نام دسته حداقل باید {{$v.CatTitle.$params.minLength.min}} حرف باشد!  </span>
                <span v-if="!$v.CatTitle.maxLength">  نام دسته حداکثر باید {{$v.CatTitle.$params.maxLength.max}} حرف باشد!  </span>
              </div>

            </div>
            <div class="position-relative mb-4">
              <canvas id="visitors-chart" height="100"></canvas>
            </div>
            <div class="d-flex flex-row justify-content-end">
              <span class="ml-2">
                <button class="btn btn-success" id="btnSaveCat" :disabled="$v.$invalid" @click.prevent="AddToDb"><i id="loading" class="fa fa-save"></i> ذخیره</button>
              </span>
            </div>
          </form>
          </div>
      </div>
    </div>

    <!-- /.col-md-6 -->
    <div class="col-lg-8">
      <div class="card card-primary">
        <div class="card-header no-border">
          <div class="d-flex justify-content-between">
            <h4 class="card-title">لیست دسته های اصلی</h4>

          </div>
        </div>
        <div class="card-body" id="listCat">
          <table id="example2" class="table table-bordered table-striped table-hover text-center">
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

        </div>
      </div>
      <!-- /.card -->

    </div>
    <!-- /.col-md-6 -->
  </div>
</template>

<script>
  import { required, minLength,maxLength, between } from 'vuelidate/lib/validators'
  const axios = require('axios').default;
  export default {
    name: 'category',

    data() {
      return {
        CatTitle: '',
    
      }
    },
    validations: {

      CatTitle: {
        required,
        minLength: minLength(4),
        maxLength:maxLength(10)
      },
    },



    methods: {
      AddToDb() {
        try {
          if (!this.$v.$invalid) {
            $("#loading").addClass("fa-spin");
            var data = new FormData();
            data.append("CatTitle", this.CatTitle)
            axios.post('/Admin/category/InsertCatToDb', data).then(function (respons) {
              $("#loading").removeClass("fa-spin");
              window.mtable.ajax.reload()
              Swal.fire(
                '',
                'دسته با موفقیت ثبت شد',
                'success'
              )
            })
              .catch(function (error) {
                console.log(error);
              });
          }
          else {

            return null;
          }

        }
        catch{

        }

      }

    },

    mounted() {
      window.mtable = $('#example2').DataTable({
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

