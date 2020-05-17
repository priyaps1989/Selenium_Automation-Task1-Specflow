Feature: login
	In order to access my account 
	As a user of the website
	I want to login to my account

Scenario:Successfull login with valid credentials
	Given is at the homepage
	And navigate to the login page
	When enter username and password
	And click on the log in button
	Then successfully logged in to the account
	

