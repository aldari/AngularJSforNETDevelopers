registrationModule.factory('instructorRepository', function ($http, $q) {
    return {
        get: function() {
            var defered = $q.defer();
            $http.get('/Instructors').success(defered.resolve).error(defered.reject);
            return defered.promise;
        }
    }
});