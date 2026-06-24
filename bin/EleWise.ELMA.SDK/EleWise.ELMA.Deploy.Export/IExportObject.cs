using System.Xml;

namespace EleWise.ELMA.Deploy.Export;

public interface IExportObject
{
	IExportObject Read();

	DeployLogMessage Write(XmlWriter writer);
}
