namespace EleWise.ELMA.Model.Ranges;

public struct DoubleRange : IRange<double>
{
	public double? From { get; set; }

	public double? To { get; set; }
}
