Feature: RegisterPageFeature
As a visitor
I want to be able to register in the website
So that I can vote for a sport car

# Pass test if you provide valid data that not registered before
# Change email address
@Automate 
Scenario: Check if user can Register with valid data
	Given  I navigate to the registration page
	When  I  Register with following Data
	| Email               | FirstName | LastName | Password | ConfirmPassword |
	| Edta.bcaa@gmail.com | Aaaa       | Baaa      | A@aa1234 | A@aa1234         |
	Then I should get message "Registration is successful"

@Automate 
Scenario: Check if user already exists
	Given  I navigate to the registration page
	And I have already registered with following data
	| Email               | FirstName | LastName | Password | ConfirmPassword |
	| Aaaa.baaa@gmail.com | Aaaa       | Baaa      | A@aa1234 | A@aa1234         |
	Then I should get message "User already exists"
	
	
@Automate 
Scenario: Check if password valid
	Given  I navigate to the registration page
	When  I have enter invalid password 
	| Email               | FirstName | LastName | Password | ConfirmPassword |
	| Edtw.baaa@gmail.com | Aaaa       | Baaa      | A@aa123 | A@aa123        |
	Then I should get message "InvalidPasswordException"
