using System.Reflection;

namespace Nemerle.Compiler;

public interface IField : IMember
{
	bool IsMutable { get; }

	bool IsVolatile { get; }

	bool IsLiteral { get; }

	bool HasBeenAssigned { get; set; }

	Literal GetValue();

	FieldInfo GetFieldInfo();
}
