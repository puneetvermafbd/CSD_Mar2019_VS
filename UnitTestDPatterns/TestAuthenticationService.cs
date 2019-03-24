using System;
using System.Collections.Generic;
using DPatterns;
using FakeItEasy;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestDPatterns
{
    [TestClass]
    public class TestAuthenticationService
    {
        AuthenticationService authenticationService;

        [TestMethod]
        public void TestAuthenticate()
        {
            // make some fakes for the test
            var user = A.Fake<IUserInfo>();
            var dao = A.Fake<IDao>();
            var authenticationService = new AuthenticationService(dao);

            // set up a call to return a value
            A.CallTo(() => dao.GetUserByName(user.Name)).Returns(user);

            Assert.AreEqual(true, authenticationService.Authenticate(user));
        }
    }
}
