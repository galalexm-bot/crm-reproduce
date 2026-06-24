using System.Configuration;
using EleWise.ELMA.Configuration;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Extensions.PostgreSQL;

public class PostgreSQLSettingsSection : MainBaseSettingsSection, IPostgreSQLDataBaseSettingsSection, IDataBaseSettingsSection, IMainBaseSettingsSection
{
	public const string PATHTOPGDUMP_NAME = "pathToPgDump";

	public const string SYSUSERNAME_NAME = "sysUser";

	public const string SYSUSERPASSWORD_NAME = "sysPassword";

	internal readonly ConfigurationProperty _pathToPgDump = new ConfigurationProperty("pathToPgDump", typeof(string), null);

	internal readonly ConfigurationProperty _sysUserName = new ConfigurationProperty("sysUser", typeof(string), null);

	internal readonly ConfigurationProperty _sysUserPassword = new ConfigurationProperty("sysPassword", typeof(string), null);

	[ConfigurationProperty("pathToPgDump", IsRequired = false)]
	public string PathToPgDump => ((string)base[_pathToPgDump]) ?? "";

	[ConfigurationProperty("sysUser", IsRequired = false)]
	public string SysUser
	{
		get
		{
			return ((string)base[_sysUserName]) ?? "postgres";
		}
		set
		{
			base[_sysUserName] = value;
		}
	}

	[ConfigurationProperty("sysPassword", IsRequired = false)]
	public string SysPassword
	{
		get
		{
			return (string)base[_sysUserPassword];
		}
		set
		{
			base[_sysUserPassword] = value;
		}
	}
}
