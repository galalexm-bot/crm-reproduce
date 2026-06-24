using System;

namespace EleWise.ELMA.vCard.Vcard;

public class VcardBirthday : VcardSampleItem
{
	private string bdayString;

	public VcardBirthday(DateTime? bday)
	{
		bdayString = (bday.HasValue ? bday.Value.ToString("yyyy-MM-dd") : "");
	}

	public override string Serialize()
	{
		return $"BDAY:{bdayString}\n";
	}
}
