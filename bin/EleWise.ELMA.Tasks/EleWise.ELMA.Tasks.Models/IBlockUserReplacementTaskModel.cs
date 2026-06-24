using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.Tasks.Models;

[InterfaceExtension(typeof(IBlockUserModel))]
public interface IBlockUserReplacementTaskModel : IBlockUserModel, IAutoImplement
{
	IReplacementTask ReplacementTask { get; set; }

	[DisplayName(typeof(__Resources_IBlockUserReplacementTaskModel), "P_CreateBlockUserTask")]
	bool CreateBlockUserTask { get; set; }
}
