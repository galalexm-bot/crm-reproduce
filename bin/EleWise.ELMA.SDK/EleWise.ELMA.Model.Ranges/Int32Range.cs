namespace EleWise.ELMA.Model.Ranges;

public struct Int32Range : IRange<int>
{
	public int? From { get; set; }

	public int? To { get; set; }
}
