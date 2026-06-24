using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EleWise.ELMA.Core;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.ExtensionPoints;
using EleWise.ELMA.Core.Logging;
using EleWise.ELMA.Core.Services;

namespace EleWise.ELMA.Model.Actions;

[Service]
internal sealed class ActionExecutionFacade : IActionExecutionFacade
{
	private sealed class _003C_003Ec__DisplayClass8_0
	{
		public IActionExecutionContext context;

		internal bool _003CGetHandler_003Eb__0(IActionExecutionHandler handler)
		{
			return handler.Check(context);
		}
	}

	private readonly INotificationService notificationService;

	private readonly ILogger logger;

	private readonly System.Collections.Generic.IEnumerable<IActionExecutionHandler> handlers;

	public ActionExecutionFacade(INotificationService notificationService, ILogger logger, System.Collections.Generic.IEnumerable<IActionExecutionHandler> handlers)
	{
		this.notificationService = notificationService;
		this.logger = logger;
		this.handlers = handlers;
	}

	public System.Threading.Tasks.Task Execute(IActionExecutionContext context)
	{
		return GetHandler(context).Execute(context).ContinueWith((Action<System.Threading.Tasks.Task>)delegate(System.Threading.Tasks.Task task)
		{
			if (task.get_IsFaulted())
			{
				if (task.get_Exception() != null)
				{
					logger.Error(((System.Exception)(object)task.get_Exception()).get_InnerException());
					throw ((System.Exception)(object)task.get_Exception()).get_InnerException();
				}
				notificationService.Error(SR.T("Ошибка"), SR.T("При выполнении серверного сценария произошла ошибка"));
			}
		});
	}

	public System.Threading.Tasks.Task<TResult> Execute<TResult>(IActionExecutionContext context)
	{
		return GetHandler(context).Execute<TResult>(context).ContinueWith<TResult>((Func<System.Threading.Tasks.Task<TResult>, TResult>)delegate(System.Threading.Tasks.Task<TResult> task)
		{
			if (((System.Threading.Tasks.Task)task).get_IsFaulted())
			{
				if (((System.Threading.Tasks.Task)task).get_Exception() != null)
				{
					logger.Error(((System.Exception)(object)((System.Threading.Tasks.Task)task).get_Exception()).get_InnerException());
					throw ((System.Exception)(object)((System.Threading.Tasks.Task)task).get_Exception()).get_InnerException();
				}
				notificationService.Error(SR.T("Ошибка"), SR.T("При выполнении серверного сценария произошла ошибка"));
				return default(TResult);
			}
			return task.get_Result();
		});
	}

	public System.Threading.Tasks.Task Execute<TParam>(IActionExecutionContext context, TParam parameter)
	{
		return GetHandler(context).Execute(context, parameter).ContinueWith((Action<System.Threading.Tasks.Task>)delegate(System.Threading.Tasks.Task task)
		{
			if (task.get_IsFaulted())
			{
				if (task.get_Exception() != null)
				{
					logger.Error(((System.Exception)(object)task.get_Exception()).get_InnerException());
					throw ((System.Exception)(object)task.get_Exception()).get_InnerException();
				}
				notificationService.Error(SR.T("Ошибка"), SR.T("При выполнении серверного сценария произошла ошибка"));
			}
		});
	}

	public System.Threading.Tasks.Task<TResult> Execute<TParam, TResult>(IActionExecutionContext context, TParam parameter)
	{
		return ((System.Threading.Tasks.Task<_003F>)(object)GetHandler(context).Execute<TParam, TResult>(context, parameter)).ContinueWith<TResult>((Func<System.Threading.Tasks.Task<_003F>, TResult>)(object)(Func<System.Threading.Tasks.Task<TResult>, TResult>)delegate(System.Threading.Tasks.Task<TResult> task)
		{
			if (((System.Threading.Tasks.Task)task).get_IsFaulted())
			{
				if (((System.Threading.Tasks.Task)task).get_Exception() != null)
				{
					logger.Error(((System.Exception)(object)((System.Threading.Tasks.Task)task).get_Exception()).get_InnerException());
					throw ((System.Exception)(object)((System.Threading.Tasks.Task)task).get_Exception()).get_InnerException();
				}
				notificationService.Error(SR.T("Ошибка"), SR.T("При выполнении серверного сценария произошла ошибка"));
				return default(TResult);
			}
			return task.get_Result();
		});
	}

	private IActionExecutionHandler GetHandler(IActionExecutionContext context)
	{
		_003C_003Ec__DisplayClass8_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass8_0();
		CS_0024_003C_003E8__locals0.context = context;
		return Enumerable.First<IActionExecutionHandler>(handlers, (Func<IActionExecutionHandler, bool>)((IActionExecutionHandler handler) => handler.Check(CS_0024_003C_003E8__locals0.context)));
	}

	private void _003CExecute_003Eb__4_0(System.Threading.Tasks.Task task)
	{
		if (task.get_IsFaulted())
		{
			if (task.get_Exception() != null)
			{
				logger.Error(((System.Exception)(object)task.get_Exception()).get_InnerException());
				throw ((System.Exception)(object)task.get_Exception()).get_InnerException();
			}
			notificationService.Error(SR.T("Ошибка"), SR.T("При выполнении серверного сценария произошла ошибка"));
		}
	}

	private TResult _003CExecute_003Eb__5_0<TResult>(System.Threading.Tasks.Task<TResult> task)
	{
		if (((System.Threading.Tasks.Task)task).get_IsFaulted())
		{
			if (((System.Threading.Tasks.Task)task).get_Exception() != null)
			{
				logger.Error(((System.Exception)(object)((System.Threading.Tasks.Task)task).get_Exception()).get_InnerException());
				throw ((System.Exception)(object)((System.Threading.Tasks.Task)task).get_Exception()).get_InnerException();
			}
			notificationService.Error(SR.T("Ошибка"), SR.T("При выполнении серверного сценария произошла ошибка"));
			return default(TResult);
		}
		return task.get_Result();
	}

	private void _003CExecute_003Eb__6_0<TParam>(System.Threading.Tasks.Task task)
	{
		if (task.get_IsFaulted())
		{
			if (task.get_Exception() != null)
			{
				logger.Error(((System.Exception)(object)task.get_Exception()).get_InnerException());
				throw ((System.Exception)(object)task.get_Exception()).get_InnerException();
			}
			notificationService.Error(SR.T("Ошибка"), SR.T("При выполнении серверного сценария произошла ошибка"));
		}
	}

	private TResult _003CExecute_003Eb__7_0<TParam, TResult>(System.Threading.Tasks.Task<TResult> task)
	{
		if (((System.Threading.Tasks.Task)task).get_IsFaulted())
		{
			if (((System.Threading.Tasks.Task)task).get_Exception() != null)
			{
				logger.Error(((System.Exception)(object)((System.Threading.Tasks.Task)task).get_Exception()).get_InnerException());
				throw ((System.Exception)(object)((System.Threading.Tasks.Task)task).get_Exception()).get_InnerException();
			}
			notificationService.Error(SR.T("Ошибка"), SR.T("При выполнении серверного сценария произошла ошибка"));
			return default(TResult);
		}
		return task.get_Result();
	}
}
