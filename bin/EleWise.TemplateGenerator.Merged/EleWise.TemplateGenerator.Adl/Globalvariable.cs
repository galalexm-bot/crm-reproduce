namespace EleWise.TemplateGenerator.Adl.Tree;

public class Globalvariable : Expression
{
	public string Name { get; set; }

	public override string ToString()
	{
		return "{#" + Name + "}";
	}

	public override TreeItem CreateCopy(TreeItem parent)
	{
		Variable obj = (Variable)base.CreateCopy(parent);
		obj.Name = Name;
		return obj;
	}
}
