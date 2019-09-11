var app = angular.module("Homeapp", []);
app.controller("HomeController", function myfunction($scope, $http) {
    $scope.btntext = "Save";
    $scope.savedata = function () {

        $http({

        })
    }
});