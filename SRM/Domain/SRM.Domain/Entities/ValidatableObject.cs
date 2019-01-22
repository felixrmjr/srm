using SRM.Domain.Exceptions;
using SRM.Domain.Uteis;

namespace SRM.Domain.Entities
{
    public class ValidatableObject
    {
        private readonly DomainSummaryException _domainSummaryException = new DomainSummaryException();

        public virtual void AddException(ExceptionItemInfo exceptionItemInfo)
        {
            Throw.IfIsNull(exceptionItemInfo, nameof(exceptionItemInfo));
            _domainSummaryException.Add(exceptionItemInfo);
        }

        public virtual void AddException(string model, string reference, string message, params object[] arguments)
        {
            var exceptionItemInfo = new ExceptionItemInfo(model, reference, message, arguments);
            AddException(exceptionItemInfo);
        }

        public virtual void Validate()
        {
            if (IsValid()) return;
            throw _domainSummaryException;
        }

        public virtual bool IsValid() => _domainSummaryException.Exceptions == null || _domainSummaryException.Exceptions.Count == 0;
    }
}
