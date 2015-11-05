﻿var registrationModule = angular.module("registrationModule", ['ngRoute'])
    .config(function ($routeProvider, $locationProvider) {
        $locationProvider.html5Mode(true);
        $routeProvider.when('/Registration/Courses', { templateUrl: '/templates/courses.html', controller: 'CoursesController' });
        $routeProvider.when('/Registration/Instructors', { templateUrl: '/templates/instructors.html', controller: 'InstructorsController' });
    });