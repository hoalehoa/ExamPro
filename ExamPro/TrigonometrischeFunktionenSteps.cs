using System;
using TechTalk.SpecFlow;
using Xunit;

namespace ExamPro
{
    [Binding]
    public class TrigonometrischeFunktionenSteps
    {
        Decimal phi;
        Decimal result;

        [Given(@"the angle alpha is (.*)")]
        public void GivenTheAngleAlphaIs(Decimal p0)
        {
            phi = p0;
        }

        [When(@"the sin function is pressed")]
        public void WhenTheSinFunctionIsPressed()
        {
            result = (Decimal)Math.Sin((double)phi);
        }

        [Then(@"the result for sine should be (.*)")]
        public void ThenTheResultForSineShouldBe(Decimal p0)
        {
            Assert.Equal(p0, result, 5);
        }

        [When(@"the cosin function is pressed")]
        public void WhenTheCosinFunctionIsPressed()
        {
            result = (Decimal)Math.Cos((double)phi);
        }

        [When(@"the tan function is pressed")]
        public void WhenTheTanFunctionIsPressed()
        {
            result = (Decimal)Math.Tan((double)phi);
        }

    }
}
