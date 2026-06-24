using System;
using System.Web.Mvc;

namespace EleWise.ELMA.Web.Actions;

public class DispatchForActionRenderBuilder : IDispatchForActionBuilder
{
	public ContentDispatchAction ContentAction { get; internal set; }

	public DispatchForActionRenderBuilder(Action<HtmlHelper> renderAction, ContentDispatchAction contentAction)
	{
		ContentAction = contentAction;
		ContentAction.OnRenderDelegate = delegate(HtmlHelper h, object[] args)
		{
			renderAction(h);
		};
	}
}
public class DispatchForActionRenderBuilder<T1> : IDispatchForActionBuilder<T1>, IDispatchForActionBuilder
{
	public ContentDispatchAction ContentAction { get; internal set; }

	public DispatchForActionRenderBuilder(Action<HtmlHelper, T1> renderAction, ContentDispatchAction contentAction)
	{
		ContentAction = contentAction;
		ContentAction.OnRenderDelegate = delegate(HtmlHelper h, object[] args)
		{
			renderAction(h, (T1)args[0]);
		};
	}
}
public class DispatchForActionRenderBuilder<T1, T2> : IDispatchForActionBuilder<T1, T2>, IDispatchForActionBuilder
{
	public ContentDispatchAction ContentAction { get; internal set; }

	public DispatchForActionRenderBuilder(Action<HtmlHelper, T1, T2> renderAction, ContentDispatchAction contentAction)
	{
		ContentAction = contentAction;
		ContentAction.OnRenderDelegate = delegate(HtmlHelper h, object[] args)
		{
			renderAction(h, (T1)args[0], (T2)args[1]);
		};
	}
}
