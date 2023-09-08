using UserLoginAssignment;

namespace SpecFlowUserLogin.StepDefinitions
{
    [Binding]
    public sealed class UserLoginStepDefinitions
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef
        private UserLogin login;
        private string msg;
        public UserLoginStepDefinitions(UserLogin userLogin)
        {
            login = userLogin;
        }

        [Given("the user name is (.*)")]
        public void GivenTheUserNameIs(string name)
        {
            login.UserName = name == "null" ? null : name;
        }

        [Given("the password is (.*)")]
        public void GivenThePasswordIs(string pwd)
        {
            login.Password = pwd == "null" ? null : pwd;
        }

        [When("the two fields are validated")]
        public void WhenTheTwoNumbersAreAdded()
        {
            msg = login.Login();
        }

        [Then("the message should be (.*)")]
        public void ThenTheResultShouldBe(string result)
        {
            msg.Should().Be(result);
        }
    }
}