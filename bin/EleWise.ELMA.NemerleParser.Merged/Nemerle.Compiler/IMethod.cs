using System.Reflection;
using Nemerle.Builtins;
using Nemerle.Compiler.Typedtree;
using Nemerle.Core;

namespace Nemerle.Compiler;

public interface IMethod : IMember
{
	TFunHeader Header { get; }

	bool IsVarArgs { get; }

	bool IsFinal { get; }

	bool IsAbstract { get; }

	bool IsExtension { get; }

	BuiltinMethodKind BuiltinKind { get; }

	TypeVar ReturnType { get; }

	Tuple<FixedType, list<TypeVar>> GetFreshType();

	TFunHeader GetHeader();

	MethodBase GetMethodBase();

	MethodInfo GetMethodInfo();

	ConstructorInfo GetConstructorInfo();

	new FixedType.Fun GetMemType();

	list<TParameter> GetParameters();
}
