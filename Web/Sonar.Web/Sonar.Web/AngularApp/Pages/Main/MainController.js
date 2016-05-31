MainController.$inject = ["$scope", "$http"];
function MainController($scope, $http) {

    $scope.showModal = false;
    $scope.toggleModal = function () {
        $scope.showModal = !$scope.showModal;
    };

    $scope.mockEvents = [
        { id: 1, title: 'First event', lat: -34.397, long: 150.644 },
        { id: 1, title: 'wfsg event', lat: -34.297, long: 150.644 },
        { id: 1, title: 'First event', lat: -34.197, long: 150.644 },
        { id: 1, title: 'First event', lat: -34.097, long: 150.654 },
    ];
}

sonar.controller('mainController', MainController);