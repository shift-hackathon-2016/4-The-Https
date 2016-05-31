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

    $scope.mockEvents = [
        { id: 1, title: 'First event', lat: 43.5117689, long: 150.644 },
        { id: 1, title: 'wfsg event', lat: 43.5117619, long: 16.46921094998 },
        { id: 1, title: 'First event', lat: 43.5117419, long: 150.644 },
        { id: 1, title: 'First event', lat: -34.097, long: 150.654 },
    ];
}

sonar.controller('mainController', MainController);