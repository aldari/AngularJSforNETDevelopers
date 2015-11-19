'use strict';

registrationModule.factory('accountRepository', function ($resource) {
    return {
        save: function (student) {
            $resource('/Account/Save', student).save(student);
        }
    };
});