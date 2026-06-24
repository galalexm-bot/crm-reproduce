using EleWise.ELMA.Deploy.Models.Certificates;

namespace EleWise.ELMA.Deploy;

internal interface ISignedExportParameters
{
	ICertificateContainer CertificateContainer { get; }
}
