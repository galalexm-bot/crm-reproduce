using EleWise.ELMA.Model.Common;

namespace EleWise.ELMA.Security.Models;

public interface IBlockUserModel : IAutoImplement
{
	IUser BlockUser { get; set; }
}
