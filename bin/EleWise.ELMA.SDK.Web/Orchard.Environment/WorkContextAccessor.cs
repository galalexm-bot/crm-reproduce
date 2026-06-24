using System;
using System.Collections.Generic;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Messaging;
using System.Web;
using Autofac;
using EleWise.ELMA.Logging;
using Orchard.Mvc;
using Orchard.Mvc.Extensions;

namespace Orchard.Environment;

public class WorkContextAccessor : ILogicalWorkContextAccessor, IWorkContextAccessor
{
	private class HttpContextScopeImplementation : IWorkContextScope, IDisposable
	{
		private readonly WorkContext _workContext;

		private readonly Action _disposer;

		public WorkContext WorkContext => _workContext;

		public HttpContextScopeImplementation(IEnumerable<IWorkContextEvents> events, ILifetimeScope lifetimeScope, HttpContextBase httpContext, object workContextKey)
		{
			_workContext = ResolutionExtensions.Resolve<WorkContext>((IComponentContext)(object)lifetimeScope);
			httpContext.Items[workContextKey] = _workContext;
			_disposer = delegate
			{
				events.Invoke(delegate(IWorkContextEvents e)
				{
					e.Finished();
				}, NullLogger.Instance);
				httpContext.Items.Remove(workContextKey);
				((IDisposable)lifetimeScope).Dispose();
			};
		}

		void IDisposable.Dispose()
		{
			_disposer();
		}

		public TService Resolve<TService>()
		{
			return WorkContext.Resolve<TService>();
		}

		public bool TryResolve<TService>(out TService service)
		{
			return WorkContext.TryResolve<TService>(out service);
		}
	}

	private class CallContextScopeImplementation : IWorkContextScope, IDisposable
	{
		private readonly WorkContext _workContext;

		private readonly Action _disposer;

		public WorkContext WorkContext => _workContext;

		public CallContextScopeImplementation(IEnumerable<IWorkContextEvents> events, ILifetimeScope lifetimeScope, string workContextSlot)
		{
			CallContext.LogicalSetData(workContextSlot, null);
			_workContext = ResolutionExtensions.Resolve<WorkContext>((IComponentContext)(object)lifetimeScope);
			HttpContextBase httpContext = ResolutionExtensions.Resolve<HttpContextBase>((IComponentContext)(object)lifetimeScope);
			_workContext.HttpContext = httpContext;
			CallContext.LogicalSetData(workContextSlot, new ObjectHandle(_workContext));
			_disposer = delegate
			{
				events.Invoke(delegate(IWorkContextEvents e)
				{
					e.Finished();
				}, NullLogger.Instance);
				CallContext.FreeNamedDataSlot(workContextSlot);
				((IDisposable)lifetimeScope).Dispose();
			};
		}

		void IDisposable.Dispose()
		{
			_disposer();
		}

		public TService Resolve<TService>()
		{
			return WorkContext.Resolve<TService>();
		}

		public bool TryResolve<TService>(out TService service)
		{
			return WorkContext.TryResolve<TService>(out service);
		}
	}

	private readonly ILifetimeScope _lifetimeScope;

	private readonly IHttpContextAccessor _httpContextAccessor;

	private readonly object _workContextKey = new object();

	private readonly string _workContextSlot;

	public WorkContextAccessor(IHttpContextAccessor httpContextAccessor, ILifetimeScope lifetimeScope)
	{
		_httpContextAccessor = httpContextAccessor;
		_lifetimeScope = lifetimeScope;
		_workContextSlot = "WorkContext." + Guid.NewGuid().ToString("n");
	}

	public WorkContext GetContext(HttpContextBase httpContext)
	{
		if (!httpContext.IsBackgroundContext())
		{
			return httpContext.Items[_workContextKey] as WorkContext;
		}
		return GetLogicalContext();
	}

	public WorkContext GetContext()
	{
		HttpContextBase httpContext = _httpContextAccessor.Current();
		return GetContext(httpContext);
	}

	public WorkContext GetLogicalContext()
	{
		if (!(CallContext.LogicalGetData(_workContextSlot) is ObjectHandle objectHandle))
		{
			return null;
		}
		return objectHandle.Unwrap() as WorkContext;
	}

	public IWorkContextScope CreateWorkContextScope(HttpContextBase httpContext)
	{
		ILifetimeScope val = _lifetimeScope.BeginLifetimeScope((object)"work");
		IEnumerable<IWorkContextEvents> events = ResolutionExtensions.Resolve<IEnumerable<IWorkContextEvents>>((IComponentContext)(object)val);
		events.Invoke(delegate(IWorkContextEvents e)
		{
			e.Started();
		}, NullLogger.Instance);
		if (!httpContext.IsBackgroundContext())
		{
			return new HttpContextScopeImplementation(events, val, httpContext, _workContextKey);
		}
		return new CallContextScopeImplementation(events, val, _workContextSlot);
	}

	public IWorkContextScope CreateWorkContextScope()
	{
		HttpContextBase httpContext = _httpContextAccessor.Current();
		return CreateWorkContextScope(httpContext);
	}
}
