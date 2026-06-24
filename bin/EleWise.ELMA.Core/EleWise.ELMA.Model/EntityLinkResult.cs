using System;

namespace EleWise.ELMA.Model;

public sealed class EntityLinkResult
{
	private string _003CUrl_003Ek__BackingField;

	private Action<object> _003CAction_003Ek__BackingField;

	public string Url
	{
		get
		{
			return _003CUrl_003Ek__BackingField;
		}
		set
		{
			_003CUrl_003Ek__BackingField = value;
		}
	}

	public Action<object> Action
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
}
