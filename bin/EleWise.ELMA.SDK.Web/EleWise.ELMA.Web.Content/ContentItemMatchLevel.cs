namespace EleWise.ELMA.Web.Content;

public enum ContentItemMatchLevel
{
	OverrideEqualUrl = 20,
	EqualUrl = 10,
	EqualActionRoute = 9,
	AreaControllerAction = 8,
	AreaControllerPlus = 7,
	AreaController = 6,
	AreaPlus = 5,
	Area = 4,
	Nothing = 0
}
