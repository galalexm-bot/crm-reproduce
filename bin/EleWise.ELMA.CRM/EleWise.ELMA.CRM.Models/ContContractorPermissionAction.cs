using System;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.CRM.Models;

public class ContContractorPermissionActions : DefaultEntityActions
{
	[Uid("e87b727c-f6e4-4c19-bdaf-2683aa8e3857")]
	[DisplayName(typeof(__Resources_ContContractorPermissionActions), "P_ChangeAccess_DisplayName")]
	public const string ChangeAccess = "e87b727c-f6e4-4c19-bdaf-2683aa8e3857";

	private static Guid _changeAccessGuid = new Guid("e87b727c-f6e4-4c19-bdaf-2683aa8e3857");

	public static Guid ChangeAccessGuid => _changeAccessGuid;

	protected ContContractorPermissionActions()
	{
	}
}
