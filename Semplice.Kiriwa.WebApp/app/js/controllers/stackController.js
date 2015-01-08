﻿kiriwaApp.controller("StackController", ['$scope', '$routeParams', '$interval', 'ObliqService', function ($scope, $routeParams, $interval, ObliqService) {
    // LEARN: document.ready() in Angular JS
    // http://stackoverflow.com/questions/18646756/how-to-run-function-in-angular-controller-on-document-ready
    $scope.init = function () {
        // LEARN: $http call complete
        // http://stackoverflow.com/questions/17181508/after-angular-js-http-request-call-complete-function-regardless-of-success-or
        ObliqService.GetStack(_stackId).then(function (data) {
            $scope.cards = data.Cards;
        }).then(function() {
            _resetPlayingList();
            // LEARN: $interval use $apply internally, which will keep two way binding between model and view
            // http://www.sitepoint.com/understanding-angulars-apply-digest/
            _slideshowInterval = $interval(_slideshow, $scope.settings.slideshowDelay);
        });
    };

    var _stackId = $routeParams.stackId,
        _playing = [],
        // _played may not be necessary
        _played = [],
        _slideshowInterval;

    $scope.settings = {
        repeat: false,
        shuffle: true,
        // slideshow may not be necessary
        slideshow: "auto",
        slideshowDelay: 1500,
        state: "play"
    };

    $scope.changeRepeat = function() {
        if ($scope.settings.repeat) {
            $scope.settings.repeat = false;
            return;
        }

        $scope.settings.repeat = true;
    };
    $scope.changeShuffle = function () {
        if ($scope.settings.shuffle) {
            $scope.settings.shuffle = false;
            return;
        }

        $scope.settings.shuffle = true;
    };
    $scope.changeSlideshow = function () {
        if ($scope.settings.slideshow == "auto") {
            $scope.settings.slideshow = "manual";
            return;
        }

        $scope.settings.slideshow = "auto";
    };
    $scope.changeState = function (state) {
        if (state == undefined)
            state = "pause";

        if ($scope.settings.state == "play") {
            $interval.cancel(_slideshowInterval);
            $scope.settings.state = state;
            return;
        }

        _resetPlayingList();
        _slideshowInterval = $interval(_slideshow, $scope.settings.slideshowDelay);
        $scope.settings.state = "play";
    };

    var _resetPlayingList = function() {
        if (_playing.length == 0) {
            _played = [];
            _playing = $scope.cards.slice(0);
        }
    }

    var _slideshow = function () {
        console.log("_shuffle=" + $scope.settings.shuffle);
        console.log("_playing.length=" + _playing.length);

        var _playingNumber;
        if ($scope.settings.shuffle)
            _playingNumber = Math.floor((Math.random() * _playing.length));
        else
            _playingNumber = 0;

        //console.log(_playing[_playingNumber]);
        console.log("_playingNumber=" + _playingNumber);
        console.log("_playing[_playingNumber]=" + _playing[_playingNumber]);
        console.log("_playing=" + _playing);
        
        $("#divCard").text(_playing[_playingNumber].FrontText);

        _played.push(_playing[_playingNumber]);
        _playing.splice(_playingNumber, 1);

        console.log("---------------");

        if (_playing.length === 0) {
            ShowDebugging();

            if ($scope.settings.repeat) {
                _resetPlayingList();
            }
            else {
                $scope.changeState("stop");
            }
        }
    };

    function ShowDebugging() {
        console.log("===========================================");
        //console.log("_playlist");
        //console.log($scope.cards);
        console.log("_playing");
        console.log(_playing);
        console.log("_played");
        console.log(_played);
        console.log("$scope.settings");
        console.log($scope.settings);
        console.log("===========================================");
    };
}]);