using System;

namespace EleWise.ELMA.Web.Mvc.Models;

public class BaseErrorModel<T> where T : Exception
{
	public string Reason { get; set; }

	public string Url { get; set; }

	public string RouteDataText { get; set; }

	public T Exception { get; set; }
}
