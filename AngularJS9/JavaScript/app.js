/// <reference path="AngularJS.js" />
var app = angular
    .module("myModule", [])
    .controller("myController",
        function ($scope) {
            var employees = [
            { Name: 'Pam', DOB: new Date("October 20,1990"), Gender: 'Male', Department: 'IT', Salary: 20000 },
            { Name: 'Sara', DOB: new Date("November 22,1991"), Gender: 'Female', Department: 'HR', Salary: 25000 },
            { Name: 'John', DOB: new Date("February 02,1995"), Gender: 'Male', Department: 'Operation', Salary: 21000 },
            { Name: 'Ben', DOB: new Date("May 20,1990"), Gender: 'Male', Department: 'IT', Salary: 30000 }
            ];
            $scope.employees = employees;
            $scope.searchText = '';
            $scope.exectMatch = false;
        });
