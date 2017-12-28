/// <reference path="AngularJS.js" />
var app = angular
    .module("myModule", [])
    .controller("myController",
        function ($scope) {
            var employee = {
                firstName:'Dennis',
                lastName:'Ritchie',
                Gender:'Male',
                Country:'USA'
            };
            $scope.employee = employee;
        });
