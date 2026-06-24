using System;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Model.Events;

namespace EleWise.ELMA.Documents.Models;

public class ConvertedFromOtherTypeHistoryModel : HistoryBaseModel, IHistoryBaseModel
{
	public Guid PrevType { get; set; }

	public string PrevTypeName { get; set; }

	public Guid NewType { get; set; }

	public string NewTypeName { get; set; }

	public ConvertedFromOtherTypeHistoryModel([NotNull] EntityActionEventArgs originalEvent, string actionTheme)
		: base(originalEvent, actionTheme)
	{
	}
}
