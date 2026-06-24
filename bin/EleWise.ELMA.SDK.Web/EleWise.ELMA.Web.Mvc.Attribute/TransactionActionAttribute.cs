using System;
using System.Data;
using System.Web.Mvc;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Web.Mvc.Attributes;

[AttributeUsage(AttributeTargets.Method, Inherited = true, AllowMultiple = false)]
public class TransactionActionAttribute : ActionFilterAttribute, IExceptionFilter
{
	private const string RequestKey = "UOW_ACTION_TransactionActionAttribute";

	public IsolationLevel IsolationLevel { get; private set; }

	public bool CommitOnResultExecuted { get; set; }

	private IUnitOfWorkManager UnitOfWorkManager => Locator.GetService<IUnitOfWorkManager>();

	public TransactionActionAttribute()
	{
		IsolationLevel = IsolationLevel.Unspecified;
	}

	public TransactionActionAttribute(IsolationLevel isolationLevel)
	{
		IsolationLevel = isolationLevel;
	}

	public override void OnActionExecuting(ActionExecutingContext filterContext)
	{
		IUnitOfWorkManager uowManager = UnitOfWorkManager;
		if (filterContext != null && uowManager != null)
		{
			ContextVars.GetOrAdd("UOW_ACTION_TransactionActionAttribute" + ((((ControllerContext)filterContext).get_Controller() != null) ? ((object)((ControllerContext)filterContext).get_Controller()).GetHashCode() : 0), () => uowManager.Create(string.Empty, transactional: true, IsolationLevel));
		}
	}

	public override void OnActionExecuted(ActionExecutedContext filterContext)
	{
		if (filterContext != null && !CommitOnResultExecuted && filterContext.get_Exception() == null)
		{
			Commit((ControllerContext)(object)filterContext);
		}
	}

	public override void OnResultExecuted(ResultExecutedContext filterContext)
	{
		((ActionFilterAttribute)this).OnResultExecuted(filterContext);
		if (filterContext != null && CommitOnResultExecuted && filterContext.get_Exception() == null)
		{
			Commit((ControllerContext)(object)filterContext);
		}
	}

	private void Commit(ControllerContext filterContext)
	{
		if (UnitOfWorkManager != null)
		{
			string name = "UOW_ACTION_TransactionActionAttribute" + ((filterContext != null && filterContext.get_Controller() != null) ? ((object)filterContext.get_Controller()).GetHashCode() : 0);
			if (ContextVars.TryGetValue<IUnitOfWork>(name, out var value) && value != null)
			{
				value.Commit();
				value.Dispose();
				ContextVars.Remove(name);
			}
		}
	}

	public void OnException(ExceptionContext filterContext)
	{
		IUnitOfWorkManager unitOfWorkManager = UnitOfWorkManager;
		if (filterContext != null && unitOfWorkManager != null)
		{
			string name = "UOW_ACTION_TransactionActionAttribute" + ((((ControllerContext)filterContext).get_Controller() != null) ? ((object)((ControllerContext)filterContext).get_Controller()).GetHashCode() : 0);
			if (ContextVars.TryGetValue<IUnitOfWork>(name, out var value) && value != null)
			{
				value.Rollback();
				value.Dispose();
				ContextVars.Remove(name);
			}
		}
	}
}
