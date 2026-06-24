using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Documents.Extensions;

[ExtensionPoint(ServiceScope.Application, ComponentType.All)]
public interface IConvertDocumentProperty
{
	bool CanConvert(Guid propUid);

	void PostProcessing(Guid targetTypeUid, IDocument doc, PropertyMetadata propMd, IDictionary<string, object> extData);
}
