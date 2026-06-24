using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.DynamicForms;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Dependencies.Analyzers;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.UI.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.UI.Services;

[Component]
internal class ComponentDynamicFormProvider : IDynamicFormsProvider
{
	private readonly IEnumerable<IObjectFormProvider> objectFormProviders;

	public static readonly Guid UID;

	internal static ComponentDynamicFormProvider kFP1hRUNMLFgtbr42nL;

	public Guid Uid => UID;

	public ComponentDynamicFormProvider(IEnumerable<IObjectFormProvider> objectFormProviders)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		this.objectFormProviders = objectFormProviders;
	}

	public void ExecuteScript(IEntity entity, RootViewItem view, DynamicFormSettings settings, string scriptName, DynamicFormResultData resultData)
	{
	}

	public Type GetEntityType(DynamicFormSettings settings)
	{
		//Discarded unreachable code: IL_0184, IL_0193
		int num = 4;
		_003C_003Ec__DisplayClass6_0 _003C_003Ec__DisplayClass6_ = default(_003C_003Ec__DisplayClass6_0);
		(Guid, Guid) tuple = default((Guid, Guid));
		object item = default(object);
		IObjectFormProvider objectFormProvider = default(IObjectFormProvider);
		ClassMetadata item2 = default(ClassMetadata);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 6:
					_003C_003Ec__DisplayClass6_.typeUid = tuple.Item1;
					num = 7;
					break;
				default:
					return null;
				case 3:
					tuple = ParseData((string)XhOpOZUa8kDiAuLL6Bn(settings));
					num2 = 6;
					continue;
				case 1:
					if (item != null)
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto case 10;
				case 8:
					objectFormProvider = objectFormProviders.FirstOrDefault(_003C_003Ec__DisplayClass6_._003CGetEntityType_003Eb__0);
					num2 = 9;
					continue;
				case 2:
					if (item2 != null)
					{
						num = 5;
						break;
					}
					goto case 10;
				case 7:
					_003C_003Ec__DisplayClass6_.subTypeUid = tuple.Item2;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
					{
						num2 = 8;
					}
					continue;
				case 9:
					if (objectFormProvider != null)
					{
						(object, ClassMetadata) objectInfo = objectFormProvider.GetObjectInfo(_003C_003Ec__DisplayClass6_.typeUid, _003C_003Ec__DisplayClass6_.subTypeUid, string.Empty);
						item = objectInfo.Item1;
						item2 = objectInfo.Item2;
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
						{
							num2 = 0;
						}
					}
					else
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
						{
							num2 = 0;
						}
					}
					continue;
				case 10:
					return null;
				case 5:
					return item.GetType();
				case 4:
					_003C_003Ec__DisplayClass6_ = new _003C_003Ec__DisplayClass6_0();
					num2 = 3;
					continue;
				}
				break;
			}
		}
	}

	public string GetPropertyValueChangeScriptName(IEntity entity, RootViewItem view, DynamicFormSettings settings, string propertyName)
	{
		return string.Empty;
	}

	public object GetProperty(DynamicFormSettings settings, object obj, Guid propertyUid, Guid[] propertyParents)
	{
		int num = 3;
		int num2 = num;
		_003C_003Ec__DisplayClass8_0 _003C_003Ec__DisplayClass8_ = default(_003C_003Ec__DisplayClass8_0);
		(Guid, Guid) tuple = default((Guid, Guid));
		IPropertyMetadata item = default(IPropertyMetadata);
		IObjectFormProvider objectFormProvider = default(IObjectFormProvider);
		while (true)
		{
			switch (num2)
			{
			case 1:
				return null;
			case 7:
				_003C_003Ec__DisplayClass8_.typeUid = tuple.Item1;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				_003C_003Ec__DisplayClass8_.subTypeUid = tuple.Item2;
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
				{
					num2 = 4;
				}
				break;
			case 3:
				_003C_003Ec__DisplayClass8_ = new _003C_003Ec__DisplayClass8_0();
				num2 = 2;
				break;
			case 2:
				tuple = ParseData((string)XhOpOZUa8kDiAuLL6Bn(settings));
				num2 = 7;
				break;
			case 6:
				return ID8dY5UDsbXg8yAm8hS(obj, item.Name, null);
			case 5:
				if (objectFormProvider == null)
				{
					num2 = 8;
				}
				else if (objectFormProvider.GetObjectInfo(_003C_003Ec__DisplayClass8_.typeUid, _003C_003Ec__DisplayClass8_.subTypeUid, string.Empty).Item2 is ComponentContextMetadata rootMetadata)
				{
					item = FindPropertyMetadata(propertyUid, propertyParents, rootMetadata).Item2;
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
					{
						num2 = 1;
					}
				}
				else
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
					{
						num2 = 1;
					}
				}
				break;
			case 4:
				objectFormProvider = objectFormProviders.FirstOrDefault(_003C_003Ec__DisplayClass8_._003CGetProperty_003Eb__0);
				num2 = 5;
				break;
			case 8:
				return null;
			}
		}
	}

	private (Guid, Guid) ParseData(string data)
	{
		string[] array = data.Split(';');
		Guid item = new Guid(array[0]);
		Guid item2 = new Guid(array[1]);
		return (item, item2);
	}

	private static (ClassMetadata, IPropertyMetadata) FindPropertyMetadata(Guid propertyUid, object propertyParents, object rootMetadata)
	{
		return ((Array)propertyParents).Length switch
		{
			0 => ViewItemsAnalyzerHelper.CaseZeroPropertyParents(propertyUid, (ClassMetadata)rootMetadata, null, null, null, null), 
			1 => ViewItemsAnalyzerHelper.CaseOnePropertyParents(propertyUid, ((IEnumerable<Guid>)propertyParents).ToArray(), (ClassMetadata)rootMetadata, null, null, null, null), 
			_ => ViewItemsAnalyzerHelper.CaseDefaultPropertyParents(propertyUid, ((IEnumerable<Guid>)propertyParents).ToArray(), (ClassMetadata)rootMetadata, null, null, null, null), 
		};
	}

	static ComponentDynamicFormProvider()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				UID = new Guid((string)iLkmZkUtFjjnOQegpNW(-538519530 ^ -538571768));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			case 2:
				SingletonReader.JJCZtPuTvSt();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	internal static object XhOpOZUa8kDiAuLL6Bn(object P_0)
	{
		return ((DynamicFormSettings)P_0).DynamicFormsProviderData;
	}

	internal static bool XyOeVdU3cIfuGbsGGw5()
	{
		return kFP1hRUNMLFgtbr42nL == null;
	}

	internal static ComponentDynamicFormProvider bbMff3UpCjF3Tjh1g7a()
	{
		return kFP1hRUNMLFgtbr42nL;
	}

	internal static object ID8dY5UDsbXg8yAm8hS(object P_0, object P_1, object P_2)
	{
		return P_0.GetPropertyValue((string)P_1, P_2);
	}

	internal static object iLkmZkUtFjjnOQegpNW(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}
}
