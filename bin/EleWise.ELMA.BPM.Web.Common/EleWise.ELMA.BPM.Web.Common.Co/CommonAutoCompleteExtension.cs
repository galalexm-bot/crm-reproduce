using EleWise.ELMA.BPM.Web.Common.ExtensionPoints;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Managers;

namespace EleWise.ELMA.BPM.Web.Common.Components;

[Component(Order = int.MaxValue)]
public class CommonAutoCompleteExtension : IAutoCompleteExtension
{
	public bool CheckFilter(IEntityManager manager, IEntityFilter filter)
	{
		manager.CheckFilter(filter);
		return true;
	}
}
