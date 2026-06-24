using System.Threading.Tasks;

namespace EleWise.ELMA.ActorModel.Abstractions;

public interface ISubscription
{
	Task Unsubscribe();
}
