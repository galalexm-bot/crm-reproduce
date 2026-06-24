using System;
using EleWise.ELMA.Core.Logging;

namespace EleWise.ELMA.Model.Types;

public abstract class CLRTypeDescriptor<T> : SimpleTypeDescriptor<T>, IRuntimeTypeDescriptor
{
	public System.Type RuntimeType => typeof(T);

	public virtual bool IsRuntimeType => true;

	protected CLRTypeDescriptor(ILogger logger)
		: base(logger)
	{
	}
}
public abstract class CLRTypeDescriptor<T, TSettings> : CLRTypeDescriptor<T>
{
	public override System.Type SettingsType => typeof(TSettings);

	protected CLRTypeDescriptor(ILogger logger)
		: base(logger)
	{
	}
}
