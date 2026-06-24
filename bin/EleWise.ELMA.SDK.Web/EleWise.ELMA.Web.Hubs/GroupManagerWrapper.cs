using System.Threading.Tasks;
using EleWise.ELMA.Hubs;
using Microsoft.AspNet.SignalR;

namespace EleWise.ELMA.Web.Hubs;

internal sealed class GroupManagerWrapper : IGroupManagerWrapper, IGroupManager
{
	private readonly IGroupManager groupManager;

	public GroupManagerWrapper(IGroupManager groupManager)
	{
		this.groupManager = groupManager;
	}

	public Task Add(string connectionId, string groupName)
	{
		return groupManager.Add(connectionId, groupName);
	}

	public Task Remove(string connectionId, string groupName)
	{
		return groupManager.Remove(connectionId, groupName);
	}
}
