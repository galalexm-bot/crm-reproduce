using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Scripts.Models;
using EleWise.ELMA.Services;
using EleWise.ELMA.UI.Helpers;
using EleWise.ELMA.UI.Metadata;
using EleWise.ELMA.UI.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.UI.Services;

[Service]
internal sealed class CheckComponentService : ICheckComponentService
{
	private readonly IScriptLoader scriptLoader;

	internal static CheckComponentService u1sdRozSaG6C0awhByg;

	public CheckComponentService(IScriptLoader scriptLoader)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			this.scriptLoader = scriptLoader;
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
			{
				num = 1;
			}
		}
	}

	public ValidationResult Validate(ComponentMetadata componentMetadata)
	{
		int num = 1;
		int num2 = num;
		List<ValidationError> list = default(List<ValidationError>);
		while (true)
		{
			switch (num2)
			{
			case 1:
			{
				IEnumerable<ValidationError> first = CheckComponentContext(componentMetadata);
				IEnumerable<ValidationError> second = CheckObjectFormViewItems(componentMetadata);
				IEnumerable<ValidationError> second2 = CheckComponentHelper.CheckComponentViewItems((FormViewItem)Vh95OxzqQFQHXmUkHG8(componentMetadata.Content), sNYFrMzKfT0QRTvu742(componentMetadata));
				list = Enumerable.Concat(second: CheckExistenceOfMethods(componentMetadata), first: first.Concat(second).Concat(second2)).ToList();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
				{
					num2 = 0;
				}
				break;
			}
			default:
				return new ValidationResult(list.Count == 0, list);
			}
		}
	}

	private IEnumerable<ValidationError> CheckExistenceOfMethods(ComponentMetadata componentMetadata)
	{
		List<ValidationError> list = new List<ValidationError>();
		Dictionary<CodeType, IEnumerable<ScriptMethodDeclaration>> dictionary = new Dictionary<CodeType, IEnumerable<ScriptMethodDeclaration>>();
		ExtendScriptMethodDeclarations(dictionary, CodeType.Client, componentMetadata.ClientScriptUid);
		ExtendScriptMethodDeclarations(dictionary, CodeType.Server, componentMetadata.ScriptUid);
		if (dictionary.Count == 0)
		{
			return list;
		}
		foreach (PropertyMetadata property in componentMetadata.Content.Context.Properties)
		{
			if (!(property is ViewModelPropertyMetadata viewModelPropertyMetadata))
			{
				continue;
			}
			if (viewModelPropertyMetadata.ComputedValue != null && viewModelPropertyMetadata.ComputedValue.ComputedValueType == ComputedValueType.Function)
			{
				AddErrorIfMethodNotExist(list, dictionary, viewModelPropertyMetadata.ComputedValue.MethodName, componentMetadata, viewModelPropertyMetadata.Uid, viewModelPropertyMetadata.DisplayName, ValidationElementType.Property);
			}
			if (viewModelPropertyMetadata.ComputedValues == null)
			{
				continue;
			}
			foreach (ComputedValue computedValue in viewModelPropertyMetadata.ComputedValues)
			{
				if (computedValue.ComputedValueType == ComputedValueType.Function)
				{
					AddErrorIfMethodNotExist(list, dictionary, computedValue.MethodName, componentMetadata, viewModelPropertyMetadata.Uid, viewModelPropertyMetadata.DisplayName, ValidationElementType.Property);
				}
			}
		}
		foreach (ViewItem allItem in componentMetadata.Content.View.GetAllItems())
		{
			foreach (ComputedValue dynamicProperty in allItem.DynamicProperties)
			{
				if (dynamicProperty.ComputedValueType == ComputedValueType.Function)
				{
					AddErrorIfMethodNotExist(list, dictionary, dynamicProperty.MethodName, componentMetadata, allItem.Uid, allItem.Name, ValidationElementType.ViewItem);
				}
			}
			if (allItem is PropertyViewItem propertyViewItem && propertyViewItem.Attributes != null)
			{
				AddErrorIfMethodNotExist(list, dictionary, propertyViewItem.Attributes.OnChangeScriptName, componentMetadata, allItem.Uid, allItem.Name, ValidationElementType.ViewItem);
			}
			if (allItem is ButtonViewItem buttonViewItem)
			{
				AddErrorIfMethodNotExist(list, dictionary, buttonViewItem.ScriptName, componentMetadata, allItem.Uid, allItem.Name, ValidationElementType.ViewItem);
			}
		}
		return list;
	}

	private void ExtendScriptMethodDeclarations(IDictionary<CodeType, IEnumerable<ScriptMethodDeclaration>> scriptMethodDeclarations, CodeType codeType, Guid? scriptUid)
	{
		try
		{
			ScriptModule script = scriptLoader.GetScript(scriptUid);
			if (script != null)
			{
				scriptMethodDeclarations.Add(codeType, script.ScriptMethods);
			}
		}
		catch (ObjectNotFoundException)
		{
		}
	}

	private void AddErrorIfMethodNotExist(List<ValidationError> errors, IDictionary<CodeType, IEnumerable<ScriptMethodDeclaration>> scriptMethodDeclarations, string scriptName, ComponentMetadata componentMetadata, Guid elementUid, string elementName, Guid validationElementType)
	{
		_003C_003Ec__DisplayClass6_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass6_0();
		CS_0024_003C_003E8__locals0.method = ScriptMethodInfoHelper.Deserialize(scriptName);
		if (!CS_0024_003C_003E8__locals0.method.Name.IsNullOrEmpty() && !(CS_0024_003C_003E8__locals0.method.MetadataUid == Guid.Empty) && (!scriptMethodDeclarations.TryGetValue(CS_0024_003C_003E8__locals0.method.CodeType, out var value) || !value.Any((ScriptMethodDeclaration script) => _003C_003Ec__DisplayClass6_0.oobee4fsaGCgPAdcrtTb(_003C_003Ec__DisplayClass6_0.yLlfQ4fs3mCwXvqFNZh6(script), _003C_003Ec__DisplayClass6_0.skYubrfspNU4qbL77gJl(CS_0024_003C_003E8__locals0.method)))))
		{
			errors.Add(new ValidationError
			{
				OwnerUid = componentMetadata.Uid,
				ElementUid = elementUid,
				ElementTypeUid = validationElementType,
				Message = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1317790512 ^ -1317747076), scriptName, elementName, elementUid, componentMetadata.DisplayName)
			});
		}
	}

	private static IEnumerable<ValidationError> CheckObjectFormViewItems(object componentMetadata)
	{
		_003C_003Ec__DisplayClass7_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass7_0();
		CS_0024_003C_003E8__locals0.componentMetadata = (ComponentMetadata)componentMetadata;
		return (from objectForm in CheckComponentHelper.FindAllObjectFormViewItems(CS_0024_003C_003E8__locals0.componentMetadata.Content.View)
			where _003C_003Ec.lLtHYvfsJIhxCX6wxExa(objectForm) == ViewItemLoadingType.SyncLoading
			select objectForm).Select(delegate(ObjectFormViewItem objectForm)
		{
			int num = 2;
			int num2 = num;
			ValidationError validationError = default(ValidationError);
			while (true)
			{
				switch (num2)
				{
				case 5:
					return validationError;
				case 3:
					_003C_003Ec__DisplayClass7_0.Advob9fsA49eyPXROTC3(validationError, ValidationElementType.ObjectFormViewItem);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					validationError = new ValidationError();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
					{
						num2 = 0;
					}
					break;
				default:
					_003C_003Ec__DisplayClass7_0.G7gHBkfsxFhrLqyQYr8d(validationError, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-97972138 ^ -97748592), _003C_003Ec__DisplayClass7_0.D7FKMffs7u47nhv2qbJk(CS_0024_003C_003E8__locals0.componentMetadata)));
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
					{
						num2 = 2;
					}
					break;
				case 4:
					validationError.ElementUid = objectForm.Uid;
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
					{
						num2 = 3;
					}
					break;
				case 1:
					_003C_003Ec__DisplayClass7_0.tonHC1fsHHcwGSSbMFWG(validationError, _003C_003Ec__DisplayClass7_0.XbDHhdfs6LnUYAKZgXEF(CS_0024_003C_003E8__locals0.componentMetadata));
					num2 = 4;
					break;
				}
			}
		});
	}

	private static IEnumerable<ValidationError> CheckComponentContext(object componentMetadata)
	{
		List<ValidationError> list = new List<ValidationError>();
		foreach (PropertyMetadata property in ((ComponentMetadata)componentMetadata).Content.Context.Properties)
		{
			if (string.IsNullOrWhiteSpace(property.Name))
			{
				list.Add(new ValidationError
				{
					OwnerUid = ((AbstractMetadata)componentMetadata).Uid,
					ElementUid = property.Uid,
					ElementTypeUid = ValidationElementType.Property,
					Message = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-195614443 ^ -195562891), ((NamedMetadata)componentMetadata).DisplayName, property.Uid)
				});
			}
			if (string.IsNullOrWhiteSpace(property.DisplayName))
			{
				list.Add(new ValidationError
				{
					OwnerUid = ((AbstractMetadata)componentMetadata).Uid,
					ElementUid = property.Uid,
					ElementTypeUid = ValidationElementType.Property,
					Message = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-218496594 ^ -218440270), ((NamedMetadata)componentMetadata).DisplayName, property.Uid)
				});
			}
			if (property.TypeUid == Guid.Empty)
			{
				list.Add(new ValidationError
				{
					OwnerUid = ((AbstractMetadata)componentMetadata).Uid,
					ElementUid = property.Uid,
					ElementTypeUid = ValidationElementType.Property,
					Message = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1637C429 ^ 0x163718DB), ((NamedMetadata)componentMetadata).DisplayName, property.Uid)
				});
			}
		}
		return list;
	}

	private static IEnumerable<ValidationError> CheckImplementationForms(object componentMetadata)
	{
		List<ValidationError> list = new List<ValidationError>();
		if (((ComponentMetadata)componentMetadata).ImplementationForms.Count == 0)
		{
			return list;
		}
		using List<ImplementationForm>.Enumerator enumerator = ((ComponentMetadata)componentMetadata).ImplementationForms.GetEnumerator();
		while (enumerator.MoveNext())
		{
			_003C_003Ec__DisplayClass9_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass9_0();
			CS_0024_003C_003E8__locals0.impl = enumerator.Current;
			if (!((ComponentMetadata)componentMetadata).Content.Context.Properties.Any(delegate(PropertyMetadata p)
			{
				int num = 1;
				int num2 = num;
				ViewModelPropertyMetadata viewModelPropertyMetadata = default(ViewModelPropertyMetadata);
				while (true)
				{
					switch (num2)
					{
					case 2:
						return _003C_003Ec__DisplayClass9_0.sODMSRfsYi18nXkSHdw9(_003C_003Ec__DisplayClass9_0.YTryfMfs5PF02LyfQdjB(viewModelPropertyMetadata), _003C_003Ec__DisplayClass9_0.xIyx9Vfsj0oIr5KRBgk2(CS_0024_003C_003E8__locals0.impl));
					case 1:
						if ((viewModelPropertyMetadata = p as ViewModelPropertyMetadata) != null)
						{
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
							{
								num2 = 0;
							}
							break;
						}
						goto IL_0040;
					default:
						{
							if (_003C_003Ec__DisplayClass9_0.pMFJk8fsgGmPpcaCN97g(viewModelPropertyMetadata))
							{
								num2 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
								{
									num2 = 2;
								}
								break;
							}
							goto IL_0040;
						}
						IL_0040:
						return false;
					}
				}
			}))
			{
				list.Add(new ValidationError
				{
					OwnerUid = ((AbstractMetadata)componentMetadata).Uid,
					ElementTypeUid = ValidationElementType.Property,
					Message = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x49E27B8A ^ 0x49E2A624), ((NamedMetadata)componentMetadata).DisplayName, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1426094279 ^ -1426105995))
				});
			}
		}
		return list;
	}

	internal static bool xwYeCDzi7xik2BCTcXD()
	{
		return u1sdRozSaG6C0awhByg == null;
	}

	internal static CheckComponentService Nejo3FzRBwkK8XtyDPv()
	{
		return u1sdRozSaG6C0awhByg;
	}

	internal static object Vh95OxzqQFQHXmUkHG8(object P_0)
	{
		return ((ComponentContentMetadata)P_0).View;
	}

	internal static Guid sNYFrMzKfT0QRTvu742(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}
}
