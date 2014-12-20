var kiriwaApp = angular.module("kiriwaApp", ["ngResource", "ngRoute"])
  .config(['$routeProvider', '$locationProvider', function ($routeProvider, $locationProvider) {
      $routeProvider.when("/Home", {
          templateUrl: "../../app/templates/home.html"//,
          //controller: "HomeController"
      });

      $routeProvider.otherwise({ redirectTo: "/Home" });

      $locationProvider.html5Mode(true);
  }]);