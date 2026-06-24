using System;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Types;
using EleWise.ELMA.Core.Logging;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Types.Groups;

namespace EleWise.ELMA.Model.Types;

public abstract class SimpleTypeDescriptor<T> : TypeDescriptor<T>
{
	private bool? canBeNullable;

	public override Guid ParentUid => SimpleTypesDescriptor.UID;

	public override bool UseForEntity => true;

	public override bool CanBeNullable
	{
		get
		{
			if (!canBeNullable.get_HasValue())
			{
				canBeNullable = typeof(T).CanBeNullableType();
			}
			return canBeNullable.get_Value();
		}
	}

	public override bool? DefaultNullableValue => null;

	public SimpleTypeDescriptor(ILogger logger)
		: base(logger)
	{
	}
}
public abstract class SimpleTypeDescriptor<T, TSettings> : SimpleTypeDescriptor<T> where TSettings : TypeSettings
{
	public override System.Type SettingsType => typeof(TSettings);

	public SimpleTypeDescriptor(ILogger logger)
		: base(logger)
	{
	}
}
