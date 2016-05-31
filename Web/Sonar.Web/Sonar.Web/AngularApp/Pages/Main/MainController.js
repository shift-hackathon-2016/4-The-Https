MainController.$inject = ["$rootScope", "$scope", "$http"];
function MainController($rootScope, $scope, $http) {
    $scope.newEvent = {};

    $scope.isAddNewEventButtonDisabled = function () {
        return !$scope.newEvent.name || !$scope.newEvent.description || !$scope.newEvent.eventType;
    };

    $scope.visibilityOptions = {
        isModalVisible: false,
        isAddEventModalVisible: false
    };

    $rootScope.$on('eventModalClosed', function () {
        $scope.visibilityOptions.isModalVisible = false;
        $scope.visibilityOptions.isAddEventModalVisible = false;
    });

    $scope.submitEvent = function () {
        $http.post('api/eventsApi/createEvent', $scope.newEvent).then(function (response) {
            console.log(response);
        }, function (error) {
            console.log(error);
        });
    };

    $http.get('api/eventsApi/GetAllEventsForUser').then(function (response) {
        $scope.events = response.data;
    });
}

sonar.controller('mainController', MainController);