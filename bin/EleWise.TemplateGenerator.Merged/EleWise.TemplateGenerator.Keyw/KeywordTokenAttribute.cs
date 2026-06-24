using System;

namespace EleWise.TemplateGenerator.Keywords;

internal class KeywordTokenAttribute : Attribute
{
	private int token;

	public int Token => token;

	public KeywordTokenAttribute(int token)
	{
		this.token = token;
	}
}
