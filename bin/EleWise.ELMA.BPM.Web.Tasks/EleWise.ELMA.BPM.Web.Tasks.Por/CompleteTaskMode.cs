using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.BPM.Web.Tasks.Portlets;

public enum CompleteTaskMode
{
	[DisplayName(typeof(__Resources_CompleteTaskMode), "P_Normal")]
	Normal,
	[DisplayName(typeof(__Resources_CompleteTaskMode), "P_Quick")]
	Quick
}
