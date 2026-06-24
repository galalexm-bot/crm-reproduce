using System;
using Bridge;
using Bridge.Html5;

namespace EleWise.ELMA.Model.Common;

[ObjectLiteral]
public class Html5UplOptions
{
	private string _003CAction_003Ek__BackingField;

	private XMLHttpRequest[] _003CXhrObjects_003Ek__BackingField;

	private Action<long, XMLHttpRequest> _003COnComplete_003Ek__BackingField;

	private Action<XMLHttpRequest> _003COnError_003Ek__BackingField;

	[Name("action")]
	public string Action
	{
		get
		{
			return _003CAction_003Ek__BackingField;
		}
		set
		{
			_003CAction_003Ek__BackingField = value;
		}
	}

	[Name("xhrObject")]
	public XMLHttpRequest[] XhrObjects
	{
		get
		{
			return _003CXhrObjects_003Ek__BackingField;
		}
		set
		{
			_003CXhrObjects_003Ek__BackingField = value;
		}
	}

	[Name("onComplete")]
	public Action<long, XMLHttpRequest> OnComplete
	{
		get
		{
			return _003COnComplete_003Ek__BackingField;
		}
		set
		{
			_003COnComplete_003Ek__BackingField = value;
		}
	}

	[Name("onError")]
	public Action<XMLHttpRequest> OnError
	{
		get
		{
			return _003COnError_003Ek__BackingField;
		}
		set
		{
			_003COnError_003Ek__BackingField = value;
		}
	}
}
