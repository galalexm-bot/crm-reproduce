using System.Threading.Tasks;
using EleWise.ELMA.Core.ComponentModel;

namespace EleWise.ELMA.Dispatcher;

[ServiceContract]
public interface IDispatcher
{
	System.Threading.Tasks.Task Dispatch(ActionCommand command);
}
