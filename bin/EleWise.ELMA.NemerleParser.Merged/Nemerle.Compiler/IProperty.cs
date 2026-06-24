using System.Reflection;

namespace Nemerle.Compiler;

public interface IProperty : IMember
{
	bool IsIndexer { get; }

	bool IsMutable { get; }

	PropertyInfo GetPropertyInfo();

	IMethod GetGetter();

	IMethod GetSetter();
}
