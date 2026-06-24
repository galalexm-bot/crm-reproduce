using System;
using System.Collections.Generic;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Tasks.Components;

namespace EleWise.ELMA.Tasks.Models;

public class UserEditWorkLogItemHistoryModel : HistoryBaseModel, IEditedHistoryModel<IWorkLogItem>, IHistoryBaseModel, ITaskHistoryBaseModel
{
	private IEntity oldObject;

	private IEntity newObject;

	public IList<PropertyMetadata> ChangedProperties { get; set; }

	public IWorkLogItem OldEntity { get; set; }

	public IWorkLogItem NewEntity { get; set; }

	public IEntity OldObject
	{
		get
		{
			if (oldObject == null)
			{
				oldObject = WorkLogExtensionHelper.LoadObject(OldEntity.ObjectId, OldEntity.ObjectUID);
			}
			return oldObject;
		}
	}

	public IEntity NewObject
	{
		get
		{
			if (oldObject == null)
			{
				oldObject = WorkLogExtensionHelper.LoadObject(NewEntity.ObjectId, NewEntity.ObjectUID);
			}
			return oldObject;
		}
	}

	public List<Guid> BaseProperties => WorkLogItemActionHelper.BaseProperties();

	public UserEditWorkLogItemHistoryModel([NotNull] EntityActionEventArgs originalEvent, string actionTheme)
		: base(originalEvent, actionTheme)
	{
	}
}
