function showPrompt1(message, icon) {
    Swal.fire({
        position: "top-end",
        icon: icon, //success, error, warning, info, question
        title: message,
        showConfirmButton: false,
        timer: 2000
      });
  } 