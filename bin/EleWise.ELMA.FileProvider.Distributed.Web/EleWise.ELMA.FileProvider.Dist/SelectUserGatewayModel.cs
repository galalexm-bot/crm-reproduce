using System.Web.Mvc;

namespace EleWise.ELMA.FileProvider.Distributed.Web.Models;

public class SelectUserGatewayModel
{
	public long UserId { get; set; }

	public string UserLogin { get; set; }

	public string DisplayName { get; set; }

	public SelectListItem[] Items { get; set; }
}
