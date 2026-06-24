using Iesi.Collections.Generic;

namespace EleWise.ELMA.Web.Mvc.Html;

public class NamingService : INamingService
{
	private int count = 1;

	private readonly HashedSet<string> names = new HashedSet<string>();

	public string GenerateName(string prefix)
	{
		string text;
		do
		{
			count++;
			text = prefix + count;
		}
		while (((Set<string>)(object)names).Contains(text));
		RegisterName(text);
		return text;
	}

	public void CheckName(string name)
	{
		if (((Set<string>)(object)names).Contains(name))
		{
			throw new NameAlreadyUsedException("name " + name + " already used");
		}
	}

	public void RegisterName(string name)
	{
		CheckName(name);
		((Set<string>)(object)names).Add(name);
	}
}
