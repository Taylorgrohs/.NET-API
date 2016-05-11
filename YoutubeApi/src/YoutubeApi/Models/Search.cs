using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;

using RestSharp;
using RestSharp.Authenticators;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace YoutubeApi.Models
{
   public class Search
    {
        
        public static List<string> newSearch(string search)
        {
            var client = new RestClient("https://www.googleapis.com");
            var request = new RestRequest(Method.GET);
            request.RequestFormat = DataFormat.Json;
            request.Resource = "youtube/v3/search";
            request.AddParameter("part", "snippet,status", ParameterType.UrlSegment);
            request.AddParameter("q", search);
            request.AddParameter("key", "AIzaSyBme5dgBotQG-bMJYL2ydexEwRlo-nSk6k");


            return Execute<Search>(request);
            //var response = client.Execute(request);
            //JObject jsonResponse = (JObject)JsonConvert.DeserializeObject(response.Content);
            //var searchList = JsonConvert.DeserializeObject<List<string>>(jsonResponse["searchs"].ToString());
            //return searchList;
        }
    }
}