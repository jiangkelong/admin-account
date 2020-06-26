/*
axios请求响应拦截处理
需引入axios.js、vue.js
*/
var baseURL = "https://localhost:44361";
//var baseURL = "https://lsweapp.jiangkelong.com"
axios.defaults.baseURL = baseURL;
axios.defaults.headers.common["userid"] = localStorage.getItem("userId");
// 请求拦截（配置发送请求的信息）
axios.interceptors.request.use(function (config) {
    // 处理请求之前的配置
    return config;
}, function (error) {
    // 请求失败的处理
    return Promise.reject(error);
});


// 响应拦截（配置请求回来的信息）
axios.interceptors.response.use(function (response) {
    // 处理响应数据
    return response;
}, function (error) {
    // 处理响应失败
    if (error.response) {
        switch (error.response.status) {
            case 401:
                Vue.prototype.$confirm('登录失效，请重新登录', '提示', {
                    confirmButtonText: '确定',
                    type: 'warning'
                }).then(function () {
                    window.top.location = "/Home/Login";
                })
                break;
            default:
                Vue.prototype.$alert(error.response.status + "：" + error.response.data.Message);
                break;
        }
    }
    return Promise.reject(error);
});
Vue.prototype.$http = axios;