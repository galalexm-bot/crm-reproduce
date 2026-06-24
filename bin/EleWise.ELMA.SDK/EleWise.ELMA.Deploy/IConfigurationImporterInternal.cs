using System;

namespace EleWise.ELMA.Deploy;

internal interface IConfigurationImporterInternal : IConfigurationImporter
{
	event EventHandler<EventArgs> OnImportFinished;
}
