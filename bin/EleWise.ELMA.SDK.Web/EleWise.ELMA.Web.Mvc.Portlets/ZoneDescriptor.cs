namespace EleWise.ELMA.Web.Mvc.Portlets.Layouts;

public class ZoneDescriptor
{
	public string Id { get; private set; }

	public string Name { get; private set; }

	public ZoneDescriptor(string id, string name)
	{
		Id = id;
		Name = name;
	}
}
