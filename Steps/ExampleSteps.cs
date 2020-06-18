using NUnit.Framework;
using TechTalk.SpecFlow;
using System;
using TechTalk.SpecFlow.Assist;

namespace SpecFlowPost30225Issue_Tests.Steps
{
    [Binding]
    public class ExampleSteps
    {
        int Result = 0;

        [When(@"I add (.*) to (.*)")]
        public void WhenIAddTo(string number1, string number2)
        {
            Result = Convert.ToInt32(number1) + Convert.ToInt32(number2);
        }
        
        [Then(@"the result is (.*)")]
        public void ThenTheResultIs(int result = 6)
        {
            Assert.True(result == Result);
        }

        [When(@"I add the follwing numbers")]
        public void WhenIAddTheFollwingNumbers(Table table)
        {
            dynamic attributes = table.CreateDynamicInstance();

            Result = attributes.Number1 + attributes.Number2;
        }

        [Then(@"the total is always correct")]
        public void ThenTheTotalIsAlwaysCorrect()
        {
            Assert.Pass();
        }

    }
}
