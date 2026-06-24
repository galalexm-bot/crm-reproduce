namespace EleWise.ELMA.vCard.Vcard;

public class VcardPairitem : VcardSampleItem
{
	private string item;

	private string key;

	public VcardPairitem(string key, string item)
	{
		this.item = item;
		this.key = key;
	}

	public override string Serialize()
	{
		return $"{key}:{item}\n";
	}
}
