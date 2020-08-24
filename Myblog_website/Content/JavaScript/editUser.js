function show_hide_edit1() {
    if ($("#edit-name").hasClass("hidden") == true) {
        $("#edit-name").removeClass("hidden");
    }
    else {
        $("#edit-name").addClass("hidden");
    }
}
function show_hide_edit2() {
    if ($("#edit-nickname").hasClass("hidden") == true) {
        $("#edit-nickname").removeClass("hidden");
    }
    else {
        $("#edit-nickname").addClass("hidden");
    }
}
function show_hide_edit3() {
    if ($("#edit-date").hasClass("hidden") == true) {
        $("#edit-date").removeClass("hidden");
    }
    else {
        $("#edit-date").addClass("hidden");
    }
}
function show_hide_edit4() {
    if ($("#edit-title").hasClass("hidden") == true) {
        $("#edit-title").removeClass("hidden");
    }
    else {
        $("#edit-title").addClass("hidden");
    }
}

function editname(idedit) {
    if (idedit == 'name') {
        var value = $("#nameuser").val();
    }
    if (idedit == 'nickname') {
        var value = $("#nickName").val();
    }
    if (idedit == 'dateOfBirth') {
        var value = $("#dateOB").val();
    }
    if (idedit == 'titleUser') {
        var value = $("#titleUser").val();
    }
    if (value == '') {
        alert('hãy điền thông tin trước!!');
    }
    else {
        $.ajax(
            {
                url: "/Home/editName",
                method: "Post",
                data: { value, idedit },
                success: function (result) {
                    if (result.Result == 'True') {
                        alert('Update Success');
                        $(".main-edit").load('/Home/ProFile_edit');
                        return true;
                    }
                    else {
                        alert(result.Result);
                        return false;
                    }
                }
            }
        )
    }
    
}

function show_hide_edit_pass() {
    if ($("#update_link").hasClass("hidden") == true) {
        $("#update_link").removeClass("hidden");
    }
    else
        $("#update_link").addClass("hidden");
}