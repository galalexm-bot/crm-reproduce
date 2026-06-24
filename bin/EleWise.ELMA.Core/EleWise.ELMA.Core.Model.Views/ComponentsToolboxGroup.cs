using System;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.Model.Managers;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Core.Model.Views.Toolbox;

[Component(Order = 10)]
public class ComponentsToolboxGroup : BaseViewItemToolboxGroup
{
	private readonly ICurrentPageService currentPageService;

	public static readonly Guid UID = new Guid("{6F73B746-22FA-455C-852D-47121CF80059}");

	public override Guid GroupUid => UID;

	public override Guid ParentGroupUid => Guid.Empty;

	public override string Name => SR.T("Компоненты");

	public override bool Visible
	{
		get
		{
			if (currentPageService.CurrentPageViewModel != null)
			{
				return currentPageService.CurrentPageViewModel.RuntimeVersion == RuntimeVersion.Version2;
			}
			return false;
		}
	}

	public ComponentsToolboxGroup(ICurrentPageService currentPageService)
	{
		this.currentPageService = currentPageService;
	}
}
