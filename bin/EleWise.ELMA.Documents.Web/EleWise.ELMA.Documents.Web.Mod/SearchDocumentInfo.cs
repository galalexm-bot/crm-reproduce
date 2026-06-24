using System;
using EleWise.ELMA.BPM.Web.Common.Models;

namespace EleWise.ELMA.Documents.Web.Models;

public class SearchDocumentInfo
{
	public FilterModel FilterModel { get; set; }

	public virtual string InfoId => Guid.NewGuid().ToString();
}
