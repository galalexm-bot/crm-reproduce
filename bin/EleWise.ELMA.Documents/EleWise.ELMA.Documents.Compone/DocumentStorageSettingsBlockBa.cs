using System;
using System.Collections.Concurrent;
using EleWise.ELMA.Cache;
using EleWise.ELMA.Documents.Extensions;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.Portlets;

namespace EleWise.ELMA.Documents.Components;

public abstract class DocumentStorageSettingsBlockBase<TSettings> : IDocumentStorageSettingsBlock where TSettings : DocumentStorageSettingsBase, new()
{
	public const string CacheRegion = "DocumentStorageSettings";

	private ICacheService _cacheService;

	private ConcurrentDictionary<string, TSettings> _settingsCache = new ConcurrentDictionary<string, TSettings>();

	public abstract Guid BlockUid { get; }

	public abstract string BlockName { get; }

	public virtual TSettings Settings
	{
		get
		{
			if (_settingsCache.TryGetValue(CurrentUserName, out var value))
			{
				return value;
			}
			return LoadSettings();
		}
		set
		{
			if (_settingsCache.ContainsKey(CurrentUserName))
			{
				if (_settingsCache.TryGetValue(CurrentUserName, out var value2))
				{
					_settingsCache.TryUpdate(CurrentUserName, value, value2);
				}
			}
			else
			{
				_settingsCache.TryAdd(CurrentUserName, value);
			}
		}
	}

	object IDocumentStorageSettingsBlock.Settings
	{
		get
		{
			return Settings;
		}
		set
		{
			Settings = (TSettings)value;
		}
	}

	private string CurrentUserName
	{
		get
		{
			IUser currentUser = Locator.GetServiceNotNull<IAuthenticationService>().GetCurrentUser();
			return "u_" + ((currentUser != null) ? currentUser.UserName : "empty");
		}
	}

	protected ICacheService CacheService => _cacheService ?? (_cacheService = Locator.GetServiceNotNull<ICacheService>());

	public void SaveSettings()
	{
		PersonalizationAdministration.SaveState(CurrentUserName, BlockUid.ToString(), Settings);
		_settingsCache.TryRemove(CurrentUserName, out var _);
	}

	protected virtual TSettings LoadSettings()
	{
		TSettings val = null;
		try
		{
			val = PersonalizationAdministration.LoadState<TSettings>(CurrentUserName, BlockUid.ToString());
		}
		catch (Exception ex)
		{
			Logger.Log.Error(ex.Message, ex);
		}
		val = val ?? new TSettings();
		if (_settingsCache.ContainsKey(CurrentUserName))
		{
			if (_settingsCache.TryGetValue(CurrentUserName, out var value))
			{
				_settingsCache.TryUpdate(CurrentUserName, val, value);
			}
		}
		else
		{
			_settingsCache.TryAdd(CurrentUserName, val);
		}
		return val;
	}
}
