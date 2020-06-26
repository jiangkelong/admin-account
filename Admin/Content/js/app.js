//=================================取得QueryString的函数========================
function QueryString(qs) {
    s = location.href.split('#')[0];
    s = s.replace("?", "?&").split("&");
    re = "";
    for (i = 1; i < s.length; i++) {
        if (s[i].indexOf(qs + "=") == 0) {
            re = s[i].replace(qs + "=", "");
        }
    }
    return re.replace("#", "");
}