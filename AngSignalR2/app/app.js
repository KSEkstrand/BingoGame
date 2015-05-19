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
    ]);

    angular.module('app')
        .config(function ($routeProvider) {
            $routeProvider.when("/", {
                controller: "homeController",
                templateUrl: "app/views/main/home.html"
            });

            $routeProvider.otherwise({ redirectTo: '/' });
        });
})();