using EleWise.ELMA.Runtime.Settings;
using EleWise.ELMA.Web.Mvc.Html.Forms;

namespace EleWise.ELMA.Web.Mvc.Models.Settings;

public class GlobalSettingsModuleForm<TSettings> where TSettings : GlobalSettingsBase
{
	public string FormUid { get; set; }

	public FormDriverForModel<TSettings> FormDriver { get; set; }

	public GlobalSettingsModuleForm(string formUid)
	{
		FormUid = formUid;
		FormDriver = new FormDriverForModel<TSettings>(formUid);
	}
}
