using System;
using System.CodeDom;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace Nemerle.Compiler;

internal class NemerleMemberAttributeConverter : TypeConverter, ISupportRelocation
{
	public static readonly NemerleMemberAttributeConverter Default;

	private readonly string[] _names = new string[5] { "Public", "Protected", "Protected Internal", "Internal", "Private" };

	private readonly object[] _values = new object[5]
	{
		MemberAttributes.Public,
		MemberAttributes.Family,
		MemberAttributes.FamilyOrAssembly,
		MemberAttributes.Assembly,
		MemberAttributes.Private
	};

	static NemerleMemberAttributeConverter()
	{
		Default = new NemerleMemberAttributeConverter();
	}

	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
	{
		return typeof(string).Equals(sourceType) || base.CanConvertFrom(context, sourceType);
	}

	public override object ConvertFrom(ITypeDescriptorContext _N_wildcard_3327, CultureInfo _N_wildcard_3328, object value)
	{
		object result;
		if (value is string)
		{
			int num = Array.IndexOf(_names, (string)value);
			result = ((num >= 0) ? _values[num] : _values[0]);
		}
		else
		{
			result = _values[0];
		}
		return result;
	}

	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
	{
		if (destinationType == null)
		{
			throw new ArgumentNullException("destinationType");
		}
		object result;
		if (typeof(string).Equals(destinationType))
		{
			int num = Array.IndexOf(_values, value);
			result = ((num >= 0) ? _names[num] : _names[0]);
		}
		else
		{
			result = base.ConvertTo(context, culture, value, destinationType);
		}
		return result;
	}

	public override bool GetStandardValuesExclusive(ITypeDescriptorContext _N_wildcard_3329)
	{
		return true;
	}

	public override bool GetStandardValuesSupported(ITypeDescriptorContext _N_wildcard_3330)
	{
		return true;
	}

	public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext _N_wildcard_3331)
	{
		return new StandardValuesCollection(_values);
	}

	[CompilerGenerated]
	internal override void RelocateImplInternal(RelocationInfo _info)
	{
	}

	void ISupportRelocation.RelocateImpl(RelocationInfo _info)
	{
		//ILSpy generated this explicit interface implementation from .override directive in RelocateImplInternal
		this.RelocateImplInternal(_info);
	}
}
