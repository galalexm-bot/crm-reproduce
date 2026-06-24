using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Serialization;

namespace EleWise.ELMA.CRM.Descriptors;

public class ColorDescriptor : EntitySubTypeDescriptor<IColor>
{
	public override Guid SubTypeUid => InterfaceActivator.UID<IColor>();

	public override object SerializeSimple(object value, Type valueType, EntitySerializationSettings settings)
	{
		if (valueType == null)
		{
			throw new ArgumentNullException("valueType");
		}
		if (valueType.IsInheritOrSame(typeof(IColor)))
		{
			IDictionary<string, object> dictionary = base.SerializeSimple(value, valueType, settings) as IDictionary<string, object>;
			if (value != null && value is IColor color)
			{
				dictionary?.Add(LinqUtils.NameOf((Expression<Func<IColor, object>>)((IColor c) => c.ColorCode)), color.ColorCode);
			}
			return dictionary;
		}
		return base.SerializeSimple(value, valueType, settings);
	}

	public override void PrepareDeserializedData(IDictionary<string, object> data)
	{
	}
}
