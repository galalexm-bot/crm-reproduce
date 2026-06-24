using System;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Scripts.DTO.Models;

namespace EleWise.ELMA.Model.Scripts.DTO.Manager;

public interface IExternalAssemblyDtoManager : IConfigurationService
{
	ExternalAssemblyDto LoadOrNull(Guid uid);

	ExternalAssemblyDto Load(string hashCode);

	string GetHashCode(Guid uid);

	Guid? Exist(string hashCode);

	void Save(ExternalAssemblyDto externalAssembly);
}
