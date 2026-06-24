using System;

namespace EleWise.ELMA.BPM.Web.Security.Models;

public class TrustedLoginScriptModel
{
	public string ConfirmCaption { get; set; }

	public string EnableConfirmMessage { get; set; }

	public string DisableConfirmMessage { get; set; }

	public long UserId { get; set; }

	public string EnableFunc { get; set; }

	public string DisableFunc { get; set; }

	public string EnableCallback { get; set; }

	public string DisableCallback { get; set; }

	public Guid CryptoActionUid { get; set; }
}
