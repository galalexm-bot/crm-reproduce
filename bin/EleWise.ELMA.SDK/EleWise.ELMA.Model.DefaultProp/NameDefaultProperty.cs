using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.DefaultProperties;

[Component(Order = 0)]
public class NameDefaultProperty : DefaultProperty
{
	private readonly Guid nameDefaultPropertyUid;

	internal static NameDefaultProperty v6B5SVWYuXWyFRp3OYHj;

	public override string Name => SR.T((string)dq2wQxWYSlnL1OjA9TJZ(0x4A1640F ^ 0x4A18D79));

	public override Guid Uid => nameDefaultPropertyUid;

	public override bool DefaultChecked => true;

	protected override string PropertyName => z2jc63fLkugS1X8Q9N.tE1kD1vbB(-812025778 ^ -812053618);

	protected override Guid TypeUid => StringDescriptor.UID;

	protected override bool Required => true;

	protected override bool Filterable => true;

	public override void InitProperty(ClassMetadata classMetadata, PropertyMetadata propertyMetadata)
	{
		int num = 9;
		EntityPropertyMetadata entityPropertyMetadata = default(EntityPropertyMetadata);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
				{
					List<ViewAttribute> attributes = ((PropertyViewSettings)KGpCc0WYqaHxjciHgEvE(propertyMetadata)).Attributes;
					ViewAttribute viewAttribute = new ViewAttribute();
					KatMOoWYXeLX4iKCrGvC(viewAttribute, ViewType.Edit);
					viewAttribute.Visibility = Visibility.Visible;
					attributes.Add(viewAttribute);
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
					{
						num2 = 4;
					}
					continue;
				}
				case 2:
					if (entityPropertyMetadata != null)
					{
						num2 = 7;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
						{
							num2 = 2;
						}
						continue;
					}
					return;
				case 5:
					return;
				case 6:
				{
					List<ViewAttribute> attributes4 = ((PropertyViewSettings)KGpCc0WYqaHxjciHgEvE(propertyMetadata)).Attributes;
					ViewAttribute viewAttribute4 = new ViewAttribute();
					KatMOoWYXeLX4iKCrGvC(viewAttribute4, ViewType.List);
					DoiDPPWYTqGGMyqUBPjb(viewAttribute4, Visibility.Visible);
					attributes4.Add(viewAttribute4);
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
					{
						num2 = 11;
					}
					continue;
				}
				case 9:
					base.InitProperty(classMetadata, propertyMetadata);
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
					{
						num2 = 1;
					}
					continue;
				case 8:
					UTHCKNWYigH6U6uGGsM4(classMetadata, propertyMetadata.Uid);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
					{
						num2 = 3;
					}
					continue;
				case 3:
					Scq7aPWYRrwA6vywMQBt(propertyMetadata, true);
					num2 = 10;
					continue;
				case 4:
				{
					List<ViewAttribute> attributes3 = propertyMetadata.ViewSettings.Attributes;
					ViewAttribute viewAttribute3 = new ViewAttribute();
					KatMOoWYXeLX4iKCrGvC(viewAttribute3, ViewType.Display);
					DoiDPPWYTqGGMyqUBPjb(viewAttribute3, Visibility.Visible);
					attributes3.Add(viewAttribute3);
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
					{
						num2 = 2;
					}
					continue;
				}
				default:
				{
					List<ViewAttribute> attributes2 = ((PropertyViewSettings)KGpCc0WYqaHxjciHgEvE(propertyMetadata)).Attributes;
					ViewAttribute viewAttribute2 = new ViewAttribute();
					KatMOoWYXeLX4iKCrGvC(viewAttribute2, ViewType.Create);
					DoiDPPWYTqGGMyqUBPjb(viewAttribute2, Visibility.Visible);
					attributes2.Add(viewAttribute2);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				case 11:
					break;
				case 7:
					entityPropertyMetadata.InFastSearch = true;
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
					{
						num2 = 3;
					}
					continue;
				case 10:
					Ca6Py7WYKlfTlUqBlyTc(((PropertyViewSettings)KGpCc0WYqaHxjciHgEvE(propertyMetadata)).Attributes);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
			entityPropertyMetadata = propertyMetadata as EntityPropertyMetadata;
			num = 2;
		}
	}

	protected override TypeSettings GetTypeSettings(ClassMetadata classMetadata, PropertyMetadata propertyMetadata)
	{
		StringSettings stringSettings = new StringSettings();
		jVAI9NWYnFXJPtoAZoDB(stringSettings, cgyS3lWYkkFM6pofYuQt(this));
		return stringSettings;
	}

	public NameDefaultProperty()
	{
		//Discarded unreachable code: IL_0050, IL_0055
		K8gmpbWYOfA3K0AimTC6();
		nameDefaultPropertyUid = new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x8317432 ^ 0x83335B4));
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object dq2wQxWYSlnL1OjA9TJZ(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool qqJoirWYIOpKnVgoexMv()
	{
		return v6B5SVWYuXWyFRp3OYHj == null;
	}

	internal static NameDefaultProperty WfQfgkWYVHZoJjvvGG9s()
	{
		return v6B5SVWYuXWyFRp3OYHj;
	}

	internal static void UTHCKNWYigH6U6uGGsM4(object P_0, Guid value)
	{
		((ClassMetadata)P_0).TitlePropertyUid = value;
	}

	internal static void Scq7aPWYRrwA6vywMQBt(object P_0, bool value)
	{
		((PropertyMetadata)P_0).Required = value;
	}

	internal static object KGpCc0WYqaHxjciHgEvE(object P_0)
	{
		return ((PropertyMetadata)P_0).ViewSettings;
	}

	internal static void Ca6Py7WYKlfTlUqBlyTc(object P_0)
	{
		((List<ViewAttribute>)P_0).Clear();
	}

	internal static void KatMOoWYXeLX4iKCrGvC(object P_0, ViewType value)
	{
		((ViewAttribute)P_0).ViewType = value;
	}

	internal static void DoiDPPWYTqGGMyqUBPjb(object P_0, Visibility value)
	{
		((ViewAttribute)P_0).Visibility = value;
	}

	internal static object cgyS3lWYkkFM6pofYuQt(object P_0)
	{
		return ((DefaultProperty)P_0).PropertyName;
	}

	internal static void jVAI9NWYnFXJPtoAZoDB(object P_0, object P_1)
	{
		((SimpleTypeSettings)P_0).FieldName = (string)P_1;
	}

	internal static void K8gmpbWYOfA3K0AimTC6()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
