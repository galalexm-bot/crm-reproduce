using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using System.Web.SessionState;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Runtime.Db;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Security;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Web.Mvc.Modules;

internal class DBTableSessionStateModule : HashTableSessionStateModule
{
	private readonly ILogger logger = Logger.GetLogger(typeof(DBTableSessionStateModule));

	private ITransformationProvider transformationProvider;

	private const string SelectSessionRowQuery = "SELECT {1}, {2} FROM {3} WHERE {1} = {0}SessionId";

	private static readonly string TicketUidColumn = AuthenticatedSessionInfo.Db.Fields.TicketUid;

	private static readonly string SessionIdColumn = AuthenticatedSessionInfo.Db.Fields.SessionId;

	private static readonly string SessionDataColumn = AuthenticatedSessionInfo.Db.Fields.SessionData;

	private static readonly string CreationDateColumn = AuthenticatedSessionInfo.Db.Fields.CreationDate;

	private static readonly string LastPingDateColumn = AuthenticatedSessionInfo.Db.Fields.LastPingDate;

	private const string SessionsTable = "ActiveUserSession";

	private static bool? sessionsTableExists;

	private ITransformationProvider Transform
	{
		get
		{
			if (transformationProvider != null)
			{
				return transformationProvider;
			}
			if (Locator.Initialized && ComponentManager.Initialized && ComponentManager.Current.Stage == ComponentManager.LifetimeStage.Initialized)
			{
				ITransformationProvider service = Locator.GetService<ITransformationProvider>();
				if (service != null)
				{
					transformationProvider = service.CreateWithNewConnection();
					return transformationProvider;
				}
			}
			return null;
		}
	}

	public DBTableSessionStateModule(int timeout, HttpCookieMode cookieMode)
		: base(timeout, cookieMode)
	{
	}

	public DBTableSessionStateModule()
	{
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
		if (sessionItem == null && CheckSessionsTableExists())
		{
			using (IDataReader dataReader = Transform.ExecuteQuery(string.Format("SELECT {1}, {2} FROM {3} WHERE {1} = {0}SessionId", Transform.ParameterSeparator, Transform.Dialect.QuoteIfNeeded(SessionIdColumn), Transform.Dialect.QuoteIfNeeded(SessionDataColumn), Transform.Dialect.QuoteIfNeeded("ActiveUserSession")), new Dictionary<string, object> { { SessionIdColumn, sessionId } }))
			{
				if (!dataReader.Read())
				{
					logger.DebugFormat("GetSessionItem {0}: not exists", sessionId);
					return sessionItem;
				}
				sessionItem = LockFreeSessionStateModule.ReadSessionItemRow(dataReader.GetBytes(SessionDataColumn));
				logger.DebugFormat("GetSessionItem {0}: exists", sessionId);
				return sessionItem;
			}
		}
		return sessionItem;
	}

	protected internal override void SaveAndReleaseSessionItem(string sessionId, ISessionStateItemCollection sessionItems, byte[] sessionOriginalDataArray, HttpStaticObjectsCollection sessionStaticObjects)
	{
		if (!CheckSessionsTableExists())
		{
			return;
		}
		SessionItem sessionData = new SessionItem
		{
			Items = sessionItems,
			StaticObjects = sessionStaticObjects,
			Expires = DateTime.MinValue,
			DataArray = sessionOriginalDataArray
		};
		LockFreeSessionStateModule.SaveSessionItemRow(sessionId, sessionData, delegate(byte[] array)
		{
			try
			{
				Transform.BeginTransaction();
				if (Transform.Update("ActiveUserSession", new string[2] { SessionDataColumn, LastPingDateColumn }, new object[2]
				{
					array,
					DateTime.Now
				}, string.Format("{1} = {0}SessionId", Transform.ParameterSeparator, Transform.Dialect.QuoteIfNeeded(SessionIdColumn)), new Dictionary<string, object> { { "SessionId", sessionId } }) == 0)
				{
					Transform.Insert("ActiveUserSession", new string[5] { TicketUidColumn, SessionIdColumn, SessionDataColumn, CreationDateColumn, LastPingDateColumn }, new object[5]
					{
						Guid.NewGuid(),
						sessionId,
						array,
						DateTime.Now,
						DateTime.Now
					});
					logger.InfoFormat("SaveAndReleaseSessionItem Insert {0}", sessionId);
				}
				else
				{
					logger.InfoFormat("SaveAndReleaseSessionItem Update {0}", sessionId);
				}
				Transform.CommitTransaction();
				base.RemoveSessionItem(sessionId);
			}
			catch (Exception exception)
			{
				logger.Error(exception, "SaveAndReleaseSessionItem {0}", sessionId);
				Transform.RollbackTransaction();
				throw;
			}
		});
	}

	protected internal override void RemoveSessionItem(string sessionId)
	{
		base.RemoveSessionItem(sessionId);
		if (CheckSessionsTableExists())
		{
			Transform.BeginTransaction();
			if (Transform.Update("ActiveUserSession", new string[1] { SessionDataColumn }, new object[1]
			{
				new ParameterValue(DbType.Binary, null)
			}, string.Format("{1} = {0}SessionId", Transform.ParameterSeparator, Transform.Dialect.QuoteIfNeeded(SessionIdColumn)), new Dictionary<string, object> { { "SessionId", sessionId } }) > 0)
			{
				logger.InfoFormat("RemoveSessionItem {0}", sessionId);
			}
			Transform.CommitTransaction();
		}
	}

	public override void Dispose()
	{
		base.Dispose();
		Release();
	}

	protected internal override void Release()
	{
		if (transformationProvider != null)
		{
			transformationProvider.Dispose();
			transformationProvider = null;
		}
	}

	private bool CheckSessionsTableExists()
	{
		if (!sessionsTableExists.HasValue)
		{
			if (Transform == null)
			{
				return false;
			}
			if (!sessionsTableExists.HasValue)
			{
				sessionsTableExists = Transform.TableExists("ActiveUserSession");
			}
		}
		return sessionsTableExists.Value;
	}
}
