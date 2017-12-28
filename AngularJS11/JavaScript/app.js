/// <reference path="Angular.js" />
var app = angular
    .module("myModule", [])
    .controller("myController",
        function ($scope, $http) {
            var successCallBack = function (response) {
                $scope.employees = response.data;
            }
            var errorCallBack = function (response) {
                $scope.error = response.data;
            }


            $http.get('EmployeeService.asmx/GetAllEmployeeList')
                .then(successCallBack, errorCallBack);

        }); 