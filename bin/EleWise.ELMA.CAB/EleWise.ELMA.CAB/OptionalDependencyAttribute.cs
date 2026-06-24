using System;
using Microsoft.Practices.ObjectBuilder;

namespace EleWise.ELMA.CAB;

public abstract class OptionalDependencyAttribute : ParameterAttribute
{
	private bool required = true;

	public bool Required
	{
		get
		{
			return required;
		}
		set
		{
			required = value;
		}
	}

	public abstract override IParameter CreateParameter(Type memberType);
}
