loginController.$inject = ['$scope', '$http', '$window'];
function loginController($scope, $http, $window) {

    $scope.credentials = {
        username: '',
        password: ''
    };

    personData = {};

    $http.get('/Api/ProfileApi/GetByUsername/', $scope.credentials.username).then(function (response) {
        personData = response.data;
    });

    $scope.login = function () {
        console.log(personData.Username);
        if (personData != null) {
            localStorage.setItem("username", $scope.credentials.username);
            localStorage.setItem("password", $scope.credentials.password);
        }
    }
}

sonar.controller('loginController', loginController);