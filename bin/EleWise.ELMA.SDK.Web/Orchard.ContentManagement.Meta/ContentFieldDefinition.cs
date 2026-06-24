namespace Orchard.ContentManagement.MetaData.Models;

public class ContentFieldDefinition
{
	public string Name { get; private set; }

	public ContentFieldDefinition(string name)
	{
		Name = name;
	}
}
