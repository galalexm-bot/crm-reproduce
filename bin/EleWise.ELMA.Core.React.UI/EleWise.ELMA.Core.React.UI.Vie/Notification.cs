using Bridge;
using Bridge.React;

namespace EleWise.ELMA.Core.React.UI.Views;

public sealed class Notification
{
	[ObjectLiteral]
	public sealed class Props
	{
		private NotificationPlacement _003CPlacement_003Ek__BackingField;

		private int _003CDuration_003Ek__BackingField;

		[Name("placement")]
		public NotificationPlacement Placement
		{
			get
			{
				return _003CPlacement_003Ek__BackingField;
			}
			set
			{
				_003CPlacement_003Ek__BackingField = value;
			}
		}

		[Name("duration")]
		public int Duration
		{
			get
			{
				return _003CDuration_003Ek__BackingField;
			}
			set
			{
				_003CDuration_003Ek__BackingField = value;
			}
		}
	}

	[ObjectLiteral]
	[Enum(/*Could not decode attribute arguments.*/)]
	public enum NotificationPlacement
	{
		TopLeft,
		TopRight,
		BottomLeft,
		BottomRight
	}

	[Template("new elmaComponents.Notification({options})")]
	public extern Notification(Props options);

	[Name("success")]
	public extern void Success(string title, Union<ReactElement, string> message);

	[Name("error")]
	public extern void Error(string title, Union<ReactElement, string> message);

	[Name("warning")]
	public extern void Warning(string title, Union<ReactElement, string> message);

	[Name("info")]
	public extern void Info(string title, Union<ReactElement, string> message);

	[Name("destroy")]
	public extern void Destroy();
}
