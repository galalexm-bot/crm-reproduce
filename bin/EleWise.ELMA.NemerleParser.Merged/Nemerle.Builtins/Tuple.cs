using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Nemerle.Internal;

namespace Nemerle.Builtins;

[Serializable]
[DebuggerDisplay("({Field0}, {Field1})")]
[DebuggerNonUserCode]
public struct Tuple<_0027p0, _0027p1> : IEquatable<Tuple<_0027p0, _0027p1>>, IStructuralEquatable
{
	public readonly _0027p0 Field0;

	public readonly _0027p1 Field1;

	public int GetHashCode(IEqualityComparer _comparer)
	{
		return GetHashCode();
	}

	public bool Equals(object other, IEqualityComparer _comparer)
	{
		return Equals(other);
	}

	public static bool operator !=(Tuple<_0027p0, _0027p1> first, Tuple<_0027p0, _0027p1> second)
	{
		return !(first == second);
	}

	public static bool operator ==(Tuple<_0027p0, _0027p1> first, Tuple<_0027p0, _0027p1> second)
	{
		return first.Equals(second);
	}

	public override int GetHashCode()
	{
		int num = 0;
		num = 0;
		num += EqualityComparer<_0027p0>.Default.GetHashCode(Field0);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p1>.Default.GetHashCode(Field1);
		num += num << 10;
		return num ^ (num >> 6);
	}

	public override bool Equals(object other)
	{
		return other is Tuple<_0027p0, _0027p1> && EqualsImpl((Tuple<_0027p0, _0027p1>)other);
	}

	public bool Equals(Tuple<_0027p0, _0027p1> other)
	{
		return EqualsImpl(other);
	}

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder("(");
		StringBuilder stringBuilder2 = stringBuilder.Append(Field0);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field1);
		stringBuilder2 = stringBuilder.Append(")");
		return stringBuilder.ToString();
	}

	private bool EqualsImpl(Tuple<_0027p0, _0027p1> other)
	{
		return EqualityComparer<_0027p1>.Default.Equals(Field1, other.Field1) && (EqualityComparer<_0027p0>.Default.Equals(Field0, other.Field0) ? true : false);
	}

	[RecordCtor]
	public Tuple([MappedMember("Field0")] _0027p0 field0, [MappedMember("Field1")] _0027p1 field1)
	{
		Field0 = field0;
		Field1 = field1;
	}
}
[Serializable]
[DebuggerNonUserCode]
[DebuggerDisplay("({Field0}, {Field1}, {Field2})")]
public struct Tuple<_0027p0, _0027p1, _0027p2> : IEquatable<Tuple<_0027p0, _0027p1, _0027p2>>, IStructuralEquatable
{
	public readonly _0027p0 Field0;

	public readonly _0027p1 Field1;

	public readonly _0027p2 Field2;

	public int GetHashCode(IEqualityComparer _comparer)
	{
		return GetHashCode();
	}

	public bool Equals(object other, IEqualityComparer _comparer)
	{
		return Equals(other);
	}

	public static bool operator !=(Tuple<_0027p0, _0027p1, _0027p2> first, Tuple<_0027p0, _0027p1, _0027p2> second)
	{
		return !(first == second);
	}

	public static bool operator ==(Tuple<_0027p0, _0027p1, _0027p2> first, Tuple<_0027p0, _0027p1, _0027p2> second)
	{
		return first.Equals(second);
	}

	public override int GetHashCode()
	{
		int num = 0;
		num = 0;
		num += EqualityComparer<_0027p0>.Default.GetHashCode(Field0);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p1>.Default.GetHashCode(Field1);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p2>.Default.GetHashCode(Field2);
		num += num << 10;
		return num ^ (num >> 6);
	}

	public override bool Equals(object other)
	{
		return other is Tuple<_0027p0, _0027p1, _0027p2> && EqualsImpl((Tuple<_0027p0, _0027p1, _0027p2>)other);
	}

	public bool Equals(Tuple<_0027p0, _0027p1, _0027p2> other)
	{
		return EqualsImpl(other);
	}

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder("(");
		StringBuilder stringBuilder2 = stringBuilder.Append(Field0);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field1);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field2);
		stringBuilder2 = stringBuilder.Append(")");
		return stringBuilder.ToString();
	}

	private bool EqualsImpl(Tuple<_0027p0, _0027p1, _0027p2> other)
	{
		return EqualityComparer<_0027p2>.Default.Equals(Field2, other.Field2) && EqualityComparer<_0027p1>.Default.Equals(Field1, other.Field1) && (EqualityComparer<_0027p0>.Default.Equals(Field0, other.Field0) ? true : false);
	}

	[RecordCtor]
	public Tuple([MappedMember("Field0")] _0027p0 field0, [MappedMember("Field1")] _0027p1 field1, [MappedMember("Field2")] _0027p2 field2)
	{
		Field0 = field0;
		Field1 = field1;
		Field2 = field2;
	}
}
[Serializable]
[DebuggerNonUserCode]
[DebuggerDisplay("({Field0}, {Field1}, {Field2}, {Field3})")]
public sealed class Tuple<_0027p0, _0027p1, _0027p2, _0027p3> : IEquatable<Tuple<_0027p0, _0027p1, _0027p2, _0027p3>>, IStructuralEquatable
{
	public readonly _0027p0 Field0;

	public readonly _0027p1 Field1;

	public readonly _0027p2 Field2;

	public readonly _0027p3 Field3;

	public int GetHashCode(IEqualityComparer _comparer)
	{
		return GetHashCode();
	}

	public bool Equals(object other, IEqualityComparer _comparer)
	{
		return Equals(other);
	}

	public static bool operator !=(Tuple<_0027p0, _0027p1, _0027p2, _0027p3> first, Tuple<_0027p0, _0027p1, _0027p2, _0027p3> second)
	{
		return !(first == second);
	}

	public static bool operator ==(Tuple<_0027p0, _0027p1, _0027p2, _0027p3> first, Tuple<_0027p0, _0027p1, _0027p2, _0027p3> second)
	{
		return ((object)first != null) ? first.Equals(second) : ((object)second == null);
	}

	public override int GetHashCode()
	{
		int num = 0;
		num = 0;
		num += EqualityComparer<_0027p0>.Default.GetHashCode(Field0);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p1>.Default.GetHashCode(Field1);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p2>.Default.GetHashCode(Field2);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p3>.Default.GetHashCode(Field3);
		num += num << 10;
		return num ^ (num >> 6);
	}

	public override bool Equals(object other)
	{
		return other is Tuple<_0027p0, _0027p1, _0027p2, _0027p3> && EqualsImpl((Tuple<_0027p0, _0027p1, _0027p2, _0027p3>)other);
	}

	public bool Equals(Tuple<_0027p0, _0027p1, _0027p2, _0027p3> other)
	{
		return EqualsImpl(other);
	}

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder("(");
		StringBuilder stringBuilder2 = stringBuilder.Append(Field0);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field1);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field2);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field3);
		stringBuilder2 = stringBuilder.Append(")");
		return stringBuilder.ToString();
	}

	private bool EqualsImpl(Tuple<_0027p0, _0027p1, _0027p2, _0027p3> other)
	{
		return (object)other != null && EqualityComparer<_0027p3>.Default.Equals(Field3, other.Field3) && EqualityComparer<_0027p2>.Default.Equals(Field2, other.Field2) && EqualityComparer<_0027p1>.Default.Equals(Field1, other.Field1) && (EqualityComparer<_0027p0>.Default.Equals(Field0, other.Field0) ? true : false);
	}

	[RecordCtor]
	public Tuple([MappedMember("Field0")] _0027p0 field0, [MappedMember("Field1")] _0027p1 field1, [MappedMember("Field2")] _0027p2 field2, [MappedMember("Field3")] _0027p3 field3)
	{
		Field0 = field0;
		Field1 = field1;
		Field2 = field2;
		Field3 = field3;
	}
}
[Serializable]
[DebuggerDisplay("({Field0}, {Field1}, {Field2}, {Field3}, {Field4})")]
[DebuggerNonUserCode]
public sealed class Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4> : IEquatable<Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4>>, IStructuralEquatable
{
	public readonly _0027p0 Field0;

	public readonly _0027p1 Field1;

	public readonly _0027p2 Field2;

	public readonly _0027p3 Field3;

	public readonly _0027p4 Field4;

	public int GetHashCode(IEqualityComparer _comparer)
	{
		return GetHashCode();
	}

	public bool Equals(object other, IEqualityComparer _comparer)
	{
		return Equals(other);
	}

	public static bool operator !=(Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4> first, Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4> second)
	{
		return !(first == second);
	}

	public static bool operator ==(Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4> first, Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4> second)
	{
		return ((object)first != null) ? first.Equals(second) : ((object)second == null);
	}

	public override int GetHashCode()
	{
		int num = 0;
		num = 0;
		num += EqualityComparer<_0027p0>.Default.GetHashCode(Field0);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p1>.Default.GetHashCode(Field1);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p2>.Default.GetHashCode(Field2);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p3>.Default.GetHashCode(Field3);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p4>.Default.GetHashCode(Field4);
		num += num << 10;
		return num ^ (num >> 6);
	}

	public override bool Equals(object other)
	{
		return other is Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4> && EqualsImpl((Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4>)other);
	}

	public bool Equals(Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4> other)
	{
		return EqualsImpl(other);
	}

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder("(");
		StringBuilder stringBuilder2 = stringBuilder.Append(Field0);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field1);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field2);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field3);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field4);
		stringBuilder2 = stringBuilder.Append(")");
		return stringBuilder.ToString();
	}

	private bool EqualsImpl(Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4> other)
	{
		return (object)other != null && EqualityComparer<_0027p4>.Default.Equals(Field4, other.Field4) && EqualityComparer<_0027p3>.Default.Equals(Field3, other.Field3) && EqualityComparer<_0027p2>.Default.Equals(Field2, other.Field2) && EqualityComparer<_0027p1>.Default.Equals(Field1, other.Field1) && (EqualityComparer<_0027p0>.Default.Equals(Field0, other.Field0) ? true : false);
	}

	[RecordCtor]
	public Tuple([MappedMember("Field0")] _0027p0 field0, [MappedMember("Field1")] _0027p1 field1, [MappedMember("Field2")] _0027p2 field2, [MappedMember("Field3")] _0027p3 field3, [MappedMember("Field4")] _0027p4 field4)
	{
		Field0 = field0;
		Field1 = field1;
		Field2 = field2;
		Field3 = field3;
		Field4 = field4;
	}
}
[Serializable]
[DebuggerNonUserCode]
[DebuggerDisplay("({Field0}, {Field1}, {Field2}, {Field3}, {Field4}, {Field5})")]
public sealed class Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5> : IEquatable<Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5>>, IStructuralEquatable
{
	public readonly _0027p0 Field0;

