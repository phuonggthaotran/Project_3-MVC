/// <reference path="angular.js" />
var app = angular.module('AppModule', []);

app.controller("MenuController", ($scope, $http) => {
    $http.get('/Home/GetJsonList').then(res => {
        $scope.menus = res.data;
    });
});

//app.controller("SanPhamController", ($scope, $http) => {
//     dùng hàm http.get, gọi đến url /Home/GetJsonList bên phía controller
//    $http.get('/Home/GetJsonListSP').then(res => {
//        $scope.hihi = res.data;
//    });
//});