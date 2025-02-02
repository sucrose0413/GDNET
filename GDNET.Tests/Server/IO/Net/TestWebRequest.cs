using System.Net.Http;
using GDNET.Server.IO.Net;
using NUnit.Framework;

namespace GDNET.Tests.Server.IO.Net
{
    public class TestWebRequest
    {
        private readonly WebRequestClient client = new WebRequestClient
        {
            Options = new WebRequestClient.WebRequestClientOptions
            {
                IgnoreGdExceptions = true
            }
        };

        [Test]
        public void TestSendQueuedRequest()
        {
            // add request
            var req = new WebRequest
            {
                Url = @"http://boomlings.com/database/accounts/loginGJAccount.php",
                Method = HttpMethod.Post
            };

            client.AddRequest(req);

            // send request
            var funky = client.SendRequest();
            Assert.AreEqual(funky, "-1", "HTTP Requests are working.");
        }

        [Test]
        public void TestSendDirectRequest()
        {
            var funky = WebRequestClient.SendRequest(new WebRequest
            {
                Url = @"http://boomlings.com/database/accounts/loginGJAccount.php",
                Method = HttpMethod.Post
            }, new WebRequestClient.WebRequestClientOptions
            {
                IgnoreGdExceptions = true
            });

            Assert.AreEqual(funky, "-1", "HTTP Requests are working.");
        }
    }
}