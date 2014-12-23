kiriwaApp.factory("ObliqService", ['$http', '$q', function ($http, $q) {
    var _getStacksWithCardCount = function () {
        var _returnDefer = $q.defer();

        //console.log("service");

        $http({
            method: "GET",
            url: "/api/Obliq/GetStacksWithCardCount"
        })
        .success(function (data, status, headers, config) {
            //$log.info(data, status, headers(), config);
            //console.log(data);
            _returnDefer.resolve(data);
        })
        .error(function (data, status, headers, config) {
            //$log.warn(data, status, headers, config);
            _returnDefer.reject(status);
        });

        return _returnDefer.promise;
    };

    var _getStack = function(id) {
        var _returnDefer = $q.defer();

        $http({
            method: "GET",
            url: "/api/Obliq/GetStack/" + id
        })
        .success(function (data, status, headers, config) {
            //$log.info(data, status, headers(), config);
            //console.log(data);
            _returnDefer.resolve(data);
        })
        .error(function (data, status, headers, config) {
            //$log.warn(data, status, headers, config);
            _returnDefer.reject(status);
        });

        return _returnDefer.promise;
    };

    return {
        GetStacksWithCardCount: _getStacksWithCardCount,
        GetStack: _getStack
    };
}]);