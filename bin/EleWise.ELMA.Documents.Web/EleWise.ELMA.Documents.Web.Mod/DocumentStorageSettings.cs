using System.Collections.Generic;
using EleWise.ELMA.Documents.Web.Extensions;

namespace EleWise.ELMA.Documents.Web.Models;

public class DocumentStorageSettings
{
	public IEnumerable<IDocumentStorageSettingsBlockController> BlockControllers { get; set; }
}