	public readonly _0027p1 Field1;

	public readonly _0027p2 Field2;

	public readonly _0027p3 Field3;

	public readonly _0027p4 Field4;

	public readonly _0027p5 Field5;

	public int GetHashCode(IEqualityComparer _comparer)
	{
		return GetHashCode();
	}

	public bool Equals(object other, IEqualityComparer _comparer)
	{
		return Equals(other);
	}

	public static bool operator !=(Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5> first, Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5> second)
	{
		return !(first == second);
	}

	public static bool operator ==(Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5> first, Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5> second)
	{
		return ((object)first != null) ? first.Equals(second) : ((object)second == null);
	}

	public override int GetHashCode()
	{
		int num = 0;
		num = 0;
		num += EqualityComparer<_0027p0>.Default.GetHashCode(Field0);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p1>.Default.GetHashCode(Field1);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p2>.Default.GetHashCode(Field2);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p3>.Default.GetHashCode(Field3);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p4>.Default.GetHashCode(Field4);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p5>.Default.GetHashCode(Field5);
		num += num << 10;
		return num ^ (num >> 6);
	}

	public override bool Equals(object other)
	{
		return other is Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5> && EqualsImpl((Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5>)other);
	}

	public bool Equals(Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5> other)
	{
		return EqualsImpl(other);
	}

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder("(");
		StringBuilder stringBuilder2 = stringBuilder.Append(Field0);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field1);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field2);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field3);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field4);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field5);
		stringBuilder2 = stringBuilder.Append(")");
		return stringBuilder.ToString();
	}

	private bool EqualsImpl(Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5> other)
	{
		return (object)other != null && EqualityComparer<_0027p5>.Default.Equals(Field5, other.Field5) && EqualityComparer<_0027p4>.Default.Equals(Field4, other.Field4) && EqualityComparer<_0027p3>.Default.Equals(Field3, other.Field3) && EqualityComparer<_0027p2>.Default.Equals(Field2, other.Field2) && EqualityComparer<_0027p1>.Default.Equals(Field1, other.Field1) && (EqualityComparer<_0027p0>.Default.Equals(Field0, other.Field0) ? true : false);
	}

	[RecordCtor]
	public Tuple([MappedMember("Field0")] _0027p0 field0, [MappedMember("Field1")] _0027p1 field1, [MappedMember("Field2")] _0027p2 field2, [MappedMember("Field3")] _0027p3 field3, [MappedMember("Field4")] _0027p4 field4, [MappedMember("Field5")] _0027p5 field5)
	{
		Field0 = field0;
		Field1 = field1;
		Field2 = field2;
		Field3 = field3;
		Field4 = field4;
		Field5 = field5;
	}
}
[Serializable]
[DebuggerNonUserCode]
[DebuggerDisplay("({Field0}, {Field1}, {Field2}, {Field3}, {Field4}, {Field5}, {Field6})")]
public sealed class Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6> : IEquatable<Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6>>, IStructuralEquatable
{
	public readonly _0027p0 Field0;

	public readonly _0027p1 Field1;

	public readonly _0027p2 Field2;

	public readonly _0027p3 Field3;

	public readonly _0027p4 Field4;

	public readonly _0027p5 Field5;

	public readonly _0027p6 Field6;

	public int GetHashCode(IEqualityComparer _comparer)
	{
		return GetHashCode();
	}

	public bool Equals(object other, IEqualityComparer _comparer)
	{
		return Equals(other);
	}

	public static bool operator !=(Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6> first, Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6> second)
	{
		return !(first == second);
	}

	public static bool operator ==(Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6> first, Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6> second)
	{
		return ((object)first != null) ? first.Equals(second) : ((object)second == null);
	}

	public override int GetHashCode()
	{
		int num = 0;
		num = 0;
		num += EqualityComparer<_0027p0>.Default.GetHashCode(Field0);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p1>.Default.GetHashCode(Field1);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p2>.Default.GetHashCode(Field2);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p3>.Default.GetHashCode(Field3);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p4>.Default.GetHashCode(Field4);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p5>.Default.GetHashCode(Field5);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p6>.Default.GetHashCode(Field6);
		num += num << 10;
		return num ^ (num >> 6);
	}

	public override bool Equals(object other)
	{
		return other is Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6> && EqualsImpl((Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6>)other);
	}

	public bool Equals(Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6> other)
	{
		return EqualsImpl(other);
	}

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder("(");
		StringBuilder stringBuilder2 = stringBuilder.Append(Field0);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field1);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field2);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field3);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field4);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field5);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field6);
		stringBuilder2 = stringBuilder.Append(")");
		return stringBuilder.ToString();
	}

	private bool EqualsImpl(Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6> other)
	{
		return (object)other != null && EqualityComparer<_0027p6>.Default.Equals(Field6, other.Field6) && EqualityComparer<_0027p5>.Default.Equals(Field5, other.Field5) && EqualityComparer<_0027p4>.Default.Equals(Field4, other.Field4) && EqualityComparer<_0027p3>.Default.Equals(Field3, other.Field3) && EqualityComparer<_0027p2>.Default.Equals(Field2, other.Field2) && EqualityComparer<_0027p1>.Default.Equals(Field1, other.Field1) && (EqualityComparer<_0027p0>.Default.Equals(Field0, other.Field0) ? true : false);
	}

	[RecordCtor]
	public Tuple([MappedMember("Field0")] _0027p0 field0, [MappedMember("Field1")] _0027p1 field1, [MappedMember("Field2")] _0027p2 field2, [MappedMember("Field3")] _0027p3 field3, [MappedMember("Field4")] _0027p4 field4, [MappedMember("Field5")] _0027p5 field5, [MappedMember("Field6")] _0027p6 field6)
	{
		Field0 = field0;
		Field1 = field1;
		Field2 = field2;
		Field3 = field3;
		Field4 = field4;
		Field5 = field5;
		Field6 = field6;
	}
}
[Serializable]
[DebuggerDisplay("({Field0}, {Field1}, {Field2}, {Field3}, {Field4}, {Field5}, {Field6}, {Field7})")]
[DebuggerNonUserCode]
public sealed class Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7> : IEquatable<Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7>>, IStructuralEquatable
{
	public readonly _0027p0 Field0;

	public readonly _0027p1 Field1;

	public readonly _0027p2 Field2;

	public readonly _0027p3 Field3;

	public readonly _0027p4 Field4;

	public readonly _0027p5 Field5;

	public readonly _0027p6 Field6;

	public readonly _0027p7 Field7;

	public int GetHashCode(IEqualityComparer _comparer)
	{
		return GetHashCode();
	}

	public bool Equals(object other, IEqualityComparer _comparer)
	{
		return Equals(other);
	}

	public static bool operator !=(Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7> first, Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7> second)
	{
		return !(first == second);
	}

	public static bool operator ==(Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7> first, Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7> second)
	{
		return ((object)first != null) ? first.Equals(second) : ((object)second == null);
	}

	public override int GetHashCode()
	{
		int num = 0;
		num = 0;
		num += EqualityComparer<_0027p0>.Default.GetHashCode(Field0);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p1>.Default.GetHashCode(Field1);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p2>.Default.GetHashCode(Field2);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p3>.Default.GetHashCode(Field3);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p4>.Default.GetHashCode(Field4);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p5>.Default.GetHashCode(Field5);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p6>.Default.GetHashCode(Field6);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p7>.Default.GetHashCode(Field7);
		num += num << 10;
		return num ^ (num >> 6);
	}

	public override bool Equals(object other)
	{
		return other is Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7> && EqualsImpl((Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7>)other);
	}

	public bool Equals(Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7> other)
	{
		return EqualsImpl(other);
	}

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder("(");
		StringBuilder stringBuilder2 = stringBuilder.Append(Field0);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field1);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field2);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field3);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field4);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field5);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field6);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field7);
		stringBuilder2 = stringBuilder.Append(")");
		return stringBuilder.ToString();
	}

	private bool EqualsImpl(Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7> other)
	{
		return (object)other != null && EqualityComparer<_0027p7>.Default.Equals(Field7, other.Field7) && EqualityComparer<_0027p6>.Default.Equals(Field6, other.Field6) && EqualityComparer<_0027p5>.Default.Equals(Field5, other.Field5) && EqualityComparer<_0027p4>.Default.Equals(Field4, other.Field4) && EqualityComparer<_0027p3>.Default.Equals(Field3, other.Field3) && EqualityComparer<_0027p2>.Default.Equals(Field2, other.Field2) && EqualityComparer<_0027p1>.Default.Equals(Field1, other.Field1) && (EqualityComparer<_0027p0>.Default.Equals(Field0, other.Field0) ? true : false);
	}

	[RecordCtor]
	public Tuple([MappedMember("Field0")] _0027p0 field0, [MappedMember("Field1")] _0027p1 field1, [MappedMember("Field2")] _0027p2 field2, [MappedMember("Field3")] _0027p3 field3, [MappedMember("Field4")] _0027p4 field4, [MappedMember("Field5")] _0027p5 field5, [MappedMember("Field6")] _0027p6 field6, [MappedMember("Field7")] _0027p7 field7)
	{
		Field0 = field0;
		Field1 = field1;
		Field2 = field2;
		Field3 = field3;
		Field4 = field4;
		Field5 = field5;
		Field6 = field6;
		Field7 = field7;
	}
}
[Serializable]
[DebuggerNonUserCode]
[DebuggerDisplay("({Field0}, {Field1}, {Field2}, {Field3}, {Field4}, {Field5}, {Field6}, {Field7}, {Field8})")]
public sealed class Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8> : IEquatable<Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8>>, IStructuralEquatable
{
	public readonly _0027p0 Field0;

	public readonly _0027p1 Field1;

	public readonly _0027p2 Field2;

	public readonly _0027p3 Field3;

	public readonly _0027p4 Field4;

	public readonly _0027p5 Field5;

	public readonly _0027p6 Field6;

	public readonly _0027p7 Field7;

	public readonly _0027p8 Field8;

	public int GetHashCode(IEqualityComparer _comparer)
	{
		return GetHashCode();
	}

	public bool Equals(object other, IEqualityComparer _comparer)
	{
		return Equals(other);
	}

	public static bool operator !=(Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8> first, Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8> second)
	{
		return !(first == second);
	}

	public static bool operator ==(Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8> first, Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8> second)
	{
		return ((object)first != null) ? first.Equals(second) : ((object)second == null);
	}

