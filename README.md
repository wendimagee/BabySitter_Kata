# Babysitter_Kata
An app to calculate a babysitter's nightly charge

First Feature: Calculate total pay, based on babysitter start and end time, and a family.

First Unit test: Family A pays $15/hr before 11pm, and $20/hr the rest of the night
		 We will test for a night of babysitting from 7:00pm-10:00pm for family A

Explaining my logic: Because this problem involves a time statement, I believe I should 
write a MVC web app because the html approach to DateTime is so easy, efficient and easy to validate.
The first step would be to create a new ASP.NET MVC app and then:
	build a form on the index page to allow the user (babysitter in this case) to input start and end time
	route the information from the form to an action in the HomeController 
	Action Calculate() would use family A's regular rate $15/hr to calculate nightly rate
	Return Nightly Rate View();





