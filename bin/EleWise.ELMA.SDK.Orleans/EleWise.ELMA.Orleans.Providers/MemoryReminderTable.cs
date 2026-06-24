using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EleWise.ELMA.Orleans.Runtime;
using EleWise.ELMA.Runtime;
using Microsoft.Extensions.Logging;
using Orleans;
using Orleans.Runtime;

namespace EleWise.ELMA.Orleans.Providers.Reminders;

internal class MemoryReminderTable : IReminderTable
{
	private Dictionary<GrainReference, Dictionary<string, ReminderEntry>> reminderTable;

	private readonly ILogger logger;

	private readonly IRuntimeApplication runtimeApplication;

	private readonly IGrainFactory grainFactory;

	public MemoryReminderTable(ILogger<MemoryReminderTable> logger, IRuntimeApplication runtimeApplication, IGrainFactory grainFactory)
	{
		this.logger = (ILogger)(object)logger;
		this.runtimeApplication = runtimeApplication;
		this.grainFactory = grainFactory;
	}

	public Task Init()
	{
		return Task.CompletedTask;
	}

	public Task TestOnlyClearTable()
	{
		LoggerExtensions.LogInformation(logger, "TestOnlyClearTable", Array.Empty<object>());
		reminderTable?.Clear();
		return Task.CompletedTask;
	}

	public async Task<ReminderTableData> ReadRows(GrainReference grainRef)
	{
		await InitInternal();
		if (logger.IsEnabled((LogLevel)0))
		{
			LoggerExtensions.LogTrace(logger, "ReadRows for grain {Grain}", new object[1] { grainRef });
		}
		reminderTable.TryGetValue(grainRef, out var value);
		return (value == null) ? new ReminderTableData() : new ReminderTableData((IEnumerable<ReminderEntry>)value.Values.ToList());
	}

	public async Task<ReminderTableData> ReadRows(uint begin, uint end)
	{
		List<ReminderEntry> list;
		if (begin == 0 && end == uint.MaxValue)
		{
			if (reminderTable == null)
			{
				throw new NullReferenceException("MemoryReminderTable not initialized");
			}
			list = reminderTable.SelectMany((KeyValuePair<GrainReference, Dictionary<string, ReminderEntry>> e) => e.Value.Values).ToList();
			if (logger.IsEnabled((LogLevel)0))
			{
				LoggerExtensions.LogTrace(logger, "Selected {SelectCount} reminders from memory. Selected: {Reminders}", new object[2]
				{
					list.Count,
					Utils.EnumerableToString<ReminderEntry>((IEnumerable<ReminderEntry>)list, (Func<ReminderEntry, string>)((ReminderEntry e) => ((object)e).ToString()), ", ", true)
				});
			}
		}
		else
		{
			await InitInternal();
			IRingRange range = RangeFactory.CreateRange(begin, end);
			list = reminderTable.Where((KeyValuePair<GrainReference, Dictionary<string, ReminderEntry>> e) => range.InRange(e.Key)).SelectMany((KeyValuePair<GrainReference, Dictionary<string, ReminderEntry>> e) => e.Value.Values).ToList();
			if (logger.IsEnabled((LogLevel)0))
			{
				LoggerExtensions.LogTrace(logger, "Selected {SelectCount} out of {TotalCount} reminders from memory for {Range}. Selected: {Reminders}", new object[4]
				{
					list.Count,
					reminderTable.Values.Sum((Dictionary<string, ReminderEntry> r) => r.Count),
					((object)range).ToString(),
					Utils.EnumerableToString<ReminderEntry>((IEnumerable<ReminderEntry>)list, (Func<ReminderEntry, string>)((ReminderEntry e) => ((object)e).ToString()), ", ", true)
				});
			}
		}
		ReminderTableData val = new ReminderTableData((IEnumerable<ReminderEntry>)list);
		if (logger.IsEnabled((LogLevel)1))
		{
			LoggerExtensions.LogDebug(logger, "Read {ReminderCount} reminders from memory: {Reminders}", new object[2]
			{
				val.get_Reminders().Count,
				Utils.EnumerableToString<ReminderEntry>((IEnumerable<ReminderEntry>)val.get_Reminders(), (Func<ReminderEntry, string>)null, ", ", true)
			});
		}
		return val;
	}

	public async Task<ReminderEntry> ReadRow(GrainReference grainRef, string reminderName)
	{
		await InitInternal();
		ReminderEntry value = null;
		if (reminderTable.TryGetValue(grainRef, out var value2))
		{
			value2.TryGetValue(reminderName, out value);
		}
		if (logger.IsEnabled((LogLevel)0))
		{
			if (value == null)
			{
				LoggerExtensions.LogTrace(logger, "Reminder not found for grain {Grain} reminder {ReminderName} ", new object[2] { grainRef, reminderName });
			}
			else
			{
				LoggerExtensions.LogTrace(logger, "Read for grain {Grain} reminder {ReminderName} row {Reminder}", new object[3]
				{
					grainRef,
					reminderName,
					((object)value).ToString()
				});
			}
		}
		return value;
	}

