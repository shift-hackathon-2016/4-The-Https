(function (angular, app) {

    config.$inject = ["$routeProvider"];
    function config($routeProvider) {

        $routeProvider
         .when('/', new AngularPage('index'))
         .when('/login', new AngularPage('login'))
          .when('/profile', new AngularPage('profile'))
            .when('/friends', new AngularPage('Friends'))
            .when('/events', new AngularPage('Events'))
         .otherwise({ redirectTo: '/' });
    }

    function AngularPage(pageName) {
        this.templateUrl = 'AngularApp/Pages/' + pageName + '/' + pageName + '.html';
        this.controller = pageName + "Controller";
    }

    app.config(config);
})(angular, sonar);



