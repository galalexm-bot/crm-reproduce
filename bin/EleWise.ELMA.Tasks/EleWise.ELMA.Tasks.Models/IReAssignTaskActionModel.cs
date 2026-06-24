using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;

namespace EleWise.ELMA.Tasks.Models;

[InterfaceExtension(typeof(IReAssignActionModel))]
public interface IReAssignTaskActionModel : IReAssignActionModel, IAutoImplement
{
	bool SetMeControler { get; set; }

	bool SetMeParticipant { get; set; }

	bool TakeCurrentControl { get; set; }
}
