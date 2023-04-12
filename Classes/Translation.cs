using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Net;
using System.IO;

namespace SoftwareII.Classes
{
    public static class Translation
    {
        public static string translateToLocalLanguage(string inputString)
        {
            try
            {
                //check which language the user's system is using
                string userLanguageCode = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
                    
                

                //create a json string for submission to a translation api
                string json = "{\"q\": \"" + inputString + "\", \"source\": \"en\", \"target\": \"" + userLanguageCode + "\", \"format\": \"text\", \"api_key\": \"10c0b74a-2c54-433e-8d15-46f48bc12cf3\"}";

                //create a web request object and send it to server
                string strUrl = String.Format("https://libretranslate.com/translate");
                WebRequest webrequest = WebRequest.Create(strUrl);
                webrequest.Method = "POST";
                webrequest.ContentType = "application/json";
                StreamWriter streamWriter = new StreamWriter(webrequest.GetRequestStream());
                streamWriter.Write(json);
                streamWriter.Flush();
                streamWriter.Close();

                //get response from server 
                var httpResponse = (HttpWebResponse)webrequest.GetResponse();

                //initialize a streamreader object using the response stream for the parameter
                StreamReader streamReader = new StreamReader(httpResponse.GetResponseStream());

                //place contents in a string object
                string responseString = streamReader.ReadToEnd();

                //remove unneccessary information from the string, leaving only the bare response.
                responseString = responseString.Remove(0, 19);
                responseString = responseString.Remove(responseString.Length - 3, 2);


                return responseString;
            }
            catch (Exception)
            {
                return "an error has occurred";
                
            } 
        }
    }
}
