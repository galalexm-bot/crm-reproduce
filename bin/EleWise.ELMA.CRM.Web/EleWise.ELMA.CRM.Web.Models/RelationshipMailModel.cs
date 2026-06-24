using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.CRM.Web.Extensions;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.CRM.Web.Models;

[Component]
public class RelationshipMailModel : RelationshipModel<IRelationshipMail>
{
	public override string EditorViewName => "RelationshipMail/Editors/RelationshipMailEdit";

	public RelationshipMailModel(IRelationshipMail relationship)
		: base(relationship)
	{
	}

	public RelationshipMailModel()
	{
	}

	public RelationshipMailModel(IRelationshipMail relationship, ViewType viewType)
		: base(relationship, viewType)
	{
	}

	public RelationshipMailModel(ViewType viewType)
		: base(viewType)
	{
	}

	protected override void SaveEntityAndCreateNew()
	{
		SaveEntity();
		IRelationshipMail relationshipMail = BaseCreateNew<IRelationshipMail>();
		relationshipMail.EndDate = relationshipMail.StartDate.AddMinutes(10.0);
		base.Entity = relationshipMail;
	}

	protected override void SaveEntity()
	{
		base.Entity.EndDate = base.Entity.StartDate.AddMinutes(10.0);
		base.SaveEntity();
	}

	protected override IRelationshipBaseModel CreateConcreteModel(IRelationshipMail entity, ViewType viewType, Guid? customFormUid)
	{
		return new RelationshipMailModel(entity, viewType)
		{
			FormUid = customFormUid
		};
	}
}
