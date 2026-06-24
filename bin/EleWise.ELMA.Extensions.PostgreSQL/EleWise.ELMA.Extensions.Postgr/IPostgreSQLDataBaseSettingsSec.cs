using EleWise.ELMA.Services;

namespace EleWise.ELMA.Extensions.PostgreSQL;

public interface IPostgreSQLDataBaseSettingsSection : IDataBaseSettingsSection
{
	string PathToPgDump { get; }

	string SysUser { get; }

	string SysPassword { get; }
}
