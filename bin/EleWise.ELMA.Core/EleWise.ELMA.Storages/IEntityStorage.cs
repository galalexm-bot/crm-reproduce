using System.Threading.Tasks;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Model.Entities;

namespace EleWise.ELMA.Storages;

[ServiceContract]
public interface IEntityStorage
{
	Entity TryAdd(Entity entity);

	Entity GetOrAdd(string typeUid, string uid, object serializedEntity);

	System.Threading.Tasks.Task<Entity> GetOrAddAsync(string typeUid, string uid, object serializedEntity);
}
