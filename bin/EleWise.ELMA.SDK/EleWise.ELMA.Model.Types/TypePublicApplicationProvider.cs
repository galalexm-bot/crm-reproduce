using System;
using System.Collections.Generic;
using EleWise.ELMA.API.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Views;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Types;

[Component]
public abstract class TypePublicApplicationProvider : ITypePublicApplicationProvider
{
	internal static TypePublicApplicationProvider EvbYxCoyIcCtlBupBQ7K;

	public virtual bool? IsPublicApplicationDisplayEnabled(Guid typeUid, Guid subTypeUid)
	{
		return null;
	}

	public virtual bool? IsPublicApplicationEditorEnabled(Guid typeUid, Guid subTypeUid)
	{
		return null;
	}

	public virtual void CheckPublicApplicationCompatibility(ClassMetadata classMetadata, PropertyMetadata propertyMetadata, PropertyViewItem viewItem, string parentPropertyName, List<IPublicApplicationCompatibilityError> errors)
	{
	}

	protected TypePublicApplicationProvider()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		vXIYswoyiep3Xnn3K4Qk();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void vXIYswoyiep3Xnn3K4Qk()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool m5PseKoyVfc7sviYpZUm()
	{
		return EvbYxCoyIcCtlBupBQ7K == null;
	}

	internal static TypePublicApplicationProvider fWAPiqoySDoUnTSI1h6T()
	{
		return EvbYxCoyIcCtlBupBQ7K;
	}
}
