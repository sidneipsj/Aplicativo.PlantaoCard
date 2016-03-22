using Aplicativo.PlantaoCard.PhoneGap.Models;
using DAL;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Aplicativo.PlantaoCard.PhoneGap.Controllers
{
    public class CartaoController : ApiController
    {
        [HttpPost]
        public HttpResponseMessage Post([FromBody]Cartoes cartao)
        {

            //Instancia objeto do tipo Cartao
            var dalCartao = new DALCartao();
            string status = "false";
            Cartoes objCartao = new Cartoes();
            objCartao = cartao;

            string codCartImpr = objCartao.CodImp;
            string senha = objCartao.Senha;

            var codCartImpDB = DALCartao.BuscarCodCartImp(objCartao.CodImp);

            if (codCartImpDB.Equals("''"))
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, " Cartão não encontrado!");
            }
            //Cartao.validarCartao(codCartImpr);
            else
            {
                if (Cartao.verificarSenha(senha, codCartImpr) == true)
                {
                    HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
                    return response;
                }
                else
                {
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound, " Cartão ou Senha Inválidos!");
                }
                    
            }

            

            //return response;

            //DataTable dt;
            ////Obtem retorno do método BuscarCartaoTitular e preenche datatable dt
            //dt = DAL.DALCartao.BuscarCartaoTitular("174244");

            //cartao.Nome = dt.Rows[0]["nome"].ToString();
            //cartao.Codigodigito = dt.Rows[0]["codcartimp"].ToString();

            //  String status = "true";
            //return status;

        }

        //public String Post()
        //{
        //    return "Ola mundo!";
        //}
    }
}
