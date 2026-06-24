using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.SessionState;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Web.Orchard.Mvc.Routes;
using Orchard.Environment;
using Orchard.Environment.Configuration;
using Orchard.Logging;
using Orchard.Mvc.Extensions;

namespace Orchard.Mvc.Routes;

public class ShellRoute : RouteBase, IRouteWithArea
{
	private class RouteHandler : IRouteHandler
	{
		private readonly IWorkContextAccessor _workContextAccessor;

		private readonly IRouteHandler _routeHandler;

		private readonly SessionStateBehavior _sessionStateBehavior;

		private readonly Func<IDictionary<string, object>, Task> _pipeline;

		public RouteHandler(IWorkContextAccessor workContextAccessor, IRouteHandler routeHandler, SessionStateBehavior sessionStateBehavior, Func<IDictionary<string, object>, Task> pipeline)
		{
			_workContextAccessor = workContextAccessor;
			_routeHandler = routeHandler;
			_sessionStateBehavior = sessionStateBehavior;
			_pipeline = pipeline;
		}

		public IHttpHandler GetHttpHandler(RequestContext requestContext)
		{
			IHttpHandler httpHandler = _routeHandler.GetHttpHandler(requestContext);
			requestContext.HttpContext.SetSessionStateBehavior(_sessionStateBehavior);
			IRouteHandler routeHandler = _routeHandler;
			if (routeHandler != null)
			{
				if (routeHandler is AsyncRouteHandler)
				{
					return new HttpAsyncHandler(_workContextAccessor, httpHandler, _pipeline);
				}
				if (routeHandler is MvcRouteHandler)
				{
					return new HttpHandler(_workContextAccessor, httpHandler);
				}
			}
			if (httpHandler is IHttpAsyncHandler)
			{
				return new HttpAsyncHandler(_workContextAccessor, httpHandler, _pipeline);
			}
			return new HttpHandler(_workContextAccessor, httpHandler);
		}
	}

	private class HttpHandler : IHttpHandler, IRequiresSessionState, IHasRequestContext
	{
		private readonly IWorkContextAccessor _workContextAccessor;

		private readonly IHttpHandler _httpHandler;

		public bool IsReusable => false;

		public RequestContext RequestContext
		{
			get
			{
				IHttpHandler httpHandler = _httpHandler;
				MvcHandler val = (MvcHandler)((httpHandler is MvcHandler) ? httpHandler : null);
				if (val != null)
				{
					return val.get_RequestContext();
				}
				return null;
			}
		}

		public HttpHandler(IWorkContextAccessor workContextAccessor, IHttpHandler httpHandler)
		{
			_workContextAccessor = workContextAccessor;
			_httpHandler = httpHandler;
		}

		public void ProcessRequest(HttpContext context)
		{
			using (_workContextAccessor.CreateWorkContextScope(new HttpContextWrapper(context)))
			{
				_httpHandler.ProcessRequest(context);
			}
		}
	}

	private class HttpAsyncHandler : HttpTaskAsyncHandler, IRequiresSessionState, IHasRequestContext
	{
		private readonly IWorkContextAccessor _workContextAccessor;

		private readonly IHttpAsyncHandler _httpAsyncHandler;

		private readonly Func<IDictionary<string, object>, Task> _pipeline;

		public RequestContext RequestContext
		{
			get
			{
				IHttpAsyncHandler httpAsyncHandler = _httpAsyncHandler;
				MvcHandler val = (MvcHandler)((httpAsyncHandler is MvcHandler) ? httpAsyncHandler : null);
				if (val != null)
				{
					return val.get_RequestContext();
				}
				return null;
			}
		}

		public HttpAsyncHandler(IWorkContextAccessor workContextAccessor, IHttpHandler httpHandler, Func<IDictionary<string, object>, Task> env)
		{
			_workContextAccessor = workContextAccessor;
			_httpAsyncHandler = httpHandler as IHttpAsyncHandler;
			_pipeline = env;
		}

		public override void ProcessRequest(HttpContext context)
		{
			throw new NotImplementedException();
		}

