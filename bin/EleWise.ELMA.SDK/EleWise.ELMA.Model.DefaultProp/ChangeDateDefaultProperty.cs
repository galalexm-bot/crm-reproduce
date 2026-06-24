using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.PropertyHandlers;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.DefaultProperties;

[Component(Order = 200)]
public class ChangeDateDefaultProperty : DefaultProperty
{
	private readonly Guid changeDateDefaultPropertyUid;

	internal static ChangeDateDefaultProperty Qq1HSsWjNe8iTIExkNPq;

	public override string Name => (string)FgmSmYWja62FNxYtWYU8(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-309639236 ^ -309786758));

	public override Guid Uid => changeDateDefaultPropertyUid;

	public override bool DefaultChecked => true;

	protected override string PropertyName => z2jc63fLkugS1X8Q9N.tE1kD1vbB(-87337865 ^ -87390097);

	protected override Guid TypeUid => DateTimeDescriptor.UID;

	protected override bool Filterable => true;

	protected override Guid HandlerUid => ChangeDatePropertyHandler.UID;

	public override void InitProperty(ClassMetadata classMetadata, PropertyMetadata propertyMetadata)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 5:
				return;
			case 2:
			{
				List<ViewAttribute> attributes3 = propertyMetadata.ViewSettings.Attributes;
				ViewAttribute viewAttribute3 = new ViewAttribute();
				yBs1b9Wj4U9xCbVjJf42(viewAttribute3, ViewType.List);
				viewAttribute3.Visibility = Visibility.Hidden;
				attributes3.Add(viewAttribute3);
				num2 = 5;
				break;
			}
			case 4:
			{
				List<ViewAttribute> attributes2 = propertyMetadata.ViewSettings.Attributes;
				ViewAttribute viewAttribute2 = new ViewAttribute();
				yBs1b9Wj4U9xCbVjJf42(viewAttribute2, ViewType.Display);
				viewAttribute2.Visibility = Visibility.Visible;
				attributes2.Add(viewAttribute2);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
				{
					num2 = 2;
				}
				break;
			}
			case 3:
			{
				List<ViewAttribute> attributes4 = ((PropertyViewSettings)BpoQfmWjD0E3HWjJ1XNl(propertyMetadata)).Attributes;
				ViewAttribute obj = new ViewAttribute
				{
					ViewType = ViewType.Create
				};
				bRBnIdWjwiMxJPeZuMfF(obj, Visibility.Hidden);
				attributes4.Add(obj);
				num2 = 6;
				break;
			}
			case 1:
				base.InitProperty(classMetadata, propertyMetadata);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
				{
					num2 = 0;
				}
				break;
			case 6:
			{
				List<ViewAttribute> attributes = ((PropertyViewSettings)BpoQfmWjD0E3HWjJ1XNl(propertyMetadata)).Attributes;
				ViewAttribute viewAttribute = new ViewAttribute();
				yBs1b9Wj4U9xCbVjJf42(viewAttribute, ViewType.Edit);
				bRBnIdWjwiMxJPeZuMfF(viewAttribute, Visibility.Visible);
				viewAttribute.ReadOnly = true;
				attributes.Add(viewAttribute);
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
				{
					num2 = 4;
				}
				break;
			}
			default:
				odMxxvWjtrKHtXx9itu8(((PropertyViewSettings)BpoQfmWjD0E3HWjJ1XNl(propertyMetadata)).Attributes);
				num2 = 3;
				break;
			}
		}
	}

	protected override TypeSettings GetTypeSettings(ClassMetadata classMetadata, PropertyMetadata propertyMetadata)
	{
		DateTimeSettings dateTimeSettings = new DateTimeSettings();
		n3I4woWjHx7CcQb04BoR(dateTimeSettings, ACB0leWj6cs14gEhkInu(this));
		return dateTimeSettings;
	}

	public ChangeDateDefaultProperty()
	{
		//Discarded unreachable code: IL_004a, IL_004f
		SingletonReader.JJCZtPuTvSt();
		changeDateDefaultPropertyUid = new Guid((string)oI7jjBWjAukSwyJInGHm(-345420348 ^ -345305822));
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object FgmSmYWja62FNxYtWYU8(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static bool L6Ne36Wj3583gGpp13TQ()
	{
		return Qq1HSsWjNe8iTIExkNPq == null;
	}

	internal static ChangeDateDefaultProperty OHR9uJWjp9w2agsZMNt8()
	{
		return Qq1HSsWjNe8iTIExkNPq;
	}

	internal static object BpoQfmWjD0E3HWjJ1XNl(object P_0)
	{
		return ((PropertyMetadata)P_0).ViewSettings;
	}

	internal static void odMxxvWjtrKHtXx9itu8(object P_0)
	{
		((List<ViewAttribute>)P_0).Clear();
	}

	internal static void bRBnIdWjwiMxJPeZuMfF(object P_0, Visibility value)
	{
		((ViewAttribute)P_0).Visibility = value;
	}

	internal static void yBs1b9Wj4U9xCbVjJf42(object P_0, ViewType value)
	{
		((ViewAttribute)P_0).ViewType = value;
	}

	internal static object ACB0leWj6cs14gEhkInu(object P_0)
	{
		return ((DefaultProperty)P_0).PropertyName;
	}

	internal static void n3I4woWjHx7CcQb04BoR(object P_0, object P_1)
	{
		((SimpleTypeSettings)P_0).FieldName = (string)P_1;
	}

	internal static object oI7jjBWjAukSwyJInGHm(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}
}
