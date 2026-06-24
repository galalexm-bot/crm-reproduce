namespace EleWise.ELMA.NemerleParser;

public class Parameter : Constant
{
	public string Name { get; set; }

	public override string ToString()
	{
		return Name;
	}
}
