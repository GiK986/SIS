using System;
using System.Collections.Generic;
using System.Text;

namespace SIS.HTTP.Headers.Contracts
{
    public interface IHttpHeaderCollection
    {
        void AddHeader(HttpHeader httpHeader);

        bool ContainsHeader(string key);

        HttpHeader GetHttpHeader(string key);
    }
}
