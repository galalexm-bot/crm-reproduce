using Bridge;
using Bridge.React;

namespace EleWise.ELMA.Core.React.UI.Views;

[External]
public class User
{
	[ObjectLiteral]
	public sealed class Props : BaseProps
	{
		private string _003CName_003Ek__BackingField;

		private string _003CPosition_003Ek__BackingField;

		private string _003CAbsenceText_003Ek__BackingField;

		private string _003CSrc_003Ek__BackingField;

		private string _003CAlt_003Ek__BackingField;

		private bool _003CDisabled_003Ek__BackingField;

		private bool _003CIsSelected_003Ek__BackingField;

		private bool _003CIsBlocked_003Ek__BackingField;

		[Name("name")]
		public string Name
		{
			get
			{
				return _003CName_003Ek__BackingField;
			}
			set
			{
				_003CName_003Ek__BackingField = value;
			}
		}

		[Name("position")]
		public string Position
		{
			get
			{
				return _003CPosition_003Ek__BackingField;
			}
			set
			{
				_003CPosition_003Ek__BackingField = value;
			}
		}

		[Name("absenceText")]
		public string AbsenceText
		{
			get
			{
				return _003CAbsenceText_003Ek__BackingField;
			}
			set
			{
				_003CAbsenceText_003Ek__BackingField = value;
			}
		}

		[Name("src")]
		public string Src
		{
			get
			{
				return _003CSrc_003Ek__BackingField;
			}
			set
			{
				_003CSrc_003Ek__BackingField = value;
			}
		}

		[Name("alt")]
		public string Alt
		{
			get
			{
				return _003CAlt_003Ek__BackingField;
			}
			set
			{
				_003CAlt_003Ek__BackingField = value;
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

		[Name("isBlocked")]
		public bool IsBlocked
		{
			get
			{
				return _003CIsBlocked_003Ek__BackingField;
			}
			set
			{
				_003CIsBlocked_003Ek__BackingField = value;
			}
		}
	}

	[Template("React.createElement(elmaComponents.EntityUser, {props}, {children})")]
	public extern User(Props props, params Union<ReactElement, string>[] children);

	public static implicit operator ReactElement(User source)
	{
		return Script.Write<ReactElement>("source", new object[0]);
	}

	public static implicit operator Union<ReactElement, string>(User source)
	{
		return Union<ReactElement, string>.op_Implicit(Script.Write<ReactElement>("source", new object[0]));
	}
}
