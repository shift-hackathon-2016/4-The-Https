MainController.$inject = ["$rootScope", "$scope", "$http"];
function MainController($rootScope, $scope, $http) {

    $scope.visibilityOptions = {
        isModalVisible: false,
        isAddEventModalVisible: false
    };

    $rootScope.$on('eventModalClosed', function () {
        $scope.visibilityOptions.isModalVisible = false;
        $scope.visibilityOptions.isAddEventModalVisible = false;
    });

    $scope.submitEvent = function() {
        throw Error('not implemented');
    };

    $http.get('api/eventsApi/GetAllEventsForUser').then(function (response) {
        $scope.events = response.data;
    });
}

sonar.controller('mainController', MainController);