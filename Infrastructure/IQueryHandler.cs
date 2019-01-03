using System.Collections.Generic;

namespace QueryHandler.Infrastructure
{
    public interface IQueryHandler<TQuery, TResult>
    {
        IEnumerable<TResult> Handle(TQuery query);
    }
}