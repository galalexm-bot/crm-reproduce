using System;

namespace EleWise.ELMA.Documents.Services;

[Serializable]
public class EncryptDocumentPasswordToken
{
	public string PasswordHash { get; set; }

	public DateTime DateCreate { get; set; }
}
