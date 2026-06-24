using System;
using System.Linq;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Tasks.Components;
using EleWise.ELMA.Tasks.ExtensionPoints;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.CRM.Components.WorkLog;

[Component(Order = int.MaxValue)]
public class RelationshipWorkLogExtension : WorkLogExtensionBase<IRelationship>
{
	public static readonly Guid uid = new Guid("{88A6F6EE-8E65-4398-BE97-5152BC7C2F7E}");

	public override Guid Uid => uid;

	protected override IUser GetDefaultHarmonizator(IEntity entity)
	{
		IUser user = DefaultHarmonizator();
		if (user != null)
		{
			return user;
		}
		if (!(entity is IRelationship relationship))
		{
			return null;
		}
		return relationship.CreationAuthor;
	}

	public override WorkTime? PlanWorkLog(IEntity entity)
	{
		if (entity is IWorkLogItem workLogItem)
		{
			return PlanWorkLog(WorkLogExtensionHelper.LoadObject(workLogItem));
		}
		IRelationship relationship = entity as IRelationship;
		if (TestForBaseChild<IRelationshipCall>(entity) || TestForBaseChild<IRelationshipMail>(entity))
		{
			return null;
		}
		if (relationship != null)
		{
			return new WorkTime((long)(relationship.EndDate - relationship.StartDate).TotalMinutes);
		}
		return null;
	}

	private static bool TestForBaseChild<T>(IEntity entity)
	{
		if (!(InterfaceActivator.LoadMetadata(entity.GetType()) is ClassMetadata classMetadata))
		{
			return false;
		}
		Guid guid = InterfaceActivator.LoadMetadata(typeof(T)).Uid;
		if (classMetadata.Uid == guid)
		{
			return true;
		}
		return MetadataLoader.GetChildClasses(classMetadata).Any((ClassMetadata m) => m.Uid == guid);
	}
}
