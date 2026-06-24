namespace EleWise.ELMA.BPM.Web.Common.Models;

public sealed class QueryParameterErrorModel
{
	public string PropertyName { get; set; }

	public string Message { get; set; }

	public QueryParameterErrorModel(string propertyName, string message)
	{
		PropertyName = propertyName;
		Message = message;
	}
}
