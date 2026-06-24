using System;
using EleWise.ELMA.Core.Model;

namespace EleWise.ELMA.Core.React.Models;

public class WrapperInputs : Inputs
{
	private Func<IWrapModel> _003CWrapModel_003Ek__BackingField;

	public Func<IWrapModel> WrapModel
	{
		get
		{
			return _003CWrapModel_003Ek__BackingField;
		}
		set
		{
			_003CWrapModel_003Ek__BackingField = value;
		}
	}
}
