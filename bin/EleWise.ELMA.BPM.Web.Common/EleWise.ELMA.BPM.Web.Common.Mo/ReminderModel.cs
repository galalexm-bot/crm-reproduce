using System;
using System.Collections.Generic;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Entities.EntityReferences;

namespace EleWise.ELMA.BPM.Web.Common.Models;

public class ReminderModel
{
	private ReferenceOnEntity refObject;

	public IEntity Entity { get; set; }

	public string PropertyName { get; set; }

	public DateTime? OriginalDate { get; set; }

	public ICollection<IReminder> Reminders { get; set; }

	public string ToolTipText { get; set; }

	public bool Periodical { get; set; }

	public DateTime? RemindDate { get; set; }

	public ReferenceOnEntity RefObject
	{
		get
		{
			return refObject ?? (refObject = ReferenceOnEntity.Create(Entity));
		}
		set
		{
			if (value != null && value.Object != null)
			{
				refObject = value;
				Entity = refObject.Object;
			}
		}
	}
}
