using EleWise.ELMA.API.Models;
using EleWise.ELMA.Security.Cryptography;

namespace EleWise.ELMA.API;

public interface IPublicSignatureService
{
	bool CheckRequestSignature(IPublicClientSession session);

	IEcdhKey ProcessAuthInfo();
}
