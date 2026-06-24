using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.BPM.Web.Security.Models;

internal interface ISecurityUserModel
{
	IUser User { get; set; }
}
