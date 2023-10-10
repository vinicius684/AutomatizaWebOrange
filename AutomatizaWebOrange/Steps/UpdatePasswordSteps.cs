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
    public class UpdatePasswordSteps : Inicializacao
    {
        public static void UpdatePassword(string CurrentPassword, string Password, string ConfirmPassword)
        {
            Thread.Sleep(5000);
            Console.WriteLine("Preencher campo Current Password");
            Driver.FindElement(UpdatePasswordPage.CurrentPassword).SendKeys(CurrentPassword);
            Thread.Sleep(5000);
            Console.WriteLine("Preencher campo Password");
            Driver.FindElement(UpdatePasswordPage.Password).SendKeys(Password);
            Thread.Sleep(5000);
            Console.WriteLine("Preencher o campo Confirm Password");
            Driver.FindElement(UpdatePasswordPage.ConfirmPassowrd).SendKeys(ConfirmPassword);
            Thread.Sleep(5000);
            Console.WriteLine("Realizar o click no botão Login");
            Driver.FindElement(UpdatePasswordPage.btSave).Click();
        }

        public static void ValidarUpdatePasswordComCurrentPasswordInvalida(string CurrentPassword, string Password, string ConfirmPassword)
        {
            UpdatePassword(CurrentPassword, Password, ConfirmPassword);

            Console.WriteLine("Realizar a validação com a senha atual invalida");
            string CurrentPasswordInvalido = Convert.ToString(Driver.FindElement(UpdatePasswordPage.CurrentPasswordInvalido).Text);
            Assert.AreEqual("Error", CurrentPasswordInvalido, "Current Password Invalido assim como esperado");
        }

        public static void ValidarUpdatePasswordComCurrentPasswordValida(string CurrentPassword, string Password, string ConfirmPassword)
        {
            UpdatePassword(CurrentPassword, Password, ConfirmPassword);

            Console.WriteLine("Realizar a validação com senha atual valida");
            string UpdatePasswordSuccess = Convert.ToString(Driver.FindElement(UpdatePasswordPage.UpdatePasswordSucesso).Text);
            Assert.AreEqual("Success", UpdatePasswordSuccess, "Sucesso no update password");
        }

        public static void ValidarCampoCurrentPasswordObrigatorio(string CurrentPassword, string Password, string ConfirmPassword)
        {
            UpdatePassword(CurrentPassword, Password, ConfirmPassword);

            Thread.Sleep(5000);
            Console.WriteLine("Campo obrigatório Current Password validado com sucesso");
            string CurrentObrigatorio = Convert.ToString(Driver.FindElement(UpdatePasswordPage.CurrentPasswordCampoObrigatorio).Text);
            Assert.AreEqual("Required", CurrentObrigatorio, "Campo obrigatório Username validado com sucesso");
        }

    }
}
