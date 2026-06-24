using System;
using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Model.Mappings.ReplaceUidsAtPropertyMapService;

[DeveloperApi(DeveloperApiType.ExtensionPoint)]
public interface IReplaceUidAtPropertyMapServiceExtension
{
	void Init(object objLeft, object objRight);

	bool GetUidReplace(Guid uid, out Guid? newUid);

	void EndWork();
}
