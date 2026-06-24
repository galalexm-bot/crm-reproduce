using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Managers;

namespace EleWise.ELMA.Documents.DTO.Managers;

public class LifeCycleTransitionDTOManager : DTOManager, ILifeCycleTransitionDTOManager, IConfigurationService
{
	public LifeCycleTransitionManager Manager { get; set; }
}
