using System;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Types;

namespace EleWise.ELMA.Projects.Types;

[Component]
internal sealed class ProjectTypeGuid : IInheriteEntityMetadataGuid
{
	public Guid Uid => ProjectTypeDescriptor.UID;
}
