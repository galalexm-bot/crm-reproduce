using System;
using System.Threading.Tasks;
using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Logging;

namespace EleWise.ELMA.Messages.Helpers;

[Service]
internal sealed class ActorEventPublisher : IActorEventPublisher
{
	private readonly IActorModelRuntime actorModelRuntime;

	private readonly ILogger logger;

	private const int MaxPublishTries = 2;

	private const int SleepMilliseconds = 1000;

	public ActorEventPublisher(IActorModelRuntime actorModelRuntime, ILogger logger)
	{
		this.actorModelRuntime = actorModelRuntime;
		this.logger = logger;
	}

	public async Task PublishActorEvent<T>(Guid eventId, string eventNamespace, T data)
	{
		int tries = 2;
		bool isSuccess = false;
		while (!isSuccess && tries > 0)
		{
			try
			{
				await actorModelRuntime.Publish(eventId, eventNamespace, data);
				isSuccess = true;
			}
			catch (Exception ex)
			{
				logger.Error(ex.Message);
				if (tries > 1)
				{
					await Task.Delay(1000);
				}
			}
			finally
			{
				tries--;
			}
		}
	}
}
