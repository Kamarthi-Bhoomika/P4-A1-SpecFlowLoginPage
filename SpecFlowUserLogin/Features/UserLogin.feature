Feature: UserLogin
![UserLogin](https://s3-alpha.figma.com/hub/file/3782986475/57be78a6-4e37-46bb-a7fd-232320886fa1-cover.png)
User login page to login to welcome page

Link to a feature: [UserLogin](SpecFlowUserLogin/Features/UserLogin.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**


@Login
Scenario: Successfull Login with valid credentials
	Given the user name is admin
	And the password is admin@123
	When the two fields are validated
	Then the message should be Welcome admin

@Login
Scenario: Login with invalid credentials
	Given the user name is notValid  
	And the password is notValid
	When the two fields are validated
	Then the message should be Invalid Credentials

@Login
Scenario: Empty username Fields
	Given the user name is null
	And the password is admin@123
	When the two fields are validated
	Then the message should be Please enter username

@Login
Scenario: Empty password Fields
	Given the user name is admin
	And the password is null
	When the two fields are validated
	Then the message should be Please enter password

@Login
Scenario: Empty Fields
	Given the user name is null
	And the password is null
	When the two fields are validated
	Then the message should be Please enter username and password