appModulo.factory("veiculoRepository", function ($resource, $http) {
    var baseUrl = "";

    return {
        getVeiculos: function () {
            return $http({ method: 'get', url: baseUrl + '/api/veiculo/getVeiculos', headers: { 'Content-Type': 'application/json;charset=UTF-8' } });
        },
        postVeiculo: function (modelVeiculo) {
            return $http({ method: 'post', url: baseUrl + '/api/veiculo/addVeiculo', params: modelVeiculo, headers: { 'Content-Type': 'application/json;charset=UTF-8' } });
        }
    }
});