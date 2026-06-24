using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.IO;
using System.IO.IsolatedStorage;
using EleWise.ELMA.CAB.Properties;

namespace EleWise.ELMA.CAB.Services;

public class IsolatedStorageStatePersistenceService : StreamStatePersistenceService
{
	public const string ScopeAttribute = "Scope";

	private IsolatedStorageScope scope;

	public IsolatedStorageScope Scope
	{
		get
		{
			return scope;
		}
		set
		{
			scope = value;
		}
	}

	public IsolatedStorageStatePersistenceService()
		: this(IsolatedStorageScope.User | IsolatedStorageScope.Domain | IsolatedStorageScope.Assembly | IsolatedStorageScope.Roaming)
	{
	}

	public IsolatedStorageStatePersistenceService(IsolatedStorageScope scope)
	{
		this.scope = scope;
	}

	public override bool Contains(string id)
	{
		IsolatedStorageFile store = IsolatedStorageFile.GetStore(scope, null, null);
		string[] fileNames = store.GetFileNames(GetFileName(id));
		return fileNames.Length == 1;
	}

	public override void RemoveStream(string id)
	{
		if (Contains(id))
		{
			IsolatedStorageFile store = IsolatedStorageFile.GetStore(scope, null, null);
			store.DeleteFile(GetFileName(id));
		}
	}

	protected override Stream GetStream(string id)
	{
		IsolatedStorageFile store = IsolatedStorageFile.GetStore(scope, null, null);
		string fileName = GetFileName(id);
		if (!Contains(id))
		{
			return new IsolatedStorageFileStream(fileName, FileMode.CreateNew, store);
		}
		return new IsolatedStorageFileStream(fileName, FileMode.Open, store);
	}

	public override void Configure(NameValueCollection settings)
	{
		base.Configure(settings);
		if (string.IsNullOrEmpty(settings["Scope"]))
		{
			return;
		}
		string[] array = settings["Scope"].Split(new char[1] { '|' }, StringSplitOptions.RemoveEmptyEntries);
		List<IsolatedStorageScope> list = new List<IsolatedStorageScope>(array.Length);
		string[] array2 = array;
		foreach (string text in array2)
		{
			string text2 = text.Trim();
			if (text2.Length > 0)
			{
				if (!Enum.IsDefined(typeof(IsolatedStorageScope), text2))
				{
					throw new StatePersistenceException(string.Format(CultureInfo.CurrentCulture, Resources.InvalidIsolatedStorageStatePersistanceScope, new object[2]
					{
						settings["Scope"],
						text2
					}));
				}
				list.Add((IsolatedStorageScope)Enum.Parse(typeof(IsolatedStorageScope), text2));
			}
		}
		scope = IsolatedStorageScope.None;
		foreach (IsolatedStorageScope item in list)
		{
			scope |= item;
		}
		try
		{
			IsolatedStorageFile store = IsolatedStorageFile.GetStore(scope, null, null);
		}
		catch (ArgumentException innerException)
		{
			throw new StatePersistenceException(string.Format(CultureInfo.CurrentCulture, Resources.InvalidIsolatedStorageStatePersistanceParsedScope, new object[1] { settings["Scope"] }), innerException);
		}
	}

	public void Clear()
	{
		IsolatedStorageFile store = IsolatedStorageFile.GetStore(scope, null, null);
		string[] fileNames = store.GetFileNames("*");
		string[] array = fileNames;
		foreach (string file in array)
		{
			store.DeleteFile(file);
		}
	}

	private string GetFileName(string id)
	{
		return string.Format(CultureInfo.InvariantCulture, "{0}.state", new object[1] { id });
	}
}
