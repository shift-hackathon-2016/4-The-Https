function sidebar() {
    return {
        templateUrl: "AngularApp/Components/Sidebar/sidebar.html",
        scope: {},
        controller: sidebarController
    }
}

sidebarController.$inject = ["$scope", "$http"];
function sidebarController($scope, $http) {
    $http.get('api/ProfileApi/Get/').then(function (response) {
        $scope.profile = response.data;
        console.log($scope.profile);
    });
}

sonar.directive('sidebar', sidebar);