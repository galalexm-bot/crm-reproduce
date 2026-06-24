using System;
using Bridge;
using Bridge.React;

namespace EleWise.ELMA.Core.React.UI.Views;

[External]
public sealed class IconSelector
{
	[ObjectLiteral]
	public sealed class Props : BaseProps
	{
		private Action<string> _003COnSelect_003Ek__BackingField;

		private string _003CSelected_003Ek__BackingField;

		private string _003CFilter_003Ek__BackingField;

		[Name("onSelect")]
		public Action<string> OnSelect
		{
			get
			{
				return _003COnSelect_003Ek__BackingField;
			}
			set
			{
				_003COnSelect_003Ek__BackingField = value;
			}
		}

		[Name("selected")]
		public string Selected
		{
			get
			{
				return _003CSelected_003Ek__BackingField;
			}
			set
			{
				_003CSelected_003Ek__BackingField = value;
			}
		}

		[Name("filter")]
		public string Filter
		{
			get
			{
				return _003CFilter_003Ek__BackingField;
			}
			set
			{
				_003CFilter_003Ek__BackingField = value;
			}
		}
	}

	[Template("React.createElement(elmaComponents.IconSelector, {props})")]
	public extern IconSelector(Props props);

	public static implicit operator ReactElement(IconSelector source)
	{
		return Script.Write<ReactElement>("source", new object[0]);
	}

	public static implicit operator Union<ReactElement, string>(IconSelector source)
	{
		return Union<ReactElement, string>.op_Implicit(Script.Write<ReactElement>("source", new object[0]));
	}
}
