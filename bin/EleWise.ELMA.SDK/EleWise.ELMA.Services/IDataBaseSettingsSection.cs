using System;

namespace EleWise.ELMA.Services;

public interface IDataBaseSettingsSection
{
	string ConnectionStringName { get; set; }

	string ConnectionString { get; }

	bool DropDatabaseOnStart { get; set; }

	int ConnectionAttemptCount { get; }

	int ConnectionAttemptInverval { get; }

	bool BackupEnabled { get; set; }

	string BackupPath { get; }

	int? CommandTimeout { get; }

	Type ProviderType { get; set; }

	bool AutoInitialize { get; set; }

	void SetConnectionString(string name, string connectionString);

	void SetBackupPath(string path);

	void SetCommandTimeOut(int commandTimeOut);
}
