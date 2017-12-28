/// <reference path="AngularJS.js" />
var app = angular
    .module("myModule", [])
    .controller("myController",
        function ($scope) {
            var employees = [
            { Name: 'Pam', Gender: 'Male', Department: 'IT', Salary: 20000 },
            { Name: 'Sara', Gender: 'Female', Department: 'HR', Salary: 25000 },
            { Name: 'John', Gender: 'Male', Department: 'Operation', Salary: 21000 },
            { Name: 'Ben', Gender: 'Male', Department: 'IT', Salary: 30000 }
            ];
            $scope.employees = employees;
        });
