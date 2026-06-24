using System.Collections.Generic;
using System.Text;

namespace EleWise.ELMA.vCard.Vcard;

public abstract class VcardItem : IVcardItem, IVcardItemWithItems
{
	public List<IVcardItem> Items;

	public VcardItem()
	{
		Items = new List<IVcardItem>();
	}

	public void Add(IVcardItem item)
	{
		Items.Add(item);
	}

	public virtual string Serialize()
	{
		StringBuilder stringBuilder = new StringBuilder();
		foreach (IVcardItem item in Items)
		{
			stringBuilder.Append(item.Serialize());
		}
		return stringBuilder.ToString();
	}
}
