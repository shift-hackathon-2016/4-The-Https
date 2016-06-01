function eventForm() {
    return {
        templateUrl: "AngularApp/Components/EventForm/eventForm.html",
        scope: {
            model: "="
        }
    }
}

sonar.directive('eventForm', eventForm);