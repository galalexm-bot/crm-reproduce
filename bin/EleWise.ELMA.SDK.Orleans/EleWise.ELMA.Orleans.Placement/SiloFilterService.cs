using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using EleWise.ELMA.ActorModel.Starting;
using EleWise.ELMA.Events;
using EleWise.ELMA.Orleans.Extensions;
using EleWise.ELMA.Runtime;
using EleWise.ELMA.Runtime.Context;
using EleWise.ELMA.Runtime.Db;
using EleWise.ELMA.Services;
using Microsoft.Extensions.Logging;
using Orleans;
using Orleans.Runtime;

namespace EleWise.ELMA.Orleans.Placements;

internal sealed class SiloFilterService : ILifecycleParticipant<ISiloLifecycle>
{
	private class ServerStatusEventHandler : IServerStatusEventHandler, IEventHandler
	{
		private readonly SiloFilterService siloFilterService;

		public ServerStatusEventHandler(SiloFilterService siloFilterService)
		{
			this.siloFilterService = siloFilterService;
		}

		public void ServerStarting(Guid serverUid)
		{
		}

		public void ServerStarted(Guid serverUid, Version serverVersion)
		{
			SiloAddress val = siloFilterService.siloStatusOracle.GetApproximateSiloStatuses(false).Keys.First((SiloAddress a) => a.ToGuid() == serverUid);
			siloFilterService.startedServers.AddOrUpdate(val, Task.FromResult(result: true), (SiloAddress a, Task<bool> v) => Task.FromResult(result: true));
			OrleansLoggerExtension.Info((ILogger)(object)siloFilterService.logger, $"{val}: started");
		}

		public void ServerStoped(Guid serverUid)
		{
		}
	}

	private readonly ISiloStatusOracle siloStatusOracle;

	private readonly IClusterMembershipService clusterMembershipService;

	private readonly IRuntimeApplication runtimeApplication;

	private readonly IServerStatusEventHandler serverStatusEventHandler;

	private readonly IClasterInformationService clasterInformationService;

	private readonly ILogger<SiloFilterService> logger;

	private readonly ConcurrentDictionary<SiloAddress, Task<bool>> startedServers = new ConcurrentDictionary<SiloAddress, Task<bool>>();

	public SiloFilterService(ISiloStatusOracle siloStatusOracle, IClusterMembershipService clusterMembershipService, IRuntimeApplication runtimeApplication, IEventHandlerSubscribeService eventHandlerSubscribeService, IServerStatusEventHandler serverStatusEventHandler, IClasterInformationService clasterInformationService, ILogger<SiloFilterService> logger)
	{
		this.siloStatusOracle = siloStatusOracle;
		this.clusterMembershipService = clusterMembershipService;
		this.runtimeApplication = runtimeApplication;
		this.serverStatusEventHandler = serverStatusEventHandler;
		this.clasterInformationService = clasterInformationService;
		this.logger = logger;
		eventHandlerSubscribeService.Subscribe(new ServerStatusEventHandler(this));
	}

	public void Participate(ISiloLifecycle lifecycle)
	{
		LifecycleExtensions.Subscribe((ILifecycleObservable)(object)lifecycle, "SiloFilterService", 8100, (Func<CancellationToken, Task>)OnStart);
		Task OnStart(CancellationToken ct)
		{
			Task.Run(() => ProcessMembershipUpdates());
			return Task.CompletedTask;
		}
	}

	public async Task<SiloAddress[]> FilterSilos(IList<SiloAddress> siloAddresses, SiloAddress localSilo)
	{
		return (await Task.WhenAll(FilterSilosInternal(siloAddresses, localSilo))).Where((SiloAddress siloAddress) => siloAddress != null).ToArray();
	}

	private async Task ProcessMembershipUpdates()
	{
		System.Collections.Generic.IAsyncEnumerator<ClusterMembershipSnapshot> membershipUpdates = clusterMembershipService.get_MembershipUpdates().GetAsyncEnumerator(default(CancellationToken));
		FilterSilosInternal(siloStatusOracle.GetApproximateSiloStatuses(true).Keys, siloStatusOracle.get_SiloAddress()).Count();
		ClusterMembershipSnapshot previous = null;
		while (await membershipUpdates.MoveNextAsync())
		{
			ClusterMembershipSnapshot current = membershipUpdates.get_Current();
			ClusterMembershipUpdate val = ((previous != null && !(current.get_Version() == MembershipVersion.get_MinValue())) ? current.CreateUpdate(previous) : current.AsUpdate());
			previous = current;
			if (!val.get_HasChanges())
			{
				continue;
			}
			using (ELMAContext.Create())
			{
				Enumerator<ClusterMember> enumerator = val.get_Changes().GetEnumerator();
				while (enumerator.MoveNext())
				{
					ClusterMember current2 = enumerator.get_Current();
					SiloStatus status = current2.get_Status();
					if ((int)status != 3)
					{
						if ((int)status == 6 && startedServers.TryRemove(current2.get_SiloAddress(), out var _))
						{
							OrleansLoggerExtension.Info((ILogger)(object)logger, $"{current2.get_SiloAddress()}: dead");
							serverStatusEventHandler.ServerStoped(current2.get_SiloAddress().ToGuid());
						}
					}
					else if (startedServers.TryAdd(current2.get_SiloAddress(), Task.FromResult(result: false)))
					{
						OrleansLoggerExtension.Info((ILogger)(object)logger, $"{current2.get_SiloAddress()}: starting");
						serverStatusEventHandler.ServerStarting(current2.get_SiloAddress().ToGuid());
					}
				}
			}
		}
	}

	private IEnumerable<Task<SiloAddress>> FilterSilosInternal(IEnumerable<SiloAddress> siloAddresses, SiloAddress localSilo)
	{
		return siloAddresses.Select((SiloAddress siloAddress) => startedServers.GetOrAdd(siloAddress, delegate(SiloAddress a)
		{
			if (a.Equals(localSilo))
			{
				bool isStarted = runtimeApplication.IsStarted;
				OrleansLoggerExtension.Info((ILogger)(object)logger, $"{a}: {isStarted}");
				return Task.FromResult(isStarted);
			}
			return Task.Run(async delegate
			{
				try
				{
					bool flag = (await clasterInformationService.GetStatus(a.ToGuid())).HasFlag(DbConnectionStatus.Started);
					OrleansLoggerExtension.Info((ILogger)(object)logger, string.Format("{0}: {1}", a, flag ? "started" : "starting"));
					return flag;
				}
				catch (Exception ex)
				{
					LoggerExtensions.LogError((ILogger)(object)logger, ex, $"{a}: unknown", Array.Empty<object>());
					return false;
				}
			});
		}).ContinueWith((Func<Task<bool>, object, SiloAddress>)((Task<bool> task, object state) => task.Result ? ((SiloAddress)state) : ((SiloAddress)null)), (object)siloAddress, TaskContinuationOptions.RunContinuationsAsynchronously | TaskContinuationOptions.NotOnFaulted));
	}
}
