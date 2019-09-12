var app = angular.module("Homeapp", []);
app.controller("HomeController", function myfunction($scope, $http) {
    $scope.btntext = "Save";
    $scope.savedata = function () {
        #scope.btntext = "Please Wait..";
        $http({
            method: "POST",
            url: '/Home/Add_record',
            data:$scope.register
        }).success(function (d) {
            $scope.btntext = "Save";
            $scope.register = null;
            alert(d);
            }).error(function myfunction() {
                alert('Failed');
            })
    }
});