using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TestingClient
{
    public class Processor
    {
        string url = "https://localhost:7259/weatherforecast";
        string jsonRequest = "";


        public string CallApi()
        {
            string result = "";
            string data = "";
            try
            {
                var request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "GET";
                request.ContentType = "application/json";
                //request.ContentLength = data.Length;
                request.Headers.Add("Client-Id", "test123");

                var response = (HttpWebResponse)request.GetResponse();

                var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
                result = responseString;
            }
            catch (Exception ee)
            {
                result = ee.Message;
            }
            return result;
        }
    }
}
