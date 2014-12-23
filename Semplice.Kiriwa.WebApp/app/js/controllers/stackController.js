kiriwaApp.controller("StackController", ['$scope', '$routeParams', 'ObliqService', function ($scope, $routeParams, ObliqService) {
    //console.log("contorller");
    //console.log(ObliqService);

    var _stackId = $routeParams.stackId;
    //console.log(_stackId);

    ObliqService.GetStack(_stackId).then(function (data) {
        //console.log(data);
        $scope.cards = data.Cards;
    });
}]);