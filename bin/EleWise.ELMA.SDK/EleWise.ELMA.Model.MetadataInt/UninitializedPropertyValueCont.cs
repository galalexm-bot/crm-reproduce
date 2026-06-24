using System;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.MetadataInternalContainer.Containers;

internal class UninitializedPropertyValueContainer : IPropertyDefaultValueContainer
{
	private readonly Guid metadataUid;

	private readonly Guid propertyUid;

	private readonly Func<Guid, Guid, IPropertyDefaultValueContainer> initFunc;

	private IPropertyDefaultValueContainer defaultValueContainer;

	internal static UninitializedPropertyValueContainer q3HCndhoEh3StHkUC0bo;

	public UninitializedPropertyValueContainer(Guid metadataUid, Guid propertyUid, Func<Guid, Guid, IPropertyDefaultValueContainer> initFunc)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		this.metadataUid = metadataUid;
		this.propertyUid = propertyUid;
		this.initFunc = initFunc;
	}

	IPropertyValueContainer IPropertyDefaultValueContainer.Initialize()
	{
		int num = 1;
		int num2 = num;
		IPropertyDefaultValueContainer propertyDefaultValueContainer = default(IPropertyDefaultValueContainer);
		IPropertyDefaultValueContainer propertyDefaultValueContainer2;
		while (true)
		{
			switch (num2)
			{
			default:
				propertyDefaultValueContainer = (defaultValueContainer = initFunc(metadataUid, propertyUid));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
				{
					num2 = 1;
				}
				continue;
			case 1:
				propertyDefaultValueContainer2 = defaultValueContainer;
				if (propertyDefaultValueContainer2 != null)
				{
					break;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				propertyDefaultValueContainer2 = propertyDefaultValueContainer;
				break;
			}
			break;
		}
		return propertyDefaultValueContainer2.Initialize();
	}

	internal static bool R43asFhofUdJKxEPudXt()
	{
		return q3HCndhoEh3StHkUC0bo == null;
	}

	internal static UninitializedPropertyValueContainer kDHdgohoQMCYnwYcCgyt()
	{
		return q3HCndhoEh3StHkUC0bo;
	}
}
