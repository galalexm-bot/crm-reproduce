using System;
using System.Threading.Tasks;

namespace EleWise.ELMA.Security;

public interface ISecurityServiceAsync : ISecurityService
{
	Task RunWithElevatedPrivilegiesAsync(Func<Task> action);

	Task RunBySystemUserAsync(Func<Task> action);

	Task RunByUserAsync(IUser user, Func<Task> action);
}
