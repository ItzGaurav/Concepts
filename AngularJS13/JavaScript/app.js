/// <reference path="AngularJS.js" />
var app = angular
    .module("myModule", [])
    .controller("myController",
        function ($scope, stringService) {
            $scope.input = "ABCD";
            $scope.process = function () {
                var inputstr = $scope.input;
                $scope.output = stringService.processString(inputstr);

            };

        });

