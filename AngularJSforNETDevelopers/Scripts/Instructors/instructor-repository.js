registrationModule.factory('instructorRepository', function ($http, $q) {
    return {
        get: function() {
            var defered = $q.defer();
            $http.get('/api/Instructors').success(defered.resolve).error(defered.reject);
            return defered.promise;
        }
    }
});