	public async Task<string> UpsertRow(ReminderEntry entry)
	{
		await InitInternal();
		if (logger.IsEnabled((LogLevel)1))
		{
			LoggerExtensions.LogDebug(logger, "UpsertRow Grain = {Grain}, ReminderName = {ReminderName}", new object[2]
			{
				entry.get_GrainRef(),
				entry.get_ReminderName()
			});
		}
		entry.set_ETag(Guid.NewGuid().ToString());
		await Publish((IReminderTableActor a) => a.UpsertRow(entry), ignoreError: true, null);
		return entry.get_ETag();
	}

	public async Task<bool> RemoveRow(GrainReference grainRef, string reminderName, string eTag)
	{
		await InitInternal();
		if (logger.IsEnabled((LogLevel)1))
		{
			LoggerExtensions.LogDebug(logger, "RemoveRow Grain = {Grain}, ReminderName = {ReminderName}, eTag = {ETag}", new object[3] { grainRef, reminderName, eTag });
		}
		return (await Publish((IReminderTableActor a) => a.RemoveRow(grainRef, reminderName, eTag), ignoreError: true, null)).Any((KeyValuePair<Guid, bool> p) => p.Value);
	}

	internal Task UpsertRowInternal(ReminderEntry entry)
	{
		if (reminderTable == null)
		{
			return Task.CompletedTask;
		}
		if (!reminderTable.TryGetValue(entry.get_GrainRef(), out var value))
		{
			value = new Dictionary<string, ReminderEntry>();
			reminderTable.Add(entry.get_GrainRef(), value);
		}
		value.TryGetValue(entry.get_ReminderName(), out var value2);
		value[entry.get_ReminderName()] = entry;
		if (logger.IsEnabled((LogLevel)0))
		{
			LoggerExtensions.LogTrace(logger, "Upserted entry {Updated}, replaced {Replaced}", new object[2] { entry, value2 });
		}
		return Task.CompletedTask;
	}

	internal Task<bool> RemoveRowInternal(GrainReference grainRef, string reminderName, string eTag)
	{
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		if (reminderTable.TryGetValue(grainRef, out var value) && value.TryGetValue(reminderName, out var value2) && value2.get_ETag() == eTag)
		{
			if (value.Count > 1)
			{
				value.Remove(reminderName);
			}
			else
			{
				reminderTable.Remove(grainRef);
			}
			return Task.FromResult(result: true);
		}
		LoggerExtensions.LogWarning(logger, EventId.op_Implicit(102914), "RemoveRow failed for Grain = {Grain}, ReminderName = {ReminderName}, eTag = {ETag}. Table now is: {3}", new object[4]
		{
			grainRef,
			reminderName,
			eTag,
			Utils.EnumerableToString<ReminderEntry>(reminderTable.Values.SelectMany((Dictionary<string, ReminderEntry> x) => x.Values), (Func<ReminderEntry, string>)null, ", ", true)
		});
		return Task.FromResult(result: false);
	}

	private async Task InitInternal()
	{
		if (reminderTable != null)
		{
			return;
		}
		if (runtimeApplication.IsFirstServerInCluster)
		{
			LoggerExtensions.LogInformation(logger, "Init", Array.Empty<object>());
		}
		else
		{
			IEnumerable<Guid> enumerable = from uid in runtimeApplication.GetActiveConnectionUids()
				where uid != runtimeApplication.ConnectionUid
				select uid;
			LoggerExtensions.LogInformation(logger, "Init", Array.Empty<object>());
			foreach (Guid item in enumerable)
			{
				IReminderTableActor actor = grainFactory.GetActor<IReminderTableActor>(item);
				try
				{
					reminderTable = (from r in (await actor.ReadAllRows()).get_Reminders()
						group r by r.get_GrainRef()).ToDictionary((IGrouping<GrainReference, ReminderEntry> g) => g.Key, (IGrouping<GrainReference, ReminderEntry> g) => g.ToDictionary((ReminderEntry r) => r.get_ReminderName()));
					return;
				}
				catch (NullReferenceException)
				{
				}
			}
		}
		reminderTable = new Dictionary<GrainReference, Dictionary<string, ReminderEntry>>();
	}

	private Task Publish(Func<IReminderTableActor, Task> action, bool ignoreError, Action<Guid, Exception> errorAction)
	{
		return Task.WhenAll(runtimeApplication.GetActiveConnectionUids().Select((Func<Guid, Task>)async delegate(Guid uid)
		{
			try
			{
				await action(grainFactory.GetActor<IReminderTableActor>(uid));
			}
			catch (Exception arg)
			{
				errorAction?.Invoke(uid, arg);
				if (!ignoreError)
				{
					throw;
				}
			}
		}));
	}

	private async Task<IReadOnlyDictionary<Guid, TRes>> Publish<TRes>(Func<IReminderTableActor, Task<TRes>> action, bool ignoreError, Action<Guid, Exception> errorAction)
	{
		return (await Task.WhenAll(runtimeApplication.GetActiveConnectionUids().Select(async delegate(Guid uid)
		{
			try
			{
				return (uid, false, await action(grainFactory.GetActor<IReminderTableActor>(uid)));
			}
			catch (Exception arg)
			{
				errorAction?.Invoke(uid, arg);
				if (!ignoreError)
				{
					throw;
				}
				return (uid, true, default(TRes));
			}
		}))).Where(((Guid Uid, bool IsFaulted, TRes Result) r) => !r.IsFaulted).ToDictionary(((Guid Uid, bool IsFaulted, TRes Result) r) => r.Uid, ((Guid Uid, bool IsFaulted, TRes Result) r) => r.Result);
	}
}
