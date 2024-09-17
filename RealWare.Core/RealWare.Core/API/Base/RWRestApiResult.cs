using System;
using System.Collections.Generic;

namespace RealWare.Core.API.Connection
{
    public class RWRestApiResult
    {
        public bool IsSuccessful { get; set; }
        public string Description { get; set; }
        public string ErrorDetails { get; set; }
        public string Data { get; set; }
        public string RequestUrl { get; set; }
        public List<RestApiResponseHeader> ResponseHeaders { get; set; }

        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public TimeSpan? RequestLength => EndTime - StartTime;

        public RWRestApiResult() 
            => ClearResult();

        public void ClearResult()
        {
            IsSuccessful = true;
            Description = null;
            StartTime = null;
            EndTime = null;
            Data = null;
            ErrorDetails = null;
            ResponseHeaders = null;
        }
    }
}
