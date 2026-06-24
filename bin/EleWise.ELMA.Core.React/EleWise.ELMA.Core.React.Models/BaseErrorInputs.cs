using System;
using EleWise.ELMA.Model.ViewModel;

namespace EleWise.ELMA.Core.React.Models;

internal class BaseErrorInputs : Inputs, IErrorInputs, IInputs
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		public static Func<bool> _003C_003E9__8_0;

		internal bool _003C_002Ector_003Eb__8_0()
		{
			return false;
		}
	}

	private Func<string> _003CMessage_003Ek__BackingField;

	private Func<bool> _003CStackShow_003Ek__BackingField = () => false;

	public Func<string> Message
	{
		get
		{
			return _003CMessage_003Ek__BackingField;
		}
		set
		{
			_003CMessage_003Ek__BackingField = value;
		}
	}

	public Func<bool> StackShow
	{
		get
		{
			return _003CStackShow_003Ek__BackingField;
		}
		set
		{
			_003CStackShow_003Ek__BackingField = value;
		}
	}
}
