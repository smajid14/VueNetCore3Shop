

function DeleteCate(id) {
  Swal.fire({
    title: 'آیا مطمئن هستید؟',
    text: "این دسته با تمام زیر دسته ها حذف خواهد شد",
    icon: 'warning',
    showCancelButton: true,
    confirmButtonColor: '#3085d6',
    cancelButtonColor: '#d33',
    confirmButtonText: 'بله حذف شود!',
    cancelButtonText: 'خیر'
  }).then((result) => {
    if (result.value) {
      $.ajax({
        url: '/Admin/Category/DeleteCategoryFromDb',
        type: "Post",
        dataType: "json",
        data: {
          id: id
        }
        ,
        success: function () {
          Swal.fire(
            '',
            'دسته با موفقیت حذف شد!',
            'success'
          )

          window.mtable.ajax.reload();
        }

      });


    }
  })
}

function EditModel(a) {

  Swal.fire({
    title: 'لطفا عنوان جدید را وارد کنید',
    input: 'text',
    //inputValue: inputValue,
    showCancelButton: true,
    confirmButtonText: 'ویرایش',
    cancelButtonText: 'انصراف',
    inputValidator: (value) => {
      if (!value) {
        return 'شما باید عنوان جدید را وارد کنید!!'
      }
    }
  }).then((value) => {
    if (value.value != null) {
      var Cattitle = value.value;
      var Catid = $(a).data("catid");

      $.ajax({
        url: '/Admin/Category/EditCategorInDb',
        type: "Post",
        dataType: "json",
        data: {
          CatId: Catid,
          CatTitle: Cattitle,
        },
        success: function () {
          Swal.fire(
            '',
            'دسته با موفقیت ویرایش شد!',
            'success'
          )

          window.mtable.ajax.reload();
        }

      });
    }

  });


}


