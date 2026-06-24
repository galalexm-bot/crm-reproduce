using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Web.Mvc.Portlets;

public enum PortletFrame
{
	[DisplayName(typeof(PortletFrame_SR), "P_HeaderAndBorder")]
	Full,
	[DisplayName(typeof(PortletFrame_SR), "P_Border")]
	BorderOnly,
	[DisplayName(typeof(PortletFrame_SR), "P_Header")]
	HeaderOnly,
	[DisplayName(typeof(PortletFrame_SR), "P_None")]
	None,
	[DisplayName(typeof(PortletFrame_SR), "P_HeaderLine")]
	HeaderLine
}
