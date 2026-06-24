using System.Collections.Generic;

namespace EleWise.ELMA.vCard.Vcard;

public class VcardTelephones : VcardSampleItem
{
	private Dictionary<VcardTelTypes, string> types;

	private string telephoneNumber;

	private VcardTelTypes[] type;

	public VcardTelephones(string telephoneNumber, VcardTelTypes[] type)
	{
		this.telephoneNumber = telephoneNumber;
		this.type = type;
		types = new Dictionary<VcardTelTypes, string>();
		types[VcardTelTypes.Work] = "WORK";
		types[VcardTelTypes.Fax] = "FAX";
		types[VcardTelTypes.Cell] = "CELL";
		types[VcardTelTypes.Pref] = "PREF";
	}

	private string PrintTypes(VcardTelTypes[] type)
	{
		List<string> list = new List<string>();
		foreach (VcardTelTypes key in type)
		{
			list.Add(types[key]);
		}
		return string.Join(",", list);
	}

	public override string Serialize()
	{
		return $"TEL;TYPE={PrintTypes(type)}:{telephoneNumber}\n";
	}
}
