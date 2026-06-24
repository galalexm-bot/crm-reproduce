using System;
using System.Data;
using System.Data.Common;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Configuration;
using EleWise.ELMA.Extensions.PostgreSQL.NH;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Packaging;
using EleWise.ELMA.Packaging.Components.PostgreSQL;
using EleWise.ELMA.Packaging.Components.PostgreSQL.Settings;
using EleWise.ELMA.Runtime;
using EleWise.ELMA.Runtime.Db;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
using EleWise.ELMA.Runtime.Exceptions;
using EleWise.ELMA.Runtime.Providers;
using EleWise.ELMA.Services;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Cfg.Loquacious;
using NHibernate.Criterion;
using NHibernate.Type;
using Npgsql;

namespace EleWise.ELMA.Extensions.PostgreSQL;

[Component]
public class PostgreSQLProvider : NHProvider
{
	public const string UID_S = "{E24C767A-BF6D-4414-941D-C8B5BEC600C9}";

	public static readonly Guid UID = new Guid("{E24C767A-BF6D-4414-941D-C8B5BEC600C9}");

	private const string DatabaseServerNameTemplate = "PostgreSQL {0}";

	private const string sysDBName = "postgres";

	private const int maxPoolSize = 1024;

	protected IPostgreSQLDataBaseSettingsSection postgreSQLSettings;

	protected ITransformationProvider provider;

	private bool initialized;

	public override string ConnectionString => UpdateConnectionString(postgreSQLSettings.ConnectionString);

	public override string DataProviderName => "PostgreSQL";

	public override Guid Uid => UID;

	public override string Name => "PostgreSQL";

	protected override Version MinServerVersion => new Version(9, 5);

	protected override IMapIdentityProvider MapIdentityProvider => new PostgreSQLMapIdentityProvider();

	protected override Type TransformationProviderType => typeof(PostgreSQLTransformationProvider);

