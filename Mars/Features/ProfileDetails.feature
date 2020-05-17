Feature: ProfileDetails
	In order to add certification
	As a profile user
	I want to see the added certificates and must be able to edit/delete certificates

@mytag
Scenario: add certificate
	Given user is logged in
	And entered certificate name, issuer, year
	When I press add
	Then the added certificate details should show

Scenario: edit certificate
	Given user is logged in
	And edited certificate name, issuer, year
	When I press edit
	Then the edited certificate details should show

Scenario: delete certificate
	Given user is logged in
	When I press delete particular certificate
	Then the certificate should be deleted

