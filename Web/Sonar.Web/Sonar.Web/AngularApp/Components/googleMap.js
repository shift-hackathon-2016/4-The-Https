var apiKey = "AIzaSyDFN-6n_8rTK7x2sgRmONkTd7STu3yJpew";
var googleMap = null;
var currentMarkers = [];

mapDirective.$inject = [];
function mapDirective() {

	return {
		scope: {
		    events: "=",
            visibilityOptions: "="
		},
		templateUrl: 'AngularApp/Components/googleMap.html',
		controller: mapController,
		link: mapLink
	};
}

mapController.$inject = ['$scope'];
function mapController($scope) {
    $scope.$watch('events', function (val) {
        currentMarkers = [];
        _($scope.events).each(function(event) {
            var marker = addMarkerToMap(event);

            marker.addListener('click', function () {
                $scope.visibilityOptions.isModalVisible = true;
                $scope.$apply();
            });
        });
    });
}

function addMarkerToMap(marker) {
    var position = new google.maps.LatLng(marker.lat, marker.long);
    var newMarker = new google.maps.Marker({
        position: position,
        map: googleMap,
        title: marker.title
    });

    currentMarkers.push(newMarker);
    return newMarker;
}

function mapLink(scope, element, attrs) {
	var element = document.getElementById('googleMap');
	googleMap = new google.maps.Map(element, {
		zoom: 9,
		center: new google.maps.LatLng(-34.397, 150.644)
	});

	googleMap.addListener("click", function (event) {
	    alert('add new event');
	});
}

sonar.directive('googleMap', mapDirective);