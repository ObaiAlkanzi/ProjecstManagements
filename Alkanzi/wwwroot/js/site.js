// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
var App = angular.module("MainModule", ["ngRoute"])
    .config(function ($routeProvider, $locationProvider) {
        $routeProvider
            .when("/Login", { templateUrl: "Home/Login", controller: "LoginController", controllerAs: "loginCtrl" })
            .when("/Users", { templateUrl: "Home/Users", controller: "UsersController", controllerAs: "UsersCtrl" })
        $locationProvider.html5Mode(true);
    })
    .controller("LoginController", function ($http) {
        var vm = this;
        this.login = function (name, pass) {
            $http.get("https://localhost:44362/api/Users/login?name=" + name + "&password=" + pass).then(function (res) {
                if (res["data"]) {
                    location.replace("/Users");
                }
            });
        }
    })
    .controller("UsersController", function ($http) {
        var vm = this;
        this.GetUsers = function () {
            $http.get("https://localhost:44362/api/Users/").then((res) => {
                vm.users = res["data"];
            });
        }
        this.setClass = function (userState) {
            if (userState) {
                return "active";
            } else {
                return "inactive";
            }
        }
        this.GetUsers();
    });


App.filter("userState", function () {
    return function (state) {
        switch (state) {
            case true:
                return "activate";
            case false:
                return "in activate";
            default:
                break;
        }
    }
})