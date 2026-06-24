using System;
using System.Web.Mvc;
using EleWise.ELMA.CAB.Events;
using EleWise.ELMA.CAB.Utility;
using EleWise.ELMA.Extensions;

namespace EleWise.ELMA.Web.Mvc.Events;

public sealed class MvcEventDispatcher
{
	public const string GUID = "B5D57FE8-34C0-421B-9BF8-97CA5939000F";

	public const string PREFIX = "event://B5D57FE8-34C0-421B-9BF8-97CA5939000F/MvcEventDispatcher/";

	public const string ACTION_EXECUTING = "event://B5D57FE8-34C0-421B-9BF8-97CA5939000F/MvcEventDispatcher/ActionExecuting";

	public const string ACTION_EXECUTED = "event://B5D57FE8-34C0-421B-9BF8-97CA5939000F/MvcEventDispatcher/ActionExecuted";

	public const string RESULT_EXECUTING = "event://B5D57FE8-34C0-421B-9BF8-97CA5939000F/MvcEventDispatcher/ResultExecuting";

	public const string RESULT_EXECUTED = "event://B5D57FE8-34C0-421B-9BF8-97CA5939000F/MvcEventDispatcher/ResultExecuted";

	private static readonly MvcEventDispatcher _instance;

	public static MvcEventDispatcher Instance => _instance;

	[EventPublication("event://B5D57FE8-34C0-421B-9BF8-97CA5939000F/MvcEventDispatcher/ActionExecuting", PublicationScope.Global)]
	public event EventHandler<DataEventArgs<ActionExecutingContext>> ActionExecuting;

	[EventPublication("event://B5D57FE8-34C0-421B-9BF8-97CA5939000F/MvcEventDispatcher/ActionExecuted", PublicationScope.Global)]
	public event EventHandler<DataEventArgs<ActionExecutedContext>> ActionExecuted;

	[EventPublication("event://B5D57FE8-34C0-421B-9BF8-97CA5939000F/MvcEventDispatcher/ResultExecuting", PublicationScope.Global)]
	public event EventHandler<DataEventArgs<ResultExecutingContext>> ResultExecuting;

	[EventPublication("event://B5D57FE8-34C0-421B-9BF8-97CA5939000F/MvcEventDispatcher/ResultExecuted", PublicationScope.Global)]
	public event EventHandler<DataEventArgs<ResultExecutedContext>> ResultExecuted;

	static MvcEventDispatcher()
	{
		_instance = new MvcEventDispatcher();
	}

	private MvcEventDispatcher()
	{
		EventInspector.Register(this);
	}

	internal void OnActionExecuting(DataEventArgs<ActionExecutingContext> e)
	{
		this.ActionExecuting.Raise(this, e);
	}

	internal void OnActionExecuted(DataEventArgs<ActionExecutedContext> e)
	{
		this.ActionExecuted.Raise(this, e);
	}

	internal void OnResultExecuting(DataEventArgs<ResultExecutingContext> e)
	{
		this.ResultExecuting.Raise(this, e);
	}

	internal void OnResultExecuted(DataEventArgs<ResultExecutedContext> e)
	{
		this.ResultExecuted.Raise(this, e);
	}
}
