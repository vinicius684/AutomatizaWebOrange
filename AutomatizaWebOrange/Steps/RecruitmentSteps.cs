using AutomatizaWebOrange.PageObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutomatizaWebOrange.Steps
{
    public class RecruitmentSteps : Inicializacao
    {
        public static void AdicionarCandidato(string FirstName, string MiddleName, string LastName, string Email)
        {
            Console.WriteLine("Realizar o click no botão Add");
            Driver.FindElement(RecruitmentPage.btAdd).Click();

            Console.WriteLine("Preencher campo First Name");
            Driver.FindElement(RecruitmentPage.FisrtName).SendKeys(FirstName);
            Thread.Sleep(5000);
            Console.WriteLine("Preencher campo Middle Name");
            Driver.FindElement(RecruitmentPage.MiddleName).SendKeys(MiddleName);
            Thread.Sleep(5000);
            Console.WriteLine("Preencher campo Last Name");
            Driver.FindElement(RecruitmentPage.LastName).SendKeys(LastName);
            Thread.Sleep(5000);
            Console.WriteLine("Preencher campo E-mail");
            Driver.FindElement(RecruitmentPage.Email).SendKeys(Email);
            Thread.Sleep(5000);
            Console.WriteLine("Realizar o click no botão Save");
            Driver.FindElement(RecruitmentPage.btSave).Click();
        }

    }
}