		public override async Task ProcessRequestAsync(HttpContext context)
		{
			using (_workContextAccessor.CreateWorkContextScope(new HttpContextWrapper(context)))
			{
				IDictionary<string, object> dictionary = context.Items["owin.Environment"] as IDictionary<string, object>;
				if (dictionary == null)
				{
					dictionary = new Dictionary<string, object>();
				}
				dictionary["orchard.Handler"] = (Func<Task>)async delegate
				{
					await Task.Factory.FromAsync(_httpAsyncHandler.BeginProcessRequest, _httpAsyncHandler.EndProcessRequest, context, null);
				};
				await _pipeline(dictionary);
			}
		}
	}

	private readonly RouteBase _route;

	private readonly ShellSettings _shellSettings;

	private readonly IWorkContextAccessor _workContextAccessor;

	private readonly IRunningShellTable _runningShellTable;

	private readonly Func<IDictionary<string, object>, Task> _pipeline;

	private readonly UrlPrefix _urlPrefix;

	public SessionStateBehavior SessionState { get; set; }

	public string ShellSettingsName => _shellSettings.Name;

	public string Area { get; private set; }

	public bool IsHttpRoute { get; set; }

	public ShellRoute(RouteBase route, ShellSettings shellSettings, IWorkContextAccessor workContextAccessor, IRunningShellTable runningShellTable, Func<IDictionary<string, object>, Task> pipeline)
	{
		_route = route;
		_shellSettings = shellSettings;
		_runningShellTable = runningShellTable;
		_pipeline = pipeline;
		_workContextAccessor = workContextAccessor;
		if (!string.IsNullOrEmpty(_shellSettings.RequestUrlPrefix))
		{
			_urlPrefix = new UrlPrefix(_shellSettings.RequestUrlPrefix);
		}
		Area = route.GetAreaName();
	}

	public override RouteData GetRouteData(HttpContextBase httpContext)
	{
		ShellSettings shellSettings = _runningShellTable.Match(httpContext);
		if (shellSettings == null || shellSettings.Name != _shellSettings.Name)
		{
			return null;
		}
		HttpContextBase httpContext2 = httpContext;
		if (_urlPrefix != null)
		{
			httpContext2 = new UrlPrefixAdjustedHttpContext(httpContext, _urlPrefix);
		}
		RouteData routeData = _route.GetRouteData(httpContext2);
		if (routeData == null)
		{
			return null;
		}
		if (routeData.RouteHandler is StopRoutingHandler)
		{
			return routeData;
		}
		routeData.RouteHandler = new RouteHandler(_workContextAccessor, routeData.RouteHandler, SessionState, _pipeline);
		routeData.DataTokens["IWorkContextAccessor"] = _workContextAccessor;
		if (IsHttpRoute)
		{
			routeData.Values["IWorkContextAccessor"] = _workContextAccessor;
		}
		return routeData;
	}

	public override VirtualPathData GetVirtualPath(RequestContext requestContext, RouteValueDictionary values)
	{
		if (values.TryGetValue("httproute", out var value) && value is bool && (bool)value != IsHttpRoute)
		{
			return null;
		}
		ShellSettings shellSettings = _runningShellTable.Match(requestContext.HttpContext);
		if (shellSettings == null || shellSettings.Name != _shellSettings.Name)
		{
			return null;
		}
		RequestContext requestContext2 = requestContext;
		if (_urlPrefix != null)
		{
			requestContext2 = new RequestContext(new UrlPrefixAdjustedHttpContext(requestContext.HttpContext, _urlPrefix), requestContext.RouteData);
		}
		if (values.ContainsKey("jsonData"))
		{
			values.Remove("jsonData");
		}
		try
		{
			VirtualPathData virtualPath = _route.GetVirtualPath(requestContext2, values);
			if (virtualPath == null)
			{
				return null;
			}
			if (_urlPrefix != null)
			{
				virtualPath.VirtualPath = _urlPrefix.PrependLeadingSegments(virtualPath.VirtualPath);
			}
			return virtualPath;
		}
		catch (Exception ex)
		{
			string text = "GetVirtualPath Error, values:";
			foreach (KeyValuePair<string, object> value2 in values)
			{
				string text2 = ((value2.Value == null) ? "" : value2.Value.ToString());
				text = string.Format("{0} {1}: {2},", text, value2.Key, (text2.Length > 100) ? (text2.Substring(0, 100) + "...") : text2);
			}
			Logger.Log.Error(text);
			throw new Exception(ex.Message);
		}
	}
}
