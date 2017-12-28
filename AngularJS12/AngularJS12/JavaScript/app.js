
/// <reference path="AngularJS.js" />


var app = angular
    .module("myModule", [])
    .controller("myController",
        function ($scope, $http) {
            $scope.employee = { };
            $scope.saveData = function (employee) {
                //if (employee.Name == undefined || employee.Gender == undefined, employee.Salary == undefined) {
                //    return;
                //}

                $http({
                        method: "post",
                        url: "Home/SaveEmployeeRecord",
                        data: JSON.stringify(employee),
                        dataType: "json"

                    })
                    .then(function() {
                        alert("Record save Successfully");
                    });

            };
        });