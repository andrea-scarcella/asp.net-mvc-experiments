function FirstCtrl($scope,Data) {
    $scope.data = Data;
};
//required by AngularJs 1.3, first argument of module is app name, also used in ng-app="app name"
angular.module('gettingStartedApp').controller('FirstCtrl', FirstCtrl);