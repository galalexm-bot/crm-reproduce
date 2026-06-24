namespace EleWise.ELMA.vCard.Vcard;

public class VcardAdress : VcardSampleItem
{
	public string SubscriberBox { get; set; }

	public string ExtendedAddress { get; set; }

	public string Home { get; set; }

	public string Street { get; set; }

	public string City { get; set; }

	public string Locality { get; set; }

	public string Region { get; set; }

	public string Postcode { get; set; }

	public string Country { get; set; }

	private string GetLocation()
	{
		if (!string.IsNullOrEmpty(City))
		{
			return City;
		}
		return Locality;
	}

	public override string Serialize()
	{
		return $"ADR;TYPE=DOM:{SubscriberBox};{ExtendedAddress};{Home} {Street};{GetLocation()};{Region};{Postcode};{Country}\n";
	}
}
