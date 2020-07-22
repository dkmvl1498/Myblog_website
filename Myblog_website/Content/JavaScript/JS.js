
function signup() {
    $(".form-singup").removeClass("hidden");
    $(".form-login").addClass("hidden");
}


function backsignin() {
    $(".form-login").removeClass("hidden");
    $(".form-singup").addClass("hidden");
}


$(document).ready(function () {
    $("#btn-login").click(function (e) {
        e.preventDefault();
        var User = $("#user-login").val();
        var Pass = $("#pass-login").val();
        if (User == '') {
            $(".al-user").html('hãy nhập tài khoản');
            return false;
        }
        if (Pass == '') {
            $(".al-pass").html('hãy nhập mật khẩu');
            return false;
        }
        else {
            alert('địt mẹ ok');
            return false;
        }
    })

    $("#btn-create").click(function (e) {
        e.preventDefault();
        var cr_User = $("#create-user").val();
        var cr_Pass = $("#create-pass").val();
        var re_Pass = $("#create-re-pass").val();

        if (cr_User == '' || cr_Pass == '' || re_Pass == '') {
            $(".al-create").html('hãy điền đầy đủ thông tin');
            return false;
        }
        else {
            if (cr_Pass.length < 8) {
                $(".al-create").html('mật khẩu phải nhiều hơn 6 ký tự');
                return false;
            }
            else {
                if (cr_Pass != re_Pass) {
                    $(".al-create").html('mật khẩu nhập lại chưa đúng');
                    return false;
                }
                else {
                    alert('địt mẹ ok tiếp');
                    return false;
                }
            }
        }
    })
})