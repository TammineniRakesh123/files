Feature: Paytm
	Open Paytm and validate its 'Mobile','Electricity','DTH','Metro' options and 
	later go ahead by validating all the elements present in the Mobile Tab
	#  Open paytm.com website in browser.
 # Validate 'Mobile','Electricity','DTH','Metro' optios are available.
 #Click 'Mobile' option and validate ' https://paytm.com/recharge' .
	# Enter Mobile number,select Operator,state and enter the Amount .
 #Click on 'Proceed to Recharge' then validate ' https://paytm.com/coupons'.
	#Click on 'Proceed to Pay'.


@mytag
Scenario: Add two numbers
	Given Open the Google Chrome Browser
	And Open the Paytm website
	And Select the Mobile Tab
	When I click on it
	Then the page gets redirected to https://paytm.com/recharge
	And  enter the mobile number
	And Select the Operator
	And Select the state
	
	
	And enter the Amount
	When clicked on 'Proceed to recharge'
	Then validate ' https://paytm.com/coupons'
