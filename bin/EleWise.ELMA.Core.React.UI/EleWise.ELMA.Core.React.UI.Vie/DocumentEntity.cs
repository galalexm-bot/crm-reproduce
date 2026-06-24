using Bridge;
using Bridge.React;

namespace EleWise.ELMA.Core.React.UI.Views;

[External]
public class DocumentEntity
{
	[ObjectLiteral]
	public sealed class Props : BaseProps
	{
		private string _003CTitle_003Ek__BackingField;

		private string _003CDate_003Ek__BackingField;

		private string _003CPath_003Ek__BackingField;

		private bool _003CDisabled_003Ek__BackingField;

		private bool _003CIsSelected_003Ek__BackingField;

		[Name("title")]
		public string Title
		{
			get
			{
				return _003CTitle_003Ek__BackingField;
			}
			set
			{
				_003CTitle_003Ek__BackingField = value;
			}
		}

		[Name("date")]
		public string Date
		{
			get
			{
				return _003CDate_003Ek__BackingField;
			}
			set
			{
				_003CDate_003Ek__BackingField = value;
			}
		}

		[Name("path")]
		public string Path
		{
			get
			{
				return _003CPath_003Ek__BackingField;
			}
			set
			{
				_003CPath_003Ek__BackingField = value;
			}
		}

		[Name("disabled")]
		public bool Disabled
		{
			get
			{
				return _003CDisabled_003Ek__BackingField;
			}
			set
			{
				_003CDisabled_003Ek__BackingField = value;
			}
		}

		[Name("isSelected")]
		public bool IsSelected
		{
			get
			{
				return _003CIsSelected_003Ek__BackingField;
			}
			set
			{
				_003CIsSelected_003Ek__BackingField = value;
			}
		}
	}

	[Template("React.createElement(elmaComponents.EntityDocument, {props}, {children})")]
	public extern DocumentEntity(Props props, params Union<ReactElement, string>[] children);

	public static implicit operator ReactElement(DocumentEntity source)
	{
		return Script.Write<ReactElement>("source", new object[0]);
	}

	public static implicit operator Union<ReactElement, string>(DocumentEntity source)
	{
		return Union<ReactElement, string>.op_Implicit(Script.Write<ReactElement>("source", new object[0]));
	}
}
