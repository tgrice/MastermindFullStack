using Microsoft.Practices.Unity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MM.Core;
using MM.Core.Test;
using MM.WebApi.App_Start;
using MM.WebApi.Controllers;

namespace MM.WebApi.Tests.Controllers
{
    [TestClass]
    public class CreateGameControllerTests
    {
        [TestMethod]
        public void CreatesAGame()
        {
            var container = new UnityContainer();
            container
                .RegisterType<CreateGameController>()
                .RegisterType<ICodeGenerator, StaticCodeGenerator>();

            var cgCtrl = container.Resolve<CreateGameController>();

            var game = cgCtrl.Post();

            Assert.AreEqual("9999", game.Code);
        }

        [TestMethod]
        public void GameServerIsCreatedOnlyOnce()
        {
            var container = new UnityContainer();
            container
                .RegisterType<CreateGameController>()
                .RegisterType<ICodeGenerator, StaticCodeGenerator>()
                .RegisterType<GameServer>(new ContainerControlledLifetimeManager());

            var cgCtrl1 = container.Resolve<CreateGameController>();
            var cgCtrl2 = container.Resolve<CreateGameController>();

            Assert.AreSame(cgCtrl1.GameServer, cgCtrl2.GameServer);
        }
    }
}
