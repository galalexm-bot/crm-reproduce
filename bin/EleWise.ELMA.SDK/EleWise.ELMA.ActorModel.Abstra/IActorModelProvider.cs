using System;
using System.Threading.Tasks;

namespace EleWise.ELMA.ActorModel.Abstractions;

public interface IActorModelProvider
{
	object GetPrimaryKey();

	Task RegisterOrUpdateReminder(string reminderName, TimeSpan dueTime, TimeSpan period);

	Task UnregisterReminder(string reminderName);

	IDisposable RegisterTimer(Func<object, Task> asyncCallback, object state, TimeSpan dueTime, TimeSpan period);

	Task RunExternalTask(Func<Task> action);

	Task<TResult> RunExternalTask<TResult>(Func<Task<TResult>> action);

	void DelayDeactivation(TimeSpan timeSpan);

	void DeactivateOnIdle();
}
