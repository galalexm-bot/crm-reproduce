using EleWise.ELMA.Core;
using EleWise.ELMA.Core.Abstractions.Metadata.Models;
using EleWise.ELMA.DTO;

namespace EleWise.ELMA.Components;

internal sealed class StartProcessContentAction : AbstractContentAction
{
	private ContentAction contentAction;

	public override string Id => "EleWise.ELMA.Workflow.Processes.StartProcessProvider";

	public override ContentAction ContentAction
	{
		get
		{
			if (contentAction == null)
			{
				contentAction = InterfaceCreator.Create<ContentAction>();
				contentAction.set_Category(SR.T("Управление бизнес-процессами"));
				contentAction.set_Name(SR.T("Запустить процесс"));
				contentAction.set_ActionType(SR.T("Страница"));
				contentAction.set_TypeProviderId("EleWise.ELMA.Workflow.Processes.StartProcessProvider");
				contentAction.set_Id("EleWise.ELMA.Workflow.Processes.StartProcessProvider");
				contentAction.set_Image16("/Content/IconPack/process.svg");
				contentAction.set_Image24("/Content/IconPack/process.svg");
				contentAction.set_Image32("/Content/IconPack/process.svg");
			}
			return contentAction;
		}
	}
}
