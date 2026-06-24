using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.BPM.Web.Common.Models;

public class ScoringPropertyModel
{
	[DisplayName("SR.M('Идентификатор')")]
	public long Id { get; set; }

	[DisplayName("SR.M('Искать дубликат в другой сущности')")]
	public bool SearchDuplicateInAnotherEntity { get; set; }

	[DisplayName("SR.M('Является ли свойство скоринга новым')")]
	public bool IsNew { get; set; }

	[DisplayName("SR.M('Сущность')")]
	public Guid TypeUid { get; set; }

	[DisplayName("SR.M('Дубликат')")]
	public Guid DuplicateTypeUid { get; set; }

	[DisplayName("SR.M('Свойство сущности')")]
	public Guid Property { get; set; }

	[DisplayName("SR.M('Свойство дубликата')")]
	public Guid DuplicateProperty { get; set; }

	[DisplayName("SR.M('Процентное значение')")]
	public long PercentValue { get; set; }

	public List<SelectListItem> EntityPropertyList => (MetadataLoader.LoadMetadata(TypeUid) as EntityMetadata).Properties.OfType<EntityPropertyMetadata>().Select((Func<EntityPropertyMetadata, SelectListItem>)delegate(EntityPropertyMetadata s)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		SelectListItem val = new SelectListItem();
		val.set_Value(s.Uid.ToString());
		val.set_Text(s.DisplayName);
		val.set_Selected(false);
		return val;
	}).ToList();

	public List<SelectListItem> DuplicateEntityList { get; set; }
}
