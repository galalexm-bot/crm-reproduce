using System;

namespace EleWise.ELMA.BPM.Web.Security.Models;

public class CryptoProviderBaseModel
{
	public string DisplayName { get; set; }

	public Guid Uid { get; set; }

	public Guid OriginalUid { get; set; }

	public bool Default { get; set; }
}
