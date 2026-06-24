using System.Reflection;
using Nemerle.Core;

namespace Nemerle.Compiler;

public interface IMember
{
	bool IsConstructor { get; }

	Location Location { get; }

	bool IsObsolete { get; }

	bool IsPrivate { get; }

	TypeInfo DeclaringType { get; }

	string Name { get; }

	Location NameLocation { get; }

	MemberTypes MemberKind { get; }

	bool IsStatic { get; }

	bool HasBeenUsed { get; set; }

	bool IsConditional { get; }

	NemerleModifiers Attributes { get; }

	FixedType GetMemType();

	System.Reflection.MemberInfo GetHandle();

	bool CanAccess(TypeInfo source);

	bool CanAccess(TypeInfo memberTypeInfo, TypeInfo currentTypeInfo, bool isThisAccess);

	list<string> GetConditions();

	AttributesAndModifiers GetModifiers();

	bool IsCustomAttributeDefined(string attributeFullName);
}
