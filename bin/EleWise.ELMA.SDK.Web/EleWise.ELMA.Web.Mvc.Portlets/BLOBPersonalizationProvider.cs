using System;
using System.Collections.Specialized;
using EleWise.ELMA.Runtime.Managers;

namespace EleWise.ELMA.Web.Mvc.Portlets;

public class BLOBPersonalizationProvider : PersonalizationProvider
{
	public const string UID_S = "DCB7CB22-3717-4DF3-90F2-B9909A5F7C4D";

	public static Guid UID = new Guid("DCB7CB22-3717-4DF3-90F2-B9909A5F7C4D");

	private string _appName = string.Empty;

	public override string ApplicationName
	{
		get
		{
			return _appName;
		}
		set
		{
			_appName = value;
		}
	}

	public override void Initialize(string name, NameValueCollection config)
	{
		if (string.IsNullOrEmpty(name))
		{
			name = "BLOBPersonalizationProvider";
		}
		if (config == null)
		{
			throw new ArgumentNullException("config");
		}
		if (string.IsNullOrEmpty(config["description"]))
		{
			config.Remove("description");
			config.Add("description", "BLOB Based Personalization Provider");
		}
		base.Initialize(name, config);
		if (!string.IsNullOrEmpty(config["applicationName"]))
		{
			_appName = config["applicationName"];
		}
	}

	private static string GetKey(string path, string userName)
	{
		string text = (userName ?? "").Trim();
		string text2 = (path ?? "~").Trim().Replace("/", "_");
		if (!string.IsNullOrEmpty(text))
		{
			return $"{text2}/{text}".Trim();
		}
		return text2;
	}

	public override void SaveState<T>(string userName, string path, T state)
	{
		if (DataAccessManager.BLOBManager != null)
		{
			DataAccessManager.BLOBManager.SetBLOB(UID, GetKey(path, userName), state);
		}
	}

	public override T LoadState<T>(string userName, string path)
	{
		if (DataAccessManager.BLOBManager == null)
		{
			return default(T);
		}
		return DataAccessManager.BLOBManager.GetBLOB<T>(UID, GetKey(path, userName));
	}

	public override void ResetState<T>(string userName, string path)
	{
		if (DataAccessManager.BLOBManager != null)
		{
			DataAccessManager.BLOBManager.RemoveBLOB<T>(UID, GetKey(path, userName));
		}
	}
}
