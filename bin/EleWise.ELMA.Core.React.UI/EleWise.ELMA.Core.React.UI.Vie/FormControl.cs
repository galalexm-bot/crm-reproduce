using Bridge;
using Bridge.React;

namespace EleWise.ELMA.Core.React.UI.Views.FormControl;

[External]
public sealed class FormControl
{
	[ObjectLiteral]
	public sealed class Props : BaseProps
	{
		private ReactElement _003CCaption_003Ek__BackingField;

		private bool _003CForceVerticalView_003Ek__BackingField;

		private ReactElement _003CValue_003Ek__BackingField;

		private ReactElement _003CDescription_003Ek__BackingField;

		private bool _003CIsRootNested_003Ek__BackingField;

		[Name("caption")]
		public ReactElement Caption
		{
			get
			{
				return _003CCaption_003Ek__BackingField;
			}
			set
			{
				_003CCaption_003Ek__BackingField = value;
			}
		}

		[Name("forceVerticalView")]
		public bool ForceVerticalView
		{
			get
			{
				return _003CForceVerticalView_003Ek__BackingField;
			}
			set
			{
				_003CForceVerticalView_003Ek__BackingField = value;
			}
		}

		[Name("value")]
		public ReactElement Value
		{
			get
			{
				return _003CValue_003Ek__BackingField;
			}
			set
			{
				_003CValue_003Ek__BackingField = value;
			}
		}

		[Name("description")]
		public ReactElement Description
		{
			get
			{
				return _003CDescription_003Ek__BackingField;
			}
			set
			{
				_003CDescription_003Ek__BackingField = value;
			}
		}

		[Name("isRootNested")]
		public bool IsRootNested
		{
			get
			{
				return _003CIsRootNested_003Ek__BackingField;
			}
			set
			{
				_003CIsRootNested_003Ek__BackingField = value;
			}
		}
	}

	[Template("React.createElement(elmaComponents.FormControl, {props})")]
	public extern FormControl(Props props);

	public static implicit operator ReactElement(FormControl source)
	{
		return Script.Write<ReactElement>("source", new object[0]);
	}

	public static implicit operator Union<ReactElement, string>(FormControl source)
	{
		return Union<ReactElement, string>.op_Implicit(Script.Write<ReactElement>("source", new object[0]));
	}
}
