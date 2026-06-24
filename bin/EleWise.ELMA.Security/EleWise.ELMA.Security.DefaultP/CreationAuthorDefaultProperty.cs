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

[Component(Order = 150)]
internal class CreationAuthorDefaultProperty : DefaultProperty
{
	private readonly Guid creationAuthorDefaultPropertyUid;

	internal static CreationAuthorDefaultProperty W47EWTuiVdQkSMdQTq7;

	public override string Name => (string)yPjem4uNQwY2yNkolkF(l5sn1LulqoFDpHXmE0M(0x4D765E72 ^ 0x4D7618D8));

	public override Guid Uid => creationAuthorDefaultPropertyUid;

	public override bool DefaultChecked => true;

	protected override string PropertyName => (string)l5sn1LulqoFDpHXmE0M(-1076846736 ^ -1076832792);

	protected override Guid TypeUid => EntityDescriptor.UID;

	protected override Guid SubTypeUid => new Guid((string)l5sn1LulqoFDpHXmE0M(-2104667969 ^ -2104660425));

	protected override bool Filterable => true;

	protected override Guid HandlerUid => CreationAuthorPropertyHandler.UID;

	public override void InitProperty(ClassMetadata classMetadata, PropertyMetadata propertyMetadata)
	{
		int num = 4;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 4:
				base.InitProperty(classMetadata, propertyMetadata);
				num2 = 3;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_fc5e0189a7f447a7b93cd505b96d5f05 != 0)
				{
					num2 = 2;
				}
				continue;
			case 1:
			{
				List<ViewAttribute> attributes2 = ((PropertyViewSettings)B4hlSEuZcMt54m1kFZ3(propertyMetadata)).Attributes;
				ViewAttribute viewAttribute2 = new ViewAttribute();
				HYj4FXuurHmLp1PTsd1(viewAttribute2, ViewType.List);
				viewAttribute2.Visibility = Visibility.Hidden;
				attributes2.Add(viewAttribute2);
				num2 = 2;
				continue;
			}
			case 2:
				return;
			case 6:
			{
				List<ViewAttribute> attributes3 = ((PropertyViewSettings)B4hlSEuZcMt54m1kFZ3(propertyMetadata)).Attributes;
				ViewAttribute obj = new ViewAttribute
				{
					ViewType = ViewType.Create
				};
				QpPt2vuBvmYIdd4RJfS(obj, Visibility.Hidden);
				attributes3.Add(obj);
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a33ec05b36714591b0adf150b655c9a8 != 0)
				{
					num2 = 0;
				}
				continue;
			}
			case 3:
				UPsQwvuxtWp7ZKUCrlG(((PropertyViewSettings)B4hlSEuZcMt54m1kFZ3(propertyMetadata)).Attributes);
				num2 = 6;
				continue;
			case 5:
			{
				List<ViewAttribute> attributes = ((PropertyViewSettings)B4hlSEuZcMt54m1kFZ3(propertyMetadata)).Attributes;
				ViewAttribute viewAttribute = new ViewAttribute();
				HYj4FXuurHmLp1PTsd1(viewAttribute, ViewType.Display);
				viewAttribute.Visibility = Visibility.Visible;
				attributes.Add(viewAttribute);
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_01fd90314ba945f0a4ee79d2372961e2 == 0)
				{
					num2 = 1;
				}
				continue;
			}
			}
			List<ViewAttribute> attributes4 = ((PropertyViewSettings)B4hlSEuZcMt54m1kFZ3(propertyMetadata)).Attributes;
			ViewAttribute viewAttribute3 = new ViewAttribute();
			HYj4FXuurHmLp1PTsd1(viewAttribute3, ViewType.Edit);
			QpPt2vuBvmYIdd4RJfS(viewAttribute3, Visibility.Visible);
			KpXtjPumqcxuQFH3OXm(viewAttribute3, true);
			attributes4.Add(viewAttribute3);
			num2 = 4;
			if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a5d922da527e46afbe4b139adb51cde5 != 0)
			{
				num2 = 5;
			}
		}
	}

	protected override TypeSettings GetTypeSettings(ClassMetadata classMetadata, PropertyMetadata propertyMetadata)
	{
		return new EntitySettings
		{
			FieldName = (string)eg1YBvueIdfFESUyM7S(this)
		};
	}

	public CreationAuthorDefaultProperty()
	{
		//Discarded unreachable code: IL_0050, IL_0055
		P5olmYuLrtBtPrhDo62();
		creationAuthorDefaultPropertyUid = new Guid((string)l5sn1LulqoFDpHXmE0M(0x2CFDCC80 ^ 0x2CFD8638));
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f5cf5deab67c429f89caddff1f348afc == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object l5sn1LulqoFDpHXmE0M(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object yPjem4uNQwY2yNkolkF(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static bool fbGFYyu7AkvpPNvxCR7()
	{
		return W47EWTuiVdQkSMdQTq7 == null;
	}

	internal static CreationAuthorDefaultProperty iNJ0WVu681ndrhNKbu3()
	{
		return W47EWTuiVdQkSMdQTq7;
	}

	internal static object B4hlSEuZcMt54m1kFZ3(object P_0)
	{
		return ((PropertyMetadata)P_0).ViewSettings;
	}

	internal static void UPsQwvuxtWp7ZKUCrlG(object P_0)
	{
		((List<ViewAttribute>)P_0).Clear();
	}

	internal static void QpPt2vuBvmYIdd4RJfS(object P_0, Visibility P_1)
	{
		((ViewAttribute)P_0).Visibility = P_1;
	}

	internal static void HYj4FXuurHmLp1PTsd1(object P_0, ViewType P_1)
	{
		((ViewAttribute)P_0).ViewType = P_1;
	}

	internal static void KpXtjPumqcxuQFH3OXm(object P_0, bool P_1)
	{
		((ViewAttribute)P_0).ReadOnly = P_1;
	}

	internal static object eg1YBvueIdfFESUyM7S(object P_0)
	{
		return ((DefaultProperty)P_0).PropertyName;
	}

	internal static void P5olmYuLrtBtPrhDo62()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}
}
