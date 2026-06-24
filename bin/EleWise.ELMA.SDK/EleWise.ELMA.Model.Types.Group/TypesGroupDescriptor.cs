using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types.Settings;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Types.Groups;

[Component]
public abstract class TypesGroupDescriptor : ITypeDescriptor, IXsiType
{
	internal static TypesGroupDescriptor xY0eZOor7ZXxxZsXFn1P;

	public abstract Guid Uid { get; }

	public Guid SubTypeUid => Guid.Empty;

	public virtual Guid ParentUid => Guid.Empty;

	public abstract string Name { get; }

	public virtual bool Visible => true;

	public bool CanBeNullable => false;

	public bool? DefaultNullableValue => null;

	public Type SettingsType => null;

	public virtual bool IsAvailibleEditPropertyTable => false;

	public bool UseForId => false;

	public bool UseForEntity => false;

	public bool IsGroup => true;

	public virtual bool IsSupportedSearchInIndex => false;

	public virtual bool IsSupportedFullTextSearchInIndex => false;

	protected virtual bool OrderTypesByName => true;

	public bool IsVisibleForMetadata(ClassMetadata classMetadata)
	{
		return true;
	}

	public Guid GetFilterType(PropertyMetadata propertyMetadata, IMetadata entityMetadata)
	{
		return Guid.Empty;
	}

	public TypeSettings CreateSettingsForFilterProperty(PropertyMetadata propertyMetadata)
	{
		return null;
	}

	public virtual bool IsEmpty(PropertyMetadata propertyMetadata, object val)
	{
		return val == null;
	}

	public virtual bool IsEmptyOrDefault(PropertyMetadata propertyMetadata, object val)
	{
		return KRbDj3ormqfR4psUYTVb(this, propertyMetadata, val);
	}

	public IEnumerable<ITypeDescriptor> GetSubTypes(ClassMetadata classMetadata)
	{
		IEnumerable<ITypeDescriptor> source = MetadataServiceContext.Service.GetTypeDescriptors().Where(delegate(ITypeDescriptor t)
		{
			//Discarded unreachable code: IL_0041, IL_0050
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					return slrkK1or9DpMavciDmHv(lgVMNuorMPnA1S9iCCKU(t), w0LTAlorJG2jDlB8Gc4g(this));
				default:
					return false;
				case 1:
					if (!Yde7WKory36Rhoj5K4R6(t))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 2;
				}
			}
		});
		if (OrderTypesByName)
		{
			source = source.OrderBy((ITypeDescriptor t) => (string)_003C_003Ec.d6UwxTCRm4vTnoQZgT5M(t));
		}
		return source.ToList();
	}

	public bool HasRealColumn(EntityMetadata entityMetadata, EntityPropertyMetadata propertyMetadata)
	{
		return false;
	}

	public List<string> SearchField()
	{
		return null;
	}

	public object FilterFiled()
	{
		return null;
	}

	protected TypesGroupDescriptor()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool qVwlNQorxpp8vNcTVhw9()
	{
		return xY0eZOor7ZXxxZsXFn1P == null;
	}

	internal static TypesGroupDescriptor hWBGZAor022f2Sca3c73()
	{
		return xY0eZOor7ZXxxZsXFn1P;
	}

	internal static bool KRbDj3ormqfR4psUYTVb(object P_0, object P_1, object P_2)
	{
		return ((TypesGroupDescriptor)P_0).IsEmpty((PropertyMetadata)P_1, P_2);
	}

	internal static bool Yde7WKory36Rhoj5K4R6(object P_0)
	{
		return ((ITypeDescriptor)P_0).Visible;
	}

	internal static Guid lgVMNuorMPnA1S9iCCKU(object P_0)
	{
		return ((ITypeDescriptor)P_0).ParentUid;
	}

	internal static Guid w0LTAlorJG2jDlB8Gc4g(object P_0)
	{
		return ((TypesGroupDescriptor)P_0).Uid;
	}

	internal static bool slrkK1or9DpMavciDmHv(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}
}
