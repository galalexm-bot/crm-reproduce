using System;

namespace EleWise.ELMA.FileProvider.Distributed.Models;

[Serializable]
public class BinaryFileOrigin
{
	public long FileId { get; set; }

	public string SourceGateway { get; set; }
}
