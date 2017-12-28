/// <reference path="AngularJS.js" />
var app = angular
    .module("myModule", [])
    .controller("myController",
        function ($scope) {
            var employee = {
                Name:'Jonson',
                Gender: 'Male',
                Department:'IT',
                Salary:'20000'
            };
            $scope.employee = employee;
        });
