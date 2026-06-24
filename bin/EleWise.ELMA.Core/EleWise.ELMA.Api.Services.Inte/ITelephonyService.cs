using System.Threading.Tasks;
using EleWise.ELMA.Api.Attributes;
using EleWise.ELMA.Core.Api;

namespace EleWise.ELMA.Api.Services.Internal;

[WebService("Telephony", "EleWise.ELMA.CRM.Telephony.Web")]
public interface ITelephonyService
{
	[Operation(Method = WebMethod.GET, UriTemplate = "/CheckRelationShip")]
	System.Threading.Tasks.Task<string> CheckRelationship(long id);

	[Operation(Method = WebMethod.GET, UriTemplate = "/GetOutputCallPopUp?popupId={popupId}&contractorId={contractorId}&contactId={contactId}&leadId={leadId}&callId={callId}")]
	System.Threading.Tasks.Task<string> GetOutputCallPopUp(string popupId, long contractorId, long contactId, long leadId, long callId);
}
