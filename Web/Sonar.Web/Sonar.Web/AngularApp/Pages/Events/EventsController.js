EventsController.$inject = ["$rootScope","$scope", "$http"];
function EventsController($rootScope,$scope, $http) {
    $http.get('api/eventsApi/GetAllEventsForUser').then(function (response) {
        $scope.events = response.data;
        console.log(response);
    });
}

sonar.controller('eventsController', EventsController);