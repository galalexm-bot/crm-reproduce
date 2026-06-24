using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;

namespace EleWise.ELMA.Documents.Extensions;

[Component]
public class DocumentsIgnoreUidUI : IIgnoreUidUI
{
	public virtual bool NeedIgnoreUid(EntityMetadata md)
	{
		return md.Uid == InterfaceActivator.UID<IDmsObjectPermission>();
	}
}
