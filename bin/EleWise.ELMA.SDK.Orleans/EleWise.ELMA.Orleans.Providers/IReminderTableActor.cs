using System.Threading.Tasks;
using EleWise.ELMA.ActorModel.Abstractions;
using Orleans;
using Orleans.Runtime;

namespace EleWise.ELMA.Orleans.Providers.Reminders;

internal interface IReminderTableActor : IServerPlacementActor, IActorWithGuidKey, IActor
{
	Task<ReminderTableData> ReadAllRows();

	Task UpsertRow(ReminderEntry entry);

	Task<bool> RemoveRow(GrainReference grainRef, string reminderName, string eTag);
}
