Feature: Regression


Scenario Outline: Get Account Details
Given Account Initial Balance is <amount>
And Account name is Rajesh Mittal
And Address is Ahmedabad, Gujarat
When GET endpoint triggered to fetch account with above details
Then Verify the response code <statuscode>
And Verify no error is returned
And Verify the <message> created
And Verify the account details are correctly returned in the JSON response


Examples:
| amount | statuscode | message |
|    $1000    |    OK        |  Successfully Fetching Account Details: |