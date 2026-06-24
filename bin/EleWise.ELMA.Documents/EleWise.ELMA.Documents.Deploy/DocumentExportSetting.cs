using System;
using System.Collections.Generic;
using EleWise.ELMA.Serialization;

namespace EleWise.ELMA.Documents.Deploy.Export;

[Serializable]
public class DocumentExportSetting
{
	public bool ExportDocTypes { get; set; }

	public List<Guid> DocTypes { get; set; }

	public SerializableDictionary<Guid, bool> Profiles { get; set; }

	public DocumentExportSetting()
	{
		ExportDocTypes = true;
		DocTypes = new List<Guid>();
	}
}
