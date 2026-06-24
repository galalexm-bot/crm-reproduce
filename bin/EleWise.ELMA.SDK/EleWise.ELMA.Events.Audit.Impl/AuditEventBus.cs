using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Events.Audit.Impl;

public class AuditEventBus : IEventBusAsync, IEventBus
{
	private readonly IEnumerableLazy<IAuditEventProvider> auditEventProviders;

	public AuditEventBus(IEnumerableLazy<IAuditEventProvider> auditEventProviders)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		this.auditEventProviders = auditEventProviders;
	}

	public IEnumerable Notify(string messageName, IDictionary<string, object> eventData)
	{
		IAuditEventArgs auditEventArgs = Prepare(messageName, eventData);
		if (auditEventArgs == null)
		{
			return null;
		}
		foreach (IAuditEventProvider item in auditEventProviders.Value)
		{
			item.Notify(messageName, auditEventArgs);
		}
		return null;
	}

	[AsyncStateMachine(typeof(_003CNotifyAsync_003Ed__3))]
	public Task<IEnumerable> NotifyAsync(string messageName, IDictionary<string, object> eventData, CancellationToken cancellationToken = default(CancellationToken))
	{
		_003CNotifyAsync_003Ed__3 stateMachine = default(_003CNotifyAsync_003Ed__3);
		stateMachine._003C_003E4__this = this;
		stateMachine.messageName = messageName;
		stateMachine.eventData = eventData;
		stateMachine.cancellationToken = cancellationToken;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<IEnumerable>.Create();
		stateMachine._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<IEnumerable> _003C_003Et__builder = stateMachine._003C_003Et__builder;
		_003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	private IAuditEventArgs Prepare(string messageName, IDictionary<string, object> eventData)
	{
		string[] array = messageName.Split('.');
		if (array.Length != 2)
		{
			throw new ArgumentException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138958856 ^ -2138698546), messageName));
		}
		if (array[0] == TypeOf<IAuditEventProvider>.Name)
		{
			return null;
		}
		if (eventData.Count != 1)
		{
			return null;
		}
		return eventData.First().Value as IAuditEventArgs;
	}
}
