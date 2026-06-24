using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Security.JWT.Services;

internal interface IJwtTokenService
{
	string CreateToken(IDictionary<string, string> payload, byte[] signatureSecret, TimeSpan duration);

	IDictionary<string, string> GetValidatedPayload(string token, byte[] signatureSecret);
}
