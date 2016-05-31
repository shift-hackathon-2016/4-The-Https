(function (angular, app) {

    config.$inject = ["$routeProvider"];
    function config($routeProvider) {

        $routeProvider
         .when('/', new AngularPage('index'))
         .when('/login', new AngularPage('login'))
         .otherwise({ redirectTo: '/' });
    }

    function AngularPage(pageName) {
        this.templateUrl = 'AngularApp/Pages/' + pageName + '/' + pageName + '.html';
        this.controller = pageName + "Controller";
    }

    app.config(config);
})(angular, sonar);



