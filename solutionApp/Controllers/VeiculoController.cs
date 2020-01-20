using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using solutionApp.Models;

namespace solutionApp.Controllers
{
    [RoutePrefix("api/veiculo")]
    public class VeiculoController : ApiController
    {
        List<VeiculoModel> list = new List<VeiculoModel>();

        [Route("getveiculos")]
        public List<VeiculoModel> getVeiculos()
        {
            GetAllVeiculos();
            return list;
        }

        [Route("addVeiculo")]
        public List<VeiculoModel> addVeiculo([FromBody]VeiculoModel veiculo)
        {
            list.Add(veiculo);
            GetAllVeiculos();
            return list;
        }

        public List<VeiculoModel> GetAllVeiculos()
        {
            list.Add(new VeiculoModel
            {
                idVeiculo = 1,
                corVeiculo = "vermelho",
                marcaVeiculo = "Volks",
                modeloVeiculo = "Fuska",
                placaVeiculo = "ABC-0000"
            });

            list.Add(new VeiculoModel
            {
                idVeiculo = 2,
                corVeiculo = "verde",
                marcaVeiculo = "Volks",
                modeloVeiculo = "Fuska",
                placaVeiculo = "ABC-0001"
            });

            return list;
        }
    }
}