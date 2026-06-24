namespace EleWise.ELMA.XmlSerializers;

internal class SpecialMapping : TypeMapping
{
	private bool namedAny;

	internal bool NamedAny
	{
		get
		{
			return namedAny;
		}
		set
		{
			namedAny = value;
		}
	}
}
