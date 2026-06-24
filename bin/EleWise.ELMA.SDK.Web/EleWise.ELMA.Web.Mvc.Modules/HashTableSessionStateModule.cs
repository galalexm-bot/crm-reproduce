using System;
using System.Collections;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.SessionState;
using EleWise.ELMA.Logging;

namespace EleWise.ELMA.Web.Mvc.Modules;

internal class HashTableSessionStateModule : LockFreeSessionStateModule
{
	private readonly ILogger logger = Logger.GetLogger(typeof(HashTableSessionStateModule));

	private const int TimerSeconds = 10;

	private static Timer timer;

	private static int timerCount;

	private static readonly Hashtable SessionItems = new Hashtable();

	private static readonly ReaderWriterLockSlim HashtableLock = new ReaderWriterLockSlim();

	public HashTableSessionStateModule(int timeout, HttpCookieMode cookieMode)
		: base(timeout, cookieMode)
	{
	}

	public HashTableSessionStateModule()
	{
	}

	protected internal override void OnInit()
	{
		base.OnInit();
		timer = timer ?? new Timer(ExpireCallback, null, 0, 10000);
		timerCount++;
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (disposing && timer != null && --timerCount <= 0)
		{
			timer.Dispose();
			timer = null;
			timerCount = 0;
		}
	}

	protected internal override SessionItem AddNewSessionItem(string sessionId, HttpStaticObjectsCollection staticObjects)
	{
		logger.InfoFormat("AddNewSessionItem {0}", sessionId);
		SessionItem sessionItem = new SessionItem();
		sessionItem.Items = new ThreadSafeSessionStateItemCollection();
		sessionItem.StaticObjects = staticObjects;
		sessionItem.Expires = DateTime.Now.AddMinutes(Timeout);
		try
		{
			HashtableLock.EnterWriteLock();
			SessionItems[sessionId] = sessionItem;
			return sessionItem;
		}
		finally
		{
			HashtableLock.ExitWriteLock();
		}
	}

	protected internal override SessionItem GetSessionItem(string sessionId)
	{
		try
		{
			HashtableLock.EnterReadLock();
			SessionItem sessionItem = (SessionItem)SessionItems[sessionId];
			if (sessionItem != null)
			{
				sessionItem.Expires = DateTime.Now.AddMinutes(Timeout);
			}
			logger.DebugFormat("GetSessionItem {0}: {1}", sessionId, (sessionItem == null) ? "not exists" : "exists");
			return sessionItem;
		}
		finally
		{
			HashtableLock.ExitReadLock();
		}
	}

	protected internal override void SaveAndReleaseSessionItem(string sessionId, ISessionStateItemCollection sessionItems, byte[] sessionOriginalDataArray, HttpStaticObjectsCollection sessionStaticObjects)
	{
		logger.InfoFormat("SaveAndReleaseSessionItem {0}", sessionId);
	}

	private void ExpireCallback(object state)
	{
		try
		{
			HashtableLock.EnterWriteLock();
			RemoveExpiredSessionData();
		}
		finally
		{
			HashtableLock.ExitWriteLock();
		}
	}

	private void RemoveExpiredSessionData()
	{
		DateTime now = DateTime.Now;
		DictionaryEntry[] array = (from DictionaryEntry e in SessionItems
			where DateTime.Compare(((SessionItem)e.Value).Expires, now) <= 0
			select e).ToArray();
		for (int i = 0; i < array.Length; i++)
		{
			DictionaryEntry dictionaryEntry = array[i];
			logger.InfoFormat("RemoveExpiredSessionItem {0}", dictionaryEntry.Key);
			SessionItems.Remove(dictionaryEntry.Key);
			SessionItem sessionItem = (SessionItem)dictionaryEntry.Value;
			SessionStateUtility.RaiseSessionEnd(new HttpSessionStateContainer(dictionaryEntry.Key.ToString(), sessionItem.Items, sessionItem.StaticObjects, Timeout, newSession: false, CookieMode, SessionStateMode.Custom, isReadonly: false), this, EventArgs.Empty);
		}
	}

	protected internal override void RemoveSessionItem(string sessionId)
	{
		if (sessionId != null)
		{
			if (logger.IsInfoEnabled() && SessionItems.ContainsKey(sessionId))
			{
				logger.InfoFormat("RemoveSessionItem {0}", sessionId);
			}
			try
			{
				HashtableLock.EnterWriteLock();
				SessionItems.Remove(sessionId);
			}
			finally
			{
				HashtableLock.ExitWriteLock();
			}
		}
	}
}