	public override int GetHashCode()
	{
		int num = 0;
		num = 0;
		num += EqualityComparer<_0027p0>.Default.GetHashCode(Field0);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p1>.Default.GetHashCode(Field1);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p2>.Default.GetHashCode(Field2);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p3>.Default.GetHashCode(Field3);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p4>.Default.GetHashCode(Field4);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p5>.Default.GetHashCode(Field5);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p6>.Default.GetHashCode(Field6);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p7>.Default.GetHashCode(Field7);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p8>.Default.GetHashCode(Field8);
		num += num << 10;
		return num ^ (num >> 6);
	}

	public override bool Equals(object other)
	{
		return other is Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8> && EqualsImpl((Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8>)other);
	}

	public bool Equals(Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8> other)
	{
		return EqualsImpl(other);
	}

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder("(");
		StringBuilder stringBuilder2 = stringBuilder.Append(Field0);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field1);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field2);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field3);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field4);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field5);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field6);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field7);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field8);
		stringBuilder2 = stringBuilder.Append(")");
		return stringBuilder.ToString();
	}

	private bool EqualsImpl(Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8> other)
	{
		return (object)other != null && EqualityComparer<_0027p8>.Default.Equals(Field8, other.Field8) && EqualityComparer<_0027p7>.Default.Equals(Field7, other.Field7) && EqualityComparer<_0027p6>.Default.Equals(Field6, other.Field6) && EqualityComparer<_0027p5>.Default.Equals(Field5, other.Field5) && EqualityComparer<_0027p4>.Default.Equals(Field4, other.Field4) && EqualityComparer<_0027p3>.Default.Equals(Field3, other.Field3) && EqualityComparer<_0027p2>.Default.Equals(Field2, other.Field2) && EqualityComparer<_0027p1>.Default.Equals(Field1, other.Field1) && (EqualityComparer<_0027p0>.Default.Equals(Field0, other.Field0) ? true : false);
	}

	[RecordCtor]
	public Tuple([MappedMember("Field0")] _0027p0 field0, [MappedMember("Field1")] _0027p1 field1, [MappedMember("Field2")] _0027p2 field2, [MappedMember("Field3")] _0027p3 field3, [MappedMember("Field4")] _0027p4 field4, [MappedMember("Field5")] _0027p5 field5, [MappedMember("Field6")] _0027p6 field6, [MappedMember("Field7")] _0027p7 field7, [MappedMember("Field8")] _0027p8 field8)
	{
		Field0 = field0;
		Field1 = field1;
		Field2 = field2;
		Field3 = field3;
		Field4 = field4;
		Field5 = field5;
		Field6 = field6;
		Field7 = field7;
		Field8 = field8;
	}
}
[Serializable]
[DebuggerNonUserCode]
[DebuggerDisplay("({Field0}, {Field1}, {Field2}, {Field3}, {Field4}, {Field5}, {Field6}, {Field7}, {Field8}, {Field9})")]
public sealed class Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9> : IEquatable<Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9>>, IStructuralEquatable
{
	public readonly _0027p0 Field0;

	public readonly _0027p1 Field1;

	public readonly _0027p2 Field2;

	public readonly _0027p3 Field3;

	public readonly _0027p4 Field4;

	public readonly _0027p5 Field5;

	public readonly _0027p6 Field6;

	public readonly _0027p7 Field7;

	public readonly _0027p8 Field8;

	public readonly _0027p9 Field9;

	public int GetHashCode(IEqualityComparer _comparer)
	{
		return GetHashCode();
	}

	public bool Equals(object other, IEqualityComparer _comparer)
	{
		return Equals(other);
	}

	public static bool operator !=(Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9> first, Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9> second)
	{
		return !(first == second);
	}

	public static bool operator ==(Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9> first, Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9> second)
	{
		return ((object)first != null) ? first.Equals(second) : ((object)second == null);
	}

	public override int GetHashCode()
	{
		int num = 0;
		num = 0;
		num += EqualityComparer<_0027p0>.Default.GetHashCode(Field0);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p1>.Default.GetHashCode(Field1);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p2>.Default.GetHashCode(Field2);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p3>.Default.GetHashCode(Field3);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p4>.Default.GetHashCode(Field4);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p5>.Default.GetHashCode(Field5);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p6>.Default.GetHashCode(Field6);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p7>.Default.GetHashCode(Field7);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p8>.Default.GetHashCode(Field8);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p9>.Default.GetHashCode(Field9);
		num += num << 10;
		return num ^ (num >> 6);
	}

	public override bool Equals(object other)
	{
		return other is Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9> && EqualsImpl((Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9>)other);
	}

	public bool Equals(Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9> other)
	{
		return EqualsImpl(other);
	}

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder("(");
		StringBuilder stringBuilder2 = stringBuilder.Append(Field0);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field1);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field2);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field3);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field4);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field5);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field6);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field7);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field8);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field9);
		stringBuilder2 = stringBuilder.Append(")");
		return stringBuilder.ToString();
	}

	private bool EqualsImpl(Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9> other)
	{
		return (object)other != null && EqualityComparer<_0027p9>.Default.Equals(Field9, other.Field9) && EqualityComparer<_0027p8>.Default.Equals(Field8, other.Field8) && EqualityComparer<_0027p7>.Default.Equals(Field7, other.Field7) && EqualityComparer<_0027p6>.Default.Equals(Field6, other.Field6) && EqualityComparer<_0027p5>.Default.Equals(Field5, other.Field5) && EqualityComparer<_0027p4>.Default.Equals(Field4, other.Field4) && EqualityComparer<_0027p3>.Default.Equals(Field3, other.Field3) && EqualityComparer<_0027p2>.Default.Equals(Field2, other.Field2) && EqualityComparer<_0027p1>.Default.Equals(Field1, other.Field1) && (EqualityComparer<_0027p0>.Default.Equals(Field0, other.Field0) ? true : false);
	}

	[RecordCtor]
	public Tuple([MappedMember("Field0")] _0027p0 field0, [MappedMember("Field1")] _0027p1 field1, [MappedMember("Field2")] _0027p2 field2, [MappedMember("Field3")] _0027p3 field3, [MappedMember("Field4")] _0027p4 field4, [MappedMember("Field5")] _0027p5 field5, [MappedMember("Field6")] _0027p6 field6, [MappedMember("Field7")] _0027p7 field7, [MappedMember("Field8")] _0027p8 field8, [MappedMember("Field9")] _0027p9 field9)
	{
		Field0 = field0;
		Field1 = field1;
		Field2 = field2;
		Field3 = field3;
		Field4 = field4;
		Field5 = field5;
		Field6 = field6;
		Field7 = field7;
		Field8 = field8;
		Field9 = field9;
	}
}
[Serializable]
[DebuggerNonUserCode]
[DebuggerDisplay("({Field0}, {Field1}, {Field2}, {Field3}, {Field4}, {Field5}, {Field6}, {Field7}, {Field8}, {Field9}, {Field10})")]
public sealed class Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10> : IEquatable<Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10>>, IStructuralEquatable
{
	public readonly _0027p0 Field0;

	public readonly _0027p1 Field1;

	public readonly _0027p2 Field2;

	public readonly _0027p3 Field3;

	public readonly _0027p4 Field4;

	public readonly _0027p5 Field5;

	public readonly _0027p6 Field6;

	public readonly _0027p7 Field7;

	public readonly _0027p8 Field8;

	public readonly _0027p9 Field9;

	public readonly _0027p10 Field10;

	public int GetHashCode(IEqualityComparer _comparer)
	{
		return GetHashCode();
	}

	public bool Equals(object other, IEqualityComparer _comparer)
	{
		return Equals(other);
	}

	public static bool operator !=(Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10> first, Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10> second)
	{
		return !(first == second);
	}

	public static bool operator ==(Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10> first, Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10> second)
	{
		return ((object)first != null) ? first.Equals(second) : ((object)second == null);
	}

	public override int GetHashCode()
	{
		int num = 0;
		num = 0;
		num += EqualityComparer<_0027p0>.Default.GetHashCode(Field0);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p1>.Default.GetHashCode(Field1);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p2>.Default.GetHashCode(Field2);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p3>.Default.GetHashCode(Field3);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p4>.Default.GetHashCode(Field4);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p5>.Default.GetHashCode(Field5);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p6>.Default.GetHashCode(Field6);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p7>.Default.GetHashCode(Field7);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p8>.Default.GetHashCode(Field8);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p9>.Default.GetHashCode(Field9);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p10>.Default.GetHashCode(Field10);
		num += num << 10;
		return num ^ (num >> 6);
	}

	public override bool Equals(object other)
	{
		return other is Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10> && EqualsImpl((Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10>)other);
	}

	public bool Equals(Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10> other)
	{
		return EqualsImpl(other);
	}

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder("(");
		StringBuilder stringBuilder2 = stringBuilder.Append(Field0);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field1);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field2);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field3);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field4);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field5);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field6);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field7);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field8);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field9);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field10);
		stringBuilder2 = stringBuilder.Append(")");
		return stringBuilder.ToString();
	}

	private bool EqualsImpl(Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10> other)
	{
		return (object)other != null && EqualityComparer<_0027p10>.Default.Equals(Field10, other.Field10) && EqualityComparer<_0027p9>.Default.Equals(Field9, other.Field9) && EqualityComparer<_0027p8>.Default.Equals(Field8, other.Field8) && EqualityComparer<_0027p7>.Default.Equals(Field7, other.Field7) && EqualityComparer<_0027p6>.Default.Equals(Field6, other.Field6) && EqualityComparer<_0027p5>.Default.Equals(Field5, other.Field5) && EqualityComparer<_0027p4>.Default.Equals(Field4, other.Field4) && EqualityComparer<_0027p3>.Default.Equals(Field3, other.Field3) && EqualityComparer<_0027p2>.Default.Equals(Field2, other.Field2) && EqualityComparer<_0027p1>.Default.Equals(Field1, other.Field1) && (EqualityComparer<_0027p0>.Default.Equals(Field0, other.Field0) ? true : false);
	}

	[RecordCtor]
	public Tuple([MappedMember("Field0")] _0027p0 field0, [MappedMember("Field1")] _0027p1 field1, [MappedMember("Field2")] _0027p2 field2, [MappedMember("Field3")] _0027p3 field3, [MappedMember("Field4")] _0027p4 field4, [MappedMember("Field5")] _0027p5 field5, [MappedMember("Field6")] _0027p6 field6, [MappedMember("Field7")] _0027p7 field7, [MappedMember("Field8")] _0027p8 field8, [MappedMember("Field9")] _0027p9 field9, [MappedMember("Field10")] _0027p10 field10)
	{
		Field0 = field0;
		Field1 = field1;
		Field2 = field2;
		Field3 = field3;
		Field4 = field4;
		Field5 = field5;
		Field6 = field6;
		Field7 = field7;
		Field8 = field8;
		Field9 = field9;
		Field10 = field10;
	}
}
[Serializable]
[DebuggerNonUserCode]
[DebuggerDisplay("({Field0}, {Field1}, {Field2}, {Field3}, {Field4}, {Field5}, {Field6}, {Field7}, {Field8}, {Field9}, {Field10}, {Field11})")]
public sealed class Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11> : IEquatable<Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11>>, IStructuralEquatable
{
	public readonly _0027p0 Field0;

