using System;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Documents.Extensions;

[ExtensionPoint(ServiceScope.Application, ComponentType.All)]
public interface IDocumentStorageSettingsBlock
{
	Guid BlockUid { get; }

	string BlockName { get; }

	object Settings { get; set; }

	void SaveSettings();
}
