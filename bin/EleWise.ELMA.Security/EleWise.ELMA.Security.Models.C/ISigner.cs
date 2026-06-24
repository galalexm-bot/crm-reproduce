using System;

namespace EleWise.ELMA.Security.Models.Crypto;

public interface ISigner
{
	string Name { get; set; }

	string Issuer { get; set; }

	string Thumbprint { get; set; }

	string Algorithm { get; set; }

	DateTime? ValidFrom { get; set; }

	DateTime? ValidTill { get; set; }

	byte[] RawData { get; set; }
}
