using System;
using System.Net;
using System.Collections.Specialized;

namespace cshttp {
  public class HttpWebGetPost {
    public static void Main() {
      int requestSize = 30;
      var targethost = "https://example.com";
      string postString = @ "0884892649966840111330768081643308848926499668401";
      for (int i = 0; i < requestSize; i++) {
        WebRequest webrequest = WebRequest.Create(targethost);
        webrequest.Credentials = CredentialCache.DefaultCredentials;
        WebResponse response = webrequest.GetResponse();
        Console.WriteLine(string.Format("{0}", i));
        Console.WriteLine(((HttpWebResponse) response).StatusDescription);
        response.Close();
        using(WebClient client = new WebClient()) {
          client.UploadValues(targethost, new NameValueCollection() {
            {
              "username",
              postString
            }
          });

        }

      }
    }
  }
}
