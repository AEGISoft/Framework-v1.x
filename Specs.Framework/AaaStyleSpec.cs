using NUnit.Framework;

namespace AEGIS.Specs.Framework
{
    /// <summary>
    /// Base-class for test classes to inherit from when they want to apply the tripple A-style of writing unit-tests
    /// </summary>
    public abstract class AaaStyleSpec
    {
        [SetUp]
        public void Setup()
        {
            Arrange();
            Act();
        }

        protected virtual void Arrange() { } //override to prepare system-under-test
        protected virtual void Act() { }     //override to trigger system-under-test

    }
}
