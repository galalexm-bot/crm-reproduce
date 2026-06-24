using System;
using System.IO;
using System.Web;
using System.Web.Configuration;
using System.Web.Hosting;
using System.Web.SessionState;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Memory;

namespace EleWise.ELMA.Web.Mvc.Modules;

public abstract class LockFreeSessionStateModule : IHttpModule, IDisposable
{
	private readonly ILogger logger = Logger.GetLogger(typeof(LockFreeSessionStateModule));

	protected int Timeout;

	protected HttpCookieMode CookieMode;

	protected string PartitionResolverType;

	private bool initialized;

	private ISessionIDManager sessionIdManager;

	private static readonly object LockObject = new object();

	private static readonly object SessionDataItemsContextKey = new object();

	private static readonly object SessionDataArrayContextKey = new object();

	private bool acquireCalled;

	private bool releaseCalled;

	private string sessionId;

	public event EventHandler Start;

	internal LockFreeSessionStateModule(int timeout, HttpCookieMode cookieMode)
	{
		Timeout = timeout;
		CookieMode = cookieMode;
	}

	protected LockFreeSessionStateModule()
	{
		Timeout = 30;
		CookieMode = HttpCookieMode.UseCookies;
	}

	public void Init(HttpApplication app)
	{
		app.AcquireRequestState += OnAcquireRequestState;
		app.ReleaseRequestState += OnReleaseRequestState;
		app.EndRequest += OnEndRequest;
		sessionIdManager = new SessionIDManager();
		sessionIdManager.Initialize();
		if (initialized)
		{
			return;
		}
		lock (LockObject)
		{
			if (!initialized)
			{
				SessionStateSection sessionStateSection = (SessionStateSection)WebConfigurationManager.OpenWebConfiguration(HostingEnvironment.ApplicationVirtualPath).GetSection("system.web/sessionState");
				Timeout = (int)sessionStateSection.Timeout.TotalMinutes;
				CookieMode = sessionStateSection.Cookieless;
				PartitionResolverType = sessionStateSection.PartitionResolverType;
				OnInit();
				initialized = true;
			}
		}
	}

	public virtual void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	protected virtual void Dispose(bool disposing)
	{
	}

	private void OnAcquireRequestState(object source, EventArgs args)
	{
		acquireCalled = true;
		HttpContext context = ((HttpApplication)source).Context;
		bool flag = false;
		SessionItem sessionItem = null;
		sessionIdManager.InitializeRequest(context, suppressAutoDetectRedirect: false, out var _);
		sessionId = sessionIdManager.GetSessionID(context);
		if (sessionId != null)
		{
			sessionItem = GetSessionItem(sessionId);
		}
		if (sessionItem == null)
		{
			sessionId = sessionIdManager.CreateSessionID(context);
			sessionIdManager.SaveSessionID(context, sessionId, out var redirected, out var _);
			if (redirected)
			{
				logger.InfoFormat("OnAcquireRequestState Redirected {0}", sessionId);
				return;
			}
			flag = true;
			sessionItem = AddNewSessionItem(sessionId, SessionStateUtility.GetSessionStaticObjects(context));
		}
		SessionStateUtility.AddHttpSessionStateToContext(context, new HttpSessionStateContainer(sessionId, sessionItem.Items, sessionItem.StaticObjects, Timeout, flag, CookieMode, SessionStateMode.Custom, isReadonly: false));
		context.Items[SessionDataItemsContextKey] = sessionItem.Items;
		context.Items[SessionDataArrayContextKey] = sessionItem.DataArray;
		if (flag && this.Start != null)
		{
			this.Start(this, EventArgs.Empty);
		}
	}

