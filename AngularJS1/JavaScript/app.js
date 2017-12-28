/// <reference path="AngularJS.js" />
var app = angular
    .module("myModule", [])
    .controller("myController",
        function ($scope) {
            $scope.message = "Hello World !";
        });