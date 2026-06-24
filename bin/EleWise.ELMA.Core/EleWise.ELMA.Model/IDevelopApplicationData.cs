namespace EleWise.ELMA.Model;

internal interface IDevelopApplicationData : IApplicationData
{
	DevelopMode DevelopMode { get; }

	TestMode TestMode { get; }
}
