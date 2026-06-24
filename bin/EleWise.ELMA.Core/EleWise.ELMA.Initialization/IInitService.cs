using System.Threading.Tasks;
using EleWise.ELMA.Core.ComponentModel;

namespace EleWise.ELMA.Initialization;

[ServiceContract]
public interface IInitService
{
	System.Threading.Tasks.Task Init();
}
