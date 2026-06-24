using System.Collections.Generic;
using EleWise.ELMA.Web.Mvc.Controllers;

namespace EleWise.ELMA.Web.Mvc.Models.DynamicForms;

public class DynamicFormChangeResult
{
	public List<DynamicFormPropertyResult> Properties { get; set; }

	public string NotifyMessages { get; set; }

	public bool ClosePopup { get; set; }

	public Dictionary<string, int> PropertiesVisibility { get; set; }

	public IDictionary<string, object> ValidationMetadata { get; set; }

	public Dictionary<string, object> ExtendedData { get; set; }

	public List<string> PropertiesValidation { get; set; }

	public string ViewTransformation { get; set; }

	public string ModelJsonState { get; set; }

	public bool Error { get; set; }

	public long TablePartLastTemporaryId => TablePartController.GetLastTemporaryId();

	public DynamicFormChangeResult()
	{
		Properties = new List<DynamicFormPropertyResult>();
		PropertiesVisibility = new Dictionary<string, int>();
		PropertiesValidation = new List<string>();
		ValidationMetadata = new Dictionary<string, object>();
		ExtendedData = new Dictionary<string, object>();
	}
}
