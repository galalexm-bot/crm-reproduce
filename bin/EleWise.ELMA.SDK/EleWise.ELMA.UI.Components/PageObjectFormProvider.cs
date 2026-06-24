using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.UI.Descriptors;
using EleWise.ELMA.UI.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.UI.Components;

[Component]
internal sealed class PageObjectFormProvider : IObjectFormProvider
{
	private readonly FormDescriptorProvider formDescriptorProvider;

	internal static PageObjectFormProvider HtlLqdBZcQIY33xVRETJ;

	public PageObjectFormProvider(FormDescriptorProvider formDescriptorProvider)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		xBsD6cBuBgbS2DMO20SH();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				this.formDescriptorProvider = formDescriptorProvider;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public bool Check(Guid typeUid, Guid subTypeUid)
	{
		//Discarded unreachable code: IL_002d, IL_003c
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (!gFaYUkBuWeP6W750qq0c(typeUid, PageMetadata.TypeUid))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto default;
			default:
				return EvMKmyBuovi7EaB4oWyN(formDescriptorProvider, typeUid, subTypeUid, false) is PageDescriptor;
			case 1:
				return false;
			}
		}
	}

	public (object, ClassMetadata) GetObjectInfo(Guid typeUid, Guid subTypeUid, string model)
	{
		FormDescriptor descriptorByHeaderUid = formDescriptorProvider.GetDescriptorByHeaderUid(PageMetadata.TypeUid, subTypeUid, forEmulation: false);
		PageMetadata pageMetadata = (PageMetadata)descriptorByHeaderUid.Metadata;
		string name = pageMetadata.FullTypeName + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-740338220 ^ -740353526) + pageMetadata.Content.Context.Name;
		Type type = descriptorByHeaderUid.Assembly.GetType(name);
		return (new EntityJsonSerializer().Deserialize(model, type, loadEntityIfExists: false), pageMetadata.Content.Context);
	}

	public FormViewItem GetFormByType(object obj, ViewType viewType)
	{
		throw new NotImplementedException(SR.T((string)RUIY2oBub4nmO2B9GmJd(-1939377524 ^ -1939439922)));
	}

	public FormViewItem GetFormByUid(object obj, Guid formUid)
	{
		return ClassSerializationHelper.CloneObjectByXml((FormViewItem)VSQ9eyBuGParM4km8aFH(((FormPartDescriptor<PageDescriptor, PageContentMetadata>)fMieAABuhEHMyhdVcL3h((PageDescriptor)formDescriptorProvider.GetDescriptorByHeaderUid(PageMetadata.TypeUid, formUid, forEmulation: false))).Metadata));
	}

	public void InitObject(object obj, ViewType viewType, IDictionary<string, object> arguments)
	{
	}

	internal static void xBsD6cBuBgbS2DMO20SH()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool MS8bxWBZzX6CEKJJCIK4()
	{
		return HtlLqdBZcQIY33xVRETJ == null;
	}

	internal static PageObjectFormProvider cE9qIaBuFWoj5rYCjIMi()
	{
		return HtlLqdBZcQIY33xVRETJ;
	}

	internal static bool gFaYUkBuWeP6W750qq0c(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static object EvMKmyBuovi7EaB4oWyN(object P_0, Guid metadataType, Guid headerUid, bool forEmulation)
	{
		return ((FormDescriptorProvider)P_0).GetDescriptorByHeaderUid(metadataType, headerUid, forEmulation);
	}

	internal static object RUIY2oBub4nmO2B9GmJd(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object fMieAABuhEHMyhdVcL3h(object P_0)
	{
		return ((PageDescriptor)P_0).Content;
	}

	internal static object VSQ9eyBuGParM4km8aFH(object P_0)
	{
		return ((FormPartMetadata)P_0).View;
	}
}
