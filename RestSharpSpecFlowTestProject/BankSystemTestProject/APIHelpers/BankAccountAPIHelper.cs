//using BankingSyatem.Model;
using BankSystemTestProject.Models;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.NUnit;

namespace BankSystemTestProject.APIHelpers
{
    public class BankAccountAPIHelper
    {
        private readonly ScenarioContext _scenarioContext;



        public BankAccountAPIHelper(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;

        }
        public void ValidateDetails()
        {
            try
            {
                //RestClient client = new RestClient("https://localhost:44391");

                RestClient client = new RestClient(new RestClientOptions
                {
                    BaseUrl = new Uri("http://localhost:44391")
                });

                

                var request = new RestRequest("https://localhost:44391/api/v1/Accounts");
                request.RequestFormat = DataFormat.Json;

                RestResponse response = client.Get(request);


                _scenarioContext["rawResponse"] = response;
                if (response.StatusCode.Equals(HttpStatusCode.OK))
                {
                    Console.WriteLine("Successfully Fetching Account Details: " + response.Content);
                    var accounts = JsonConvert.DeserializeObject<AccountResponseModel>(response.Content.Substring(1, (response.Content.Length-2)));
                }

                else if (response.StatusCode.Equals(HttpStatusCode.BadRequest))
                {
                    Console.WriteLine(response.Content);
                    var accounts = JsonConvert.DeserializeObject<AccountResponseModel>(response.Content);
                }

                else if (response.StatusCode.Equals(HttpStatusCode.InternalServerError))
                {
                    Console.WriteLine(response.Content);
                    var accounts = JsonConvert.DeserializeObject<AccountResponseModel>(response.Content);
                }
                else
                {
                    throw new Exception("The Response Status Code is: " + response.StatusCode);
                }
            }



            catch (Exception ex)
            {
                throw new Exception("Failed : " + ex.Message);
            }
        }



    }

}
