using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Views.Toolbox;

namespace EleWise.ELMA.CRM.ViewItems;

[Component]
public class RelationshipViewItemToolboxGroup : IViewItemToolboxGroup
{
	public static readonly Guid UID = new Guid("{A4C3316C-BE1B-498F-9692-BFE729715FF4}");

	public Guid GroupUid => UID;

	public Guid ParentGroupUid => Guid.Empty;

	public string Name => SR.T("Взаимоотношение");
}
