using System;
using System.Collections.Generic;

namespace EleWise.ELMA.TestFramework.Results;

internal class TestSuiteResult
{
	private System.Collections.Generic.ICollection<AssertResult> _003CAsserts_003Ek__BackingField;

	private List<TestSuiteResult> _003CChildren_003Ek__BackingField;

	private int _003CScenarioCount_003Ek__BackingField;

	private int _003CDuration_003Ek__BackingField;

	private int _003CTotal_003Ek__BackingField;

	private int _003CPassed_003Ek__BackingField;

	private int _003CFailed_003Ek__BackingField;

	private int _003CSkipped_003Ek__BackingField;

	private TestSuiteResult _003CParent_003Ek__BackingField;

	private System.Exception _003CException_003Ek__BackingField;

	private string _003CName_003Ek__BackingField;

	private string _003CFullName_003Ek__BackingField;

	private string _003CId_003Ek__BackingField;

	private System.Collections.Generic.ICollection<string> _003CFailedIds_003Ek__BackingField;

	private TestStatus _003CStatus_003Ek__BackingField;

	private string _003CSkipReason_003Ek__BackingField;

	public System.Collections.Generic.ICollection<AssertResult> Asserts
	{
		get
		{
			return _003CAsserts_003Ek__BackingField;
		}
		set
		{
			_003CAsserts_003Ek__BackingField = value;
		}
	}

	public List<TestSuiteResult> Children
	{
		get
		{
			return _003CChildren_003Ek__BackingField;
		}
		set
		{
			_003CChildren_003Ek__BackingField = value;
		}
	}

	public int ScenarioCount
	{
		get
		{
			return _003CScenarioCount_003Ek__BackingField;
		}
		set
		{
			_003CScenarioCount_003Ek__BackingField = value;
		}
	}

	public int Duration
	{
		get
		{
			return _003CDuration_003Ek__BackingField;
		}
		set
		{
			_003CDuration_003Ek__BackingField = value;
		}
	}

	public int Total
	{
		get
		{
			return _003CTotal_003Ek__BackingField;
		}
		set
		{
			_003CTotal_003Ek__BackingField = value;
		}
	}

	public int Passed
	{
		get
		{
			return _003CPassed_003Ek__BackingField;
		}
		internal set
		{
			_003CPassed_003Ek__BackingField = value;
		}
	}

	public int Failed
	{
		get
		{
			return _003CFailed_003Ek__BackingField;
		}
		set
		{
			_003CFailed_003Ek__BackingField = value;
		}
	}

	public int Skipped
	{
		get
		{
			return _003CSkipped_003Ek__BackingField;
		}
		set
		{
			_003CSkipped_003Ek__BackingField = value;
		}
	}

	public TestSuiteResult Parent
	{
		get
		{
			return _003CParent_003Ek__BackingField;
		}
		set
		{
			_003CParent_003Ek__BackingField = value;
		}
	}

	public System.Exception Exception
	{
		get
		{
			return _003CException_003Ek__BackingField;
		}
		set
		{
			_003CException_003Ek__BackingField = value;
		}
	}

	public string Name
	{
		get
		{
			return _003CName_003Ek__BackingField;
		}
		set
		{
			_003CName_003Ek__BackingField = value;
		}
	}

	public string FullName
	{
		get
		{
			return _003CFullName_003Ek__BackingField;
		}
		set
		{
			_003CFullName_003Ek__BackingField = value;
		}
	}

	public string Id
	{
		get
		{
			return _003CId_003Ek__BackingField;
		}
		set
		{
			_003CId_003Ek__BackingField = value;
		}
	}

	public System.Collections.Generic.ICollection<string> FailedIds
	{
		get
		{
			return _003CFailedIds_003Ek__BackingField;
		}
		set
		{
			_003CFailedIds_003Ek__BackingField = value;
		}
	}

	public TestStatus Status
	{
		get
		{
			return _003CStatus_003Ek__BackingField;
		}
		set
		{
			_003CStatus_003Ek__BackingField = value;
		}
	}

	public string SkipReason
	{
		get
		{
			return _003CSkipReason_003Ek__BackingField;
		}
		set
		{
			_003CSkipReason_003Ek__BackingField = value;
		}
	}

	public TestSuiteResult()
	{
		Asserts = (System.Collections.Generic.ICollection<AssertResult>)new List<AssertResult>();
		Children = new List<TestSuiteResult>();
		FailedIds = (System.Collections.Generic.ICollection<string>)new List<string>();
	}

	internal void AddChildResult(TestSuiteResult result)
	{
		result.Parent = this;
		Children.Add(result);
		Total += result.Total;
		Passed += result.Passed;
		Failed += result.Failed;
		Skipped += result.Skipped;
	}

	internal void AddAssertResult(AssertResult result)
	{
		result.Id = $"{Id}_assert{Asserts.get_Count()}";
		Asserts.Add(result);
		Total++;
		if (result.Passed)
		{
			Passed++;
		}
		else
		{
			Failed++;
		}
	}
}
