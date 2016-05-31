ProfileController.$inject = ["$scope", "$http"];
function ProfileController($scope, $http) {
    //$http.get('Api/ProfileApi/GetProfile/', { id: 0 }).then(function (response) {
    $http.get('Api/ProfileApi/GetPerson/').then(function (response) {
        $scope.profileViewModel = response.data;
    });
}

sonar.controller('profileController', ProfileController);