var apiKey = "AIzaSyDFN-6n_8rTK7x2sgRmONkTd7STu3yJpew";
var googleMap = null;
var currentMarkers = [];
var DEFAULT_ZOOM = 13;

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
                $scope.visibilityOptions.isEventDetailsModalVisible = true;
                $scope.$apply();
            });
        });
    });
}

function addMarkerToMap(marker) {
    var position = new google.maps.LatLng(marker.Latitude, marker.Longitude);
    var newMarker = new google.maps.Marker({
        position: position,
        map: googleMap,
        title: marker.Name
    });

    newMarker.description = marker.Description;
    newMarker.authorName = marker.AuthorName;

    currentMarkers.push(newMarker);
    return newMarker;
}

function mapLink(scope, element, attrs) {
    var element = document.getElementById('googleMap');

	googleMap = new google.maps.Map(element, {
		zoom: DEFAULT_ZOOM
	});

	getCurrentLocationAndCenter();

	googleMap.addListener("click", function (event) {
	    scope.visibilityOptions.isAddEventModalVisible = true;
	    scope.$apply();
	});
}

function getCurrentLocationAndCenter() {
    navigator.geolocation.getCurrentPosition(function (position) {
        var pos = {
            lat: position.coords.latitude,
            lng: position.coords.longitude
        };
        var image = {
            url: 'https://developers.google.com/maps/documentation/javascript/examples/full/images/beachflag.png',
            // This marker is 20 pixels wide by 32 pixels high.
            size: new google.maps.Size(20, 32),
            // The origin for this image is (0, 0).
            origin: new google.maps.Point(0, 0),
            // The anchor for this image is the base of the flagpole at (0, 32).
            anchor: new google.maps.Point(0, 32)
        };
        googleMap.setCenter(pos);
        new google.maps.Marker({ position: pos, map: googleMap, animation: google.maps.Animation.DROP,icon:image });
        googleMap.setZoom(DEFAULT_ZOOM);(position.lat, position.lng);
    }, function () {
        alert('geolocation disabled');
    });
}


sonar.directive('googleMap', mapDirective);