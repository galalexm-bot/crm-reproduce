using System.Collections.Generic;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;

namespace EleWise.ELMA.Security.Models;

[InterfaceExtension(typeof(IBlockUserModel))]
public interface IChangeReplacementsBlockUserModel : IBlockUserModel, IAutoImplement
{
	IList<ChangeTargetUsersModel> ChangeTargetUsersModelList { get; set; }
}
