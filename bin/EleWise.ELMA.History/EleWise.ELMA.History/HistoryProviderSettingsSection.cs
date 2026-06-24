using System;
using System.ComponentModel;
using System.Configuration;
using EleWise.ELMA.Configuration;
using EleWise.ELMA.History.Components;
using EleWise.ELMA.History.Services;

namespace EleWise.ELMA.History;

internal sealed class HistoryProviderSettingsSection : ProviderSettingsSection
{
	[ConfigurationProperty("type", IsRequired = false, IsKey = false)]
	public override Type ProviderType
	{
		get
		{
			return typeof(HistoryProvider);
		}
		set
		{
		}
	}

	[ConfigurationProperty("ConnectionString")]
	public string ConnectionString
	{
		get
		{
			return (string)base["ConnectionString"];
		}
		set
		{
			base["ConnectionString"] = value;
		}
	}

	[ConfigurationProperty("DatabaseType")]
	[TypeConverter(typeof(TypeNameConverter))]
	public Type DatabaseType
	{
		get
		{
			return (Type)base["DatabaseType"];
		}
		set
		{
			base["DatabaseType"] = value;
		}
	}

	[ConfigurationProperty("RepositoryType")]
	[TypeConverter(typeof(TypeNameConverter))]
	public Type RepositoryType
	{
		get
		{
			return ((Type)base["RepositoryType"]) ?? typeof(DatabaseHistoryRepository);
		}
		set
		{
			base["RepositoryType"] = value;
		}
	}
}
