using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using EleWise.ELMA.Orleans.Extensions;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Orleans;
using Orleans.Configuration;
using Orleans.Runtime;

namespace EleWise.ELMA.Orleans.Providers.Implementations;

internal class DBMembershipTable : IMembershipTable
{
	private class Db
	{
		public static class Fields
		{
			public const string Uid = "Uid";

			public const string HostName = "HostName";

			public const string SiloName = "SiloName";

			public const string ProxyPort = "ProxyPort";

			public const string Address = "Address";

			public const string Status = "Status";

			public const string StartTime = "StartTime";

			public const string IAmAliveTime = "IAmAliveTime";

			public const string ETag = "eTag";

			public const string SuspectTimes = "SuspectTimes";

			public const int SuspectTimesLength = 4000;
		}

		public const string TableName = "Orleans_MembershipTable";
	}

	private readonly ILogger<DBMembershipTable> logger;

	private readonly ITransformationProviderAsync transformationProvider;

	private readonly string queryReadVersion;

	private readonly string queryReadAll;

	private readonly string queryReadRow;

	private readonly string queryDeleteRows;

	private const string uidParameter = "UidP";

	private const string eTagParameter = "ETagP";

	private const string beforeDateParameter = "BeforeDateP";

	public DBMembershipTable(ILogger<DBMembershipTable> logger, ITransformationProviderAsync transformationProvider, IOptions<ClusterMembershipOptions> options)
	{
		this.logger = logger;
		this.transformationProvider = transformationProvider;
		options.get_Value().set_NumVotesForDeathDeclaration(Math.Min(options.get_Value().get_NumVotesForDeathDeclaration(), 66));
		string text = transformationProvider.Dialect.QuoteIfNeeded("Orleans_MembershipTable");
		string text2 = transformationProvider.Dialect.QuoteIfNeeded("Uid");
		string text3 = transformationProvider.Dialect.QuoteIfNeeded("HostName");
		string text4 = transformationProvider.Dialect.QuoteIfNeeded("SiloName");
		string text5 = transformationProvider.Dialect.QuoteIfNeeded("ProxyPort");
		string text6 = transformationProvider.Dialect.QuoteIfNeeded("Address");
		string text7 = transformationProvider.Dialect.QuoteIfNeeded("Status");
		string text8 = transformationProvider.Dialect.QuoteIfNeeded("StartTime");
		string text9 = transformationProvider.Dialect.QuoteIfNeeded("IAmAliveTime");
		string text10 = transformationProvider.Dialect.QuoteIfNeeded("SuspectTimes");
		string text11 = transformationProvider.Dialect.QuoteIfNeeded("eTag");
		string text12 = text3 + ", " + text4 + ", " + text5 + ", " + text6 + ", " + text7 + ", " + text8 + ", " + text9 + ", " + text10 + ", " + text11;
		queryReadVersion = "select max(" + text11 + ") as " + text11 + " from " + text;
		queryReadAll = "select " + text2 + ", " + text12 + " from " + text;
		queryReadRow = "select " + text12 + " from " + text + " where " + text2 + " = " + transformationProvider.ParameterSeparator + "UidP\r\nunion select null, null, null, null, null, null, null, null, max(" + text11 + ") from " + text;
		queryDeleteRows = "delete from " + text + " where " + text9 + " < " + transformationProvider.ParameterSeparator + "BeforeDateP";
	}

	public async Task InitializeMembershipTable(bool tryInitTableVersion)
	{
		if (tryInitTableVersion && !transformationProvider.TableExists("Orleans_MembershipTable"))
		{
			transformationProvider.BeginTransaction();
			try
			{
				Table table = new Table
				{
					Sequence = false,
					Name = "Orleans_MembershipTable",
					Columns = new List<Column>
					{
						new Column("Uid", DbType.Guid, ColumnProperty.PrimaryKey),
						new Column("HostName", new ColumnType(DbType.String, 150)),
						new Column("SiloName", new ColumnType(DbType.String, 150)),
						new Column("Address", new ColumnType(DbType.String, 100)),
						new Column("ProxyPort", DbType.Int32),
						new Column("IAmAliveTime", DbType.DateTime),
						new Column("Status", DbType.Int32),
						new Column("StartTime", DbType.DateTime),
						new Column("SuspectTimes", new ColumnType(DbType.AnsiString, 4000)),
						new Column("eTag", DbType.Int32)
					}
				};
				transformationProvider.AddTable(table);
				transformationProvider.CommitTransaction();
			}
			catch (Exception ex)
			{
				transformationProvider.RollbackTransaction();
				LoggerExtensions.LogError((ILogger)(object)logger, ex, "InitializeMembershipTable error", Array.Empty<object>());
				throw;
			}
		}
	}