	public readonly _0027p1 Field1;

	public readonly _0027p2 Field2;

	public readonly _0027p3 Field3;

	public readonly _0027p4 Field4;

	public readonly _0027p5 Field5;

	public readonly _0027p6 Field6;

	public readonly _0027p7 Field7;

	public readonly _0027p8 Field8;

	public readonly _0027p9 Field9;

	public readonly _0027p10 Field10;

	public readonly _0027p11 Field11;

	public int GetHashCode(IEqualityComparer _comparer)
	{
		return GetHashCode();
	}

	public bool Equals(object other, IEqualityComparer _comparer)
	{
		return Equals(other);
	}

	public static bool operator !=(Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11> first, Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11> second)
	{
		return !(first == second);
	}

	public static bool operator ==(Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11> first, Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11> second)
	{
		return ((object)first != null) ? first.Equals(second) : ((object)second == null);
	}

	public override int GetHashCode()
	{
		int num = 0;
		num = 0;
		num += EqualityComparer<_0027p0>.Default.GetHashCode(Field0);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p1>.Default.GetHashCode(Field1);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p2>.Default.GetHashCode(Field2);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p3>.Default.GetHashCode(Field3);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p4>.Default.GetHashCode(Field4);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p5>.Default.GetHashCode(Field5);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p6>.Default.GetHashCode(Field6);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p7>.Default.GetHashCode(Field7);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p8>.Default.GetHashCode(Field8);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p9>.Default.GetHashCode(Field9);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p10>.Default.GetHashCode(Field10);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p11>.Default.GetHashCode(Field11);
		num += num << 10;
		return num ^ (num >> 6);
	}

	public override bool Equals(object other)
	{
		return other is Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11> && EqualsImpl((Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11>)other);
	}

	public bool Equals(Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11> other)
	{
		return EqualsImpl(other);
	}

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder("(");
		StringBuilder stringBuilder2 = stringBuilder.Append(Field0);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field1);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field2);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field3);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field4);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field5);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field6);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field7);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field8);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field9);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field10);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field11);
		stringBuilder2 = stringBuilder.Append(")");
		return stringBuilder.ToString();
	}

	private bool EqualsImpl(Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11> other)
	{
		return (object)other != null && EqualityComparer<_0027p11>.Default.Equals(Field11, other.Field11) && EqualityComparer<_0027p10>.Default.Equals(Field10, other.Field10) && EqualityComparer<_0027p9>.Default.Equals(Field9, other.Field9) && EqualityComparer<_0027p8>.Default.Equals(Field8, other.Field8) && EqualityComparer<_0027p7>.Default.Equals(Field7, other.Field7) && EqualityComparer<_0027p6>.Default.Equals(Field6, other.Field6) && EqualityComparer<_0027p5>.Default.Equals(Field5, other.Field5) && EqualityComparer<_0027p4>.Default.Equals(Field4, other.Field4) && EqualityComparer<_0027p3>.Default.Equals(Field3, other.Field3) && EqualityComparer<_0027p2>.Default.Equals(Field2, other.Field2) && EqualityComparer<_0027p1>.Default.Equals(Field1, other.Field1) && (EqualityComparer<_0027p0>.Default.Equals(Field0, other.Field0) ? true : false);
	}

	[RecordCtor]
	public Tuple([MappedMember("Field0")] _0027p0 field0, [MappedMember("Field1")] _0027p1 field1, [MappedMember("Field2")] _0027p2 field2, [MappedMember("Field3")] _0027p3 field3, [MappedMember("Field4")] _0027p4 field4, [MappedMember("Field5")] _0027p5 field5, [MappedMember("Field6")] _0027p6 field6, [MappedMember("Field7")] _0027p7 field7, [MappedMember("Field8")] _0027p8 field8, [MappedMember("Field9")] _0027p9 field9, [MappedMember("Field10")] _0027p10 field10, [MappedMember("Field11")] _0027p11 field11)
	{
		Field0 = field0;
		Field1 = field1;
		Field2 = field2;
		Field3 = field3;
		Field4 = field4;
		Field5 = field5;
		Field6 = field6;
		Field7 = field7;
		Field8 = field8;
		Field9 = field9;
		Field10 = field10;
		Field11 = field11;
	}
}
[Serializable]
[DebuggerDisplay("({Field0}, {Field1}, {Field2}, {Field3}, {Field4}, {Field5}, {Field6}, {Field7}, {Field8}, {Field9}, {Field10}, {Field11}, {Field12})")]
[DebuggerNonUserCode]
public sealed class Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12> : IEquatable<Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12>>, IStructuralEquatable
{
	public readonly _0027p0 Field0;

	public readonly _0027p1 Field1;

	public readonly _0027p2 Field2;

	public readonly _0027p3 Field3;

	public readonly _0027p4 Field4;

	public readonly _0027p5 Field5;

	public readonly _0027p6 Field6;

	public readonly _0027p7 Field7;

	public readonly _0027p8 Field8;

	public readonly _0027p9 Field9;

	public readonly _0027p10 Field10;

	public readonly _0027p11 Field11;

	public readonly _0027p12 Field12;

	public int GetHashCode(IEqualityComparer _comparer)
	{
		return GetHashCode();
	}

	public bool Equals(object other, IEqualityComparer _comparer)
	{
		return Equals(other);
	}

	public static bool operator !=(Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12> first, Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12> second)
	{
		return !(first == second);
	}

	public static bool operator ==(Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12> first, Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12> second)
	{
		return ((object)first != null) ? first.Equals(second) : ((object)second == null);
	}

	public override int GetHashCode()
	{
		int num = 0;
		num = 0;
		num += EqualityComparer<_0027p0>.Default.GetHashCode(Field0);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p1>.Default.GetHashCode(Field1);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p2>.Default.GetHashCode(Field2);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p3>.Default.GetHashCode(Field3);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p4>.Default.GetHashCode(Field4);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p5>.Default.GetHashCode(Field5);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p6>.Default.GetHashCode(Field6);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p7>.Default.GetHashCode(Field7);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p8>.Default.GetHashCode(Field8);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p9>.Default.GetHashCode(Field9);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p10>.Default.GetHashCode(Field10);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p11>.Default.GetHashCode(Field11);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p12>.Default.GetHashCode(Field12);
		num += num << 10;
		return num ^ (num >> 6);
	}

	public override bool Equals(object other)
	{
		return other is Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12> && EqualsImpl((Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12>)other);
	}

	public bool Equals(Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12> other)
	{
		return EqualsImpl(other);
	}

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder("(");
		StringBuilder stringBuilder2 = stringBuilder.Append(Field0);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field1);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field2);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field3);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field4);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field5);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field6);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field7);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field8);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field9);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field10);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field11);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field12);
		stringBuilder2 = stringBuilder.Append(")");
		return stringBuilder.ToString();
	}

	private bool EqualsImpl(Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12> other)
	{
		return (object)other != null && EqualityComparer<_0027p12>.Default.Equals(Field12, other.Field12) && EqualityComparer<_0027p11>.Default.Equals(Field11, other.Field11) && EqualityComparer<_0027p10>.Default.Equals(Field10, other.Field10) && EqualityComparer<_0027p9>.Default.Equals(Field9, other.Field9) && EqualityComparer<_0027p8>.Default.Equals(Field8, other.Field8) && EqualityComparer<_0027p7>.Default.Equals(Field7, other.Field7) && EqualityComparer<_0027p6>.Default.Equals(Field6, other.Field6) && EqualityComparer<_0027p5>.Default.Equals(Field5, other.Field5) && EqualityComparer<_0027p4>.Default.Equals(Field4, other.Field4) && EqualityComparer<_0027p3>.Default.Equals(Field3, other.Field3) && EqualityComparer<_0027p2>.Default.Equals(Field2, other.Field2) && EqualityComparer<_0027p1>.Default.Equals(Field1, other.Field1) && (EqualityComparer<_0027p0>.Default.Equals(Field0, other.Field0) ? true : false);
	}

	[RecordCtor]
	public Tuple([MappedMember("Field0")] _0027p0 field0, [MappedMember("Field1")] _0027p1 field1, [MappedMember("Field2")] _0027p2 field2, [MappedMember("Field3")] _0027p3 field3, [MappedMember("Field4")] _0027p4 field4, [MappedMember("Field5")] _0027p5 field5, [MappedMember("Field6")] _0027p6 field6, [MappedMember("Field7")] _0027p7 field7, [MappedMember("Field8")] _0027p8 field8, [MappedMember("Field9")] _0027p9 field9, [MappedMember("Field10")] _0027p10 field10, [MappedMember("Field11")] _0027p11 field11, [MappedMember("Field12")] _0027p12 field12)
	{
		Field0 = field0;
		Field1 = field1;
		Field2 = field2;
		Field3 = field3;
		Field4 = field4;
		Field5 = field5;
		Field6 = field6;
		Field7 = field7;
		Field8 = field8;
		Field9 = field9;
		Field10 = field10;
		Field11 = field11;
		Field12 = field12;
	}
}
[Serializable]
[DebuggerDisplay("({Field0}, {Field1}, {Field2}, {Field3}, {Field4}, {Field5}, {Field6}, {Field7}, {Field8}, {Field9}, {Field10}, {Field11}, {Field12}, {Field13})")]
[DebuggerNonUserCode]
public sealed class Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13> : IEquatable<Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13>>, IStructuralEquatable
{
	public readonly _0027p0 Field0;

	public readonly _0027p1 Field1;

	public readonly _0027p2 Field2;

	public readonly _0027p3 Field3;

	public readonly _0027p4 Field4;

	public readonly _0027p5 Field5;

	public readonly _0027p6 Field6;

	public readonly _0027p7 Field7;

	public readonly _0027p8 Field8;

	public readonly _0027p9 Field9;

	public readonly _0027p10 Field10;

	public readonly _0027p11 Field11;

	public readonly _0027p12 Field12;

	public readonly _0027p13 Field13;

	public int GetHashCode(IEqualityComparer _comparer)
	{
		return GetHashCode();
	}

	public bool Equals(object other, IEqualityComparer _comparer)
	{
		return Equals(other);
	}

	public static bool operator !=(Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13> first, Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13> second)
	{
		return !(first == second);
	}