	internal static string UpdateConnectionString(string connectionString)
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected O, but got Unknown
		string text = connectionString.Split(new char[1] { ';' }, StringSplitOptions.RemoveEmptyEntries).FirstOrDefault((string s) => s.Trim().StartsWith("unicode", StringComparison.OrdinalIgnoreCase));
		if (!string.IsNullOrWhiteSpace(text))
		{
			int startIndex = connectionString.IndexOf(text, StringComparison.Ordinal);
			connectionString = connectionString.Remove(startIndex, text.Length);
		}
		return ((object)new NpgsqlConnectionStringBuilder(connectionString)).ToString();
	}

	public override IProjection GenerateOrderByProjection(EntityMetadata metadata, PropertyMetadata propertyMetadata, string entityName = null, string si = null)
	{
		IMetadataRuntimeService service = Locator.GetService<IMetadataRuntimeService>();
		IProjection obj;
		if (!string.IsNullOrEmpty(entityName) && service != null)
		{
			string realProperty;
			EntityMetadata realMetadata;
			EntityPropertyMetadata realPropertyMetadata;
			IProjection val = (IProjection)(object)NHQueryExtensions.PropertyProjection(service.GetTypeByUid(metadata.Uid), entityName, si, forOrder: true, out realProperty, out realMetadata, out realPropertyMetadata);
			obj = val;
		}
		else
		{
			IProjection val = (IProjection)(object)Projections.Property(si ?? propertyMetadata.Name);
			obj = val;
		}
		IProjection prj = obj;
		return PrepareOrderByProjection(prj, propertyMetadata?.TypeUid);
	}

	public override IProjection PrepareOrderByProjection(IProjection prj, Guid? propertyMetadataTypeUid)
	{
		if (propertyMetadataTypeUid == StringDescriptor.UID || propertyMetadataTypeUid == TextDescriptor.UID || propertyMetadataTypeUid == UrlDescriptor.UID || propertyMetadataTypeUid == HtmlStringDescriptor.UID)
		{
			return Projections.SqlFunction("lower", (IType)(object)NHibernateUtil.String, (IProjection[])(object)new IProjection[1] { Projections.Cast((IType)(object)TypeFactory.GetStringType(100), Projections.SqlFunction("substring", (IType)(object)NHibernateUtil.String, (IProjection[])(object)new IProjection[3]
			{
				prj,
				Projections.SqlProjection("1 as From_Index_", (string[])null, (IType[])null),
				Projections.SqlProjection("100 as Length_Index_", (string[])null, (IType[])null)
			})) });
		}
		return prj;
	}

	public override IProjection GenerateComparableStringProjection(IProjection propertyProjection, int maxLength = 255)
	{
		return Projections.Cast((IType)(object)TypeFactory.GetStringType(maxLength), Projections.SqlFunction("substring", (IType)(object)NHibernateUtil.String, (IProjection[])(object)new IProjection[3]
		{
			propertyProjection,
			Projections.SqlProjection("1 as From_Index_", (string[])null, (IType[])null),
			Projections.SqlProjection(maxLength + " as Length_Index_", (string[])null, (IType[])null)
		}));
	}

	public override string GuidQuerySintaxis(Guid guid)
	{
		return PostgreSQLTransformationProvider.GuidQuerySintaxisStatic(guid);
	}

	public override ProviderSettingsSection CreateSettings()
	{
		return new MainBaseSettingsSection
		{
			ProviderType = typeof(PostgreSQLProvider)
		};
	}

	protected override void InitInternal()
	{
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected O, but got Unknown
		//IL_0250: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Expected O, but got Unknown
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		//IL_026a: Expected O, but got Unknown
		Contract.NotNull(postgreSQLSettings, "postgreSQLSettings");
		if (initialized)
		{
			return;
		}
		initialized = true;
		CheckDatabaseServerVersion();
		bool? flag = null;
		if (postgreSQLSettings.DropDatabaseOnStart)
		{
			flag = IsDatabaseExists(ConnectionString);
			if (flag.Value)
			{
				Logger.Log.Info("Dropping database...");
				try
				{
					DropDatabase(ConnectionString);
					Thread.Sleep(2500);
					Logger.Log.Info("Database dropped");
				}
				catch (Exception ex)
				{
					Logger.Log.Error("Drop database error", ex);
					throw new InvalidOperationException(SR.T("Ошибка при удалении базы данных"), ex);
				}
				flag = false;
			}
		}
		if (flag.HasValue)
		{
			CreateDatabase(ConnectionString);
			flag = true;
		}
		int num = 0;
		bool flag2 = false;
		bool flag3 = false;
		while (!flag2 && num < postgreSQLSettings.ConnectionAttemptCount)
		{
			num++;
			try
			{
				Logger.Log.Debug("Checking database connection...");
				NpgsqlConnection val = new NpgsqlConnection(ConnectionString);
				try
				{
					((DbConnection)(object)val).Open();
					NpgsqlCommand val2 = val.CreateCommand();
					try
					{
						((DbCommand)(object)val2).CommandText = "select count(*) from pg_extension where extname='uuid-ossp'";
						flag3 = Convert.ToBoolean(((DbCommand)(object)val2).ExecuteScalar());
					}
					finally
					{
						((IDisposable)val2)?.Dispose();
					}
					((DbConnection)(object)val).Close();
				}
				finally
				{
					((IDisposable)val)?.Dispose();
				}
				Logger.Log.Debug("Database connection OK");
				flag2 = true;
			}
			catch (Exception ex2)
			{
				if (num >= postgreSQLSettings.ConnectionAttemptCount)
				{
					Logger.Log.Error("Error connecting to database", ex2);
					throw new InvalidOperationException(SR.T("Не удалось подключиться к базе данных"), ex2);
				}
				Logger.Log.Warn("Fault connecting to database (attempt " + num + ")", ex2);
				if (!flag.HasValue)
				{
					flag = IsDatabaseExists(ConnectionString);
					if (!flag.Value)
					{
						using (StartInformation.Operation(1.0, SR.M("Создание базы данных")))
						{
							CreateDatabase(ConnectionString);
							flag = true;
						}
					}
				}
				Thread.Sleep(postgreSQLSettings.ConnectionAttemptInverval * 1000);
			}
		}
		if (flag3)
		{
			return;
		}
		try
		{
			NpgsqlConnectionStringBuilder val3 = new NpgsqlConnectionStringBuilder(ConnectionString);
			NpgsqlConnection val4 = new NpgsqlConnection(BuildMasterConnectionString(ConnectionString));
			try
			{
				((DbConnection)(object)val4).Open();
				((DbConnection)(object)val4).ChangeDatabase(val3.get_Database());
				NpgsqlCommand val5 = val4.CreateCommand();
				try
				{
					((DbCommand)(object)val5).CommandTimeout = TransformationProviderBase.DefaultCommandTimeout;
					((DbCommand)(object)val5).CommandText = "create extension \"uuid-ossp\"";
					((DbCommand)(object)val5).ExecuteNonQuery();
				}
				finally
				{
					((IDisposable)val5)?.Dispose();
				}
				((DbConnection)(object)val4).Close();
			}
			finally
			{
				((IDisposable)val4)?.Dispose();
			}
		}
		catch (Exception)
		{
			string text = SR.T("Для запуска сервера необходимо установить расширение \"uuid-ossp\".");
			throw new ConfigurationInitializeException(text, usePrefix: true, new Exception(text + Environment.NewLine + SR.T("Нужно выполнить запрос в базе данных от имени суперпользователя: create extension \"uuid-ossp\"")));
		}
	}

	protected bool IsDatabaseExists(string connectionString)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		Logger.Log.Debug("Checking database exists...");
		try
		{
			new NpgsqlConnectionStringBuilder(connectionString);
			NpgsqlConnection val = new NpgsqlConnection(connectionString);
			try
			{
				((DbConnection)(object)val).Open();
				((DbConnection)(object)val).Close();
				return true;
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		catch (Exception ex)
		{
			PostgresException val2 = (PostgresException)(object)((ex is PostgresException) ? ex : null);
			if (val2 != null && val2.get_SqlState() == "3D000")
			{
				Logger.Log.Debug("Database DOES NOT EXISTS");
				return false;
			}
			throw new InvalidOperationException("Cannot check database exists", ex);
		}
	}

	protected string BuildMasterConnectionString(string baseConnectionString)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		NpgsqlConnectionStringBuilder val = new NpgsqlConnectionStringBuilder(baseConnectionString);
		val.set_Database("postgres");
		bool flag = false;
		NpgsqlConnection val2 = new NpgsqlConnection(((DbConnectionStringBuilder)(object)val).ConnectionString);
		try
		{
			((DbConnection)(object)val2).Open();
			NpgsqlCommand val3 = val2.CreateCommand();
			try
			{
				((DbCommand)(object)val3).CommandText = "select usesuper from pg_user where usename = CURRENT_USER";
				flag = Convert.ToBoolean(((DbCommand)(object)val3).ExecuteScalar());
			}
			finally
			{
				((IDisposable)val3)?.Dispose();
			}
			((DbConnection)(object)val2).Close();
		}
		finally
		{
			((IDisposable)val2)?.Dispose();
		}
		if (flag)
		{
			return ((DbConnectionStringBuilder)(object)val).ConnectionString;
		}
		val.set_Username(this.postgreSQLSettings.SysUser);
		val.set_Password(this.postgreSQLSettings.SysPassword);
		PackageService packageService = (ComponentManager.Initialized ? ComponentManager.Current.PackageService : null);
		if (packageService == null)
		{
			packageService = new PackageService();
			packageService.Initialize();
		}
		if (packageService.GetComponent("PostgreSQL") is PostgreSQLComponent postgreSQLComponent && postgreSQLComponent.IsInstalled())
		{
			PostgreSQLSettings postgreSQLSettings = postgreSQLComponent.LoadSettings();
			val.set_Username(postgreSQLSettings.SuperuserName);
			val.set_Password(postgreSQLSettings.SuperuserPassword);
		}
		return ((DbConnectionStringBuilder)(object)val).ConnectionString;
	}

	protected void DropDatabase(string connectionString)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		Logger.Log.Info("Dropping database...");
		try
		{
			string text = BuildMasterConnectionString(connectionString);
			NpgsqlConnectionStringBuilder val = new NpgsqlConnectionStringBuilder(connectionString);
			NpgsqlConnection val2 = new NpgsqlConnection(text);
			try
			{
				((DbConnection)(object)val2).Open();
				NpgsqlCommand val3 = val2.CreateCommand();
				try
				{
					((DbCommand)(object)val3).CommandText = $"select pg_terminate_backend(pid) from pg_stat_activity where datname='{val.get_Database()}'";
					((DbCommand)(object)val3).ExecuteNonQuery();
					((DbCommand)(object)val3).CommandText = $"DROP DATABASE IF EXISTS \"{val.get_Database()}\"";
					((DbCommand)(object)val3).ExecuteNonQuery();
				}
				finally
				{
					((IDisposable)val3)?.Dispose();
				}
			}
			finally
			{
				((IDisposable)val2)?.Dispose();
			}
			Logger.Log.Info("Database dropped");
		}
		catch (Exception ex)
		{
			Logger.Log.Error("Drop database error", ex);
			throw new InvalidOperationException(SR.T("Ошибка при удалении базы данных"), ex);
		}
	}

	protected static string BuildAttachDatabaseCommand(string dbFileName, ref string dbName, string logFileName = null)
	{
		Contract.ArgumentNotNullOrEmpty(dbFileName, "dbFileName");
		Contract.CheckWithMessage<FileNotFoundException>(File.Exists(dbFileName), SR.T("Файл '{0}' не найден", dbFileName));
		if (string.IsNullOrEmpty(dbName))
		{
			dbName = Path.GetFileNameWithoutExtension(IOExtensions.GetTempFileName());
		}
		if (string.IsNullOrEmpty(logFileName))
		{
			logFileName = Path.Combine(Path.GetDirectoryName(dbFileName), Path.GetFileNameWithoutExtension(dbFileName) + "_log.ldf");
		}
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append("CREATE DATABASE [");
		stringBuilder.Append(dbName);
		stringBuilder.Append("] ON (FILENAME=N'");
		stringBuilder.Append(dbFileName);
		stringBuilder.Append("'), (FILENAME=N'");
		stringBuilder.Append(logFileName);
		stringBuilder.Append("') FOR ATTACH");
		return stringBuilder.ToString();
	}

	public override void Configure(ProviderSettingsSection settings, RuntimeConfiguration configuration)
	{
		base.Configure(settings, configuration);
		postgreSQLSettings = (IPostgreSQLDataBaseSettingsSection)settings;
	}

	protected override void Configure(Configuration cfg)
	{
		Contract.ArgumentNotNull(postgreSQLSettings, "postgreSQLSettings");
		string connectionString = UpdateConnectionString(postgreSQLSettings.ConnectionString);
		ConfigurationExtensions.DataBaseIntegration(cfg, (Action<IDbIntegrationConfigurationProperties>)delegate(IDbIntegrationConfigurationProperties i)
		{
			i.set_ConnectionString(connectionString);
			i.Dialect<NHPostgreSQLDialect>();
			i.Driver<PostgreSqlDriver>();
		});
		cfg.SetProperty("use_reflection_optimizer", "true");
	}

	public override ITransformationProvider CreateTransformationProvider()
	{
		InitInternal();
		return new PostgreSQLTransformationProvider(() => (IDbConnection)new NpgsqlConnection(ConnectionString), postgreSQLSettings.PathToPgDump);
	}

	protected override string GetDatabaseServerName(Version version)
	{
		return $"PostgreSQL {version.ToString()}";
	}

	protected override Version GetDatabaseServerVersion()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		Logger.Log.Info("Querying database version...");
		try
		{
			NpgsqlConnectionStringBuilder val = new NpgsqlConnectionStringBuilder(ConnectionString);
			val.set_Database("postgres");
			NpgsqlConnection val2 = new NpgsqlConnection(((DbConnectionStringBuilder)val).ConnectionString);
			Version result;
			try
			{
				((DbConnection)(object)val2).Open();
				NpgsqlCommand val3 = val2.CreateCommand();
				try
				{
					((DbCommand)(object)val3).CommandTimeout = TransformationProviderBase.DefaultCommandTimeout;
					((DbCommand)(object)val3).CommandText = "show SERVER_VERSION";
					string text = Convert.ToString(((DbCommand)(object)val3).ExecuteScalar()).Trim('\r', '\n');
					result = Version.Parse(Regex.Match(text, "\\d+(\\.\\d)*").Value);
					Logger.Log.Info("Success! Database server version is " + text);
				}
				finally
				{
					((IDisposable)val3)?.Dispose();
				}
				((DbConnection)(object)val2).Close();
			}
			finally
			{
				((IDisposable)val2)?.Dispose();
			}
			return result;
		}
		catch (Exception exception)
		{
			Logger.Log.Error("Error while querying database server version", exception);
			return null;
		}
	}

	protected void CreateDatabase(string connectionString)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		Logger.Log.Info("Creating new database...");
		try
		{
			NpgsqlConnectionStringBuilder val = new NpgsqlConnectionStringBuilder(ConnectionString);
			NpgsqlConnection val2 = new NpgsqlConnection(BuildMasterConnectionString(connectionString));
			try
			{
				Logger.Log.Info("Creating database. Connection string: " + postgreSQLSettings.ConnectionString);
				((DbConnection)(object)val2).Open();
				NpgsqlCommand val3 = val2.CreateCommand();
				try
				{
					((DbCommand)(object)val3).CommandTimeout = TransformationProviderBase.DefaultCommandTimeout;
					((DbCommand)(object)val3).CommandText = "select current_schema()";
					object arg = ((DbCommand)(object)val3).ExecuteScalar();
					((DbCommand)(object)val3).CommandText = BuildCreateDatabaseCommand(connectionString);
					((DbCommand)(object)val3).ExecuteNonQuery();
					((DbCommand)(object)val3).CommandText = $"GRANT ALL PRIVILEGES ON DATABASE \"{val.get_Database()}\" to \"{val.get_Username()}\"";
					((DbCommand)(object)val3).ExecuteNonQuery();
					((DbCommand)(object)val3).CommandText = $"GRANT ALL PRIVILEGES ON ALL TABLES IN SCHEMA \"{arg}\" TO \"{val.get_Username()}\"";
					((DbCommand)(object)val3).ExecuteNonQuery();
					((DbCommand)(object)val3).CommandText = $"GRANT ALL PRIVILEGES ON ALL SEQUENCES IN SCHEMA \"{arg}\" TO \"{val.get_Username()}\"";
					((DbCommand)(object)val3).ExecuteNonQuery();
					((DbCommand)(object)val3).CommandText = $"GRANT ALL PRIVILEGES ON ALL FUNCTIONS IN SCHEMA \"{arg}\" TO \"{val.get_Username()}\"";
					((DbCommand)(object)val3).ExecuteNonQuery();
					((DbCommand)(object)val3).CommandText = $"ALTER DEFAULT PRIVILEGES IN SCHEMA \"{arg}\" GRANT ALL PRIVILEGES ON TABLES TO \"{val.get_Username()}\"";
					((DbCommand)(object)val3).ExecuteNonQuery();
					((DbCommand)(object)val3).CommandText = $"ALTER DEFAULT PRIVILEGES IN SCHEMA \"{arg}\" GRANT ALL PRIVILEGES ON SEQUENCES TO \"{val.get_Username()}\"";
					((DbCommand)(object)val3).ExecuteNonQuery();
					((DbCommand)(object)val3).CommandText = $"ALTER DEFAULT PRIVILEGES IN SCHEMA \"{arg}\" GRANT ALL PRIVILEGES ON FUNCTIONS TO \"{val.get_Username()}\"";
					((DbCommand)(object)val3).ExecuteNonQuery();
				}
				finally
				{
					((IDisposable)val3)?.Dispose();
				}
				Logger.Log.Info("Database created successfully");
			}
			finally
			{
				((IDisposable)val2)?.Dispose();
			}
			Thread.Sleep(2500);
		}
		catch (Exception ex)
		{
			Logger.Log.Error("Create database error", ex);
			throw new InvalidOperationException(SR.T("Ошибка при создании базы данных"), ex);
		}
	}

	protected string BuildCreateDatabaseCommand(string connectionString)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		NpgsqlConnectionStringBuilder val = new NpgsqlConnectionStringBuilder(connectionString);
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append($"CREATE DATABASE \"{val.get_Database()}\" ");
		stringBuilder.Append($"WITH OWNER = \"{val.get_Username()}\" ");
		stringBuilder.Append("ENCODING = 'UTF8' ");
		stringBuilder.Append("TABLESPACE = pg_default ");
		stringBuilder.Append("CONNECTION LIMIT = -1");
		return stringBuilder.ToString();
	}
}
