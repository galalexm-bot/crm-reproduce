using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Common.API.ExtensionPoints;

[ExtensionPoint(ComponentType.All)]
public interface ICommentProvider
{
	void Process(ICommentActionModel commentActionModel, WebData parameters);
}
