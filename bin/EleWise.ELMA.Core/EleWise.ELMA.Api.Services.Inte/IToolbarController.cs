using System.Threading.Tasks;
using EleWise.ELMA.Api.Attributes;
using EleWise.ELMA.Api.Models;
using EleWise.ELMA.Core.Api;

namespace EleWise.ELMA.Api.Services.Internal;

[WebService("Toolbar", "EleWise.ELMA.Workflow.Web")]
internal interface IToolbarController
{
	[Operation(Method = WebMethod.GET, UriTemplate = "/GetConnectorData?workflowTaskId={workflowTaskId}&htmlPrefix={htmlPrefix}")]
	System.Threading.Tasks.Task<ConnectorDataWrapper> GetConnectorData(long workflowTaskId, string htmlPrefix);
}
