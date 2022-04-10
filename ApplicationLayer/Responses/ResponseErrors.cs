using System.Net;

namespace ApplicationLayer.Responses
{
    public class ResponseErrors
    {
        public ResponseErrors(HttpStatusCode statusCode, string errorMessage)
        {
            StatusCode = statusCode;
            ErrorMessage = errorMessage;
        }
        public HttpStatusCode StatusCode { get; private set; }
        public string ErrorMessage { get; private set; }
    }
}
