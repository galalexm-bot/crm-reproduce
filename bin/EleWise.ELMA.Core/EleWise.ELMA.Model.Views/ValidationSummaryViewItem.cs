using System;
using EleWise.ELMA.Core;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.Model.Managers;
using EleWise.ELMA.Core.Model.Views.Toolbox;

namespace EleWise.ELMA.Model.Views;

internal sealed class ValidationSummaryViewItem : ViewItem
{
	[Component(Order = 450)]
	private class ToolboxItem : AdditionalViewItemToolboxItem<ValidationSummaryViewItem>
	{
		private readonly ICurrentPageService currentPageService;

		public override Guid Uid => new Guid("F4C56E6F-9321-489C-910B-22F7E5361B52");

		public override string Name => SR.T("Результат валидации формы");

		public override bool Visible => currentPageService.CurrentPageViewModel.RuntimeVersion == RuntimeVersion.Version2;

		public override string Icon => "validation-summary";

		public ToolboxItem(ICurrentPageService currentPageService, IViewItemInfoService viewItemInfoService)
			: base(viewItemInfoService)
		{
			this.currentPageService = currentPageService;
		}
	}
}
