using System;
using System.IO;
using System.Net;

namespace ProducvitityTools.NetworkUtilities
{
    public static class ExternalIP
    {
        public static string Get()
        {
            var request = (HttpWebRequest)WebRequest.Create("http://ifconfig.me/ip");
            //request.UserAgent = "curl"; // this will tell the server to return the information as if the request was made by the linux "curl" command

            string publicIPAddress;

            request.Method = "GET";
            using (WebResponse response = request.GetResponse())
            {
                using (var reader = new StreamReader(response.GetResponseStream()))
                {
                    publicIPAddress = reader.ReadToEnd();
                    return publicIPAddress;
                }
            }

            throw new Exception("Addres not returned");
        }
    }
}
