using System.Net.Http.Headers;

namespace iSchoolWebAppBogaard.Services
{
    public class DataRetrieval
    {
        //build a method to go get my data from my api...
        //we are going to send in the endpoint of the url ("about/" or "people/"...)
        public async Task<string> GetData(string endpoint)
        {
            //Task vs Thread - 
            //Task has async/await and a return value, can cancel a task
            //Thread - no direct way to return from a thread, thread can do multile things at once

            //using statement - at the end of it, it is automagically disposed...
            using(var client = new HttpClient())
            {
                //we need to set up our http client!
                //request/response
                client.BaseAddress = new Uri("https://ischool.gccis.rit.edu/api/");
                client.DefaultRequestHeaders.Accept.Clear();
                //tell the server the type of file I'm looking for to come back
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                try
                {
                    HttpResponseMessage response = await client.GetAsync(endpoint, HttpCompletionOption.ResponseHeadersRead);
                    response.EnsureSuccessStatusCode();
                    //go get it...
                    var data = await response.Content.ReadAsStringAsync();
                    //data is a bg string...
                    return data;

                }
                catch (HttpRequestException hre)
                {
                    var msg = hre.Message;
                    return "httpRequest" + msg;
                }
                catch (Exception e)
                {
                    var msg = e.Message;
                    return "Ex: " + msg;
                }

            }
        }
    }
}
