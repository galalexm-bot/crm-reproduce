using EleWise.ELMA.Documents.Models;

namespace EleWise.ELMA.Documents.Web.Models;

public class DmsObjectPermissionModel : BasePermissionModel
{
	public bool ChangeInherite { get; set; }

	public bool ForPopup { get; set; }

	public bool HasCrypto { get; set; }

	public IDmsObject Object { get; set; }
}