	private void OnReleaseRequestState(object source, EventArgs args)
	{
		releaseCalled = true;
		HttpContext context = ((HttpApplication)source).Context;
		HttpSessionStateContainer httpSessionStateContainer = (HttpSessionStateContainer)SessionStateUtility.GetHttpSessionStateFromContext(context);
		ISessionStateItemCollection sessionStateItemCollection = (ISessionStateItemCollection)context.Items[SessionDataItemsContextKey];
		byte[] sessionOriginalDataArray = (byte[])context.Items[SessionDataArrayContextKey];
		if (httpSessionStateContainer.IsNewSession && ELMASessionStateModule.DisableSession)
		{
			logger.InfoFormat("OnReleaseRequestState {0}: ELMASessionStateModule.DisableSession", sessionId);
			httpSessionStateContainer.Abandon();
		}
		else if (!httpSessionStateContainer.IsReadOnly && (httpSessionStateContainer.IsNewSession || sessionStateItemCollection.Dirty))
		{
			SaveAndReleaseSessionItem(sessionId, sessionStateItemCollection, sessionOriginalDataArray, SessionStateUtility.GetSessionStaticObjects(context));
		}
		else if (logger.IsDebugEnabled())
		{
			if (httpSessionStateContainer.IsReadOnly)
			{
				logger.DebugFormat("OnReleaseRequestState {0}: IsReadOnly", sessionId);
			}
			else if (!sessionStateItemCollection.Dirty)
			{
				logger.DebugFormat("OnReleaseRequestState {0}: !Dirty", sessionId);
			}
		}
		if (httpSessionStateContainer.IsAbandoned)
		{
			RemoveSessionItem(sessionId);
			SessionStateUtility.RaiseSessionEnd(httpSessionStateContainer, this, EventArgs.Empty);
		}
		SessionStateUtility.RemoveHttpSessionStateFromContext(context);
	}

	private void OnEndRequest(object source, EventArgs eventArgs)
	{
		try
		{
			if (!releaseCalled && acquireCalled)
			{
				OnReleaseRequestState(source, eventArgs);
			}
			Release();
		}
		finally
		{
			acquireCalled = false;
			releaseCalled = false;
		}
	}

	protected internal virtual void Release()
	{
	}

	protected internal virtual void OnInit()
	{
	}

	protected internal abstract SessionItem AddNewSessionItem(string sessionId, HttpStaticObjectsCollection staticObjects);

	protected internal abstract SessionItem GetSessionItem(string sessionId);

	protected internal abstract void SaveAndReleaseSessionItem(string sessionId, ISessionStateItemCollection sessionItems, byte[] sessionOriginalDataArray, HttpStaticObjectsCollection getSessionStaticObjects);

	protected internal abstract void RemoveSessionItem(string sessionId);

	private static void SerializeToWriter(BinaryWriter writer, SessionItem sessionItem)
	{
		if (sessionItem != null)
		{
			SessionStateItemCollection sessionStateItemCollection = UnWrapSessionItems(sessionItem.Items);
			if (sessionStateItemCollection != null)
			{
				writer.Write(sessionItem.Expires.ToBinary());
				sessionStateItemCollection.Serialize(writer);
				sessionItem.StaticObjects.Serialize(writer);
			}
		}
	}

	private static SessionItem DeserializeFromReader(BinaryReader reader)
	{
		return new SessionItem
		{
			Expires = DateTime.FromBinary(reader.ReadInt64()),
			Items = WrapSessionItems(SessionStateItemCollection.Deserialize(reader)),
			StaticObjects = HttpStaticObjectsCollection.Deserialize(reader)
		};
	}

	protected static SessionStateItemCollection UnWrapSessionItems(ISessionStateItemCollection sessionItemItems)
	{
		return sessionItemItems as SessionStateItemCollection;
	}

	protected static ISessionStateItemCollection WrapSessionItems(SessionStateItemCollection sessionStateItemCollection)
	{
		return sessionStateItemCollection;
	}

	protected static void SaveSessionItemRow(string sessionId, SessionItem sessionData, Action<byte[]> saveAction)
	{
		using MemoryStream memoryStream = MemoryHelper.GetMemoryStream();
		using BinaryWriter writer = new BinaryWriter(memoryStream);
		SerializeToWriter(writer, sessionData);
		byte[] array = memoryStream.ToArray();
		if (sessionData.DataArray != null && CollectionExtensions.ByteArrayCompare(sessionData.DataArray, array))
		{
			return;
		}
		try
		{
			saveAction(array);
			sessionData.DataArray = array;
		}
		catch (Exception message)
		{
			Logger.Log.Error(message);
		}
	}

	protected static SessionItem ReadSessionItemRow(byte[] dataBytes)
	{
		if (dataBytes == null || dataBytes.Length == 0)
		{
			return null;
		}
		SessionItem sessionItem = null;
		using (BinaryReader reader = new BinaryReader(MemoryHelper.GetMemoryStream(dataBytes, writable: false)))
		{
			sessionItem = DeserializeFromReader(reader);
		}
		sessionItem.DataArray = dataBytes;
		return sessionItem;
	}
}
