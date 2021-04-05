# Babysitter_Kata
An app to calculate a babysitter's nightly charge

How to run: I built this program using c#8 and .NET 5.0. If you have cloned my repo and 
have Visual Studio 2019 installed, simply open the repo folder and click on the 
file "BabySitter_Rate_Calculator.sln" and run the solution via IIS Express in your preferred web browser. 
Chrome or Microsoft Edge are recommended. 

I used Xunit through Visual Studio for my testing. I left in my old tests should you need to see them. 
They are commented out, and only the newest tests can/should run.
The tests I have documented in my BabySitterTests project in the ShiftTests file are for the following features:
- Pays different rates for each family (based on bedtimes, kids and pets, etc...)
- Family A pays $15 per hour before 11pm, and $20 per hour the rest of the night
- Family B pays $12 per hour before 10pm, $8 between 10 and 12, and $16 the rest of the night
- Family C pays $21 per hour before 9pm, then $15 the rest of the night
- The time ranges are the same as the babysitter (5pm through 4am)
- gets paid for full hours (no fractional hours)

I'm handling these features via html:
The babysitter:
- starts no earlier than 5:00PM
- leaves no later than 4:00AM
- only babysits for one family per night
- should be prevented from mistakes when entering times (e.g. end time before start time, or outside of allowable work hours)

Feature 1: Calculate rate for a regular shift with familyA
Feature 2: Calculate rate for late shift with familyA
Feature 3: Allow the user to choose a family to babysit
	a. Add a dropdown form to HTML page
	b. Route that information to Controller to build Shift model w/ familyRate
Feature 4: Make a corresponding rate calculator for family B
	a. Make a test for feature 4
	b. code feature 4
Feature 5. Make a corresponding rate calculator for family C
	a. Make a test for feature 5
	b. Code Feature 5
Feature 6. The time ranges are the same as the babysitter (5pm through 4am)
	a. restrict the model building via the Shift Model
	b. Alter the html page
Feature 7. Visual Appeal! 
	a. Display more information on Calculate View
Feature 8. More Testing. 





