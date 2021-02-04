using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Http;

namespace BooksAPI.BusinessLogic.Exceptions
{
    public class BaseException : Exception
    {
        public HttpStatusCode StatusCode { get; set; }

        public BaseException(HttpStatusCode statusCode, string message) : base(message)
        {
            StatusCode = statusCode;
        }

        public HttpResponseMessage CreateResponse(HttpRequestMessage request)
        {
            return new HttpResponseMessage(StatusCode)
            {
                RequestMessage = request,
                Content = new StringContent(JsonConvert.SerializeObject(new
                {
                    Message
                }))
            };
        }
    }
}
