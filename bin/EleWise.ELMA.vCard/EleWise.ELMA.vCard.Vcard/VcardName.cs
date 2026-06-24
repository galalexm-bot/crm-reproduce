using System.Text;

namespace EleWise.ELMA.vCard.Vcard;

public class VcardName : VcardSampleItem
{
	public string FirstName { get; set; }

	public string LastName { get; set; }

	public string MiddleName { get; set; }

	public string FullName { get; set; }

	public override string Serialize()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendFormat("N:{0};{1};{2}\n", LastName, FirstName, MiddleName);
		stringBuilder.AppendFormat("FN:{0}\n", FullName);
		return stringBuilder.ToString();
	}
}
