using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.Workflow.Models;

[InterfaceExtension(typeof(IBlockUserModel))]
public interface IBlockUserReplacementWorkflowResponsibleModel : IBlockUserModel, IAutoImplement
{
	[DisplayName("SR.M('Новый ответственный за экземпляры процессов')")]
	IUser ResponsibleUser { get; set; }

	[DisplayName("SR.M('Изменить ответственного за экземпляры процессов')")]
	bool ChangeResponsible { get; set; }
}
