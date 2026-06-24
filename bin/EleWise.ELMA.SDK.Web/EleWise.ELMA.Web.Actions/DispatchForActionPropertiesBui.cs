using System;

namespace EleWise.ELMA.Web.Actions;

public class DispatchForActionPropertiesBuilder : IDispatchForActionBuilder
{
	public ContentDispatchAction ContentAction { get; internal set; }

	public DispatchForActionPropertiesBuilder(ContentDispatchAction contentAction, Action<ContentDispatchAction> changeProperties)
	{
		ContentAction = contentAction;
		changeProperties(ContentAction);
	}
}
public class DispatchForActionPropertiesBuilder<T1> : DispatchForActionPropertiesBuilder, IDispatchForActionBuilder<T1>, IDispatchForActionBuilder
{
	public DispatchForActionPropertiesBuilder(ContentDispatchAction contentAction, Action<ContentDispatchAction> changeProperties)
		: base(contentAction, changeProperties)
	{
	}
}
public class DispatchForActionPropertiesBuilder<T1, T2> : DispatchForActionPropertiesBuilder, IDispatchForActionBuilder<T1, T2>, IDispatchForActionBuilder
{
	public DispatchForActionPropertiesBuilder(ContentDispatchAction contentAction, Action<ContentDispatchAction> changeProperties)
		: base(contentAction, changeProperties)
	{
	}
}