	public static bool operator ==(Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13> first, Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13> second)
	{
		return ((object)first != null) ? first.Equals(second) : ((object)second == null);
	}

	public override int GetHashCode()
	{
		int num = 0;
		num = 0;
		num += EqualityComparer<_0027p0>.Default.GetHashCode(Field0);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p1>.Default.GetHashCode(Field1);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p2>.Default.GetHashCode(Field2);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p3>.Default.GetHashCode(Field3);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p4>.Default.GetHashCode(Field4);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p5>.Default.GetHashCode(Field5);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p6>.Default.GetHashCode(Field6);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p7>.Default.GetHashCode(Field7);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p8>.Default.GetHashCode(Field8);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p9>.Default.GetHashCode(Field9);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p10>.Default.GetHashCode(Field10);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p11>.Default.GetHashCode(Field11);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p12>.Default.GetHashCode(Field12);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p13>.Default.GetHashCode(Field13);
		num += num << 10;
		return num ^ (num >> 6);
	}

	public override bool Equals(object other)
	{
		return other is Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13> && EqualsImpl((Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13>)other);
	}

	public bool Equals(Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13> other)
	{
		return EqualsImpl(other);
	}

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder("(");
		StringBuilder stringBuilder2 = stringBuilder.Append(Field0);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field1);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field2);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field3);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field4);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field5);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field6);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field7);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field8);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field9);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field10);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field11);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field12);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field13);
		stringBuilder2 = stringBuilder.Append(")");
		return stringBuilder.ToString();
	}

	private bool EqualsImpl(Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13> other)
	{
		return (object)other != null && EqualityComparer<_0027p13>.Default.Equals(Field13, other.Field13) && EqualityComparer<_0027p12>.Default.Equals(Field12, other.Field12) && EqualityComparer<_0027p11>.Default.Equals(Field11, other.Field11) && EqualityComparer<_0027p10>.Default.Equals(Field10, other.Field10) && EqualityComparer<_0027p9>.Default.Equals(Field9, other.Field9) && EqualityComparer<_0027p8>.Default.Equals(Field8, other.Field8) && EqualityComparer<_0027p7>.Default.Equals(Field7, other.Field7) && EqualityComparer<_0027p6>.Default.Equals(Field6, other.Field6) && EqualityComparer<_0027p5>.Default.Equals(Field5, other.Field5) && EqualityComparer<_0027p4>.Default.Equals(Field4, other.Field4) && EqualityComparer<_0027p3>.Default.Equals(Field3, other.Field3) && EqualityComparer<_0027p2>.Default.Equals(Field2, other.Field2) && EqualityComparer<_0027p1>.Default.Equals(Field1, other.Field1) && (EqualityComparer<_0027p0>.Default.Equals(Field0, other.Field0) ? true : false);
	}

	[RecordCtor]
	public Tuple([MappedMember("Field0")] _0027p0 field0, [MappedMember("Field1")] _0027p1 field1, [MappedMember("Field2")] _0027p2 field2, [MappedMember("Field3")] _0027p3 field3, [MappedMember("Field4")] _0027p4 field4, [MappedMember("Field5")] _0027p5 field5, [MappedMember("Field6")] _0027p6 field6, [MappedMember("Field7")] _0027p7 field7, [MappedMember("Field8")] _0027p8 field8, [MappedMember("Field9")] _0027p9 field9, [MappedMember("Field10")] _0027p10 field10, [MappedMember("Field11")] _0027p11 field11, [MappedMember("Field12")] _0027p12 field12, [MappedMember("Field13")] _0027p13 field13)
	{
		Field0 = field0;
		Field1 = field1;
		Field2 = field2;
		Field3 = field3;
		Field4 = field4;
		Field5 = field5;
		Field6 = field6;
		Field7 = field7;
		Field8 = field8;
		Field9 = field9;
		Field10 = field10;
		Field11 = field11;
		Field12 = field12;
		Field13 = field13;
	}
}
[Serializable]
[DebuggerNonUserCode]
[DebuggerDisplay("({Field0}, {Field1}, {Field2}, {Field3}, {Field4}, {Field5}, {Field6}, {Field7}, {Field8}, {Field9}, {Field10}, {Field11}, {Field12}, {Field13}, {Field14})")]
public sealed class Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14> : IEquatable<Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14>>, IStructuralEquatable
{
	public readonly _0027p0 Field0;

	public readonly _0027p1 Field1;

	public readonly _0027p2 Field2;

	public readonly _0027p3 Field3;

	public readonly _0027p4 Field4;

	public readonly _0027p5 Field5;

	public readonly _0027p6 Field6;

	public readonly _0027p7 Field7;

	public readonly _0027p8 Field8;

	public readonly _0027p9 Field9;

	public readonly _0027p10 Field10;

	public readonly _0027p11 Field11;

	public readonly _0027p12 Field12;

	public readonly _0027p13 Field13;

	public readonly _0027p14 Field14;

	public int GetHashCode(IEqualityComparer _comparer)
	{
		return GetHashCode();
	}

	public bool Equals(object other, IEqualityComparer _comparer)
	{
		return Equals(other);
	}

	public static bool operator !=(Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14> first, Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14> second)
	{
		return !(first == second);
	}

	public static bool operator ==(Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14> first, Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14> second)
	{
		return ((object)first != null) ? first.Equals(second) : ((object)second == null);
	}

	public override int GetHashCode()
	{
		int num = 0;
		num = 0;
		num += EqualityComparer<_0027p0>.Default.GetHashCode(Field0);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p1>.Default.GetHashCode(Field1);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p2>.Default.GetHashCode(Field2);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p3>.Default.GetHashCode(Field3);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p4>.Default.GetHashCode(Field4);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p5>.Default.GetHashCode(Field5);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p6>.Default.GetHashCode(Field6);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p7>.Default.GetHashCode(Field7);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p8>.Default.GetHashCode(Field8);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p9>.Default.GetHashCode(Field9);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p10>.Default.GetHashCode(Field10);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p11>.Default.GetHashCode(Field11);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p12>.Default.GetHashCode(Field12);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p13>.Default.GetHashCode(Field13);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p14>.Default.GetHashCode(Field14);
		num += num << 10;
		return num ^ (num >> 6);
	}

	public override bool Equals(object other)
	{
		return other is Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14> && EqualsImpl((Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14>)other);
	}

	public bool Equals(Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14> other)
	{
		return EqualsImpl(other);
	}

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder("(");
		StringBuilder stringBuilder2 = stringBuilder.Append(Field0);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field1);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field2);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field3);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field4);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field5);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field6);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field7);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field8);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field9);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field10);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field11);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field12);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field13);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field14);
		stringBuilder2 = stringBuilder.Append(")");
		return stringBuilder.ToString();
	}

	private bool EqualsImpl(Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14> other)
	{
		return (object)other != null && EqualityComparer<_0027p14>.Default.Equals(Field14, other.Field14) && EqualityComparer<_0027p13>.Default.Equals(Field13, other.Field13) && EqualityComparer<_0027p12>.Default.Equals(Field12, other.Field12) && EqualityComparer<_0027p11>.Default.Equals(Field11, other.Field11) && EqualityComparer<_0027p10>.Default.Equals(Field10, other.Field10) && EqualityComparer<_0027p9>.Default.Equals(Field9, other.Field9) && EqualityComparer<_0027p8>.Default.Equals(Field8, other.Field8) && EqualityComparer<_0027p7>.Default.Equals(Field7, other.Field7) && EqualityComparer<_0027p6>.Default.Equals(Field6, other.Field6) && EqualityComparer<_0027p5>.Default.Equals(Field5, other.Field5) && EqualityComparer<_0027p4>.Default.Equals(Field4, other.Field4) && EqualityComparer<_0027p3>.Default.Equals(Field3, other.Field3) && EqualityComparer<_0027p2>.Default.Equals(Field2, other.Field2) && EqualityComparer<_0027p1>.Default.Equals(Field1, other.Field1) && (EqualityComparer<_0027p0>.Default.Equals(Field0, other.Field0) ? true : false);
	}

	[RecordCtor]
	public Tuple([MappedMember("Field0")] _0027p0 field0, [MappedMember("Field1")] _0027p1 field1, [MappedMember("Field2")] _0027p2 field2, [MappedMember("Field3")] _0027p3 field3, [MappedMember("Field4")] _0027p4 field4, [MappedMember("Field5")] _0027p5 field5, [MappedMember("Field6")] _0027p6 field6, [MappedMember("Field7")] _0027p7 field7, [MappedMember("Field8")] _0027p8 field8, [MappedMember("Field9")] _0027p9 field9, [MappedMember("Field10")] _0027p10 field10, [MappedMember("Field11")] _0027p11 field11, [MappedMember("Field12")] _0027p12 field12, [MappedMember("Field13")] _0027p13 field13, [MappedMember("Field14")] _0027p14 field14)
	{
		Field0 = field0;
		Field1 = field1;
		Field2 = field2;
		Field3 = field3;
		Field4 = field4;
		Field5 = field5;
		Field6 = field6;
		Field7 = field7;
		Field8 = field8;
		Field9 = field9;
		Field10 = field10;
		Field11 = field11;
		Field12 = field12;
		Field13 = field13;
		Field14 = field14;
	}
}
[Serializable]
[DebuggerDisplay("({Field0}, {Field1}, {Field2}, {Field3}, {Field4}, {Field5}, {Field6}, {Field7}, {Field8}, {Field9}, {Field10}, {Field11}, {Field12}, {Field13}, {Field14}, {Field15})")]
[DebuggerNonUserCode]
public sealed class Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14, _0027p15> : IEquatable<Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14, _0027p15>>, IStructuralEquatable
{
	public readonly _0027p0 Field0;

	public readonly _0027p1 Field1;

	public readonly _0027p2 Field2;

	public readonly _0027p3 Field3;

	public readonly _0027p4 Field4;

	public readonly _0027p5 Field5;

	public readonly _0027p6 Field6;

	public readonly _0027p7 Field7;

	public readonly _0027p8 Field8;

	public readonly _0027p9 Field9;

	public readonly _0027p10 Field10;

	public readonly _0027p11 Field11;

	public readonly _0027p12 Field12;

	public readonly _0027p13 Field13;

	public readonly _0027p14 Field14;

	public readonly _0027p15 Field15;

	public int GetHashCode(IEqualityComparer _comparer)
	{
		return GetHashCode();
	}

	public bool Equals(object other, IEqualityComparer _comparer)
	{
		return Equals(other);
	}

	public static bool operator !=(Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14, _0027p15> first, Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14, _0027p15> second)
	{
		return !(first == second);
	}

