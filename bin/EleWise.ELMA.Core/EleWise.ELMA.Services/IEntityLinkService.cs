using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Model;
using EleWise.ELMA.Model.Entities;

namespace EleWise.ELMA.Services;

[ServiceContract]
public interface IEntityLinkService
{
	EntityLinkResult GetLink(Entity entity);

	bool HasLink(EntityLinkResult entityLink);

	void OpenEntityLink(EntityLinkResult entityLink, Entity entity);
}
