namespace EleWise.ELMA.Model.Ranges;

public interface IRange<T> where T : struct
{
	T? From { get; set; }

	T? To { get; set; }
}
