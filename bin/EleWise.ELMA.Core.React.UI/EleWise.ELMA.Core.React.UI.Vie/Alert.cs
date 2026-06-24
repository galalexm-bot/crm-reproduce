using System;
using System.Collections.Generic;
using Bridge;
using Bridge.Html5;
using Bridge.React;

namespace EleWise.ELMA.Core.React.UI.Views;

[External]
public sealed class Alert
{
	[ObjectLiteral]
	public sealed class Props : BaseProps
	{
		private bool _003CClosable_003Ek__BackingField;

		private AlertType _003CType_003Ek__BackingField;

		private Action<HTMLAnchorElement> _003COnClose_003Ek__BackingField;

		[Name("closable")]
		public bool Closable
		{
			get
			{
				return _003CClosable_003Ek__BackingField;
			}
			set
			{
				_003CClosable_003Ek__BackingField = value;
			}
		}

		[Name("type")]
		public AlertType Type
		{
			get
			{
				return _003CType_003Ek__BackingField;
			}
			set
			{
				_003CType_003Ek__BackingField = value;
			}
		}

		[Name("onClose")]
		public Action<HTMLAnchorElement> OnClose
		{
			get
			{
				return _003COnClose_003Ek__BackingField;
			}
			set
			{
				_003COnClose_003Ek__BackingField = value;
			}
		}
	}

	[Template("React.createElement(elmaComponents.Alert, {props})")]
	public extern Alert(Props props);

	[Template("React.createElement(elmaComponents.Alert, {props}, {children})")]
	public extern Alert(Props props, params Union<ReactElement, string>[] children);

	[Template("React.createElement(elmaComponents.Alert, {props}, System.Linq.Enumerable.from({children}).ToArray())")]
	public extern Alert(Props props, global::System.Collections.Generic.IEnumerable<ReactElement> children);

	public static implicit operator ReactElement(Alert source)
	{
		return Script.Write<ReactElement>("source", new object[0]);
	}

	public static implicit operator Union<ReactElement, string>(Alert source)
	{
		return Union<ReactElement, string>.op_Implicit(Script.Write<ReactElement>("source", new object[0]));
	}
}
