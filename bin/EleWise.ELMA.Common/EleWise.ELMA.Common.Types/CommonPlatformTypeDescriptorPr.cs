using System.Collections.Generic;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Types;

namespace EleWise.ELMA.Common.Types;

[Component]
internal class CommonPlatformTypeDescriptorProvider : PlatformTypeDescriptorProvider
{
	public override IEnumerable<ITypeDescriptor> GetTypeDescriptors()
	{
		return new ITypeDescriptor[1] { CreateEntityDescriptor<IAttachment>() };
	}
}