	private async Task ValidateVersion(TableVersion tableVersion)
	{
		int version = 0;
		using (ITransformationProviderAsync transform = (ITransformationProviderAsync)transformationProvider.CreateWithNewConnection())
		{
			using DbDataReader r = (DbDataReader)(await transform.ExecuteQueryAsync(queryReadVersion));
			if (await r.ReadAsync() && !(r["eTag"] is DBNull))
			{
				version = Convert.ToInt32(r["eTag"]);
			}
		}
		if (version.ToString() != tableVersion.get_VersionEtag())
		{
			throw new InvalidOperationException("Etag mismatch");
		}
		if (version >= tableVersion.get_Version())
		{
			throw new InvalidOperationException("Version must increase on update");
		}
	}

	public async Task<MembershipTableData> ReadAll()
	{
		_ = 1;
		try
		{
			List<Tuple<MembershipEntry, string>> memberEntries = new List<Tuple<MembershipEntry, string>>();
			int version = 0;
			using (ITransformationProviderAsync transform = (ITransformationProviderAsync)transformationProvider.CreateWithNewConnection())
			{
				using DbDataReader r = (DbDataReader)(await transform.ExecuteQueryAsync(queryReadAll));
				while (await r.ReadAsync())
				{
					memberEntries.Add(Read(r, out var etag));
					version = ((etag > version) ? etag : version);
				}
			}
			if (((ILogger)logger).IsEnabled((LogLevel)0))
			{
				LoggerExtensions.LogTrace((ILogger)(object)logger, "ReadAll: " + string.Join(", ", memberEntries.Select((Tuple<MembershipEntry, string> me) => $"{me.Item1.get_SiloName()}: {me.Item1.get_Status()} ({me.Item1.get_SiloAddress()})")), Array.Empty<object>());
			}
			return new MembershipTableData(memberEntries, new TableVersion(version, version.ToString()));
		}
		catch (Exception ex)
		{
			LoggerExtensions.LogError((ILogger)(object)logger, ex, ex.Message, Array.Empty<object>());
			throw;
		}
	}

	public async Task<MembershipTableData> ReadRow(SiloAddress key)
	{
		int version = 0;
		using (ITransformationProviderAsync transform = (ITransformationProviderAsync)transformationProvider.CreateWithNewConnection())
		{
			using DbDataReader r = (DbDataReader)(await transform.ExecuteQueryAsync(queryReadRow, new Dictionary<string, object> { ["UidP"] = key.ToGuid() }));
			Tuple<MembershipEntry, string> memberEntry = null;
			while (await r.ReadAsync())
			{
				if (!(r["Address"] is DBNull))
				{
					memberEntry = Read(r, out var _);
				}
				else if (!(r["eTag"] is DBNull))
				{
					version = Convert.ToInt32(r["eTag"]);
				}
			}
			if (memberEntry != null)
			{
				if (((ILogger)logger).IsEnabled((LogLevel)1))
				{
					LoggerExtensions.LogDebug((ILogger)(object)logger, $"ReadRow: {memberEntry.Item1.get_SiloName()}: {memberEntry.Item1.get_Status()} ({memberEntry.Item1.get_SiloAddress()})", Array.Empty<object>());
				}
				return new MembershipTableData(memberEntry, new TableVersion(version, version.ToString()));
			}
			if (((ILogger)logger).IsEnabled((LogLevel)1))
			{
				LoggerExtensions.LogDebug((ILogger)(object)logger, $"ReadRow ({key}) is empty", Array.Empty<object>());
			}
		}
		return new MembershipTableData(new TableVersion(version, version.ToString()));
	}

