using System.Threading.Tasks;
using EleWise.ELMA.ActorModel.Abstractions;
using Orleans.Streams;

namespace EleWise.ELMA.Orleans.Runtime;

internal class StreamSubscriptionHandleAdapter<T> : ISubscription
{
	private readonly StreamSubscriptionHandle<T> adaptee;

	public StreamSubscriptionHandleAdapter(StreamSubscriptionHandle<T> adaptee)
	{
		Contract.ArgumentNotNull(adaptee, "adaptee");
		this.adaptee = adaptee;
	}

	public Task Unsubscribe()
	{
		return adaptee.UnsubscribeAsync();
	}
}
