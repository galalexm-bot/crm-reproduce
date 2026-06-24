using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.BPM.Web.Common.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IFilterTreeButtonsDraging
{
	string DragStartCondition(FilterTreeEditModel model);

	string DraggingCondition(FilterTreeEditModel model);
}
