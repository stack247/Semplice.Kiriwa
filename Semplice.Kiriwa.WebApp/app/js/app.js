var kiriwaApp = angular.module("kiriwaApp", ["ngResource", "ngRoute", "ngAnimate"])
  .config(['$routeProvider', '$locationProvider', function ($routeProvider, $locationProvider) {
      $routeProvider.when("/Home", {
          templateUrl: "../../app/templates/home.html"//,
          //controller: "HomeController"
      });

      $routeProvider.when("/Stacks", {
          templateUrl: "../../app/templates/stacks.html",
          controller: "StacksController"
      });

      $routeProvider.when("/Stack/:stackId", {
          templateUrl: "../../app/templates/stack.html",
          controller: "StackController"
      });

      $routeProvider.otherwise({ redirectTo: "/Home" });

      $locationProvider.html5Mode(true);
  }]);