using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Enums;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.CRM.Web.Extensions;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.CRM.Web.Models;

[Component]
public class RelationshipCallModel : RelationshipModel<IRelationshipCall>
{
	public override string EditorViewName => "RelationshipCall/Editors/RelationshipCallEdit";

	public RelationshipCallModel(IRelationshipCall relationship)
		: base(relationship)
	{
	}

	public RelationshipCallModel()
	{
		base.Entity.Type = RelationshipCallType.Output;
	}

	public RelationshipCallModel(ViewType viewType)
		: base(viewType)
	{
		base.Entity.Type = RelationshipCallType.Output;
	}

	public RelationshipCallModel(IRelationshipCall relationship, ViewType viewType)
		: base(relationship, viewType)
	{
	}

	protected override void SaveEntityAndCreateNew()
	{
		SaveEntity();
		IRelationshipCall relationshipCall = BaseCreateNew<IRelationshipCall>();
		relationshipCall.EndDate = relationshipCall.StartDate.AddMinutes(10.0);
		relationshipCall.Type = base.Entity.Type;
		base.Entity = relationshipCall;
	}

	protected override void SaveEntity()
	{
		base.Entity.EndDate = base.Entity.StartDate.AddMinutes(10.0);
		base.SaveEntity();
	}

	protected override IRelationshipBaseModel CreateConcreteModel(IRelationshipCall entity, ViewType viewType, Guid? customFormUid)
	{
		return new RelationshipCallModel(entity, viewType)
		{
			FormUid = customFormUid
		};
	}
}
