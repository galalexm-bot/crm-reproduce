using System;
using System.Collections.Generic;
using System.Diagnostics;

internal sealed class _003C_003Ef__AnonymousType0<_003Ctestid_003Ej__TPar>
{
	[DebuggerBrowsable(/*Could not decode attribute arguments.*/)]
	private readonly _003Ctestid_003Ej__TPar _003Ctestid_003Ei__Field;

	public _003Ctestid_003Ej__TPar testid => _003Ctestid_003Ei__Field;

	[DebuggerHidden]
	public _003C_003Ef__AnonymousType0(_003Ctestid_003Ej__TPar testid)
	{
		_003Ctestid_003Ei__Field = testid;
	}

	[DebuggerHidden]
	public override bool Equals(object value)
	{
		if (value is _003C_003Ef__AnonymousType0<_003Ctestid_003Ej__TPar> _003C_003Ef__AnonymousType)
		{
			return EqualityComparer<_003Ctestid_003Ej__TPar>.get_Default().Equals(_003Ctestid_003Ei__Field, _003C_003Ef__AnonymousType._003Ctestid_003Ei__Field);
		}
		return false;
	}

	[DebuggerHidden]
	public override int GetHashCode()
	{
		return 496260823 * -1521134295 + EqualityComparer<_003Ctestid_003Ej__TPar>.get_Default().GetHashCode(_003Ctestid_003Ei__Field);
	}

	[DebuggerHidden]
	public override string ToString()
	{
		return string.Format((IFormatProvider)null, "{{ testid = {0} }}", new object[1] { ((object)_003Ctestid_003Ei__Field)?.ToString() });
	}
}
