namespace EleWise.ELMA.TestFramework;

public class TestConfig
{
	public bool AutoRun;

	public bool HidePassed;

	private int _003CTestTimeout_003Ek__BackingField;

	private bool _003CAlterTitle_003Ek__BackingField;

	private bool _003CScrollTop_003Ek__BackingField;

	public bool Reorder;

	private string _003CTestAssemblyNamePattern_003Ek__BackingField = ".Tests";

	public int TestTimeout
	{
		get
		{
			return _003CTestTimeout_003Ek__BackingField;
		}
		set
		{
			_003CTestTimeout_003Ek__BackingField = value;
		}
	}

	public bool AlterTitle
	{
		get
		{
			return _003CAlterTitle_003Ek__BackingField;
		}
		set
		{
			_003CAlterTitle_003Ek__BackingField = value;
		}
	}

	public bool ScrollTop
	{
		get
		{
			return _003CScrollTop_003Ek__BackingField;
		}
		set
		{
			_003CScrollTop_003Ek__BackingField = value;
		}
	}

	public string TestAssemblyNamePattern
	{
		get
		{
			return _003CTestAssemblyNamePattern_003Ek__BackingField;
		}
		set
		{
			_003CTestAssemblyNamePattern_003Ek__BackingField = value;
		}
	}
}
