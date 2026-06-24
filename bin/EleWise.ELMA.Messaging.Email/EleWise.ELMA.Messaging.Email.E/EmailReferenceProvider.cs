using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.CodeGeneration;

namespace EleWise.ELMA.Messaging.Email.Extensions;

[Component]
public class EmailReferenceProvider : IModelReferenceProvider, IReferenceProviderBase
{
	public string[] GetDefaultReferences()
	{
		return new string[2] { "EleWise.ELMA.Messaging.Email", "Aspose.Email" };
	}
}
