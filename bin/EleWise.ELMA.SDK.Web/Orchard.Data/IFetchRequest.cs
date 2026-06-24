using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Orchard.Data;

public interface IFetchRequest<TQueried, TFetch> : IOrderedQueryable<TQueried>, IQueryable<TQueried>, IEnumerable<TQueried>, IEnumerable, IQueryable, IOrderedQueryable
{
}
