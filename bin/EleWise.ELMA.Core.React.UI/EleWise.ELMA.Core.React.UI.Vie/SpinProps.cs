using System;
using Bridge;
using Bridge.Html5;
using Bridge.React;

namespace EleWise.ELMA.Core.React.UI.Views;

[ObjectLiteral]
public class SpinProps : BaseProps
{
	private SpinSize _003CSize_003Ek__BackingField;

	private bool _003CSpinning_003Ek__BackingField;

	private Union<ReactElement, string> _003CTip_003Ek__BackingField;

	private ReactElement _003CIndicator_003Ek__BackingField;

	private Func<HTMLElement> _003CGetContainer_003Ek__BackingField;

	[Name("size")]
	public SpinSize Size
	{
		get
		{
			return _003CSize_003Ek__BackingField;
		}
		set
		{
			_003CSize_003Ek__BackingField = value;
		}
	}

	[Name("spinning")]
	public bool Spinning
	{
		get
		{
			return _003CSpinning_003Ek__BackingField;
		}
		set
		{
			_003CSpinning_003Ek__BackingField = value;
		}
	}

	[Name("tip")]
	public Union<ReactElement, string> Tip
	{
		get
		{
			return _003CTip_003Ek__BackingField;
		}
		set
		{
			_003CTip_003Ek__BackingField = value;
		}
	}

	[Name("indicator")]
	public ReactElement Indicator
	{
		get
		{
			return _003CIndicator_003Ek__BackingField;
		}
		set
		{
			_003CIndicator_003Ek__BackingField = value;
		}
	}

	[Name("getContainer")]
	public Func<HTMLElement> GetContainer
	{
		get
		{
			return _003CGetContainer_003Ek__BackingField;
		}
		set
		{
			_003CGetContainer_003Ek__BackingField = value;
		}
	}
}
