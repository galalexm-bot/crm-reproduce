using System;
using System.Collections.Generic;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Entities;

namespace EleWise.ELMA.Model.Managers;

public interface IFormDependencyDTOManager : IConfigurationService
{
	IEnumerable<IFormDependencyData> LoadByDependObjectUid(Guid uid);

	IEnumerable<IFormDependencyData> LoadByUsesObjectUid(Guid uid);

	IEnumerable<IFormDependencyData> LoadByBaseUids(IEnumerable<Guid> baseUids);

	string GetInterfaceFormDisplayInfo(Guid objectUid, Guid formUid);
}
