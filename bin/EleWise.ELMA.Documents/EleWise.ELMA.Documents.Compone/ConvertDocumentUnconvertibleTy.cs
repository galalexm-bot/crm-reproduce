using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Extensions;
using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Documents.Components;

[Component]
public class ConvertDocumentUnconvertibleTypesProjects : IConvertDocumentUnconvertibleTypes
{
	public List<Guid> GetUnconvertibleTypesUids()
	{
		return (from m in WebDocumentManager.Instance.GetWebDocumentTypes(onlyChild: false)
			select m.Uid).ToList();
	}
}
