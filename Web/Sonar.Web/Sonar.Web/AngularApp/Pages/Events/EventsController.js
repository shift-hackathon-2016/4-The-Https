EventsController.$inject = ["$scope", "$http"];
function EventsController($scope, $http) {
    $http.get('api/Eventsapi/GetAllEventsForUser').then(function (response) {
        $scope.events = response.data;
        console.log(response);
    });
}

sonar.controller('eventsController', EventsController);