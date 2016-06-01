function sidebar() {
    return {
        templateUrl: "AngularApp/Components/Sidebar/sidebar.html",
        scope: {},
        controller: sidebarController
    }
}

sidebarController.$inject = ["$rootScope","$scope", "$http"];
function sidebarController($rootScope,$scope, $http) {
    
   
    };

    


sonar.directive('sidebar', sidebar);