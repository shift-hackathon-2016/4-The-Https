FriendsController.$inject = ["$scope", "$http"];
function FriendsController($scope, $http) {
    $http.get('api/friendsapi/GetAllFriendsForUser').then(function (response) {
        $scope.friends = response.data;
    });
}

sonar.controller('friendsController', FriendsController);