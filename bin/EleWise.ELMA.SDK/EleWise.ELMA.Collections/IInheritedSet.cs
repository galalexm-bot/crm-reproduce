using System.Collections;
using Iesi.Collections;

namespace EleWise.ELMA.Collections;

public interface IInheritedSet : ISet, ICollection, IEnumerable
{
	bool WasInitialized { get; }

	ISet GetSourceSet();
}
