﻿using System.Runtime.InteropServices;
using BankingSite.Controllers;
using NUnit.Framework;
using TestStack.FluentMVCTesting;

namespace BankingSite.ControllerTests   
{
    [TestFixture]
    public class HomeControllerTests
    {
        [Test]
        public void ShouldRedirectToPluralsightForContact()
        {
            var sut = new HomeController();

            sut.WithCallTo(x => x.Contact()).ShouldRedirectTo("http://pli.edu");
            // Added comment to test task created in jira synced and git commits appear on JIRA
        }
    }
}
