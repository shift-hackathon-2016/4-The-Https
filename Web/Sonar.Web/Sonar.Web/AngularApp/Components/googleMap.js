mapDirective.$inject = [];
function mapDirective() {
	var apiKey = "AIzaSyDFN-6n_8rTK7x2sgRmONkTd7STu3yJpew";

	return {
		scope: {},
		template: '<div id="googleMap"></div>',
		controller: mapController,
		link: mapLink
	};
}

function mapController() {

}

function mapLink(scope, element, attrs) {
	var element = document.getElementById('googleMap');
	new google.maps.Map(element, {
		zoom: 8,
		center: new google.maps.LatLng(-34.397, 150.644)
	});
}

sonar.directive('googleMap', mapDirective);