	public async Task UpdateIAmAlive(MembershipEntry entry)
	{
		using ITransformationProviderAsync transform = (ITransformationProviderAsync)transformationProvider.CreateWithNewConnection();
		transform.BeginTransaction();
		try
		{
			if (((ILogger)logger).IsEnabled((LogLevel)0))
			{
				LoggerExtensions.LogTrace((ILogger)(object)logger, $"UpdateIAmAlive: {entry.get_SiloName()} {entry.get_IAmAliveTime()}", Array.Empty<object>());
			}
			await transform.UpdateAsync("Orleans_MembershipTable", new string[1] { "IAmAliveTime" }, new object[1]
			{
				new ParameterValue(entry.get_IAmAliveTime(), convertToDbTime: false)
			}, transform.Dialect.QuoteIfNeeded("Uid") + " = " + transform.ParameterSeparator + "UidP", new Dictionary<string, object> { ["UidP"] = entry.get_SiloAddress().ToGuid() });
			transform.CommitTransaction();
		}
		catch (Exception ex)
		{
			LoggerExtensions.LogError((ILogger)(object)logger, ex, "UpdateIAmAlive error", Array.Empty<object>());
			transform.RollbackTransaction();
		}
	}

	public async Task<bool> InsertRow(MembershipEntry entry, TableVersion tableVersion)
	{
		await ValidateVersion(tableVersion);
		using ITransformationProviderAsync transform = (ITransformationProviderAsync)transformationProvider.CreateWithNewConnection();
		transform.BeginTransaction();
		try
		{
			if (((ILogger)logger).IsEnabled((LogLevel)2))
			{
				LoggerExtensions.LogInformation((ILogger)(object)logger, $"InsertRow: {entry.get_SiloName()}: {entry.get_Status()} ({entry.get_SiloAddress()})", Array.Empty<object>());
			}
			int num = await transform.InsertAsync("Orleans_MembershipTable", new string[10] { "Uid", "HostName", "SiloName", "ProxyPort", "Address", "Status", "StartTime", "IAmAliveTime", "SuspectTimes", "eTag" }, new object[10]
			{
				entry.get_SiloAddress().ToGuid(),
				entry.get_HostName(),
				entry.get_SiloName(),
				entry.get_ProxyPort(),
				entry.get_SiloAddress().ToParsableString(),
				(int)entry.get_Status(),
				new ParameterValue(entry.get_StartTime(), convertToDbTime: false),
				new ParameterValue(entry.get_IAmAliveTime(), convertToDbTime: false),
				SerializeSuspectTimes(entry.get_SuspectTimes()),
				tableVersion.get_Version()
			});
			transform.CommitTransaction();
			return num == 1;
		}
		catch (Exception ex)
		{
			LoggerExtensions.LogError((ILogger)(object)logger, ex, "InsertRow error", Array.Empty<object>());
			transform.RollbackTransaction();
			return false;
		}
	}

	public async Task<bool> UpdateRow(MembershipEntry entry, string etag, TableVersion tableVersion)
	{
		await ValidateVersion(tableVersion);
		using ITransformationProviderAsync transform = (ITransformationProviderAsync)transformationProvider.CreateWithNewConnection();
		transform.BeginTransaction();
		try
		{
			if (((ILogger)logger).IsEnabled((LogLevel)2))
			{
				LoggerExtensions.LogInformation((ILogger)(object)logger, $"UpdateRow: {entry.get_SiloName()}: {entry.get_Status()} ({entry.get_SiloAddress()})", Array.Empty<object>());
			}
			bool result = await transform.UpdateAsync("Orleans_MembershipTable", new string[9] { "HostName", "SiloName", "ProxyPort", "Address", "Status", "StartTime", "IAmAliveTime", "SuspectTimes", "eTag" }, new object[9]
			{
				entry.get_HostName(),
				entry.get_SiloName(),
				entry.get_ProxyPort(),
				entry.get_SiloAddress().ToParsableString(),
				(int)entry.get_Status(),
				new ParameterValue(entry.get_StartTime(), convertToDbTime: false),
				new ParameterValue(entry.get_IAmAliveTime(), convertToDbTime: false),
				SerializeSuspectTimes(entry.get_SuspectTimes()),
				tableVersion.get_Version()
			}, transform.Dialect.QuoteIfNeeded("Uid") + " = " + transform.ParameterSeparator + "UidP and " + transform.Dialect.QuoteIfNeeded("eTag") + " = " + transform.ParameterSeparator + "ETagP", new Dictionary<string, object>
			{
				["UidP"] = entry.get_SiloAddress().ToGuid(),
				["ETagP"] = int.Parse(etag)
			}) == 1;
			transform.CommitTransaction();
			return result;
		}
		catch (Exception ex)
		{
			LoggerExtensions.LogError((ILogger)(object)logger, ex, "UpdateRow error", Array.Empty<object>());
			transform.RollbackTransaction();
			return false;
		}
	}