	public static bool operator ==(Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14, _0027p15> first, Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14, _0027p15> second)
	{
		return ((object)first != null) ? first.Equals(second) : ((object)second == null);
	}

	public override int GetHashCode()
	{
		int num = 0;
		num = 0;
		num += EqualityComparer<_0027p0>.Default.GetHashCode(Field0);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p1>.Default.GetHashCode(Field1);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p2>.Default.GetHashCode(Field2);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p3>.Default.GetHashCode(Field3);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p4>.Default.GetHashCode(Field4);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p5>.Default.GetHashCode(Field5);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p6>.Default.GetHashCode(Field6);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p7>.Default.GetHashCode(Field7);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p8>.Default.GetHashCode(Field8);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p9>.Default.GetHashCode(Field9);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p10>.Default.GetHashCode(Field10);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p11>.Default.GetHashCode(Field11);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p12>.Default.GetHashCode(Field12);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p13>.Default.GetHashCode(Field13);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p14>.Default.GetHashCode(Field14);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p15>.Default.GetHashCode(Field15);
		num += num << 10;
		return num ^ (num >> 6);
	}

	public override bool Equals(object other)
	{
		return other is Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14, _0027p15> && EqualsImpl((Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14, _0027p15>)other);
	}

	public bool Equals(Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14, _0027p15> other)
	{
		return EqualsImpl(other);
	}

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder("(");
		StringBuilder stringBuilder2 = stringBuilder.Append(Field0);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field1);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field2);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field3);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field4);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field5);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field6);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field7);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field8);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field9);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field10);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field11);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field12);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field13);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field14);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field15);
		stringBuilder2 = stringBuilder.Append(")");
		return stringBuilder.ToString();
	}

	private bool EqualsImpl(Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14, _0027p15> other)
	{
		return (object)other != null && EqualityComparer<_0027p15>.Default.Equals(Field15, other.Field15) && EqualityComparer<_0027p14>.Default.Equals(Field14, other.Field14) && EqualityComparer<_0027p13>.Default.Equals(Field13, other.Field13) && EqualityComparer<_0027p12>.Default.Equals(Field12, other.Field12) && EqualityComparer<_0027p11>.Default.Equals(Field11, other.Field11) && EqualityComparer<_0027p10>.Default.Equals(Field10, other.Field10) && EqualityComparer<_0027p9>.Default.Equals(Field9, other.Field9) && EqualityComparer<_0027p8>.Default.Equals(Field8, other.Field8) && EqualityComparer<_0027p7>.Default.Equals(Field7, other.Field7) && EqualityComparer<_0027p6>.Default.Equals(Field6, other.Field6) && EqualityComparer<_0027p5>.Default.Equals(Field5, other.Field5) && EqualityComparer<_0027p4>.Default.Equals(Field4, other.Field4) && EqualityComparer<_0027p3>.Default.Equals(Field3, other.Field3) && EqualityComparer<_0027p2>.Default.Equals(Field2, other.Field2) && EqualityComparer<_0027p1>.Default.Equals(Field1, other.Field1) && (EqualityComparer<_0027p0>.Default.Equals(Field0, other.Field0) ? true : false);
	}

	[RecordCtor]
	public Tuple([MappedMember("Field0")] _0027p0 field0, [MappedMember("Field1")] _0027p1 field1, [MappedMember("Field2")] _0027p2 field2, [MappedMember("Field3")] _0027p3 field3, [MappedMember("Field4")] _0027p4 field4, [MappedMember("Field5")] _0027p5 field5, [MappedMember("Field6")] _0027p6 field6, [MappedMember("Field7")] _0027p7 field7, [MappedMember("Field8")] _0027p8 field8, [MappedMember("Field9")] _0027p9 field9, [MappedMember("Field10")] _0027p10 field10, [MappedMember("Field11")] _0027p11 field11, [MappedMember("Field12")] _0027p12 field12, [MappedMember("Field13")] _0027p13 field13, [MappedMember("Field14")] _0027p14 field14, [MappedMember("Field15")] _0027p15 field15)
	{
		Field0 = field0;
		Field1 = field1;
		Field2 = field2;
		Field3 = field3;
		Field4 = field4;
		Field5 = field5;
		Field6 = field6;
		Field7 = field7;
		Field8 = field8;
		Field9 = field9;
		Field10 = field10;
		Field11 = field11;
		Field12 = field12;
		Field13 = field13;
		Field14 = field14;
		Field15 = field15;
	}
}
[Serializable]
[DebuggerNonUserCode]
[DebuggerDisplay("({Field0}, {Field1}, {Field2}, {Field3}, {Field4}, {Field5}, {Field6}, {Field7}, {Field8}, {Field9}, {Field10}, {Field11}, {Field12}, {Field13}, {Field14}, {Field15}, {Field16})")]
public sealed class Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14, _0027p15, _0027p16> : IEquatable<Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14, _0027p15, _0027p16>>, IStructuralEquatable
{
	public readonly _0027p0 Field0;

	public readonly _0027p1 Field1;

	public readonly _0027p2 Field2;

	public readonly _0027p3 Field3;

	public readonly _0027p4 Field4;

	public readonly _0027p5 Field5;

	public readonly _0027p6 Field6;

	public readonly _0027p7 Field7;

	public readonly _0027p8 Field8;

	public readonly _0027p9 Field9;

	public readonly _0027p10 Field10;

	public readonly _0027p11 Field11;

	public readonly _0027p12 Field12;

	public readonly _0027p13 Field13;

	public readonly _0027p14 Field14;

	public readonly _0027p15 Field15;

	public readonly _0027p16 Field16;

	public int GetHashCode(IEqualityComparer _comparer)
	{
		return GetHashCode();
	}

	public bool Equals(object other, IEqualityComparer _comparer)
	{
		return Equals(other);
	}

	public static bool operator !=(Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14, _0027p15, _0027p16> first, Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14, _0027p15, _0027p16> second)
	{
		return !(first == second);
	}

	public static bool operator ==(Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14, _0027p15, _0027p16> first, Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14, _0027p15, _0027p16> second)
	{
		return ((object)first != null) ? first.Equals(second) : ((object)second == null);
	}

	public override int GetHashCode()
	{
		int num = 0;
		num = 0;
		num += EqualityComparer<_0027p0>.Default.GetHashCode(Field0);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p1>.Default.GetHashCode(Field1);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p2>.Default.GetHashCode(Field2);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p3>.Default.GetHashCode(Field3);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p4>.Default.GetHashCode(Field4);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p5>.Default.GetHashCode(Field5);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p6>.Default.GetHashCode(Field6);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p7>.Default.GetHashCode(Field7);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p8>.Default.GetHashCode(Field8);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p9>.Default.GetHashCode(Field9);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p10>.Default.GetHashCode(Field10);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p11>.Default.GetHashCode(Field11);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p12>.Default.GetHashCode(Field12);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p13>.Default.GetHashCode(Field13);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p14>.Default.GetHashCode(Field14);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p15>.Default.GetHashCode(Field15);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p16>.Default.GetHashCode(Field16);
		num += num << 10;
		return num ^ (num >> 6);
	}

	public override bool Equals(object other)
	{
		return other is Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14, _0027p15, _0027p16> && EqualsImpl((Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14, _0027p15, _0027p16>)other);
	}

	public bool Equals(Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14, _0027p15, _0027p16> other)
	{
		return EqualsImpl(other);
	}

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder("(");
		StringBuilder stringBuilder2 = stringBuilder.Append(Field0);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field1);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field2);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field3);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field4);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field5);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field6);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field7);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field8);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field9);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field10);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field11);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field12);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field13);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field14);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field15);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field16);
		stringBuilder2 = stringBuilder.Append(")");
		return stringBuilder.ToString();
	}

	private bool EqualsImpl(Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14, _0027p15, _0027p16> other)
	{
		return (object)other != null && EqualityComparer<_0027p16>.Default.Equals(Field16, other.Field16) && EqualityComparer<_0027p15>.Default.Equals(Field15, other.Field15) && EqualityComparer<_0027p14>.Default.Equals(Field14, other.Field14) && EqualityComparer<_0027p13>.Default.Equals(Field13, other.Field13) && EqualityComparer<_0027p12>.Default.Equals(Field12, other.Field12) && EqualityComparer<_0027p11>.Default.Equals(Field11, other.Field11) && EqualityComparer<_0027p10>.Default.Equals(Field10, other.Field10) && EqualityComparer<_0027p9>.Default.Equals(Field9, other.Field9) && EqualityComparer<_0027p8>.Default.Equals(Field8, other.Field8) && EqualityComparer<_0027p7>.Default.Equals(Field7, other.Field7) && EqualityComparer<_0027p6>.Default.Equals(Field6, other.Field6) && EqualityComparer<_0027p5>.Default.Equals(Field5, other.Field5) && EqualityComparer<_0027p4>.Default.Equals(Field4, other.Field4) && EqualityComparer<_0027p3>.Default.Equals(Field3, other.Field3) && EqualityComparer<_0027p2>.Default.Equals(Field2, other.Field2) && EqualityComparer<_0027p1>.Default.Equals(Field1, other.Field1) && (EqualityComparer<_0027p0>.Default.Equals(Field0, other.Field0) ? true : false);
	}

	[RecordCtor]
	public Tuple([MappedMember("Field0")] _0027p0 field0, [MappedMember("Field1")] _0027p1 field1, [MappedMember("Field2")] _0027p2 field2, [MappedMember("Field3")] _0027p3 field3, [MappedMember("Field4")] _0027p4 field4, [MappedMember("Field5")] _0027p5 field5, [MappedMember("Field6")] _0027p6 field6, [MappedMember("Field7")] _0027p7 field7, [MappedMember("Field8")] _0027p8 field8, [MappedMember("Field9")] _0027p9 field9, [MappedMember("Field10")] _0027p10 field10, [MappedMember("Field11")] _0027p11 field11, [MappedMember("Field12")] _0027p12 field12, [MappedMember("Field13")] _0027p13 field13, [MappedMember("Field14")] _0027p14 field14, [MappedMember("Field15")] _0027p15 field15, [MappedMember("Field16")] _0027p16 field16)
	{
		Field0 = field0;
		Field1 = field1;
		Field2 = field2;
		Field3 = field3;
		Field4 = field4;
		Field5 = field5;
		Field6 = field6;
		Field7 = field7;
		Field8 = field8;
		Field9 = field9;
		Field10 = field10;
		Field11 = field11;
		Field12 = field12;
		Field13 = field13;
		Field14 = field14;
		Field15 = field15;
		Field16 = field16;
	}
}
[Serializable]
[DebuggerDisplay("({Field0}, {Field1}, {Field2}, {Field3}, {Field4}, {Field5}, {Field6}, {Field7}, {Field8}, {Field9}, {Field10}, {Field11}, {Field12}, {Field13}, {Field14}, {Field15}, {Field16}, {Field17})")]
[DebuggerNonUserCode]
public sealed class Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14, _0027p15, _0027p16, _0027p17> : IEquatable<Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14, _0027p15, _0027p16, _0027p17>>, IStructuralEquatable
{
	public readonly _0027p0 Field0;

