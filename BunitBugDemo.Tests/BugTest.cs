namespace BunitBugDemo.Tests
{
    using Bunit;
    using BunitBugDemo.Components;
    using NUnit.Framework;

    [TestFixture]
    public class BugTest : TestContextWrapper
    {
        [SetUp]
        public void Init()
        {
            TestContext = new Bunit.TestContext();
            TestContext.ComponentFactories.AddStub<MyExampleSubComponent>();
        }

        [TearDown]
        public void TearDown()
        {
            TestContext?.Dispose();
        }

        [Test]
        public void RenderMyExampleComponent()
        {
            var component = RenderComponent<MyExampleComponent>();

            var heading = component.FindAll("h3");
        }
    }
}