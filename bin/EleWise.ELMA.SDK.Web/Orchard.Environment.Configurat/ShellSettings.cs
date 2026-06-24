using System;
using System.Collections.Generic;
using System.Linq;

namespace Orchard.Environment.Configuration;

public class ShellSettings
{
	public const string DefaultName = "Default";

	private TenantState _tenantState;

	private string[] _themes;

	private string[] _modules;

	private readonly IDictionary<string, string> _values;

	public string this[string key]
	{
		get
		{
			if (!_values.TryGetValue(key, out var value))
			{
				return null;
			}
			return value;
		}
		set
		{
			_values[key] = value;
		}
	}

	public IEnumerable<string> Keys => _values.Keys;

	public string Name
	{
		get
		{
			return this["Name"] ?? "";
		}
		set
		{
			this["Name"] = value;
		}
	}

	public string DataProvider
	{
		get
		{
			return this["DataProvider"] ?? "";
		}
		set
		{
			this["DataProvider"] = value;
		}
	}

	public string DataConnectionString
	{
		get
		{
			return this["DataConnectionString"];
		}
		set
		{
			this["DataConnectionString"] = value;
		}
	}

	public string DataTablePrefix
	{
		get
		{
			return this["DataTablePrefix"];
		}
		set
		{
			this["DataTablePrefix"] = value;
		}
	}

	public string RequestUrlHost
	{
		get
		{
			return this["RequestUrlHost"];
		}
		set
		{
			this["RequestUrlHost"] = value;
		}
	}

	public string RequestUrlPrefix
	{
		get
		{
			return this["RequestUrlPrefix"];
		}
		set
		{
			_values["RequestUrlPrefix"] = value;
		}
	}

	public string EncryptionAlgorithm
	{
		get
		{
			return this["EncryptionAlgorithm"];
		}
		set
		{
			this["EncryptionAlgorithm"] = value;
		}
	}

	public string EncryptionKey
	{
		get
		{
			return this["EncryptionKey"];
		}
		set
		{
			_values["EncryptionKey"] = value;
		}
	}

	public string HashAlgorithm
	{
		get
		{
			return this["HashAlgorithm"];
		}
		set
		{
			this["HashAlgorithm"] = value;
		}
	}

	public string HashKey
	{
		get
		{
			return this["HashKey"];
		}
		set
		{
			this["HashKey"] = value;
		}
	}

	public string[] Themes
	{
		get
		{
			string[] array = _themes;
			if (array == null)
			{
				string[] source = (Themes = (_values["Themes"] ?? "").Split(new char[1] { ';' }, StringSplitOptions.RemoveEmptyEntries));
				array = source.Select((string t) => t.Trim()).ToArray();
			}
			return array;
		}
		set
		{
			_themes = value;
			this["Themes"] = string.Join(";", value);
		}
	}

	public string[] Modules
	{
		get
		{
			string[] array = _modules;
			if (array == null)
			{
				string[] source = (Modules = (_values["Modules"] ?? "").Split(new char[1] { ';' }, StringSplitOptions.RemoveEmptyEntries));
				array = source.Select((string t) => t.Trim()).ToArray();
			}
			return array;
		}
		set
		{
			_modules = value;
			this["Modules"] = string.Join(";", value);
		}
	}

	public TenantState State
	{
		get
		{
			return _tenantState;
		}
		set
		{
			_tenantState = value;
			this["State"] = value.ToString();
		}
	}

	public ShellSettings()
	{
		_values = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
		State = TenantState.Invalid;
		Themes = new string[0];
		Modules = new string[0];
	}

	public ShellSettings(ShellSettings settings)
	{
		_values = new Dictionary<string, string>(settings._values, StringComparer.OrdinalIgnoreCase);
		Name = settings.Name;
		DataProvider = settings.DataProvider;
		DataConnectionString = settings.DataConnectionString;
		DataTablePrefix = settings.DataTablePrefix;
		RequestUrlHost = settings.RequestUrlHost;
		RequestUrlPrefix = settings.RequestUrlPrefix;
		EncryptionAlgorithm = settings.EncryptionAlgorithm;
		EncryptionKey = settings.EncryptionKey;
		HashAlgorithm = settings.HashAlgorithm;
		HashKey = settings.HashKey;
		State = settings.State;
		Themes = settings.Themes;
		Modules = settings.Modules;
	}
}