	public readonly _0027p1 Field1;

	public readonly _0027p2 Field2;

	public readonly _0027p3 Field3;

	public readonly _0027p4 Field4;

	public readonly _0027p5 Field5;

	public readonly _0027p6 Field6;

	public readonly _0027p7 Field7;

	public readonly _0027p8 Field8;

	public readonly _0027p9 Field9;

	public readonly _0027p10 Field10;

	public readonly _0027p11 Field11;

	public readonly _0027p12 Field12;

	public readonly _0027p13 Field13;

	public readonly _0027p14 Field14;

	public readonly _0027p15 Field15;

	public readonly _0027p16 Field16;

	public readonly _0027p17 Field17;

	public int GetHashCode(IEqualityComparer _comparer)
	{
		return GetHashCode();
	}

	public bool Equals(object other, IEqualityComparer _comparer)
	{
		return Equals(other);
	}

	public static bool operator !=(Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14, _0027p15, _0027p16, _0027p17> first, Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14, _0027p15, _0027p16, _0027p17> second)
	{
		return !(first == second);
	}

	public static bool operator ==(Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14, _0027p15, _0027p16, _0027p17> first, Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14, _0027p15, _0027p16, _0027p17> second)
	{
		return ((object)first != null) ? first.Equals(second) : ((object)second == null);
	}

	public override int GetHashCode()
	{
		int num = 0;
		num = 0;
		num += EqualityComparer<_0027p0>.Default.GetHashCode(Field0);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p1>.Default.GetHashCode(Field1);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p2>.Default.GetHashCode(Field2);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p3>.Default.GetHashCode(Field3);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p4>.Default.GetHashCode(Field4);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p5>.Default.GetHashCode(Field5);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p6>.Default.GetHashCode(Field6);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p7>.Default.GetHashCode(Field7);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p8>.Default.GetHashCode(Field8);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p9>.Default.GetHashCode(Field9);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p10>.Default.GetHashCode(Field10);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p11>.Default.GetHashCode(Field11);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p12>.Default.GetHashCode(Field12);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p13>.Default.GetHashCode(Field13);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p14>.Default.GetHashCode(Field14);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p15>.Default.GetHashCode(Field15);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p16>.Default.GetHashCode(Field16);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p17>.Default.GetHashCode(Field17);
		num += num << 10;
		return num ^ (num >> 6);
	}

	public override bool Equals(object other)
	{
		return other is Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14, _0027p15, _0027p16, _0027p17> && EqualsImpl((Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14, _0027p15, _0027p16, _0027p17>)other);
	}

	public bool Equals(Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14, _0027p15, _0027p16, _0027p17> other)
	{
		return EqualsImpl(other);
	}

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder("(");
		StringBuilder stringBuilder2 = stringBuilder.Append(Field0);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field1);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field2);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field3);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field4);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field5);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field6);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field7);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field8);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field9);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field10);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field11);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field12);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field13);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field14);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field15);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field16);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field17);
		stringBuilder2 = stringBuilder.Append(")");
		return stringBuilder.ToString();
	}

	private bool EqualsImpl(Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14, _0027p15, _0027p16, _0027p17> other)
	{
		return (object)other != null && EqualityComparer<_0027p17>.Default.Equals(Field17, other.Field17) && EqualityComparer<_0027p16>.Default.Equals(Field16, other.Field16) && EqualityComparer<_0027p15>.Default.Equals(Field15, other.Field15) && EqualityComparer<_0027p14>.Default.Equals(Field14, other.Field14) && EqualityComparer<_0027p13>.Default.Equals(Field13, other.Field13) && EqualityComparer<_0027p12>.Default.Equals(Field12, other.Field12) && EqualityComparer<_0027p11>.Default.Equals(Field11, other.Field11) && EqualityComparer<_0027p10>.Default.Equals(Field10, other.Field10) && EqualityComparer<_0027p9>.Default.Equals(Field9, other.Field9) && EqualityComparer<_0027p8>.Default.Equals(Field8, other.Field8) && EqualityComparer<_0027p7>.Default.Equals(Field7, other.Field7) && EqualityComparer<_0027p6>.Default.Equals(Field6, other.Field6) && EqualityComparer<_0027p5>.Default.Equals(Field5, other.Field5) && EqualityComparer<_0027p4>.Default.Equals(Field4, other.Field4) && EqualityComparer<_0027p3>.Default.Equals(Field3, other.Field3) && EqualityComparer<_0027p2>.Default.Equals(Field2, other.Field2) && EqualityComparer<_0027p1>.Default.Equals(Field1, other.Field1) && (EqualityComparer<_0027p0>.Default.Equals(Field0, other.Field0) ? true : false);
	}

	[RecordCtor]
	public Tuple([MappedMember("Field0")] _0027p0 field0, [MappedMember("Field1")] _0027p1 field1, [MappedMember("Field2")] _0027p2 field2, [MappedMember("Field3")] _0027p3 field3, [MappedMember("Field4")] _0027p4 field4, [MappedMember("Field5")] _0027p5 field5, [MappedMember("Field6")] _0027p6 field6, [MappedMember("Field7")] _0027p7 field7, [MappedMember("Field8")] _0027p8 field8, [MappedMember("Field9")] _0027p9 field9, [MappedMember("Field10")] _0027p10 field10, [MappedMember("Field11")] _0027p11 field11, [MappedMember("Field12")] _0027p12 field12, [MappedMember("Field13")] _0027p13 field13, [MappedMember("Field14")] _0027p14 field14, [MappedMember("Field15")] _0027p15 field15, [MappedMember("Field16")] _0027p16 field16, [MappedMember("Field17")] _0027p17 field17)
	{
		Field0 = field0;
		Field1 = field1;
		Field2 = field2;
		Field3 = field3;
		Field4 = field4;
		Field5 = field5;
		Field6 = field6;
		Field7 = field7;
		Field8 = field8;
		Field9 = field9;
		Field10 = field10;
		Field11 = field11;
		Field12 = field12;
		Field13 = field13;
		Field14 = field14;
		Field15 = field15;
		Field16 = field16;
		Field17 = field17;
	}
}
[Serializable]
[DebuggerDisplay("({Field0}, {Field1}, {Field2}, {Field3}, {Field4}, {Field5}, {Field6}, {Field7}, {Field8}, {Field9}, {Field10}, {Field11}, {Field12}, {Field13}, {Field14}, {Field15}, {Field16}, {Field17}, {Field18})")]
[DebuggerNonUserCode]
public sealed class Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14, _0027p15, _0027p16, _0027p17, _0027p18> : IEquatable<Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14, _0027p15, _0027p16, _0027p17, _0027p18>>, IStructuralEquatable
{
	public readonly _0027p0 Field0;

	public readonly _0027p1 Field1;

	public readonly _0027p2 Field2;

	public readonly _0027p3 Field3;

	public readonly _0027p4 Field4;

	public readonly _0027p5 Field5;

	public readonly _0027p6 Field6;

	public readonly _0027p7 Field7;

	public readonly _0027p8 Field8;

	public readonly _0027p9 Field9;

	public readonly _0027p10 Field10;

	public readonly _0027p11 Field11;

	public readonly _0027p12 Field12;

	public readonly _0027p13 Field13;

	public readonly _0027p14 Field14;

	public readonly _0027p15 Field15;

	public readonly _0027p16 Field16;

	public readonly _0027p17 Field17;

	public readonly _0027p18 Field18;

	public int GetHashCode(IEqualityComparer _comparer)
	{
		return GetHashCode();
	}

	public bool Equals(object other, IEqualityComparer _comparer)
	{
		return Equals(other);
	}

	public static bool operator !=(Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14, _0027p15, _0027p16, _0027p17, _0027p18> first, Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14, _0027p15, _0027p16, _0027p17, _0027p18> second)
	{
		return !(first == second);
	}

	public static bool operator ==(Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14, _0027p15, _0027p16, _0027p17, _0027p18> first, Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14, _0027p15, _0027p16, _0027p17, _0027p18> second)
	{
		return ((object)first != null) ? first.Equals(second) : ((object)second == null);
	}

	public override int GetHashCode()
	{
		int num = 0;
		num = 0;
		num += EqualityComparer<_0027p0>.Default.GetHashCode(Field0);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p1>.Default.GetHashCode(Field1);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p2>.Default.GetHashCode(Field2);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p3>.Default.GetHashCode(Field3);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p4>.Default.GetHashCode(Field4);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p5>.Default.GetHashCode(Field5);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p6>.Default.GetHashCode(Field6);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p7>.Default.GetHashCode(Field7);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p8>.Default.GetHashCode(Field8);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p9>.Default.GetHashCode(Field9);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p10>.Default.GetHashCode(Field10);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p11>.Default.GetHashCode(Field11);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p12>.Default.GetHashCode(Field12);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p13>.Default.GetHashCode(Field13);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p14>.Default.GetHashCode(Field14);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p15>.Default.GetHashCode(Field15);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p16>.Default.GetHashCode(Field16);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p17>.Default.GetHashCode(Field17);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p18>.Default.GetHashCode(Field18);
		num += num << 10;
		return num ^ (num >> 6);
	}

	public override bool Equals(object other)
	{
		return other is Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14, _0027p15, _0027p16, _0027p17, _0027p18> && EqualsImpl((Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14, _0027p15, _0027p16, _0027p17, _0027p18>)other);
	}

