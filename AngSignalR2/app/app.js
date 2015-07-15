(function () {
    'use strict';

    angular.module('app', [
    'ngRoute',
    'ngAnimate',
    'ngResource',
    'ngSanitize',
    'ngCookies',
    //'ngLoader',
    'ngMessages',
    'LocalStorageModule',
    'angular-loading-bar'
    ]);

    //angular.module('app').config(function ($routeProvider) {

    //    $routeProvider.when("/home", {
    //        controller: "homeController",
    //        templateUrl: "/app/views/main/home.html"
    //    });
    //    $routeProvider.otherwise({ redirectTo: "/home" });
    //});

    angular.module('app')
        .run(['$route', function ($route) {
        // Include $route to kick start the router.
    }]);
    
})();