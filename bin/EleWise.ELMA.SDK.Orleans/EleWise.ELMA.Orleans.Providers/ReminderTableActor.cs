using System;
using System.Threading.Tasks;
using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Orleans.Runtime;
using Orleans;
using Orleans.Runtime;

namespace EleWise.ELMA.Orleans.Providers.Reminders;

internal sealed class ReminderTableActor : Actor, IReminderTableActor, IServerPlacementActor, IActorWithGuidKey, IActor
{
	private readonly MemoryReminderTable memoryReminderTable;

	public ReminderTableActor(IActorModelRuntime actorModelRuntime)
	{
		try
		{
			memoryReminderTable = (MemoryReminderTable)(object)((ActorModelRuntime)actorModelRuntime).GetService<IReminderTable>();
		}
		catch (Exception exception)
		{
			Logger.GetLogger(typeof(MemoryReminderTable)).Error("ошибка", exception);
			throw;
		}
	}

	public Task<ReminderTableData> ReadAllRows()
	{
		return memoryReminderTable.ReadRows(0u, uint.MaxValue);
	}

	public Task UpsertRow(ReminderEntry entry)
	{
		return memoryReminderTable.UpsertRowInternal(entry);
	}

	public Task<bool> RemoveRow(GrainReference grainRef, string reminderName, string eTag)
	{
		return memoryReminderTable.RemoveRowInternal(grainRef, reminderName, eTag);
	}
}
