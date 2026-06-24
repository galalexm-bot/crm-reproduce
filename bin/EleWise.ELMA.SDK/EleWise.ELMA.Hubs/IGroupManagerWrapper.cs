using System.Threading.Tasks;

namespace EleWise.ELMA.Hubs;

public interface IGroupManagerWrapper
{
	Task Add(string connectionId, string groupName);

	Task Remove(string connectionId, string groupName);
}
