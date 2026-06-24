using System;
using EleWise.ELMA.ExtensionPoints;

namespace EleWise.ELMA.Deploy.Managers;

public interface ITypeDTOManager : IConfigurationService
{
	bool CheckUniqueName(Guid typeUid, string propertyName, Guid propertyUid);
}
