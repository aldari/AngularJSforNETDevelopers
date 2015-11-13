'use strict';

registrationModule.factory('accountRepository', function ($http, $q) {
    return {
        save: function(student) {
            $http.post('/Account/Save', student);
        }
    };
});