using System;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.UI.Metadata;
using EleWise.ELMA.Core.ComponentModel;

namespace EleWise.ELMA.Core.Services;

[ServiceContract]
public interface ICustomComponentCacheService
{
	void RegisterComponent(ComponentMetadata metadata, Guid headerUid);

	bool GetCustomComponent(Guid typeUid, Guid subTypeUid, bool isCollection, out Guid headerUid);
}
