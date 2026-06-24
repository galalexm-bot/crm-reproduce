using System;
using System.Web;
using System.Web.SessionState;
using EleWise.ELMA.Cache;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Web.Mvc.Modules;

internal class CacheSessionStateModule : HashTableSessionStateModule
{
	private readonly ILogger logger = Logger.GetLogger(typeof(CacheSessionStateModule));

	private readonly ICacheService cacheService;

	public CacheSessionStateModule(int timeout, HttpCookieMode cookieMode)
		: base(timeout, cookieMode)
	{
		cacheService = Locator.GetService<ICacheService>();
	}

	protected internal override SessionItem AddNewSessionItem(string sessionId, HttpStaticObjectsCollection staticObjects)
	{
		SessionItem sessionItem = base.AddNewSessionItem(sessionId, staticObjects);
		sessionItem.Items = LockFreeSessionStateModule.WrapSessionItems(new SessionStateItemCollection());
		sessionItem.Expires = DateTime.MinValue;
		LockFreeSessionStateModule.SaveSessionItemRow(sessionId, sessionItem, delegate
		{
		});
		return sessionItem;
	}

	protected internal override SessionItem GetSessionItem(string sessionId)
	{
		SessionItem sessionItem = base.GetSessionItem(sessionId);
		if (sessionItem == null)
		{
			if (cacheService.TryGetValue<byte[]>(GetKey(sessionId), out var value))
			{
				sessionItem = LockFreeSessionStateModule.ReadSessionItemRow(value);
				logger.DebugFormat("GetSessionItem {0}: exists", sessionId);
			}
			else
			{
				logger.DebugFormat("GetSessionItem {0}: not exists", sessionId);
			}
		}
		return sessionItem;
	}

	protected internal override void SaveAndReleaseSessionItem(string sessionId, ISessionStateItemCollection sessionItems, byte[] sessionOriginalDataArray, HttpStaticObjectsCollection sessionStaticObjects)
	{
		SessionItem sessionData = new SessionItem
		{
			Items = sessionItems,
			StaticObjects = sessionStaticObjects,
			Expires = DateTime.MinValue,
			DataArray = sessionOriginalDataArray
		};
		LockFreeSessionStateModule.SaveSessionItemRow(sessionId, sessionData, delegate(byte[] array)
		{
			cacheService.Insert(GetKey(sessionId), array, TimeSpan.FromMinutes(Timeout));
		});
		logger.InfoFormat("SaveAndReleaseSessionItem {0}", sessionId);
		base.RemoveSessionItem(sessionId);
	}

	protected internal override void RemoveSessionItem(string sessionId)
	{
		base.RemoveSessionItem(sessionId);
		logger.InfoFormat("RemoveSessionItem {0}", sessionId);
		cacheService.Remove(GetKey(sessionId));
	}

	private string GetKey(string sessionId)
	{
		return "SessionState_" + sessionId;
	}
}
