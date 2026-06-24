using System.Dynamic;
using System.Linq.Expressions;

namespace Orchard.DisplayManagement.Shapes;

public class Nil : DynamicObject
{
	private static readonly Nil Singleton = new Nil();

	public static Nil Instance => Singleton;

	private Nil()
	{
	}

	public override bool TryGetMember(GetMemberBinder binder, out object result)
	{
		result = Instance;
		return true;
	}

	public override bool TryGetIndex(GetIndexBinder binder, object[] indexes, out object result)
	{
		result = Instance;
		return true;
	}

	public override bool TryInvokeMember(InvokeMemberBinder binder, object[] args, out object result)
	{
		result = Instance;
		return true;
	}

	public override bool TryBinaryOperation(BinaryOperationBinder binder, object arg, out object result)
	{
		switch (binder.Operation)
		{
		case ExpressionType.Equal:
			result = arg == Instance || arg == null;
			return true;
		case ExpressionType.NotEqual:
			result = arg != Instance && arg != null;
			return true;
		default:
			return base.TryBinaryOperation(binder, arg, out result);
		}
	}

	public static bool operator ==(Nil a, Nil b)
	{
		return true;
	}

	public static bool operator !=(Nil a, Nil b)
	{
		return false;
	}

	public static bool operator ==(Nil a, object b)
	{
		if ((object)a != b)
		{
			return b == null;
		}
		return true;
	}

	public static bool operator !=(Nil a, object b)
	{
		return !(a == b);
	}

	public override bool Equals(object obj)
	{
		if (obj == null)
		{
			return true;
		}
		return obj == Instance;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public override bool TryConvert(ConvertBinder binder, out object result)
	{
		result = null;
		return true;
	}

	public override string ToString()
	{
		return string.Empty;
	}
}
