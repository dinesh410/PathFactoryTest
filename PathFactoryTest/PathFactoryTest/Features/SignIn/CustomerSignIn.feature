Feature: Customer Sign In
	In order to go to my account
	As a registered customer
	I want to sign in with my valid credentials

Background: 
	#Given I am in Sign In page

	@smoke @rainyPath
Scenario Outline: Enter invalid email ID and verify the warning shown
	Given I am in Sign In page
	When I enter invalid email address '<emailId>' 
	Then email address field should be highlighted red as warning
	 
	 Examples: 
	 | emailId               |
	 | test@ca               |
	 | test@abc.com@abc      |
	 | test.com@abc          |
	 | test.123abc.com.ca    |
	 | test123               |
	 | test.123.com          |
	 | test@.com             |
	 | @123.com              |
	 | *+47-$££$.123@abc.com |
	 |                       |

	@smoke @happyPath
Scenario Outline: Enter valid email ID and verify the approval
	Given I am in Sign In page
	When I enter valid email address '<emailId>' 
	Then email address field should be highlighted in green
	 
	 Examples: 
	 | emailId               |
	 | test@ca.com           |
	 | test.abc.com@abc.com  |
	 | test.123@abc.pe       |
	 | test.123@abc.com.ca   |
	 | test123@ab.bc.12.ca   |
	 | test@123.com          |
	 | test@automation.co.uk |
	 | test-abc@test.com     |

Scenario: Click Sign In button with no email address and password given and verify warning message
	Given I am in Sign In page
	When I click on Sign in button
	Then a warning message should be shown 'An email address required.'

Scenario: Click Sign In button with email address and no password given and verify warning message
	Given I am in Sign In page
	When I enter valid email address 'test@automation.co.uk' 
	And I click on Sign in button
	Then a warning message should be shown 'Password is required.'

Scenario: Enter valid email ID and incorrect password and verify the warning shown
	Given I am in Sign In page
	When I enter invalid email address 'test@aba.ca' 
	And I enter a password '1passwd'
	And I click on Sign in button
	Then a warning message should be shown 'Authentication failed.'

Scenario: Enter valid email ID and invalid password and verify the warning shown
	Given I am in Sign In page
	When I enter invalid email address 'test@aba.ca' 
	And I enter a password 'sswd'
	And I click on Sign in button
	Then a warning message should be shown 'Invalid password.'

Scenario: Enter invalid email ID and password and verify the warning shown
	Given I am in Sign In page
	When I enter invalid email address 'test@aba@' 
	And I enter a password '1*passwd'
	And I click on Sign in button
	Then a warning message should be shown 'Invalid email address.'
	 
# Log out tag used to get back to initial state for next tests
# Created a user manually for this test. Can use services to create user and make test 
@logout 
Scenario: Enter valid email ID and valid password and verify navigation to my account section
	Given I am in Sign In page
	When I enter valid emailid 'test@1.com' and password '123456'
	And I click on Sign in button
	Then I am on My account section

Scenario: When I click forgot password should navigate next section where I can retrieve it
	Given I am in Sign In page
	When I click on Forgot password link
	Then I am on Forgot your password page
	 

	
	
