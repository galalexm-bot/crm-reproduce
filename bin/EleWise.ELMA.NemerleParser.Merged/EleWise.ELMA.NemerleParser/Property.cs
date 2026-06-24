namespace EleWise.ELMA.NemerleParser;

public class Property : Expression
{
	public string Name { get; set; }

	public bool RootProperty { get; set; }

	public int ParentProperty { get; set; }

	public override string ToString()
	{
		return RootProperty ? (Name + " (root)") : ((ParentProperty <= 0) ? Name : string.Concat(string.Concat(Name + " (parent: ", ParentProperty.ToString()), ")"));
	}

	public override TreeItem CreateCopy(TreeItem parent)
	{
		Property property = (Property)base.CreateCopy(parent);
		property.Name = Name;
		return property;
	}
}
