using System.Threading.Tasks;

namespace EleWise.ELMA.Core.Controllers;

public interface IOnDestroyAsync
{
	System.Threading.Tasks.Task OnDestroyAsync();
}
