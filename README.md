# Babysitter_Kata
An app to calculate a babysitter's nightly charge

How to run: If you have cloned my repo and have Visual Studio 2019 installed,
simply open the repo folder and click on the file "BabySitter_Rate_Calculator.sln"

First Feature: Calculate total pay, based on babysitter start and end time, and a family.

First Unit test: Family A pays $15/hr before 11pm, and $20/hr the rest of the night
		 We will test for a night of babysitting from 7:00pm-10:00pm for family A

Explaining my logic: Because this problem involves a time statement, I believe I should 
write a MVC web app because the html approach to DateTime is efficient and easy to validate.
The first step would be to create a new ASP.NET MVC app and then:
	build a form on the index page to allow the user (babysitter in this case) to input start and end time
	route the information from the form to an action in the HomeController 
	Action Calculate() would use family A's regular rate $15/hr to calculate nightly rate
	Return Nightly Rate View();

Second Unit Test: Family A pays $15/hr before 11pm, and $20/hr the rest of the night
		 We will test for a night of babysitting from 7:00pm-12:00am for family A





## Feature
*As a babysitter<br>
In order to get paid for 1 night of work<br>
I want to calculate my nightly charge<br>*

## Requirements
The babysitter:
- starts no earlier than 5:00PM
- leaves no later than 4:00AM
- only babysits for one family per night
- gets paid for full hours (no fractional hours)
- should be prevented from mistakes when entering times (e.g. end time before start time, or outside of allowable work hours)

The job:
- Pays different rates for each family (based on bedtimes, kids and pets, etc...)
- Family A pays $15 per hour before 11pm, and $20 per hour the rest of the night
- Family B pays $12 per hour before 10pm, $8 between 10 and 12, and $16 the rest of the night
- Family C pays $21 per hour before 9pm, then $15 the rest of the night
- The time ranges are the same as the babysitter (5pm through 4am)

Deliverable:
- Calculate total pay, based on babysitter start and end time, and a family.





