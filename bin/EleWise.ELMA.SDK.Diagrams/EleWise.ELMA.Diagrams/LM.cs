using System;
using System.Reflection;
using Nevron;

namespace EleWise.ELMA.Diagrams;

public class LM
{
	public static void Init()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		NLicenseManager.get_Instance().set_LockLicense(false);
		NLicense license = new NLicense("185fa416-0202-4e83-1502-f183dcbb0bc8");
		NLicenseManager.get_Instance().SetLicense(license);
		NLicenseManager.get_Instance().set_LockLicense(true);
		Action<string, object> obj = delegate(string fieldName, object fieldValue)
		{
			((object)NLicenseManager.get_Instance()).GetType().InvokeMember(fieldName, BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.SetField, null, NLicenseManager.get_Instance(), new object[1] { fieldValue });
		};
		obj("l1l1lIIl1l1", true);
		obj("l1l1IlI1I1I", false);
	}
}
