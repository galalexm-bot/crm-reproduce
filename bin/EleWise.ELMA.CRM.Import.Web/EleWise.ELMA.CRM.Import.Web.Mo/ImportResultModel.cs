using System;
using System.Collections.Generic;
using EleWise.ELMA.CRM.Import.Web.Code;
using EleWise.ELMA.Model.Entities;

namespace EleWise.ELMA.CRM.Import.Web.Models;

public class ImportResultModel
{
	public List<IEntity<long>> Entities { get; set; }

	public List<Guid> TemplatePropertyUids { get; set; }

	public List<Guid> TemplateContactPropertyUids { get; set; }

	public List<LogMessage> LogMessages { get; set; }

	public List<string> Info { get; set; }

	public List<long> UpdatedContacts { get; set; }

	public List<TotalTimeItem> TotalTime { get; set; }

	public ImportResultModel()
	{
		LogMessages = new List<LogMessage>();
		TemplatePropertyUids = new List<Guid>();
		TemplateContactPropertyUids = new List<Guid>();
		UpdatedContacts = new List<long>();
	}
}
