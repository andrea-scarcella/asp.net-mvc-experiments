var gettingStartedApp=angular.module('gettingStartedApp', []);
gettingStartedApp.factory('Data', function () {
    return { message: "I'm data from a service!" };
});