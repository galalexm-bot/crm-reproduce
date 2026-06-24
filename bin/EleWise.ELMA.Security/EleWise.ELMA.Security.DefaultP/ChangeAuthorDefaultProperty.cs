using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.DefaultProperties;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Security.PropertyHandlers;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security.DefaultProperties;

[Component(Order = 250)]
internal class ChangeAuthorDefaultProperty : DefaultProperty
{
	private readonly Guid changeAuthorDefaultPropertyUid;

	private static ChangeAuthorDefaultProperty R3cDujBba8S3BNdeg7d;

	public override string Name => (string)uahCXBBfIYPC8HXwo33(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xCD88DD8 ^ 0xCD8C7D2));

	public override Guid Uid => changeAuthorDefaultPropertyUid;

	public override bool DefaultChecked => true;

	protected override string PropertyName => (string)PdMW3wuWievo9uYIIBG(-848444002 ^ -848457806);

	protected override Guid TypeUid => EntityDescriptor.UID;

	protected override Guid SubTypeUid => new Guid(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2CFDCC80 ^ 0x2CFDF208));

	protected override bool Filterable => true;

	protected override Guid HandlerUid => ChangeAuthorPropertyHandler.UID;

	public override void InitProperty(ClassMetadata classMetadata, PropertyMetadata propertyMetadata)
	{
		int num = 6;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					return;
				default:
				{
					List<ViewAttribute> attributes2 = ((PropertyViewSettings)twekRMBzXixf1UjPsfa(propertyMetadata)).Attributes;
					ViewAttribute viewAttribute2 = new ViewAttribute();
					LNO7MjupuXtTQmex3bI(viewAttribute2, ViewType.List);
					CnoT4Tu5P2DfGDon91v(viewAttribute2, Visibility.Hidden);
					attributes2.Add(viewAttribute2);
					num2 = 4;
					continue;
				}
				case 5:
					uLR7hcuk3UNkQ98Sptp(((PropertyViewSettings)twekRMBzXixf1UjPsfa(propertyMetadata)).Attributes);
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c843c5b509d748f086ceb6be01690351 == 0)
					{
						num2 = 1;
					}
					continue;
				case 3:
				{
					List<ViewAttribute> attributes3 = propertyMetadata.ViewSettings.Attributes;
					ViewAttribute viewAttribute3 = new ViewAttribute();
					LNO7MjupuXtTQmex3bI(viewAttribute3, ViewType.Edit);
					CnoT4Tu5P2DfGDon91v(viewAttribute3, Visibility.Visible);
					GnLnpkuAje8ff3aa45v(viewAttribute3, true);
					attributes3.Add(viewAttribute3);
					num2 = 2;
					continue;
				}
				case 1:
					((PropertyViewSettings)twekRMBzXixf1UjPsfa(propertyMetadata)).Attributes.Add(new ViewAttribute
					{
						ViewType = ViewType.Create,
						Visibility = Visibility.Hidden
					});
					num2 = 3;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_dffee0180fb244db9738339fa28792b4 != 0)
					{
						num2 = 0;
					}
					continue;
				case 6:
					break;
				case 2:
				{
					List<ViewAttribute> attributes = ((PropertyViewSettings)twekRMBzXixf1UjPsfa(propertyMetadata)).Attributes;
					ViewAttribute viewAttribute = new ViewAttribute();
					LNO7MjupuXtTQmex3bI(viewAttribute, ViewType.Display);
					viewAttribute.Visibility = Visibility.Visible;
					attributes.Add(viewAttribute);
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_488725796a2e487f95c022f5056d8a88 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				}
				break;
			}
			XEpZjNB1SW9sHXMx9V0(this, classMetadata, propertyMetadata);
			num = 5;
		}
	}

	protected override TypeSettings GetTypeSettings(ClassMetadata classMetadata, PropertyMetadata propertyMetadata)
	{
		return new EntitySettings
		{
			FieldName = (string)lKm4NCuX5OTCEjNOGwa(this)
		};
	}

	public ChangeAuthorDefaultProperty()
	{
		//Discarded unreachable code: IL_004a, IL_004f
		ig16jNunFTmQxLSPZoy();
		changeAuthorDefaultPropertyUid = new Guid((string)PdMW3wuWievo9uYIIBG(0x4A799728 ^ 0x4A79DD60));
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_05864899c47d415d8fae32c68fb25d39 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object uahCXBBfIYPC8HXwo33(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static bool BB58s9BSjWt6jcXUjPQ()
	{
		return R3cDujBba8S3BNdeg7d == null;
	}

	internal static ChangeAuthorDefaultProperty ecXYABB9ORRleHbiScj()
	{
		return R3cDujBba8S3BNdeg7d;
	}

	internal static void XEpZjNB1SW9sHXMx9V0(object P_0, object P_1, object P_2)
	{
		((DefaultProperty)P_0).InitProperty((ClassMetadata)P_1, (PropertyMetadata)P_2);
	}

	internal static object twekRMBzXixf1UjPsfa(object P_0)
	{
		return ((PropertyMetadata)P_0).ViewSettings;
	}

	internal static void uLR7hcuk3UNkQ98Sptp(object P_0)
	{
		((List<ViewAttribute>)P_0).Clear();
	}

	internal static void LNO7MjupuXtTQmex3bI(object P_0, ViewType P_1)
	{
		((ViewAttribute)P_0).ViewType = P_1;
	}

	internal static void CnoT4Tu5P2DfGDon91v(object P_0, Visibility P_1)
	{
		((ViewAttribute)P_0).Visibility = P_1;
	}

	internal static void GnLnpkuAje8ff3aa45v(object P_0, bool P_1)
	{
		((ViewAttribute)P_0).ReadOnly = P_1;
	}

	internal static object PdMW3wuWievo9uYIIBG(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object lKm4NCuX5OTCEjNOGwa(object P_0)
	{
		return ((DefaultProperty)P_0).PropertyName;
	}

	internal static void ig16jNunFTmQxLSPZoy()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}
}
