using Bridge;
using Bridge.React;

namespace EleWise.ELMA.Core.React.UI.Views;

[External]
public sealed class ProgressBar
{
	[ObjectLiteral]
	public sealed class Props : BaseProps
	{
		private int _003CPercent_003Ek__BackingField;

		private ProgressStatus _003CStatus_003Ek__BackingField;

		private bool _003CShowInfo_003Ek__BackingField;

		[Name("percent")]
		public int Percent
		{
			get
			{
				return _003CPercent_003Ek__BackingField;
			}
			set
			{
				_003CPercent_003Ek__BackingField = value;
			}
		}

		[Name("status")]
		public ProgressStatus Status
		{
			get
			{
				return _003CStatus_003Ek__BackingField;
			}
			set
			{
				_003CStatus_003Ek__BackingField = value;
			}
		}

		[Name("showInfo")]
		public bool ShowInfo
		{
			get
			{
				return _003CShowInfo_003Ek__BackingField;
			}
			set
			{
				_003CShowInfo_003Ek__BackingField = value;
			}
		}
	}

	[Template("React.createElement(elmaComponents.ProgressBar, {props})")]
	public extern ProgressBar(Props props);

	public static implicit operator ReactElement(ProgressBar source)
	{
		return Script.Write<ReactElement>("source", new object[0]);
	}

	public static implicit operator Union<ReactElement, string>(ProgressBar source)
	{
		return Union<ReactElement, string>.op_Implicit(Script.Write<ReactElement>("source", new object[0]));
	}
}
