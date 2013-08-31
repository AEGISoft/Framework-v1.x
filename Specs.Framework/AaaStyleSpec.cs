using NUnit.Framework;

namespace AEGIS.Specs.Framework
{
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