	public async Task CleanupDefunctSiloEntries(DateTimeOffset beforeDate)
	{
		using ITransformationProviderAsync transform = (ITransformationProviderAsync)transformationProvider.CreateWithNewConnection();
		transform.BeginTransaction();
		try
		{
			LoggerExtensions.LogInformation((ILogger)(object)logger, $"CleanupDefunctSiloEntries ({beforeDate})", Array.Empty<object>());
			await transform.ExecuteNonQueryAsync(queryDeleteRows, new Dictionary<string, object> { ["BeforeDateP"] = beforeDate.DateTime });
			transform.CommitTransaction();
		}
		catch (Exception ex)
		{
			LoggerExtensions.LogError((ILogger)(object)logger, ex, "CleanupDefunctSiloEntries error", Array.Empty<object>());
			transform.RollbackTransaction();
		}
	}

	public async Task DeleteMembershipTableEntries(string clusterId)
	{
		using ITransformationProviderAsync transform = (ITransformationProviderAsync)transformationProvider.CreateWithNewConnection();
		transform.BeginTransaction();
		try
		{
			LoggerExtensions.LogInformation((ILogger)(object)logger, "DeleteMembershipTableEntries", Array.Empty<object>());
			await transform.ExecuteNonQueryAsync("delete from " + transform.Dialect.QuoteIfNeeded("Orleans_MembershipTable"));
			transform.CommitTransaction();
		}
		catch (Exception ex)
		{
			LoggerExtensions.LogError((ILogger)(object)logger, ex, "DeleteMembershipTableEntries error", Array.Empty<object>());
			transform.RollbackTransaction();
		}
	}

	private static Tuple<MembershipEntry, string> Read(IDataReader reader, out int etag)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected O, but got Unknown
		MembershipEntry val = new MembershipEntry();
		val.set_SiloAddress(SiloAddress.FromParsableString((string)reader["Address"]));
		val.set_Status((SiloStatus)Convert.ToInt32(reader["Status"]));
		val.set_ProxyPort(Convert.ToInt32(reader["ProxyPort"]));
		val.set_HostName((string)reader["HostName"]);
		val.set_SiloName((string)reader["SiloName"]);
		val.set_StartTime((DateTime)reader["StartTime"]);
		val.set_IAmAliveTime((DateTime)reader["IAmAliveTime"]);
		val.set_SuspectTimes(DeserializeSuspectTimes(reader["SuspectTimes"] as string));
		int num = (etag = Convert.ToInt32(reader["eTag"]));
		return Tuple.Create<MembershipEntry, string>(val, num.ToString());
	}

	private static List<Tuple<SiloAddress, DateTime>> DeserializeSuspectTimes(string suspectTimes)
	{
		if (string.IsNullOrWhiteSpace(suspectTimes))
		{
			return null;
		}
		return suspectTimes.Split('|').Select(delegate(string s)
		{
			string[] array = s.Split(',');
			return Tuple.Create<SiloAddress, DateTime>(SiloAddress.FromParsableString(array[0]), LogFormatter.ParseDate(array[1]));
		}).ToList();
	}

	private static string SerializeSuspectTimes(List<Tuple<SiloAddress, DateTime>> suspectTimes)
	{
		if (suspectTimes == null || suspectTimes.Count <= 0)
		{
			return null;
		}
		return string.Join("|", suspectTimes.Select((Tuple<SiloAddress, DateTime> s) => s.Item1.ToParsableString() + "," + LogFormatter.PrintDate(s.Item2)));
	}
}
