registrationModule.controller("AccountController", function ($scope, accountRepository) {
    $scope.save = function(student) {
        accountRepository.save(student);
    };
});