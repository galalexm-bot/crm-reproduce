using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Views;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Services;

[Service]
internal sealed class EntityFormsService : IEntityFormsService
{
	private static EntityFormsService sZiONbbvbsPqiAqQAAY6;

	public IEnumerable<FormViewItem> GetAllForms(ClassMetadata metadata)
	{
		IMetadata obj = ((metadata.BaseClassUid != Guid.Empty) ? MetadataServiceContext.Service.GetMetadata(metadata.BaseClassUid, loadImplementation: false) : null);
		List<FormViewItem> list = new List<FormViewItem>();
		ClassDefaultForms defaultForms = new ClassDefaultForms();
		if (obj != null)
		{
			GetBaseForms(list, defaultForms, metadata as EntityMetadata, metadata.Uid);
		}
		else
		{
			AddForms(list, defaultForms, metadata);
		}
		return list;
	}

	public void GetBaseForms(List<FormViewItem> forms, ClassDefaultForms defaultForms, EntityMetadata metadata, Guid ignoreExtensionUid)
	{
		_003C_003Ec__DisplayClass1_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass1_0();
		CS_0024_003C_003E8__locals0.metadata = metadata;
		CS_0024_003C_003E8__locals0.ignoreExtensionUid = ignoreExtensionUid;
		if (CS_0024_003C_003E8__locals0.metadata == null)
		{
			return;
		}
		EntityMetadata entityMetadata = ((CS_0024_003C_003E8__locals0.metadata.BaseClassUid != Guid.Empty) ? ((EntityMetadata)MetadataServiceContext.Service.GetMetadata(CS_0024_003C_003E8__locals0.metadata.BaseClassUid, loadImplementation: false)) : null);
		if (entityMetadata != null)
		{
			GetBaseForms(forms, defaultForms, entityMetadata, Guid.Empty);
		}
		AddForms(forms, defaultForms, CS_0024_003C_003E8__locals0.metadata);
		if (CS_0024_003C_003E8__locals0.metadata.Type != EntityMetadataType.Interface)
		{
			return;
		}
		foreach (EntityMetadata item in MetadataServiceContext.Service.GetMetadataList().OfType<EntityMetadata>().Where(delegate(EntityMetadata m)
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (m.Type == EntityMetadataType.InterfaceExtension)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				default:
					if (_003C_003Ec__DisplayClass1_0.vfqqeqCOQH0jeJVJbJmX(m.BaseClassUid, _003C_003Ec__DisplayClass1_0.BeJVFiCOf5m0xscQCZeo(CS_0024_003C_003E8__locals0.metadata)))
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
						{
							num2 = 1;
						}
						continue;
					}
					break;
				case 2:
					return _003C_003Ec__DisplayClass1_0.BeJVFiCOf5m0xscQCZeo(m) != CS_0024_003C_003E8__locals0.ignoreExtensionUid;
				}
				break;
			}
			return false;
		})
			.ToList())
		{
			AddForms(forms, defaultForms, item);
		}
	}

	public void AddForms(List<FormViewItem> forms, ClassDefaultForms defaultForms, ClassMetadata metadata)
	{
		using (List<FormViewItemTransformation>.Enumerator enumerator = metadata.FormTransformations.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				_003C_003Ec__DisplayClass2_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass2_0();
				CS_0024_003C_003E8__locals0.transform = enumerator.Current;
				FormViewItem formViewItem = forms.Find(delegate(FormViewItem f)
				{
					//Discarded unreachable code: IL_00d1, IL_00e0
					int num = 5;
					int num2 = num;
					Guid uid2 = default(Guid);
					Guid? uid = default(Guid?);
					while (true)
					{
						switch (num2)
						{
						case 4:
							uid2 = CS_0024_003C_003E8__locals0.transform.Uid;
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
							{
								num2 = 0;
							}
							break;
						case 3:
							return true;
						case 1:
							return _003C_003Ec__DisplayClass2_0.h7bsKSCOuFfQe0wGschd(uid.GetValueOrDefault(), uid2);
						default:
							if (!uid.HasValue)
							{
								num2 = 2;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
								{
									num2 = 2;
								}
								break;
							}
							if (uid.HasValue)
							{
								num2 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
								{
									num2 = 1;
								}
								break;
							}
							goto case 3;
						case 2:
							return false;
						case 5:
							uid = f.uid;
							num2 = 4;
							break;
						}
					}
				});
				if (formViewItem != null)
				{
					int index = forms.IndexOf(formViewItem);
					FormViewItem formViewItem3 = (forms[index] = formViewItem.Transformate(CS_0024_003C_003E8__locals0.transform));
				}
			}
		}
		forms.AddRange(metadata.Forms);
		IEnumerable<FormViewItemTransformation> enumerable = metadata.FormTransformations.Where((FormViewItemTransformation t) => _003C_003Ec.Avw128CORCLVNQwiQWtq(t) != Guid.Empty);
		foreach (FormViewItemTransformation item in enumerable)
		{
			AddChildForm(forms, enumerable, item);
		}
		defaultForms.FromDictionary(metadata.DefaultForms.ToDictionary(), reset: false);
		defaultForms.FormSettingsFromDictionary(metadata.DefaultForms.FormSettingsToDictionary(), reset: false);
	}

	public FormViewItem AddChildForm(List<FormViewItem> forms, IEnumerable<FormViewItemTransformation> childFormTransformations, FormViewItemTransformation transform)
	{
		_003C_003Ec__DisplayClass3_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass3_0();
		CS_0024_003C_003E8__locals0.transform = transform;
		FormViewItem formViewItem = forms.Find((FormViewItem f) => _003C_003Ec__DisplayClass3_0.IdCh0qCOndKEElPKujDI(_003C_003Ec__DisplayClass3_0.sEX1DXCOk0SMIguFl1Lr(f), CS_0024_003C_003E8__locals0.transform.NewFormUid));
		if (formViewItem != null)
		{
			return formViewItem;
		}
		FormViewItem formViewItem2 = forms.Find((FormViewItem f) => _003C_003Ec__DisplayClass3_0.IdCh0qCOndKEElPKujDI(f.Uid, CS_0024_003C_003E8__locals0.transform.Uid));
		if (formViewItem2 == null)
		{
			FormViewItemTransformation formViewItemTransformation = childFormTransformations.FirstOrDefault((FormViewItemTransformation t) => _003C_003Ec__DisplayClass3_0.Nm7KDLCOOSkxuY57uDy8(t) == CS_0024_003C_003E8__locals0.transform.Uid);
			if (formViewItemTransformation == null)
			{
				return null;
			}
			formViewItem2 = AddChildForm(forms, childFormTransformations, formViewItemTransformation);
			if (formViewItem2 == null)
			{
				return null;
			}
		}
		formViewItem = formViewItem2.Transformate(CS_0024_003C_003E8__locals0.transform);
		forms.Add(formViewItem);
		return formViewItem;
	}

	public EntityFormsService()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		cBDZ7ubvE79QcHNWdPN2();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void cBDZ7ubvE79QcHNWdPN2()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool rpnJLlbvhuNRycRFnrNa()
	{
		return sZiONbbvbsPqiAqQAAY6 == null;
	}

	internal static EntityFormsService ROAlRObvG64RUrNvSoLV()
	{
		return sZiONbbvbsPqiAqQAAY6;
	}
}
