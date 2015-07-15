(function () {
    'use strict';

    angular.module('app').constant('routes', getRoutes());


    angular.module('app')
    .config(['$routeProvider', 'routes', routeConfigs]);

    function routeConfigs($routeProvider, routes) {
        routes.forEach(function (r) {
            $routeProvider.when(r.url, r.config);
        });
        $routeProvider.otherwise({ redirectTo: '/' });
    };

    function getRoutes() {
        return [
            {
                url: '/',
                config: {
                    templateUrl: 'app/views/main/home.html',
                    controller: 'homeController',
                    title: 'Home',
                    settings: {
                        nav: 1
                    }
                }
            },

            {
                url: '/register',
                config: {
                    templateUrl: 'app/views/register/register.html',
                    controller: 'registerController',
                    title: 'Register',
                    settings: {
                        nav: 2
                    }
                }
            },

            {
                url: '/login',
                config: {
                    templateUrl: 'app/views/login/login.html',
                    controller: 'loginController',
                    title: 'Login',
                    settings: {
                        nav: 3
                    }
                }
            }
        ];
    };
})();