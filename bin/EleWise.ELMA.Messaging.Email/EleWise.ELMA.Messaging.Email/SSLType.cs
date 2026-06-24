using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Messaging.Email;

[DisplayName(typeof(SSLType_SR), "SmtpSSLType")]
public enum SSLType
{
	[DisplayName(typeof(SSLType_SR), "P_None")]
	None,
	[DisplayName(typeof(SSLType_SR), "P_SSL")]
	SSL,
	[DisplayName(typeof(SSLType_SR), "P_TLS")]
	TLS
}
