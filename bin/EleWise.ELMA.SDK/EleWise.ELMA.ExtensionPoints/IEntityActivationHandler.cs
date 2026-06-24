using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;

namespace EleWise.ELMA.ExtensionPoints;

[ExtensionPoint(ComponentType.Server)]
public interface IEntityActivationHandler
{
	void OnActivating(IEntity entity);

	void OnActivated(IEntity entity);
}
