using System;
using System.Collections.Generic;
using System.Linq;
using QueryHandler.DataAccess;
using QueryHandler.Domain;
using QueryHandler.Infrastructure;
using QueryHandler.Models;

namespace QueryHandler
{
    public class AuditQueryHandler : IQueryHandler<AuditQuery, AuditDTO>
    {
        private readonly MainContext _ctx;
        public AuditQueryHandler(MainContext ctx)
        {
            _ctx = ctx;
        }
        public IEnumerable<AuditDTO> Handle(AuditQuery query)
        {

            var audits = _ctx.Audit.Select(x => x);
            
            if(query.AuditState.HasValue)
            {
                audits = audits.Where(x => x.AuditState == query.AuditState);
            }
            //var result = _ctx.Audit.Where(query.Query);
            return audits.Select(x => new AuditDTO(x));
        }
    }

    public class AuditDTO{

        public AuditDTO(Audit audit)
        {
            AuditId = audit.Id;
            AuditType = audit.AuditType;
            AuditState = audit.AuditState.ToString();
            CreatedDate = audit.DateCreated.ToString();
        }


        public int AuditId { get; set; }
        public string AuditType { get; set; }
        public string AuditState { get; set; }
        public string CreatedDate { get; set; }
    }

}