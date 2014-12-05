/**
 * AngularJS Tutorial 1
 * @author Nick Kaye <nick.c.kaye@gmail.com>
 */

/**
 * Main AngularJS Web Application
 */
var app = angular.module('tutorialWebApp', [
  'ngRoute'
]);

/**
 * Configure the Routes
 */
app.config(['$routeProvider', function ($routeProvider) {
  $routeProvider
    // Home
    .when("/", {templateUrl: "partials/entry.html", controller: "EntryCtrl"})
    // Pages
    .when("/about", {templateUrl: "partials/about.html", controller: "PageCtrl"})
    .when("/faq", {templateUrl: "partials/faq.html", controller: "PageCtrl"})
    .when("/pricing", {templateUrl: "partials/pricing.html", controller: "PageCtrl"})
    .when("/services", {templateUrl: "partials/services.html", controller: "PageCtrl"})
    .when("/contact", {templateUrl: "partials/contact.html", controller: "PageCtrl"})
    // Blog
    .when("/blog", {templateUrl: "partials/blog.html", controller: "BlogCtrl"})
    .when("/blog/post", {templateUrl: "partials/blog_item.html", controller: "BlogCtrl"})
    // else 404
    .otherwise("/404", {templateUrl: "partials/404.html", controller: "PageCtrl"});
}]);

/**
 * Controls the Blog
 */
app.controller('BlogCtrl', function (/* $scope, $location, $http */) {
  console.log("Blog Controller reporting for duty.");
});

/**
 * Controls all other Pages
 */
app.controller('PageCtrl', function (/* $scope, $location, $http */) {
  console.log("Page Controller reporting for duty.");

  // Activates the Carousel
  $('.carousel').carousel({
    interval: 5000
  });

  // Activates Tooltips for Social Links
  $('.tooltip-social').tooltip({
    selector: "a[data-toggle=tooltip]"
  })
});

/** 
* Entry controller  
*/
app.controller('EntryCtrl',	function ($scope, $location, $http) {
	$scope.selectedClientValue = "default";
	$scope.selectPlatformValue = "default";
	$scope.selectApiVersionValue = "default";
	$scope.selectCsdNameValue = "default";
	$scope.selectFeatureValue = "default";
	$scope.selectYNValue = "default";

	$scope.platform = false;
	$scope.apiversion = false;
	$scope.csdname = false;
	$scope.other = false;


	$scope.selectClient = function(){
	    $scope.selectedvalue = $scope.selectedChoice;

	    var req = {
	        method: 'GET',
	        url: 'http://localhost/api/clients',
	        headers: {
	            'Content-Type': 'application/json'
	        }
	    }

	    $http(req).success(function (data, status, headers, config) {
	        var t = data;
	    }).error(function (data, status, headers, config) {
	    });

	};

	$scope.selectPlatform = function(){

	};

	$scope.selectApiVersion= function(){

	};

	$scope.selectHeaderFooter= function(){

	};

	$scope.selectCsdName= function(){

	};

	$scope.selectAccountManager= function(){

	};

	$scope.selectFeature= function(){
		$scope.platform = false;
		$scope.apiversion = false;
		$scope.csdname = false;
		$scope.other = false;

		if($scope.selectFeatureValue > 3)
			$scope.other = true;
		if($scope.selectFeatureValue ==1)
			$scope.apiversion =true;
		if($scope.selectFeatureValue ==2)
			$scope.platform =true;
		if($scope.selectFeatureValue ==3)
			$scope.csdname =true;
	}

	$scope.selectYN= function(){
		
	}

	$scope.go = function () {
	    var req = {
	        method: 'GET',
	        url: 'http://localhost/api/clients',
	        headers: {
	            'Content-Type': 'application/json'
	        }
	    }

	    $http(req).success(function (data, status, headers, config) {
	        var t = data;
	    }).error(function (data, status, headers, config) {
	    });
	}

});  
