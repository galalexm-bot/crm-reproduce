using EleWise.ELMA.TestFramework.Services;

namespace EleWise.ELMA.TestFramework.API;

internal interface IComponentTest
{
	ITestComponentCreatorService TestComponentCreatorService { get; set; }
}
