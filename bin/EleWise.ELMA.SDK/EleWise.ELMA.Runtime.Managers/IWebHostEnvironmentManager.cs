using System;
using EleWise.ELMA.ExtensionPoints;

namespace EleWise.ELMA.Runtime.Managers;

public interface IWebHostEnvironmentManager : IConfigurationService
{
	void RestartHost();

	Guid GetHostSessionUid();
}
