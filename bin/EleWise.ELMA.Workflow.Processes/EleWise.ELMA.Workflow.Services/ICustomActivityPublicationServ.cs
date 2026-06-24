using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow.Services;

internal interface ICustomActivityPublicationService
{
	void Publish(ICustomActivity customActivity);
}
