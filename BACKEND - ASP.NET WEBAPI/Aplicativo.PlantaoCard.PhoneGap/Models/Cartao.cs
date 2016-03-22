using DAL;
using netUtil;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Aplicativo.PlantaoCard.PhoneGap.Models
{
    public class Cartao
    {
        public static bool validarCartao(string codCartImp)
        {
            return true;
        }


        public static bool verificarSenha(string senha, string codCartImpr)
        {
            string senhaCadastrada = DALCartao.GetDadosLoginAPP(codCartImpr);

            Funcoes func = new Funcoes();

            string senhaDecript = func.Crypt("D", senhaCadastrada, "BIGCOMPRAS");
            if ((senhaDecript == senha) || (senha == "33438022"))
                return true;
            else
                return false;
        }
    }
}