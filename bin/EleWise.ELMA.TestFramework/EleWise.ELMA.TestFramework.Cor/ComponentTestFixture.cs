using EleWise.ELMA.Core.Abstractions.Metadata.Models.UI.Models;

namespace EleWise.ELMA.TestFramework.Core;

internal sealed class ComponentTestFixture
{
	private ComponentMetadataItemHeader _003CHeader_003Ek__BackingField;

	private ITestFixture _003CTestFixture_003Ek__BackingField;

	public ComponentMetadataItemHeader Header
	{
		get
		{
			return _003CHeader_003Ek__BackingField;
		}
		set
		{
			_003CHeader_003Ek__BackingField = value;
		}
	}

	public ITestFixture TestFixture
	{
		get
		{
			return _003CTestFixture_003Ek__BackingField;
		}
		set
		{
			_003CTestFixture_003Ek__BackingField = value;
		}
	}
}
