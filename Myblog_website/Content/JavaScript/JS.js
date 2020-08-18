
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
        var userName = $("#user-login").val();
        var pass_Word = $("#pass-login").val();
        if (userName == '') {
            $(".al-user").html('hãy nhập tài khoản');
            return false;
        }
        if (pass_Word == '') {
            $(".al-pass").html('hãy nhập mật khẩu');
            return false;
        }
        else {
            if (/^[a-zA-Z0-9- ]*$/.test(userName) == false) {
                $(".al-user").html('Tài khoản không được chứa ký tự đặc biệt');
            }
            else {
                var account = { userName, pass_Word };
                $.ajax(
                    {
                        url: "/Login/CheckLogin",
                        method: "POST",
                        data: { account },
                        success: function (result) {
                            if (result.Result == 'true') {
                                window.location.href = "/Home/Index";
                            }
                            else {
                                $(".al-pass").html('Sai tài khoản hoặc mật khẩu');
                                return false;
                            }
                        }
                    }
                )
            }
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