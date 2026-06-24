using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.UI.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.UI.Descriptors;

public class FormPartDescriptor<TOwnerDescriptor, TMetadata> : IFormPartDescriptor where TOwnerDescriptor : FormDescriptor where TMetadata : FormPartMetadata
{
	internal static object zChp3CJFEmTT3kMs9BO;

	public TOwnerDescriptor FormDescriptor { get; private set; }

	public TMetadata Metadata { get; private set; }

	public Type ContextType
	{
		[CompilerGenerated]
		get
		{
			return _003CContextType_003Ek__BackingField;
		}
		[CompilerGenerated]
		private set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					_003CContextType_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	IFormDescriptor IFormPartDescriptor.FormDescriptor => FormDescriptor;

	FormPartMetadata IFormPartDescriptor.Metadata => Metadata;

	public FormPartDescriptor(TOwnerDescriptor formDescriptor, TMetadata metadata)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		Contract.ArgumentNotNull(formDescriptor, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1837662597 ^ -1837641135));
		Contract.ArgumentNotNull(metadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1317790512 ^ -1317775890));
		FormDescriptor = formDescriptor;
		Metadata = metadata;
		string text = formDescriptor.Metadata.FullTypeName + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-576149596 ^ -576132998) + metadata.Context.Name;
		ContextType = formDescriptor.Assembly.GetType(text);
		if (ContextType == null)
		{
			throw new TypeNotFoundException(text);
		}
		List<Type> list = new List<Type>();
		GetTypesToRegister(Metadata.Context, list);
		Locator.GetServiceNotNull<IMetadataRuntimeService>().RegisterTypes(list, asEntity: false);
	}

	private void GetTypesToRegister(EntityMetadata metadata, List<Type> typesToRegister)
	{
		string name = FormDescriptor.Metadata.FullTypeName + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3B36AB09 ^ 0x3B36E4D7) + metadata.Name;
		Type type = FormDescriptor.Assembly.GetType(name);
		if (type != null)
		{
			typesToRegister.Add(type);
		}
		foreach (TablePartMetadata tablePart in metadata.TableParts)
		{
			GetTypesToRegister(tablePart, typesToRegister);
		}
	}

	internal static bool xdJF8VJB6b6v7dy5YpZ()
	{
		return zChp3CJFEmTT3kMs9BO == null;
	}

	internal static object CSdwNLJW6vTeZahde7k()
	{
		return zChp3CJFEmTT3kMs9BO;
	}
}
