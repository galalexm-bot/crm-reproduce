using System.Collections.Generic;
using System.Linq;
using System.Text;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.vCard.Vcard;

public class Vcard : VcardItem
{
	public Vcard()
	{
	}

	public Vcard(IUser user)
	{
		Add(new VcardPairitem("TITLE", string.Join(",", ((IEnumerable<IOrganizationItem>)user.OrganizationItems).Select((IOrganizationItem x) => x.Name))));
		Add(new VcardPairitem("ORG", SR.M("ELMA")));
		Add(new VcardName
		{
			FirstName = user.FirstName,
			LastName = user.LastName,
			MiddleName = user.MiddleName,
			FullName = user.FullName
		});
		Add(new VcardBirthday(user.BirthDate));
		Add(new VcardEmail(user.EMail));
		Add(new VcardTelephones(user.WorkPhone, new VcardTelTypes[1]));
		Add(new VcardTelephones(user.MobilePhone, new VcardTelTypes[1] { VcardTelTypes.Cell }));
		Add(new VcardPairitem("NOTE", SR.T("Контакт выгружен из ELMA")));
		Add(new VcardPairitem("X-SKYPE-USERNAME", user.Skype));
		Add(new VcardPairitem("X-ICQ", user.ICQ));
		Add(new VcardPairitem("X-JABBER", user.JabberID));
	}

	public override string Serialize()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append("BEGIN:VCARD\n");
		stringBuilder.Append("VERSION:3.0\n");
		foreach (IVcardItem item in Items)
		{
			stringBuilder.Append(item.Serialize());
		}
		stringBuilder.Append("CLASS:PUBLIC\n");
		stringBuilder.Append("END:VCARD\n");
		return stringBuilder.ToString();
	}
}
