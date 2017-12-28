/// <reference path="AngularJS.js" />
var app = angular
    .module("myModule", [])
    .controller("myController",
        function ($scope) {
            var employees = [
            { Name: 'Pam', Gender: 'Male', Department: 'IT', Salary: 20000, Likes: 0, Dislikes: 0 },
            { Name: 'Sara', Gender: 'Female', Department: 'HR', Salary: 25000, Likes: 0, Dislikes: 0 },
            { Name: 'John', Gender: 'Male', Department: 'Operation', Salary: 21000, Likes: 0, Dislikes: 0 },
            { Name: 'Ben', Gender: 'Male', Department: 'IT', Salary: 30000, Likes: 0, Dislikes: 0 }
            ];
            $scope.employees = employees;

            $scope.incrementLikes= function(emp) {
                emp.Likes++;
            }

            $scope.incrementDisikes = function (emp) {
                emp.Dislikes++;
            }
        });