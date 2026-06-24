using System.Collections.Generic;
using Bridge;
using Bridge.React;

namespace EleWise.ELMA.Core.React.UI.Views;

[External]
public sealed class ApplicationWrapper
{
	[ObjectLiteral]
	public sealed class Props : BaseProps
	{
		private string _003CClassName_003Ek__BackingField;

		[Name("className")]
		public string ClassName
		{
			get
			{
				return _003CClassName_003Ek__BackingField;
			}
			set
			{
				_003CClassName_003Ek__BackingField = value;
			}
		}
	}

	[Template("React.createElement(elmaComponents.ApplicationWrapper, {props}, {children})")]
	public extern ApplicationWrapper(Props props, params Union<ReactElement, string>[] children);

	[Template("React.createElement(elmaComponents.ApplicationWrapper, {props}, System.Linq.Enumerable.from({children}).ToArray())")]
	public extern ApplicationWrapper(Props props, global::System.Collections.Generic.IEnumerable<ReactElement> children);

	public static implicit operator ReactElement(ApplicationWrapper source)
	{
		return Script.Write<ReactElement>("source", new object[0]);
	}

	public static implicit operator Union<ReactElement, string>(ApplicationWrapper source)
	{
		return Union<ReactElement, string>.op_Implicit(Script.Write<ReactElement>("source", new object[0]));
	}
}
