using System.Collections;
using System.Collections.Generic;
using Nemerle.Builtins;
using Nemerle.Core;

namespace Nemerle.Collections;

public interface ICollection<_0027a> : IEnumerable, IEnumerable<_0027a>, System.Collections.Generic.ICollection<_0027a>
{
	bool IsEmpty { get; }

	option<_0027a> First();

	ICollection<_0027a> Clone();

	_0027b Fold<_0027b>(Function<_0027a, _0027b, _0027b> f, _0027b x);

	ICollection<_0027b> Map<_0027b>(Function<_0027a, _0027b> f);

	void Iter(FunctionVoid<_0027a> f);

	bool ForAll(Function<_0027a, bool> f);

	bool Exists(Function<_0027a, bool> f);

	void Filter(Function<_0027a, bool> f);

	Tuple<ICollection<_0027a>, ICollection<_0027a>> Partition(Function<_0027a, bool> f);
}
