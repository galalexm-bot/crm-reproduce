namespace EleWise.ELMA.vCard.Vcard;

public class VcardEmail : VcardSampleItem
{
	private string Email;

	public VcardEmail(string email)
	{
		Email = email;
	}

	public override string Serialize()
	{
		return $"EMAIL;TYPE=INTERNET:{Email}\n";
	}
}
