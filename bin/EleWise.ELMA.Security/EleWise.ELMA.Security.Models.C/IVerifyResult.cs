namespace EleWise.ELMA.Security.Models.Crypto;

public interface IVerifyResult
{
	bool Verified { get; set; }

	ISigner Signer { get; set; }

	string Error { get; set; }

	string Warning { get; set; }

	string ProviderName { get; set; }

	void ThrowIfNotVerified();
}
