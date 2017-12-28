
/// <reference path="AngularJS.js" />


var app = angular.module("myModule", ["ngRoute"])
    .config(function ($routeProvider, $locationProvider) {
        $routeProvider
            .when("/Home",
            {
                templateUrl: "Template/Home.html",
                controller: "homeController"
            })
            .when("/Courses",
            {
                templateUrl: "Template/Courses.html",
                controller: "courseController"
            })
            .when("/Students",
            {
                templateUrl: "Template/Students.html",
                controller: "studentsController"
            })
            .otherwise({ redirectTo: "/Home" });

        $locationProvider.html5Mode(true);
    })
    .controller("homeController",
        function ($scope) {
            $scope.PageHeading = "Home";
        })
    .controller("courseController",
        function ($scope) {
            $scope.PageHeading = "Course";
            $scope.courses = ["C", "C#", "Vb.NET", "ASP.NET", "MVC", "SQL Server", "AngularJS"];
        })
    .controller("studentsController",
        function ($scope, $http) {
            $scope.PageHeading = "Student";

            $http.get("studentService.asmx/GetAllStudentList")
                .then(function (response) {
                    $scope.students = response.data;
                });
        });