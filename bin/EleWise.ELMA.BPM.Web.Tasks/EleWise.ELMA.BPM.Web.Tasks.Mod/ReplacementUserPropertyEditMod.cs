using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Entities.EntityReferences;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Tasks.ExtensionPoints;
using EleWise.ELMA.Tasks.Extensions;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.BPM.Web.Tasks.Models;

public class ReplacementUserPropertyEditModel
{
	private readonly long sourceUserId;

	private readonly IReplacementTask replacementTask;

	public long ReplacementTaskId { get; private set; }

	public PropertyMetadata PropertyMetadata { get; private set; }

	public IEntity Entity { get; private set; }

	public IUser User
	{
		get
		{
			if (HasReplacementProperty())
			{
				return replacementTask.GetAssignment(new ReferenceOnEntity
				{
					Object = Entity
				}, PropertyMetadata.Uid);
			}
			return RealUser();
		}
	}

	public ReplacementUserPropertyEditModel(IReplacementTask replacementTask, IEntity entity, PropertyMetadata propertyMetadata)
	{
		this.replacementTask = replacementTask;
		ReplacementTaskId = replacementTask.Id;
		sourceUserId = replacementTask.GetReplacementUser().Id;
		PropertyMetadata = propertyMetadata;
		Entity = entity.CastAsRealType();
	}

	private IUser RealUser()
	{
		try
		{
			return Entity.GetPropertyValue<IUser>(PropertyMetadata.Uid);
		}
		catch (MetadataException)
		{
			return null;
		}
	}

	public bool HasReplacementProperty()
	{
		if (!((ICollection<TaskBaseStatus>)TaskBaseExtensions.ActiveTaskStatuses).Contains(replacementTask.Status))
		{
			return false;
		}
		if (ComponentManager.Current.GetExtensionPoints<IReplacementTaskRemapObjectsFilterExtension>().Any((IReplacementTaskRemapObjectsFilterExtension e) => e.CanUseForReplacementTaskType(replacementTask) && e.IsPropertyReadOnly(replacementTask.GetReplacementObject(), PropertyMetadata, Entity)))
		{
			return false;
		}
		IUser user = RealUser();
		if (user != null)
		{
			return user.Id == sourceUserId;
		}
		return false;
	}
}
