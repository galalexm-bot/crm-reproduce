using System;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.Model.Managers;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Core.Model.Views.Toolbox;

[Component(Order = 15)]
internal sealed class ChartViewItemToolboxGroup : BaseViewItemToolboxGroup
{
	private readonly ICurrentPageService currentPageService;

	public static readonly Guid UID = new Guid("{9B836324-FA2E-4E30-8173-3A2D82509707}");

	public override Guid GroupUid => UID;

	public override Guid ParentGroupUid => Guid.Empty;

	public override string Name => SR.T("Диаграммы");

	public override bool Visible => currentPageService.CurrentPageViewModel.RuntimeVersion == RuntimeVersion.Version2;

	public ChartViewItemToolboxGroup(ICurrentPageService currentPageService)
	{
		this.currentPageService = currentPageService;
	}
}
