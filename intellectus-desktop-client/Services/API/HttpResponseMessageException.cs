using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace intellectus_desktop_client.Services.API
{
    public class HttpResponseMessageException : Exception
    {
        public HttpStatusCode Code { get; private set; }

        public HttpResponseMessage Response { get; private set; }

        public HttpResponseMessageException()
        {
        }

        public HttpResponseMessageException(string message) : base(message)
        {
        }

        public HttpResponseMessageException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected HttpResponseMessageException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        public HttpResponseMessageException(HttpStatusCode code, HttpResponseMessage response)
        {
            Code = code;
            Response = response;
        }
    }
}