	public bool Equals(Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14, _0027p15, _0027p16, _0027p17, _0027p18> other)
	{
		return EqualsImpl(other);
	}

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder("(");
		StringBuilder stringBuilder2 = stringBuilder.Append(Field0);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field1);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field2);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field3);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field4);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field5);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field6);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field7);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field8);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field9);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field10);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field11);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field12);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field13);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field14);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field15);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field16);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field17);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field18);
		stringBuilder2 = stringBuilder.Append(")");
		return stringBuilder.ToString();
	}

	private bool EqualsImpl(Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14, _0027p15, _0027p16, _0027p17, _0027p18> other)
	{
		return (object)other != null && EqualityComparer<_0027p18>.Default.Equals(Field18, other.Field18) && EqualityComparer<_0027p17>.Default.Equals(Field17, other.Field17) && EqualityComparer<_0027p16>.Default.Equals(Field16, other.Field16) && EqualityComparer<_0027p15>.Default.Equals(Field15, other.Field15) && EqualityComparer<_0027p14>.Default.Equals(Field14, other.Field14) && EqualityComparer<_0027p13>.Default.Equals(Field13, other.Field13) && EqualityComparer<_0027p12>.Default.Equals(Field12, other.Field12) && EqualityComparer<_0027p11>.Default.Equals(Field11, other.Field11) && EqualityComparer<_0027p10>.Default.Equals(Field10, other.Field10) && EqualityComparer<_0027p9>.Default.Equals(Field9, other.Field9) && EqualityComparer<_0027p8>.Default.Equals(Field8, other.Field8) && EqualityComparer<_0027p7>.Default.Equals(Field7, other.Field7) && EqualityComparer<_0027p6>.Default.Equals(Field6, other.Field6) && EqualityComparer<_0027p5>.Default.Equals(Field5, other.Field5) && EqualityComparer<_0027p4>.Default.Equals(Field4, other.Field4) && EqualityComparer<_0027p3>.Default.Equals(Field3, other.Field3) && EqualityComparer<_0027p2>.Default.Equals(Field2, other.Field2) && EqualityComparer<_0027p1>.Default.Equals(Field1, other.Field1) && (EqualityComparer<_0027p0>.Default.Equals(Field0, other.Field0) ? true : false);
	}

	[RecordCtor]
	public Tuple([MappedMember("Field0")] _0027p0 field0, [MappedMember("Field1")] _0027p1 field1, [MappedMember("Field2")] _0027p2 field2, [MappedMember("Field3")] _0027p3 field3, [MappedMember("Field4")] _0027p4 field4, [MappedMember("Field5")] _0027p5 field5, [MappedMember("Field6")] _0027p6 field6, [MappedMember("Field7")] _0027p7 field7, [MappedMember("Field8")] _0027p8 field8, [MappedMember("Field9")] _0027p9 field9, [MappedMember("Field10")] _0027p10 field10, [MappedMember("Field11")] _0027p11 field11, [MappedMember("Field12")] _0027p12 field12, [MappedMember("Field13")] _0027p13 field13, [MappedMember("Field14")] _0027p14 field14, [MappedMember("Field15")] _0027p15 field15, [MappedMember("Field16")] _0027p16 field16, [MappedMember("Field17")] _0027p17 field17, [MappedMember("Field18")] _0027p18 field18)
	{
		Field0 = field0;
		Field1 = field1;
		Field2 = field2;
		Field3 = field3;
		Field4 = field4;
		Field5 = field5;
		Field6 = field6;
		Field7 = field7;
		Field8 = field8;
		Field9 = field9;
		Field10 = field10;
		Field11 = field11;
		Field12 = field12;
		Field13 = field13;
		Field14 = field14;
		Field15 = field15;
		Field16 = field16;
		Field17 = field17;
		Field18 = field18;
	}
}
[Serializable]
[DebuggerDisplay("({Field0}, {Field1}, {Field2}, {Field3}, {Field4}, {Field5}, {Field6}, {Field7}, {Field8}, {Field9}, {Field10}, {Field11}, {Field12}, {Field13}, {Field14}, {Field15}, {Field16}, {Field17}, {Field18}, {Field19})")]
[DebuggerNonUserCode]
public sealed class Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14, _0027p15, _0027p16, _0027p17, _0027p18, _0027p19> : IEquatable<Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14, _0027p15, _0027p16, _0027p17, _0027p18, _0027p19>>, IStructuralEquatable
{
	public readonly _0027p0 Field0;

	public readonly _0027p1 Field1;

	public readonly _0027p2 Field2;

	public readonly _0027p3 Field3;

	public readonly _0027p4 Field4;

	public readonly _0027p5 Field5;

	public readonly _0027p6 Field6;

	public readonly _0027p7 Field7;

	public readonly _0027p8 Field8;

	public readonly _0027p9 Field9;

	public readonly _0027p10 Field10;

	public readonly _0027p11 Field11;

	public readonly _0027p12 Field12;

	public readonly _0027p13 Field13;

	public readonly _0027p14 Field14;

	public readonly _0027p15 Field15;

	public readonly _0027p16 Field16;

	public readonly _0027p17 Field17;

	public readonly _0027p18 Field18;

	public readonly _0027p19 Field19;

	public int GetHashCode(IEqualityComparer _comparer)
	{
		return GetHashCode();
	}

	public bool Equals(object other, IEqualityComparer _comparer)
	{
		return Equals(other);
	}

	public static bool operator !=(Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14, _0027p15, _0027p16, _0027p17, _0027p18, _0027p19> first, Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14, _0027p15, _0027p16, _0027p17, _0027p18, _0027p19> second)
	{
		return !(first == second);
	}

	public static bool operator ==(Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14, _0027p15, _0027p16, _0027p17, _0027p18, _0027p19> first, Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14, _0027p15, _0027p16, _0027p17, _0027p18, _0027p19> second)
	{
		return ((object)first != null) ? first.Equals(second) : ((object)second == null);
	}

	public override int GetHashCode()
	{
		int num = 0;
		num = 0;
		num += EqualityComparer<_0027p0>.Default.GetHashCode(Field0);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p1>.Default.GetHashCode(Field1);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p2>.Default.GetHashCode(Field2);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p3>.Default.GetHashCode(Field3);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p4>.Default.GetHashCode(Field4);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p5>.Default.GetHashCode(Field5);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p6>.Default.GetHashCode(Field6);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p7>.Default.GetHashCode(Field7);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p8>.Default.GetHashCode(Field8);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p9>.Default.GetHashCode(Field9);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p10>.Default.GetHashCode(Field10);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p11>.Default.GetHashCode(Field11);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p12>.Default.GetHashCode(Field12);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p13>.Default.GetHashCode(Field13);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p14>.Default.GetHashCode(Field14);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p15>.Default.GetHashCode(Field15);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p16>.Default.GetHashCode(Field16);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p17>.Default.GetHashCode(Field17);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p18>.Default.GetHashCode(Field18);
		num += num << 10;
		num = (num ^ (num >> 6)) + EqualityComparer<_0027p19>.Default.GetHashCode(Field19);
		num += num << 10;
		return num ^ (num >> 6);
	}

	public override bool Equals(object other)
	{
		return other is Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14, _0027p15, _0027p16, _0027p17, _0027p18, _0027p19> && EqualsImpl((Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14, _0027p15, _0027p16, _0027p17, _0027p18, _0027p19>)other);
	}

	public bool Equals(Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14, _0027p15, _0027p16, _0027p17, _0027p18, _0027p19> other)
	{
		return EqualsImpl(other);
	}

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder("(");
		StringBuilder stringBuilder2 = stringBuilder.Append(Field0);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field1);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field2);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field3);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field4);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field5);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field6);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field7);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field8);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field9);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field10);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field11);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field12);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field13);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field14);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field15);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field16);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field17);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field18);
		stringBuilder2 = stringBuilder.Append(", ");
		stringBuilder2 = stringBuilder.Append(Field19);
		stringBuilder2 = stringBuilder.Append(")");
		return stringBuilder.ToString();
	}

	private bool EqualsImpl(Tuple<_0027p0, _0027p1, _0027p2, _0027p3, _0027p4, _0027p5, _0027p6, _0027p7, _0027p8, _0027p9, _0027p10, _0027p11, _0027p12, _0027p13, _0027p14, _0027p15, _0027p16, _0027p17, _0027p18, _0027p19> other)
	{
		return (object)other != null && EqualityComparer<_0027p19>.Default.Equals(Field19, other.Field19) && EqualityComparer<_0027p18>.Default.Equals(Field18, other.Field18) && EqualityComparer<_0027p17>.Default.Equals(Field17, other.Field17) && EqualityComparer<_0027p16>.Default.Equals(Field16, other.Field16) && EqualityComparer<_0027p15>.Default.Equals(Field15, other.Field15) && EqualityComparer<_0027p14>.Default.Equals(Field14, other.Field14) && EqualityComparer<_0027p13>.Default.Equals(Field13, other.Field13) && EqualityComparer<_0027p12>.Default.Equals(Field12, other.Field12) && EqualityComparer<_0027p11>.Default.Equals(Field11, other.Field11) && EqualityComparer<_0027p10>.Default.Equals(Field10, other.Field10) && EqualityComparer<_0027p9>.Default.Equals(Field9, other.Field9) && EqualityComparer<_0027p8>.Default.Equals(Field8, other.Field8) && EqualityComparer<_0027p7>.Default.Equals(Field7, other.Field7) && EqualityComparer<_0027p6>.Default.Equals(Field6, other.Field6) && EqualityComparer<_0027p5>.Default.Equals(Field5, other.Field5) && EqualityComparer<_0027p4>.Default.Equals(Field4, other.Field4) && EqualityComparer<_0027p3>.Default.Equals(Field3, other.Field3) && EqualityComparer<_0027p2>.Default.Equals(Field2, other.Field2) && EqualityComparer<_0027p1>.Default.Equals(Field1, other.Field1) && (EqualityComparer<_0027p0>.Default.Equals(Field0, other.Field0) ? true : false);
	}

	[RecordCtor]
	public Tuple([MappedMember("Field0")] _0027p0 field0, [MappedMember("Field1")] _0027p1 field1, [MappedMember("Field2")] _0027p2 field2, [MappedMember("Field3")] _0027p3 field3, [MappedMember("Field4")] _0027p4 field4, [MappedMember("Field5")] _0027p5 field5, [MappedMember("Field6")] _0027p6 field6, [MappedMember("Field7")] _0027p7 field7, [MappedMember("Field8")] _0027p8 field8, [MappedMember("Field9")] _0027p9 field9, [MappedMember("Field10")] _0027p10 field10, [MappedMember("Field11")] _0027p11 field11, [MappedMember("Field12")] _0027p12 field12, [MappedMember("Field13")] _0027p13 field13, [MappedMember("Field14")] _0027p14 field14, [MappedMember("Field15")] _0027p15 field15, [MappedMember("Field16")] _0027p16 field16, [MappedMember("Field17")] _0027p17 field17, [MappedMember("Field18")] _0027p18 field18, [MappedMember("Field19")] _0027p19 field19)
	{
		Field0 = field0;
		Field1 = field1;
		Field2 = field2;
		Field3 = field3;
		Field4 = field4;
		Field5 = field5;
		Field6 = field6;
		Field7 = field7;
		Field8 = field8;
		Field9 = field9;
		Field10 = field10;
		Field11 = field11;
		Field12 = field12;
		Field13 = field13;
		Field14 = field14;
		Field15 = field15;
		Field16 = field16;
		Field17 = field17;
		Field18 = field18;
		Field19 = field19;
	}
}
