using System;

namespace QueryHandler.Models
{
    public class Audit
    {
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public AuditState AuditState { get; set; }
        public string AuditType { get; set; }

    }

    public enum AuditState
    {
        InProgress,
        Complete

    }
}