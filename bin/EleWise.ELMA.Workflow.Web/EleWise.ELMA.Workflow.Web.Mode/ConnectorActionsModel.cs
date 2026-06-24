using System.Web.Mvc;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Workflow.Web.Models;

public class ConnectorActionsModel
{
	public string ConnectorCode { get; set; }

	public MvcHtmlString ConfirmPopup { get; set; }

	public MvcHtmlString FormPopup { get; set; }

	public string ConnectorName { get; set; }

	public string ConnectorId { get; set; }

	public ButtonStyle ColorConnectorButton { get; set; }
}
