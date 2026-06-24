using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security;

namespace EleWise.ELMA.CRM.Security;

[Component]
internal class TemplateCRMRoleTypes : IPermissionRoleTypeProvider
{
	public IEnumerable<PermissionRoleTypeStereotype> GetTypePermissionRoleStereotypes()
	{
		PermissionRoleType organizationItem = CommonRoleTypes.OrganizationItem;
		PermissionRoleType group = CommonRoleTypes.Group;
		PermissionRoleType user = CommonRoleTypes.User;
		PermissionRoleType author = CommonRoleTypes.Author;
		PermissionRoleType responsible = CommonRoleTypes.Responsible;
		PermissionRoleType participantWork = CommonRoleTypes.ParticipantWork;
		PermissionRoleType informs = CommonRoleTypes.Informs;
		PermissionRoleType[] roleTypes = new PermissionRoleType[7] { organizationItem, group, user, author, responsible, participantWork, informs };
		return new PermissionRoleTypeStereotype[10]
		{
			new PermissionRoleTypeStereotype(InterfaceActivator.TypeOf<IContContractorPermission>(), CRMPermissionProvider.ViewContractorPermission, roleTypes),
			new PermissionRoleTypeStereotype(InterfaceActivator.TypeOf<IContContractorPermission>(), CRMPermissionProvider.EditContractorPermission, roleTypes),
			new PermissionRoleTypeStereotype(InterfaceActivator.TypeOf<IContContractorPermission>(), CRMPermissionProvider.CRMContractorCreateElementPermission, roleTypes),
			new PermissionRoleTypeStereotype(InterfaceActivator.TypeOf<IContContractorPermission>(), CRMPermissionProvider.CRMContractorIssuanceElementPermission, roleTypes),
			new PermissionRoleTypeStereotype(InterfaceActivator.TypeOf<IContContractorPermission>(), CRMPermissionProvider.CRMContractorFullAccessPermission, roleTypes),
			new PermissionRoleTypeStereotype(InterfaceActivator.TypeOf<IContLeadPermission>(), CRMPermissionProvider.ViewLeadPermission, roleTypes),
			new PermissionRoleTypeStereotype(InterfaceActivator.TypeOf<IContLeadPermission>(), CRMPermissionProvider.EditLeadPermission, roleTypes),
			new PermissionRoleTypeStereotype(InterfaceActivator.TypeOf<IContLeadPermission>(), CRMPermissionProvider.CRMLeadCreateElementPermission, roleTypes),
			new PermissionRoleTypeStereotype(InterfaceActivator.TypeOf<IContLeadPermission>(), CRMPermissionProvider.CRMLeadIssuanceElementPermission, roleTypes),
			new PermissionRoleTypeStereotype(InterfaceActivator.TypeOf<IContLeadPermission>(), CRMPermissionProvider.CRMLeadFullAccessPermission, roleTypes)
		};
	}

	public IEnumerable<PermissionRoleType> GetRoleTypes()
	{
		return new PermissionRoleType[3]
		{
			CommonRoleTypes.Responsible,
			CommonRoleTypes.ParticipantWork,
			CommonRoleTypes.Informs
		};
	}

	public List<string> LocalizedItemNames()
	{
		return new List<string>
		{
			SR.T("Ответственный"),
			SR.T("Участники работы"),
			SR.T("Информируемые")
		};
	}
}
