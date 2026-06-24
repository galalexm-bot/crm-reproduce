using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events;
using EleWise.ELMA.Model.Events;

namespace EleWise.ELMA.Common.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.Server)]
public interface ICommentActionHandler : IEventHandler
{
	void ProcessToCommentModel(object target, ICommentActionModel commentModel);

	void Process(object target, ICommentActionModel commentModel);

	void ProcessEventArgs(EntityActionEventArgs e, ICommentActionModel commentModel);
}
