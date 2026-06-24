namespace EleWise.ELMA.Model.Ranges;

public struct Int16Range : IRange<short>
{
	public short? From { get; set; }

	public short? To { get; set; }
}
