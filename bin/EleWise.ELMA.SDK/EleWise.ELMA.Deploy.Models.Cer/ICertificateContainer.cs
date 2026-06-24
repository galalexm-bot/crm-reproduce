namespace EleWise.ELMA.Deploy.Models.Certificates;

internal interface ICertificateContainer
{
	void WriteSignature(string filePath);
}
