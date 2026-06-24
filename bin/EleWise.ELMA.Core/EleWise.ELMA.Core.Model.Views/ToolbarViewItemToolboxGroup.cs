using System;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.UI.Metadata;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.Model.Managers;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Core.Model.Views.Toolbox;

[Component(Order = 10)]
public class ToolbarViewItemToolboxGroup : BaseViewItemToolboxGroup
{
	private readonly ICurrentPageService currentPageService;

	public static readonly Guid UID = new Guid("{3227C76C-755E-4B39-8473-C7A12AF7C750}");

	public override Guid GroupUid => UID;

	public override Guid ParentGroupUid => Guid.Empty;

	public override string Name => SR.T("Панель инструментов");

	public override bool Visible
	{
		get
		{
			if (currentPageService.CurrentPageViewModel.RuntimeVersion == RuntimeVersion.Version2)
			{
				return currentPageService.CurrentPageViewModel.Metadata is PageComponentMetadata;
			}
			return false;
		}
	}

	public ToolbarViewItemToolboxGroup(ICurrentPageService currentPageService)
	{
		this.currentPageService = currentPageService;
	}
}
