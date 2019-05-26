using SIS.HTTP.Headers.Contracts;
using SIS.HTTP.Common;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SIS.HTTP.Headers
{
    public class HttpHeaderCollection : IHttpHeaderCollection
    {
        private readonly Dictionary<string, HttpHeader> httpHeaders;

        public HttpHeaderCollection()
        {
            this.httpHeaders = new Dictionary<string, HttpHeader>();
        }
        public void AddHeader(HttpHeader httpHeader)
        {
            CoreValidator.ThrowIfNull(httpHeader, nameof(httpHeader));

            this.httpHeaders.Add(httpHeader.Key, httpHeader);
        }

        public bool ContainsHeader(string key)
        {
            CoreValidator.ThrowIfNullOrEmpty(key, nameof(key));

            return this.httpHeaders.ContainsKey(key);
        }

        public HttpHeader GetHttpHeader(string key)
        {
            CoreValidator.ThrowIfNullOrEmpty(key, nameof(key));

            return this.httpHeaders[key];
        }

        public override string ToString() => string.Join(GlobalConstants.HttpNewLine,
            this.httpHeaders.Values.Select(httpHeader => httpHeader.ToString()));
       
    }
}
