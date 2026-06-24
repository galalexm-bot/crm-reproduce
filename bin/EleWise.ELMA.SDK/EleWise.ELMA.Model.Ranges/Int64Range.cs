namespace EleWise.ELMA.Model.Ranges;

public struct Int64Range : IRange<long>
{
	public long? From { get; set; }

	public long? To { get; set; }
}
