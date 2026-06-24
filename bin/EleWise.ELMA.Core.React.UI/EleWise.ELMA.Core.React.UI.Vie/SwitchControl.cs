using Bridge;
using Bridge.React;

namespace EleWise.ELMA.Core.React.UI.Views;

[External]
public sealed class SwitchControl
{
	[ObjectLiteral]
	public sealed class Props : BaseProps
	{
		private Union<ReactElement, string> _003CDisplayName_003Ek__BackingField;

		private ReactElement _003CSwitcher_003Ek__BackingField;

		private bool _003CCompact_003Ek__BackingField;

		private bool _003CIsRequired_003Ek__BackingField;

		[Name("displayName")]
		public Union<ReactElement, string> DisplayName
		{
			get
			{
				return _003CDisplayName_003Ek__BackingField;
			}
			set
			{
				_003CDisplayName_003Ek__BackingField = value;
			}
		}

		[Name("switcher")]
		public ReactElement Switcher
		{
			get
			{
				return _003CSwitcher_003Ek__BackingField;
			}
			set
			{
				_003CSwitcher_003Ek__BackingField = value;
			}
		}

		[Name("compact")]
		public bool Compact
		{
			get
			{
				return _003CCompact_003Ek__BackingField;
			}
			set
			{
				_003CCompact_003Ek__BackingField = value;
			}
		}

		[Name("isRequired")]
		public bool IsRequired
		{
			get
			{
				return _003CIsRequired_003Ek__BackingField;
			}
			set
			{
				_003CIsRequired_003Ek__BackingField = value;
			}
		}
	}

	[Template("React.createElement(elmaComponents.SwitchControl, {props}, {children})")]
	public extern SwitchControl(Props props, params Union<ReactElement, string>[] children);

	public static implicit operator ReactElement(SwitchControl source)
	{
		return Script.Write<ReactElement>("source", new object[0]);
	}

	public static implicit operator Union<ReactElement, string>(SwitchControl source)
	{
		return Union<ReactElement, string>.op_Implicit(Script.Write<ReactElement>("source", new object[0]));
	}
}
