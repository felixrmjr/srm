using SRM.Domain.Uteis;
using System;
using System.Collections.Generic;

namespace SRM.Domain.Exceptions
{
    public class DomainSummaryException : Exception
    {
        public List<ExceptionItemInfo> Exceptions { get; set; } = new List<ExceptionItemInfo>();

        public DomainSummaryException() { }

        public DomainSummaryException(List<ExceptionItemInfo> exceptions) => this.Exceptions.AddRange(exceptions);


        public void Add(ExceptionItemInfo exceptionItemInfo)
        {
            Throw.IfIsNull(exceptionItemInfo, nameof(exceptionItemInfo));
            Exceptions.Add(exceptionItemInfo);
        }

        public void Add(string model, string reference, string message)
        {
            var exceptionItemInfo = new ExceptionItemInfo(model, reference, message);
            Add(exceptionItemInfo);
        }
    }
}
