using System;

namespace EleWise.ELMA.Workflow.Processes.Web.Models;

public class CreatePackageInfo
{
	public string JsonItemIds { get; set; }

	public string Name { get; set; }

	public string MigrationReason { get; set; }

	public CreatePackageInfo()
	{
		Name = SR.T("Пакет миграции {0}", DateTime.Now.ToLongDateString());
		JsonItemIds = string.Empty;
	}
}
