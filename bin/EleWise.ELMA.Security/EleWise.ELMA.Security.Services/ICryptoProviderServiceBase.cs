using System;
using EleWise.ELMA.Files;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Models.Crypto;

namespace EleWise.ELMA.Security.Services;

public interface ICryptoProviderServiceBase
{
	Guid DefaultProviderUid { get; }

	Guid GetUserProviderUid(EleWise.ELMA.Security.Models.IUser user);

	string GetUserProviderName(EleWise.ELMA.Security.Models.IUser user);

	Guid GetUserProviderUid(EleWise.ELMA.Security.Models.IUser user, bool onlyProfile);

	Guid GetCurrentUserProviderUid();

	Guid GetCurrentUserProviderUid(bool onlyProfile);

	IVerifyResult CheckSignature(string text, string signature, bool checkSignatureOnly);

	IVerifyResult CheckSignature(string text, string signature, bool checkSignatureOnly, out string encoding);

	IVerifyResult CheckSignature(string text, string signature, bool checkSignatureOnly, Guid providerUid);

	IVerifyResult CheckSignature(string text, string signature, bool checkSignatureOnly, EleWise.ELMA.Security.Models.IUser user);

	IVerifyResult CheckSignature(string text, string signature, bool checkSignatureOnly, Guid providerUid, out string encoding);

	IVerifyResult CheckSignature(string text, string signature, bool checkSignatureOnly, EleWise.ELMA.Security.Models.IUser user, out string encoding);

	IVerifyResult CheckSignature(string text, string signature, bool checkSignatureOnly, EleWise.ELMA.Security.Models.IUser user, Guid? providerUid, out string encoding);

	IVerifyResult CheckSignature(byte[] content, string signature, bool checkSignatureOnly);

	IVerifyResult CheckSignature(BinaryFile file, string signature, bool checkSignatureOnly);

	IVerifyResult CheckSignature(byte[] content, string signature, bool checkSignatureOnly, Guid providerUid);

	IVerifyResult CheckSignature(BinaryFile file, string signature, bool checkSignatureOnly, Guid providerUid);

	IVerifyResult CheckSignature(BinaryFile file, byte[] signature, bool checkSignatureOnly, Guid providerUid);

	IVerifyResult CheckSignature(byte[] content, string signature, bool checkSignatureOnly, EleWise.ELMA.Security.Models.IUser user);

	IVerifyResult CheckSignature(string text, byte[] signature, bool checkSignatureOnly, out string encoding);

	IVerifyResult CheckSignature(string text, byte[] signature, bool checkSignatureOnly, EleWise.ELMA.Security.Models.IUser user, out string encoding);

	IVerifyResult CheckSignature(string text, byte[] signature, bool checkSignatureOnly, Guid providerUid, out string encoding);

	IVerifyResult CheckSignature(string text, byte[] signature, bool checkSignatureOnly, Guid providerUid, string encoding);

	IVerifyResult CheckSignature(string text, byte[] signature, bool checkSignatureOnly, EleWise.ELMA.Security.Models.IUser user, Guid? providerUid, out string encoding);

	IVerifyResult CheckSignature(string text, byte[] signature, bool checkSignatureOnly);

	IVerifyResult CheckSignature(string text, byte[] signature, bool checkSignatureOnly, Guid providerUid);

	IVerifyResult CheckSignature(string text, byte[] signature, bool checkSignatureOnly, EleWise.ELMA.Security.Models.IUser user);

	IVerifyResult CheckSignature(byte[] content, byte[] signature, bool checkSignatureOnly);

	IVerifyResult CheckSignature(byte[] content, byte[] signature, bool checkSignatureOnly, EleWise.ELMA.Security.Models.IUser user);

	IVerifyResult CheckSignature(byte[] content, byte[] signature, bool checkSignatureOnly, Guid providerUid);

	IVerifyResult CheckSignature(byte[] content, byte[] signature, bool checkSignatureOnly, EleWise.ELMA.Security.Models.IUser user, Guid? providerUid);
}
