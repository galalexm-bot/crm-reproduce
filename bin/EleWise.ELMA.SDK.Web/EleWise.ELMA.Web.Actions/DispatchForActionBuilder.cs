using System;
using System.Linq.Expressions;
using System.Reflection;
using System.Web.Mvc;
using EleWise.ELMA.Actions.Impl;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Model.Managers;

namespace EleWise.ELMA.Web.Actions;

public class DispatchForActionBuilder<TManager> : IDispatchForActionBuilder where TManager : IEntityManager
{
	public MethodInfo ActionMethodInfo { get; internal set; }

	public ContentDispatchAction ContentAction { get; internal set; }

	public DispatchForActionBuilder(MethodInfo actionMethodInfo, ContentDispatchAction contentAction)
	{
		ActionMethodInfo = actionMethodInfo;
		ContentAction = contentAction;
		IAuditEventHolder methodActionInfo = ManagerActionInvokeProvider.GetMethodActionInfo(actionMethodInfo);
		if (methodActionInfo != null)
		{
			ContentAction.Action = methodActionInfo.Action;
			ContentAction.Object = methodActionInfo.Object;
			ContentAction.Id = ContentAction.Object.Name + "_" + ContentAction.Action.Name;
			ContentAction.Name = ContentAction.Action.DisplayName;
			ContentAction.Description = ContentAction.Action.Description;
		}
	}

	public DispatchForActionControllerLinkBuilder<TController> MapHrefTo<TController>(Expression<Func<Action<TController>>> expression) where TController : Controller
	{
		return new DispatchForActionControllerLinkBuilder<TController>(expression, ContentAction);
	}
}
public class DispatchForActionBuilder<TManager, T1> : IDispatchForActionBuilder<T1>, IDispatchForActionBuilder where TManager : IEntityManager
{
	public MethodInfo ActionMethodInfo { get; internal set; }

	[NotNull]
	public ContentDispatchAction ContentAction { get; internal set; }

	public DispatchForActionBuilder(MethodInfo actionMethodInfo, ContentDispatchAction contentAction)
	{
		ActionMethodInfo = actionMethodInfo;
		ContentAction = contentAction;
		IAuditEventHolder methodActionInfo = ManagerActionInvokeProvider.GetMethodActionInfo(actionMethodInfo);
		if (methodActionInfo != null)
		{
			ContentAction.Action = methodActionInfo.Action;
			ContentAction.Object = methodActionInfo.Object;
			ContentAction.Id = ContentAction.Object.Name + "_" + ContentAction.Action.Name;
			ContentAction.Name = ContentAction.Action.DisplayName;
			ContentAction.Description = ContentAction.Action.Description;
		}
	}

	public DispatchForActionControllerLinkBuilder<TController, T1> MapHrefTo<TController>([NotNull] Expression<Func<T1, Action<TController>>> expression) where TController : Controller
	{
		if (expression == null)
		{
			throw new ArgumentNullException("expression");
		}
		return new DispatchForActionControllerLinkBuilder<TController, T1>(expression, ContentAction);
	}
}
public class DispatchForActionBuilder<TManager, T1, T2> : IDispatchForActionBuilder<T1, T2>, IDispatchForActionBuilder where TManager : IEntityManager
{
	public MethodInfo ActionMethodInfo { get; internal set; }

	public ContentDispatchAction ContentAction { get; internal set; }

	public DispatchForActionBuilder(MethodInfo actionMethodInfo, ContentDispatchAction contentAction)
	{
		ActionMethodInfo = actionMethodInfo;
		ContentAction = contentAction;
		IAuditEventHolder methodActionInfo = ManagerActionInvokeProvider.GetMethodActionInfo(actionMethodInfo);
		if (methodActionInfo != null)
		{
			ContentAction.Action = methodActionInfo.Action;
			ContentAction.Object = methodActionInfo.Object;
			ContentAction.Id = ContentAction.Object.Name + "_" + ContentAction.Action.Name;
			ContentAction.Name = ContentAction.Action.DisplayName;
			ContentAction.Description = ContentAction.Action.Description;
		}
	}

	public DispatchForActionControllerLinkBuilder<TController, T1, T2> MapHrefTo<TController>(Expression<Func<T1, T2, Action<TController>>> expression) where TController : Controller
	{
		return new DispatchForActionControllerLinkBuilder<TController, T1, T2>(expression, ContentAction);
	}
}
