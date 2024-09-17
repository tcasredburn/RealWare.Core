using System;
using System.Net;

namespace RealWare.Core.API.Exceptions
{
    /// <summary>
    /// Exception thrown when a RealWare API call fails.
    /// </summary>
    public class RealWareApiException : Exception
    {
        /// <summary>
        /// Gets the HTTP status code returned by the API.
        /// </summary>
        public HttpStatusCode StatusCode { get; }

        /// <summary>
        /// Initializes a new instance of the RealWareApiException class with a specified error message.
        /// </summary>
        /// <param name="message">The error message.</param>
        public RealWareApiException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ApiException class with a specified error message and inner exception.
        /// </summary>
        /// <param name="message">The error message.</param>
        /// <param name="innerException">The inner exception.</param>
        public RealWareApiException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ApiException class with a specified status code and error content.
        /// </summary>
        /// <param name="statusCode">The HTTP status code.</param>
        /// <param name="content">The error content returned by the API.</param>
        public RealWareApiException(HttpStatusCode statusCode, string content)
            : base($"Request failed with status code {(int)statusCode} ({statusCode}). Content: {content}")
        {
            StatusCode = statusCode;
        }
    }
}
