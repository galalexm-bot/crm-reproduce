using System.Linq;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.CRM.Web.Extensions;

namespace EleWise.ELMA.CRM.Web.Controllers;

public class PhoneController : BPMController<IPhone, long>
{
	public bool IsReplacePhoneStringByLink()
	{
		return ComponentManager.Current.GetExtensionPoints<IPhoneSettingsExtension>().FirstOrDefault()?.IsReplacePhoneStringByLink() ?? false;
	}
}
