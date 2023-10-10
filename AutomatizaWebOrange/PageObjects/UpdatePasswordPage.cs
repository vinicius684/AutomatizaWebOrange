using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;//*[@id="app"]/div[1]/div[2]/div[2]/div/div/form/div[1]/div/div[2]/div/div[2]/input

namespace AutomatizaWebOrange.PageObjects
{
    public class UpdatePasswordPage
    {
        public static By CurrentPassword = By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div/form/div[1]/div/div[2]/div/div[2]/input");
        public static By Password = By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div/form/div[2]/div/div[1]/div/div[2]/input");
        public static By ConfirmPassowrd = By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div/form/div[2]/div/div[2]/div/div[2]/input");

        public static By btSave = By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div/form/div[3]/button[2]");
        public static By CurrentPasswordInvalido = By.XPath("//*[@id=\"app\"]/div[1]/div[1]/aside/nav/div[2]");
        public static By UpdatePasswordSucesso = By.XPath("//*[@id=\"oxd-toaster_1\"]");
        public static By CurrentPasswordCampoObrigatorio = By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div/form/div[1]/div/div[2]/div/span");
    }
}
