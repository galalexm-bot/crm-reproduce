using System.Collections;

namespace EleWise.ELMA.Collections;

public interface IUntypedCollectionProxy : IEnumerable
{
	void Add(object o);

	bool Remove(object o);

	void Clear();

	bool Contains(object o);
}
