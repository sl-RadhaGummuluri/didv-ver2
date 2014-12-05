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
    // Entry
    .when("/", {templateUrl: "partials/entry.html", controller: "EntryCtrl"})
    .when("/client/:id", { templateUrl: "partials/clientPage.html", controller: "ClientCtrl" })

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

app.controller('ClientCtrl', function ($scope, $location, $http, $routeParams, $anchorScroll) {

    var id = $routeParams.id;
    var req = {
        method: 'GET',
        url: 'http://gdl-l-gummuluri.us.ad.gannett.com/api/clients',
        headers: {
            'Content-Type': 'application/json'
        }
    }

    $http(req).success(function (data, status, headers, config) {
        var t = data;
        $scope.client = data[id - 1];
    }).error(function (data, status, headers, config) {
    });

    $scope.update = function () {

        var id = $scope.client.Id;
        var client = $scope.client;

        var dataObj = {
            val: $scope.client
        };

        var req = {
            method: 'POST',
            url: 'http://gdl-l-gummuluri.us.ad.gannett.com/api/clients',
            headers: {
                'Content-Type': 'application/json'
            },
            data: dataObj
        }

        $http(req).success(function (data, status, headers, config) {
            alert('worked');
        }).error(function (data, status, headers, config) {
        });
    }



    $('html, body').animate({
        scrollTop: $(".header_top").offset().top
    }, 1000);

    $("#clientinfo").click(function (e) {
        e.preventDefault();
        $('html, body').animate({
            scrollTop: $(".pod1").offset().top
        }, 1000);
    });

    $("#sitelinks").click(function (e) {
        e.preventDefault();
        $('html, body').animate({
            scrollTop: $(".pod2").offset().top
        }, 1000);
    });

    $("#apitrackinginfo").click(function (e) {
        e.preventDefault();
        $('html, body').animate({
            scrollTop: $(".pod3").offset().top
        }, 1000);
    });

    $("#compatibilityinfo").click(function (e) {
        e.preventDefault();
        $('html, body').animate({
            scrollTop: $(".pod4").offset().top
        }, 1000);
    });

    $("#siteaddons").click(function (e) {
        e.preventDefault();
        $('html, body').animate({
            scrollTop: $(".pod5").offset().top
        }, 1000);
    });

    $("#clientfeatures").click(function (e) {
        e.preventDefault();
        $('html, body').animate({
            scrollTop: $(".pod6").offset().top
        }, 1000);
    });

    $("#operationalinfo").click(function (e) {
        e.preventDefault();
        $('html, body').animate({
            scrollTop: $(".pod7").offset().top
        }, 1000);
    });

    $("#developmentinfo").click(function (e) {
        e.preventDefault();
        $('html, body').animate({
            scrollTop: $(".pod8").offset().top
        }, 1000);
    });

    $(".jumpToTop").click(function (e) {
        e.preventDefault();
        $('html, body').animate({
            scrollTop: $(".header_top").offset().top
        }, 1000);
    });

});


