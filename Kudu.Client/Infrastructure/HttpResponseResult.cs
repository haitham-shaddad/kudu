﻿using System.Collections.Generic;

namespace Kudu.Client.Infrastructure
{
    public class HttpResponseResult<T>
    {
        public IDictionary<string, IEnumerable<string>> Headers { get; set; }
        public T Body { get; set; }

        public HttpResponseResult()
        {
        }

        public HttpResponseResult(IDictionary<string, IEnumerable<string>> headers, T body)
        {
            Headers = headers;
            Body = body;
        }
    }
}