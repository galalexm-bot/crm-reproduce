using System;
using System.Collections.Generic;
using EleWise.ELMA.API.Models;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Types;

public class SubTypeGroupDescriptor : ITypeDescriptor, IXsiType, IPublicApplicationTypeDescriptor
{
	private string name;

	private ITypeDescriptor parent;

	private List<ITypeDescriptor> subTypes;

	private static SubTypeGroupDescriptor gYEsdyo9EC6abuqbi8YI;

	public Guid Uid => Guid.Empty;

	public Guid SubTypeUid => Guid.Empty;

	public Guid ParentUid => Guid.Empty;

	public List<ITypeDescriptor> SubTypes => subTypes;

	public bool IsGroup => true;

	public string Name => name;

	public virtual bool Visible => true;

	public bool CanBeNullable => false;

	public bool? DefaultNullableValue => null;

	public Type SettingsType => null;

	public virtual bool IsAvailibleEditPropertyTable => false;

	public bool UseForId => false;

	public bool UseForEntity => false;

	public SubTypeGroupDescriptor(string name, ITypeDescriptor parent)
	{
		//Discarded unreachable code: IL_003a, IL_003f
		SingletonReader.JJCZtPuTvSt();
		subTypes = new List<ITypeDescriptor>();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				this.name = name;
				num = 2;
				break;
			case 1:
				return;
			case 2:
				this.parent = parent;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
				{
					num = 1;
				}
				break;
			}
		}
	}

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

	public IEnumerable<ITypeDescriptor> GetSubTypes(ClassMetadata classMetadata)
	{
		return subTypes;
	}

	public virtual bool IsEmpty(PropertyMetadata propertyMetadata, object val)
	{
		return val == null;
	}

	public virtual bool IsEmptyOrDefault(PropertyMetadata propertyMetadata, object val)
	{
		return BajoA7o9CYVMe0RsqKYf(this, propertyMetadata, val);
	}

	public bool HasRealColumn(EntityMetadata entityMetadata, EntityPropertyMetadata propertyMetadata)
	{
		return false;
	}

	public bool IsPublicApplicationDisplayEnabled(Guid subTypeUid)
	{
		int num = 2;
		int num2 = num;
		IPublicApplicationTypeDescriptor publicApplicationTypeDescriptor = default(IPublicApplicationTypeDescriptor);
		while (true)
		{
			switch (num2)
			{
			case 2:
				publicApplicationTypeDescriptor = parent as IPublicApplicationTypeDescriptor;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				return gP1rSxo9vU4tWNhDfpbI(publicApplicationTypeDescriptor, subTypeUid);
			case 1:
				if (publicApplicationTypeDescriptor == null)
				{
					return true;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public bool IsPublicApplicationEditorEnabled(Guid subTypeUid)
	{
		//Discarded unreachable code: IL_004d, IL_005c
		int num = 1;
		int num2 = num;
		IPublicApplicationTypeDescriptor publicApplicationTypeDescriptor = default(IPublicApplicationTypeDescriptor);
		while (true)
		{
			switch (num2)
			{
			default:
				if (publicApplicationTypeDescriptor == null)
				{
					num2 = 3;
					break;
				}
				goto case 2;
			case 2:
				return IIyTJpo98SilOdl5bLgF(publicApplicationTypeDescriptor, subTypeUid);
			case 3:
				return true;
			case 1:
				publicApplicationTypeDescriptor = parent as IPublicApplicationTypeDescriptor;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public void CheckPublicApplicationCompatibility(ClassMetadata classMetadata, PropertyMetadata propertyMetadata, PropertyViewItem viewItem, string parentPropertyName, List<IPublicApplicationCompatibilityError> errors)
	{
		if (parent is IPublicApplicationTypeDescriptor publicApplicationTypeDescriptor)
		{
			publicApplicationTypeDescriptor.CheckPublicApplicationCompatibility(classMetadata, propertyMetadata, viewItem, parentPropertyName, errors);
		}
	}

	internal static bool cF42WUo9fCx6nqQGCvBH()
	{
		return gYEsdyo9EC6abuqbi8YI == null;
	}

	internal static SubTypeGroupDescriptor D3IAV9o9QlmiiMuKEsdY()
	{
		return gYEsdyo9EC6abuqbi8YI;
	}

	internal static bool BajoA7o9CYVMe0RsqKYf(object P_0, object P_1, object P_2)
	{
		return ((SubTypeGroupDescriptor)P_0).IsEmpty((PropertyMetadata)P_1, P_2);
	}

	internal static bool gP1rSxo9vU4tWNhDfpbI(object P_0, Guid subTypeUid)
	{
		return ((IPublicApplicationTypeDescriptor)P_0).IsPublicApplicationDisplayEnabled(subTypeUid);
	}

	internal static bool IIyTJpo98SilOdl5bLgF(object P_0, Guid subTypeUid)
	{
		return ((IPublicApplicationTypeDescriptor)P_0).IsPublicApplicationEditorEnabled(subTypeUid);
	}
}
