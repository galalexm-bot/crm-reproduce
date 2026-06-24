using System.Threading.Tasks;

namespace EleWise.ELMA.Core.Controllers;

public interface IOnLoadAsync
{
	System.Threading.Tasks.Task OnLoadAsync();
}
