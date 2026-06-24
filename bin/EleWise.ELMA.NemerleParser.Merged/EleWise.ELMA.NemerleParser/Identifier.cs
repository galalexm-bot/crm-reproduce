using Nemerle.Peg;

namespace EleWise.ELMA.NemerleParser;

public class Identifier : Located
{
	public string Value { get; set; }
}
