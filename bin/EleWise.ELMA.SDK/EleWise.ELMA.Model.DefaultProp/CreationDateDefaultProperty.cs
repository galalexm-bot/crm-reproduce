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

[Component(Order = 100)]
public class CreationDateDefaultProperty : DefaultProperty
{
	private readonly Guid creationDateDefaultPropertyUid;

	internal static CreationDateDefaultProperty QvIrwnWj7ikPUqLwEZTb;

	public override string Name => (string)cAI4TyWjyZUbFPbHEUiv(RPLVGOWjmcrqjwOekSFF(-3333094 ^ -3292478));

	public override Guid Uid => creationDateDefaultPropertyUid;

	public override bool DefaultChecked => true;

	protected override string PropertyName => z2jc63fLkugS1X8Q9N.tE1kD1vbB(-978351861 ^ -978395995);

	protected override Guid TypeUid => DateTimeDescriptor.UID;

	protected override bool Required => true;

	protected override bool Filterable => true;

	protected override Guid HandlerUid => CreationDatePropertyHandler.UID;

	public override void InitProperty(ClassMetadata classMetadata, PropertyMetadata propertyMetadata)
	{
		int num = 7;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 7:
					base.InitProperty(classMetadata, propertyMetadata);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
					{
						num2 = 6;
					}
					continue;
				case 5:
					break;
				case 3:
				{
					List<ViewAttribute> attributes3 = ((PropertyViewSettings)AMH3h4WjMCFkwjHghS5B(propertyMetadata)).Attributes;
					ViewAttribute viewAttribute3 = new ViewAttribute();
					TgYQlEWjJNbvTrkXGKZR(viewAttribute3, ViewType.Display);
					QC9nNHWj9cyronp7gKDs(viewAttribute3, Visibility.Visible);
					attributes3.Add(viewAttribute3);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
					{
						num2 = 1;
					}
					continue;
				}
				default:
					((PropertyViewSettings)AMH3h4WjMCFkwjHghS5B(propertyMetadata)).Attributes.Clear();
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
					{
						num2 = 4;
					}
					continue;
				case 1:
				{
					List<ViewAttribute> attributes2 = propertyMetadata.ViewSettings.Attributes;
					ViewAttribute viewAttribute2 = new ViewAttribute();
					TgYQlEWjJNbvTrkXGKZR(viewAttribute2, ViewType.List);
					QC9nNHWj9cyronp7gKDs(viewAttribute2, Visibility.Hidden);
					attributes2.Add(viewAttribute2);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
					{
						num2 = 2;
					}
					continue;
				}
				case 4:
				{
					List<ViewAttribute> attributes = ((PropertyViewSettings)AMH3h4WjMCFkwjHghS5B(propertyMetadata)).Attributes;
					ViewAttribute viewAttribute = new ViewAttribute();
					TgYQlEWjJNbvTrkXGKZR(viewAttribute, ViewType.Create);
					viewAttribute.Visibility = Visibility.Hidden;
					attributes.Add(viewAttribute);
					num2 = 5;
					continue;
				}
				case 6:
					propertyMetadata.Nullable = false;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					return;
				}
				break;
			}
			List<ViewAttribute> attributes4 = ((PropertyViewSettings)AMH3h4WjMCFkwjHghS5B(propertyMetadata)).Attributes;
			ViewAttribute viewAttribute4 = new ViewAttribute();
			TgYQlEWjJNbvTrkXGKZR(viewAttribute4, ViewType.Edit);
			QC9nNHWj9cyronp7gKDs(viewAttribute4, Visibility.Visible);
			SZbGHMWjdLXkIYZH7JZi(viewAttribute4, true);
			attributes4.Add(viewAttribute4);
			num = 3;
		}
	}

	protected override TypeSettings GetTypeSettings(ClassMetadata classMetadata, PropertyMetadata propertyMetadata)
	{
		DateTimeSettings obj = new DateTimeSettings
		{
			FieldName = (string)CnSHkYWjld2W9UWv7RSt(this)
		};
		GgOHnHWjrsxihn9XcyLp(obj, true);
		return obj;
	}

	public CreationDateDefaultProperty()
	{
		//Discarded unreachable code: IL_004a, IL_004f
		SingletonReader.JJCZtPuTvSt();
		creationDateDefaultPropertyUid = new Guid((string)RPLVGOWjmcrqjwOekSFF(-2112703338 ^ -2112817760));
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object RPLVGOWjmcrqjwOekSFF(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object cAI4TyWjyZUbFPbHEUiv(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static bool icuFXCWjxAWFynndM1L2()
	{
		return QvIrwnWj7ikPUqLwEZTb == null;
	}

	internal static CreationDateDefaultProperty PQ5vdpWj0Mnkoe3j9A4N()
	{
		return QvIrwnWj7ikPUqLwEZTb;
	}

	internal static object AMH3h4WjMCFkwjHghS5B(object P_0)
	{
		return ((PropertyMetadata)P_0).ViewSettings;
	}

	internal static void TgYQlEWjJNbvTrkXGKZR(object P_0, ViewType value)
	{
		((ViewAttribute)P_0).ViewType = value;
	}

	internal static void QC9nNHWj9cyronp7gKDs(object P_0, Visibility value)
	{
		((ViewAttribute)P_0).Visibility = value;
	}

	internal static void SZbGHMWjdLXkIYZH7JZi(object P_0, bool value)
	{
		((ViewAttribute)P_0).ReadOnly = value;
	}

	internal static object CnSHkYWjld2W9UWv7RSt(object P_0)
	{
		return ((DefaultProperty)P_0).PropertyName;
	}

	internal static void GgOHnHWjrsxihn9XcyLp(object P_0, bool value)
	{
		((DateTimeSettings)P_0).SetCurrentDate = value;
	}
}
