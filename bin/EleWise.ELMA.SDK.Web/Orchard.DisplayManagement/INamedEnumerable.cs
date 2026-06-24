using System.Collections;
using System.Collections.Generic;

namespace Orchard.DisplayManagement;

public interface INamedEnumerable<T> : IEnumerable<T>, IEnumerable
{
	IEnumerable<T> Positional { get; }

	IDictionary<string, T> Named { get; }
}
