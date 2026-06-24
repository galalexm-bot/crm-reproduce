using System.Collections.ObjectModel;

namespace Nemerle.Extensions;

public interface IAnonymous
{
	object this[string field] { get; }

	ReadOnlyCollection<string> GetFields();

	object GetContent();
}
