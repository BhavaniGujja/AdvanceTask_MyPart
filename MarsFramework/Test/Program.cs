using NUnit.Framework;
using MarsFramework.Pages;
using MarsFramework.Global;
using System;
using NUnit.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using Assert = NUnit.Framework.Assert;

namespace MarsFramework
{
    [TestClass]
    public class Program
    {
        [TestFixture]
        [Category("Sprint1")]
        class User : Global.Base
        {

            [Test, Order(1)]
            public void SkillPage()         
            {
                test = extent.StartTest("Skills test started");
                Skills skills = new Skills();
                skills.AddSkill();
                skills.UpdateSkill();
                skills.DeleteSkill();

            }

            [Test, Order(2)]
            public void EducationPage()
            {
                test = extent.StartTest("Education test started");
                Education education = new Education();
                education.AddEducation();
                education.UpdateEducation();
                education.DeleteEducation();
            }
            [Test, Order(3)]
            public void CertificationPage()
            {
                test = extent.StartTest("Certification test started");
                Certification certification = new Certification();
                certification.AddCertification();
                certification.UpdateCertification();
                certification.DeleteCertification();
            }
            [Test, Order(4)]
            public void Profile()
            {
                test = extent.StartTest("Profile Description test started");
                Profile_Description profile = new Profile_Description();
                profile.AddDescription();
            }



        }
    }
}