using EleWise.ELMA.DynamicForms;
using EleWise.ELMA.Web.Mvc.Controllers;

namespace EleWise.ELMA.Web.Mvc.Models.DynamicForms;

public class DynamicFormPropertyChangedData : DynamicFormSettings
{
	public DynamicFormEditMode FormEditMode { get; set; }

	public string ChangedPropertyName { get; set; }

	public string ScriptName { get; set; }

	public bool IgnoreChangedPropertyInResult { get; set; }

	public long TablePartLastTemporaryId
	{
		get
		{
			return TablePartController.GetLastTemporaryId();
		}
		set
		{
			if (value != 0L && value < TablePartController.GetLastTemporaryId())
			{
				TablePartController.SetLastTemporaryId(value);
			}
		}
	}

	public string DynamicFormId { get; set; }
}
