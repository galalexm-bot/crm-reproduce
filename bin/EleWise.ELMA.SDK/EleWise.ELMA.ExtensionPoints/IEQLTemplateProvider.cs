using System;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.ExtensionPoints;

[ExtensionPoint(ComponentType.All)]
public interface IEQLTemplateProvider
{
	bool Check(Guid typeUid, Guid subTypeUid);

	object GetObjectInfo(Guid typeUid, Guid subTypeUid, string model);
}
