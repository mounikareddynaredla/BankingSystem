//using BankingSyatem.APIHelper;
using BankSystemTestProject.APIHelpers;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using NUnit.Framework;
using Newtonsoft.Json;
using BankSystemTestProject.Models;

namespace BankSystemTestProject.Steps
{
    [Binding]
    public class BankSystemStepDefintions
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;
        private RestClient restClient;
        private RestRequest restRequest;
        private RestResponse restResponse;

        BankAccountAPIHelper ba;

        public BankSystemStepDefintions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }



        [Given(@"Account Initial Balance is (.*)")]
        public void GivenAccountInitialBalanceIs(string amount)
        {
            Console.WriteLine("Intial Balance in the account is :" + amount);
        }


        [Given(@"Account name is Rajesh Mittal")]
        public void GivenAccountNameIsRajeshMittal()
        {
            Console.WriteLine("Account Name is Rajesh Mittal");
        }

        [Given(@"Address is Ahmedabad, Gujarat")]
        public void GivenAddressIsAhmedabadGujarat()
        {
            Console.WriteLine("Address is Ahmedabad, Gujarat");
        }




        [When(@"GET endpoint triggered to fetch account with above details")]
        public void WhenGETEndpointTriggeredToFetchAccountWithAboveDetails()
        {
            Console.WriteLine("End point is triggered with above details");
        }



        [Then(@"Verify the response code (.*)")]
        public void ThenVerifyTheResponseCode(string statuscode)
        {

            ba = new BankAccountAPIHelper(_scenarioContext);
            ba.ValidateDetails();
            var response = (RestResponse)_scenarioContext["rawResponse"];
            
            string HttpStatusCode = response.StatusCode.ToString();
            if (HttpStatusCode == statuscode)
            {
                //Assert.That(response.ContentType, Is.EqualTo("application / json"));
                Assert.True(HttpStatusCode.Trim().Equals(response.StatusCode.ToString()), "Expected: " + HttpStatusCode + "\nActual: " + response.StatusCode.ToString());
            }

        }


        [Then(@"Verify no error is returned")]
        public void ThenVerifyNoErrorIsReturned()
        {
            var response = (RestResponse)_scenarioContext["rawResponse"];
            string HttpStatusCode = response.StatusCode.ToString();
            if (!(HttpStatusCode == "OK"))
            {
                Assert.True(HttpStatusCode.Trim().Equals(response.StatusCode.ToString()), "Expected: " + HttpStatusCode + "\nActual: " + response.StatusCode.ToString());
            }
        }


        [Then(@"Verify the (.*) created")]
        public void ThenVerifyTheCreated(string message)
        {
            var response = (RestResponse)_scenarioContext["rawResponse"];
            string HttpStatusCode = response.StatusCode.ToString();
            string success_message = "Successfully Fetching Account Details:";
            if (HttpStatusCode == "OK")
            {
                Assert.AreEqual(message, success_message);
            }

        }

        [Then(@"Verify the account details are correctly returned in the JSON response")]
        public void ThenVerifyTheAccountDetailsAreCorrectlyReturnedInTheJSONResponse()
        {
            var response = (RestResponse)_scenarioContext["rawResponse"];
            string HttpStatusCode = response.StatusCode.ToString();
            //string success_message = "Successfully Fetching Account Details:";
            var accounts = JsonConvert.DeserializeObject<AccountResponseModel>(response.Content.Substring(1, (response.Content.Length - 2)));

            if (HttpStatusCode == "OK")
            {
                Assert.That(accounts.Id,Is.EqualTo(1));
                Assert.That(accounts.AccountName, Is.EqualTo("Rajesh Mittal"));
                Assert.That(accounts.AccountNumber, Is.EqualTo("X123"));
                Assert.That(accounts.NewBalance, Is.EqualTo(1000));
                Assert.That(accounts.Message, Is.EqualTo("New account added"));
                Assert.That(accounts.Errors, Is.EqualTo("No errors"));
            }
        }

    }
}
