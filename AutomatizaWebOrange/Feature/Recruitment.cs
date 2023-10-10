using AutomatizaWebOrange.Steps;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace AutomatizaWebOrange.Feature
{
    [TestClass]
    public class Recruitment : Inicializacao
    {
        [TestMethod]
        [TestCategory("01")]
        public void ValidarExclusaoDeCandidato()
        {
            WriteLine("Dado que: Acesse o site 'https://opensource-demo.orangehrmlive.com/web/index.php/recruitment/viewCandidates'");
            WriteLine("E: Marcar a caixa de seleção do candidato no lista de candidatos");
            WriteLine("E: Clicar no botão [Delete Selected]");
            WriteLine("Quando: Clicar no botão [Yes, Delete]");
            WriteLine("Então: O candidato selecionado deve ser excluido da lista de candidatos");

            UpdatePasswordSteps.ValidarUpdatePasswordComCurrentPasswordInvalida("123", "senha1234", "senha1234");
        }

        [TestMethod]
        [TestCategory("02")]
        public void AdicaoDeCandidato()
        {
            WriteLine("Dado que: Acesse o site 'https://opensource-demo.orangehrmlive.com/web/index.php/recruitment/viewCandidates'");
            WriteLine("E: Clique no Botão [+ Add]");
            WriteLine("E: E preencher os campos @Full Name e @E-mail");
            WriteLine("Quando: Clicar no botão [Save]");
            WriteLine("Então: Um novo candidado deve ser adicionado na lista da tela Recruitment");

            RecruitmentSteps.AdicionarCandidato("João", "Henriques", "Silva","joaohs334@gmail.com");
        }


    }
}
