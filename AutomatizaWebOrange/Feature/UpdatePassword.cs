using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomatizaWebOrange.Steps;

namespace AutomatizaWebOrange.Feature
{
    [TestClass]
    public class UpdatePassword : Inicializacao
    {
        [TestMethod]
        [TestCategory("01")]
        public void ValidarUpdatePasswordPreenchendoCurrentPasswordlInvalida()
        {
            WriteLine("Dado que: Acesse o site 'https://opensource-demo.orangehrmlive.com/web/index.php/pim/updatePassword'");
            WriteLine("E: Preencher os campos @Current Password, com senha invalida, @Password e @Confirm Password");
            WriteLine("Quando: Clicar no botão [Save]");
            WriteLine("Então: O sistema apresentará a mensagem 'Error'");

            UpdatePasswordSteps.ValidarUpdatePasswordComCurrentPasswordInvalida("123", "senha1234", "senha1234");
        }

        [TestMethod]
        [TestCategory("02")]
        public void ValidarUpdatePasswordPreenchendoCurrentPasswordValida()
        {
            WriteLine("Dado que: Acesse o site 'https://opensource-demo.orangehrmlive.com/web/index.php/pim/updatePassword'");
            WriteLine("E: Preencher os campos @Current Password, com senha valida, @Password e @Confirm Password ");
            WriteLine("Quando: Clicar no botão [Save]");
            WriteLine("Então: O sistema apresentará a mensagem 'Success'");

            UpdatePasswordSteps.ValidarUpdatePasswordComCurrentPasswordValida("Admin123", "senha1234", "senha1234");
        }

        [TestMethod]
        [TestCategory("03")]
        public void ValidarCurrentPasswordObrigatorioNoUpdatePassword() {
            WriteLine("Dado que: Acesse o site 'https://opensource-demo.orangehrmlive.com/web/index.php/pim/updatePassword'");
            WriteLine("E: Não preencher o campo @Current Password");
            WriteLine("E: Preencher os campos @Password e @Confirm Password ");
            WriteLine("Quando: Clicar no botão [Save]");
            WriteLine("Então: O Campo @Current Passoword ficará em destaque na cor vermelha e apresentará o alerta 'Required'");

            UpdatePasswordSteps.ValidarCampoCurrentPasswordObrigatorio("", "senha1234", "senha1234"); ;
        }
    }
}