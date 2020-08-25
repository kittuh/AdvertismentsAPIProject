﻿using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace BLL.Infastructure.Exceptions
{
    public class StatusCodeException : Exception
    {
        public HttpStatusCode Code { get; set; }
        public string Error { get; set; }
        public Guid Id { get; set; }
        public StatusCodeException(HttpStatusCode Code)
        {
            this.Code = Code;
        }
        public StatusCodeException(HttpStatusCode Code, string Error) : base(Error)
        {
            this.Code = Code;
            this.Error = Error;
        }

        public StatusCodeException(HttpStatusCode Code, string Error, Guid Id) : base(Error)
        {
            this.Code = Code;
            this.Error = Error;
            this.Id = Id;
        }
    }
}
