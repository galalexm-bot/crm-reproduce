using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.CRM.Web.Extensions;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IContractorBaseModel
{
	IContractor Contractor { get; }

	Guid ContratorTypeUid { get; }

	string EditorViewName { get; }

	string EditorFieldsViewName { get; }

	FormViewItem View { get; set; }

	IContractorBaseModel CreateFromContrator(IContractor contractor);

	IContractorBaseModel CreateFromContrator(IContractor contractor, ViewType viewType);

	void PrepareSave();
}