/** 
* Entry controller  
*/
app.controller('EntryCtrl', function ($scope, $location, $http, $routeParams) {
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

    var req = {
        method: 'GET',
        url: 'http://gdl-l-gummuluri.us.ad.gannett.com/api/clients',
        headers: {
            'Content-Type': 'application/json'
        }
    }

    $http(req).success(function (data, status, headers, config) {
        $scope.clients = data;
    }).error(function (data, status, headers, config) {
    });


    $scope.selectClient = function () {
        $scope.selectedvalue = $scope.selectedClientValue;
        $location.path('/client/' + $scope.selectedvalue);
    };

    $scope.selectPlatform = function () {

        $scope.filterClients = [];
        for (i = 0; i < $scope.clients.length - 1; i++) {
            var client = $scope.clients[i];
            if (client.platform == $scope.selectPlatformValue) {
                $scope.filterClients.push(client);
            }
        }
    };

    $scope.selectApiVersion = function () {
        $scope.filterClients = [];
        for (i = 0; i < $scope.clients.length - 1; i++) {
            var client = $scope.clients[i];
            if (client.apiversion == $scope.selectApiVersionValue) {
                $scope.filterClients.push(client);
            }
        }
    };

    $scope.selectCsdName = function () {
        $scope.filterClients = [];
        for (i = 0; i < $scope.clients.length - 1; i++) {
            var client = $scope.clients[i];
            if (client.csd == $scope.selectCsdNameValue) {
                $scope.filterClients.push(client);
            }
        }
    };

    $scope.selectFeature = function () {
        $scope.filterClients = [];
        $scope.platform = false;
        $scope.apiversion = false;
        $scope.csdname = false;
        $scope.other = false;
        $scope.selectYNValue = "default";
        $scope.selectCsdNameValue = "default";
        $scope.selectApiVersionValue = "default";

        if ($scope.selectFeatureValue > 3)
            $scope.other = true;
        if ($scope.selectFeatureValue == 1)
            $scope.apiversion = true;
        if ($scope.selectFeatureValue == 2)
            $scope.platform = true;
        if ($scope.selectFeatureValue == 3)
            $scope.csdname = true;
    }

    $scope.selectYN = function () {
        $scope.filterClients = [];

        //mobileoptimized
        if ($scope.selectFeatureValue == 4) {
            $scope.selectYNValue
            for (i = 0; i < $scope.clients.length - 1; i++) {
                var client = $scope.clients[i];
                if (client.mobileoptimized == $scope.selectYNValue) {
                    $scope.filterClients.push(client);
                }
            }
        }

        //tabletoptimized

        if ($scope.selectFeatureValue == 5) {
            $scope.selectYNValue
            for (i = 0; i < $scope.clients.length - 1; i++) {
                var client = $scope.clients[i];
                if (client.tabletoptimized == $scope.selectYNValue) {
                    $scope.filterClients.push(client);
                }
            }
        }

        //spanish

        if ($scope.selectFeatureValue == 6) {
            $scope.selectYNValue
            for (i = 0; i < $scope.clients.length - 1; i++) {
                var client = $scope.clients[i];
                if (client.spanish == $scope.selectYNValue) {
                    $scope.filterClients.push(client);
                }
            }
        }

        //french

        if ($scope.selectFeatureValue == 7) {
            $scope.selectYNValue
            for (i = 0; i < $scope.clients.length - 1; i++) {
                var client = $scope.clients[i];
                if (client.spanish == $scope.selectYNValue) {
                    $scope.filterClients.push(client);
                }
            }
        }

        //sneakpeek

        if ($scope.selectFeatureValue == 8) {
            $scope.selectYNValue
            for (i = 0; i < $scope.clients.length - 1; i++) {
                var client = $scope.clients[i];
                if (client.spanish == $scope.selectYNValue) {
                    $scope.filterClients.push(client);
                }
            }
        }

        //facebook

        if ($scope.selectFeatureValue == 9) {
            $scope.selectYNValue
            for (i = 0; i < $scope.clients.length - 1; i++) {
                var client = $scope.clients[i];
                if (client.spanish == $scope.selectYNValue) {
                    $scope.filterClients.push(client);
                }
            }
        }

        //dynamic pages

        if ($scope.selectFeatureValue == 10) {
            $scope.selectYNValue
            for (i = 0; i < $scope.clients.length - 1; i++) {
                var client = $scope.clients[i];
                if (client.spanish == $scope.selectYNValue) {
                    $scope.filterClients.push(client);
                }
            }
        }

        //googlemaps
        if ($scope.selectFeatureValue == 11) {
            $scope.selectYNValue
            for (i = 0; i < $scope.clients.length - 1; i++) {
                var client = $scope.clients[i];
                if (client.googlemaps == $scope.selectYNValue) {
                    $scope.filterClients.push(client);
                }
            }
        }

    }

    $scope.go = function () {
        var req = {
            method: 'GET',
            url: 'http://gdl-l-gummuluri.us.ad.gannett.com/api/clients',
            headers: {
                'Content-Type': 'application/json'
            }
        }

        $http(req).success(function (data, status, headers, config) {
            var t = data;
        }).error(function (data, status, headers, config) {
        });
    }

    $scope.gotoClient = function (id) {
        $location.path('/client/' + id);
    }
});  
