appModulo.controller("vController", function ($scope, $window, veiculoRepository) {

    function listaveiculo() {
        veiculoRepository.getVeiculos().success(success).catch(fail);
        function sucess(data) {
            $scope.veiculos = data;
        }
    }

})