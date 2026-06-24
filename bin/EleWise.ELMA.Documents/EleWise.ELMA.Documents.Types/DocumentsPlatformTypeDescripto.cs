using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Types;

namespace EleWise.ELMA.Documents.Types;

[Component]
internal class DocumentsPlatformTypeDescriptorProvider : PlatformTypeDescriptorProvider
{
	public override IEnumerable<ITypeDescriptor> GetTypeDescriptors()
	{
		return new ITypeDescriptor[2]
		{
			CreateEntityDescriptor<IDocument>(),
			CreateEntityDescriptor<IFolder>()
		};
	}
}
