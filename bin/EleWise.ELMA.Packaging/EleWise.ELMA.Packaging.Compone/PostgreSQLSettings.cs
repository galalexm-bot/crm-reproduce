using System.ComponentModel;

namespace EleWise.ELMA.Packaging.Components.PostgreSQL.Settings;

public class PostgreSQLSettings : ElmaComponentSettings
{
	public const int DefaultPort = 5433;

	public const string DefaultServiceName = "ElmaPostgreSQL";

	public const string DefaultServiceUser = "NT AUTHORITY\\NetworkService";

	public const string DefaultSuperuserName = "postgres";

	[DefaultValue(5433)]
	public int Port { get; set; }

	[DefaultValue("ElmaPostgreSQL")]
	public string ServiceName { get; set; }

	[DefaultValue("NT AUTHORITY\\NetworkService")]
	public string ServiceUser { get; set; }

	[DefaultValue("postgres")]
	public string SuperuserName { get; set; }

	[DefaultValue("")]
	public string SuperuserPassword { get; set; }

	public PostgreSQLSettings()
	{
		Port = 5433;
		ServiceName = "ElmaPostgreSQL";
		ServiceUser = "NT AUTHORITY\\NetworkService";
		SuperuserName = "postgres";
		SuperuserPassword = "";
	}

	public static PostgreSQLSettings Load(string fileName)
	{
		return ElmaComponentSettings.Load<PostgreSQLSettings>(fileName);
	}
}
