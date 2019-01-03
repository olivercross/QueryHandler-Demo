using System;
using System.Linq;
using QueryHandler.Models;

namespace QueryHandler.Domain
{
    public class AuditQuery : IQuery
    {
        public DateTime? AuditCreatedOn { get; set; }
        public AuditState? AuditState { get; set; }
        public Func<Audit, bool> Query { get; set; }

        

    }
}