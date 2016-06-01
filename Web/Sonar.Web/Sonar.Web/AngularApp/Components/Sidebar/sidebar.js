function sidebar() {
    return {
        templateUrl: "AngularApp/Components/Sidebar/sidebar.html",
        scope: {},
        controller: sidebarController
    }
}

sidebarController.$inject = ["$rootScope","$scope", "$http"];
function sidebarController($rootScope,$scope, $http) {
    $http.get('api/friendsapi/GetAllFriendsForUser').then(function (response) {
        $scope.friends = response.data;
    });
    $http.get('api/eventsApi/GetAllEventsForUser').then(function (response) {
        $scope.events = response.data;
    });
    $http.get('Api/ProfileApi/Get/', { params: { id: userId } }).then(function (response) {
        $scope.profileViewModel = response.data;
        setOtherFields();
    });

    
}

sonar.directive('sidebar', sidebar);