using System;
using EleWise.ELMA.UIBuilder.Model;

namespace EleWise.ELMA.UIBuilder.Web.Models;

public sealed class DesignerModel
{
	public string JwtAuthToken { get; set; }

	public string RefreshToken { get; set; }

	public bool Debug { get; set; }

	public Guid? PageUid { get; set; }

	public long CurrentUser { get; set; }

	public InstallationState InstallationState { get; set; }

	public int TestMode { get; set; }
}
