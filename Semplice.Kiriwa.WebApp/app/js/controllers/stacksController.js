kiriwaApp.controller("StacksController", ['$scope', 'ObliqService', function ($scope, ObliqService) {
    //console.log("contorller");
    //console.log(ObliqService);

    ObliqService.GetStacksWithCardCount().then(function (data) {
        //console.log(data);
        $scope.stacks = data;
    });
}]);