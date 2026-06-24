using System;
using System.Data.Common;
using System.Xml.Serialization;
using Npgsql;

namespace EleWise.ELMA.Extensions.PostgreSQL;

public class PostgreSQLConnectionSettings
{
	private readonly NpgsqlConnectionStringBuilder builder = new NpgsqlConnectionStringBuilder();

	[XmlElement]
	public Guid ProviderUid => PostgreSQLProvider.UID;

	[XmlElement]
	public string Host
	{
		get
		{
			return builder.get_Host();
		}
		set
		{
			builder.set_Host(value);
		}
	}

	[XmlElement]
	public int Port
	{
		get
		{
			return builder.get_Port();
		}
		set
		{
			builder.set_Port(value);
		}
	}

	[XmlElement]
	public string Path
	{
		get
		{
			return builder.get_Database();
		}
		set
		{
			builder.set_Database(value);
		}
	}

	[XmlElement]
	public string UserName
	{
		get
		{
			return builder.get_Username();
		}
		set
		{
			builder.set_Username(value);
		}
	}

	[XmlElement]
	public string Password
	{
		get
		{
			return builder.get_Password();
		}
		set
		{
			builder.set_Password(value);
		}
	}

	public PostgreSQLConnectionSettings()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		string text;
		builder.set_Host(text = "localhost");
		builder.set_Port(5432);
		builder.set_Database("elma4");
		builder.set_Username("postgres");
		builder.set_Password("masterkey");
	}

	public string BuildConnectionString()
	{
		return ((DbConnectionStringBuilder)(object)builder).ConnectionString;
	}
}
