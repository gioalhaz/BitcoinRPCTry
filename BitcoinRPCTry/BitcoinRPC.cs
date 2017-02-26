using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BitcoinRPCTry
{
    class BitcoinRPC
    {
        public string Host { get; set; }
        public uint Port { get; set; }

        public string User { get; set; }
        public string Password { private get; set; }

        private HttpWebRequest createWebRequest()
        {
            var urlString = string.Format("http://{0}:{1}", Host, Port);
            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(urlString);

            webRequest.Credentials = new NetworkCredential(User, Password);

            webRequest.ContentType = "application/json-rpc";
            webRequest.Method = "POST";

            return webRequest;
        }

        private string callMethod(string method, ArrayList methodParams)
        {
            string result = null;
            var request = createWebRequest();

            JObject joe = new JObject();
            joe.Add(new JProperty("jsonrpc", "1.0"));
            joe.Add(new JProperty("id", "1"));
            joe.Add(new JProperty("method", method));

            // params is a collection values which the method requires..
            if (methodParams == null || methodParams.Count == 0)
            {
                joe.Add(new JProperty("params", new JArray()));
            }
            else
            {
                JArray props = new JArray();
                // add the props in the reverse order!
                for (int i = methodParams.Count - 1; i >= 0; i--)
                {
                    props.Add(methodParams[i]);
                }

                joe.Add(new JProperty("params", props));
            }

            // serialize json for the request
            string s = JsonConvert.SerializeObject(joe);
            byte[] byteArray = Encoding.UTF8.GetBytes(s);
            request.ContentLength = byteArray.Length;
            Stream dataStream = request.GetRequestStream();
            dataStream.Write(byteArray, 0, byteArray.Length);
            dataStream.Close();

            WebResponse response = request.GetResponse();
            using (var reader = new StreamReader(response.GetResponseStream()))
            {
                result = reader.ReadToEnd();
            }
            
            return result;
        }

        internal string getBlockchainInfo()
        {
            return callMethod("getblockchaininfo", null);
        }

        internal string getWalletInfo()
        {
            return callMethod("getwalletinfo", null);
        }

        internal string listTransactions()
        {
            return callMethod("listtransactions", null);
        }

        internal string getInfo()
        {
            return callMethod("getinfo", null);
        }

        internal string listAccounts()
        {
            return callMethod("listaccounts", null);
        }

        internal string dumpWallet(string fileName)
        {
            var array = new ArrayList(1);
            array.Add(fileName);

            return callMethod("dumpwallet", array);
        }
    }
}
