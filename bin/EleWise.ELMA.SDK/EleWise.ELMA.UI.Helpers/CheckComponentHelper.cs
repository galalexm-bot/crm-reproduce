using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model;
using EleWise.ELMA.Model.Dependencies;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Signatures;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Model.Views.Toolbar;
using EleWise.ELMA.Services;
using EleWise.ELMA.UI.Metadata;
using EleWise.ELMA.UI.Models;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.UI.Helpers;

public static class CheckComponentHelper
{
	internal static CheckComponentHelper E47vkdBZBmxUeTvFlEYS;

	public static IEnumerable<ComponentViewItem> FindAllComponentViewItems(FormViewItem form)
	{
		Contract.ArgumentNotNull(form, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7EC153F ^ 0x7ECEED9));
		return form.FindItems(ignoreHide: false, (ViewItem i) => i is ComponentViewItem).Cast<ComponentViewItem>().Concat(ComponentsFromToolbar(form));
	}

	public static IEnumerable<ObjectFormViewItem> FindAllObjectFormViewItems(FormViewItem form)
	{
		Contract.ArgumentNotNull(form, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-521266112 ^ -521214042));
		return form.FindItems(ignoreHide: false, (ViewItem i) => i is ObjectFormViewItem).Cast<ObjectFormViewItem>();
	}

	public static IEnumerable<ValidationError> CheckComponentViewItems(FormViewItem form, Guid ownerUid)
	{
		return CheckComponentViewItems(form, ownerUid, null, null);
	}

	public static IEnumerable<ValidationError> CheckComponentViewItems(FormViewItem form, Guid ownerUid, Func<Guid, bool> componentFilter)
	{
		return CheckComponentViewItems(form, ownerUid, null, componentFilter);
	}

	public static IEnumerable<ValidationError> CheckComponentViewItems(FormViewItem form, Guid ownerUid, EntityMetadata ownerEntity)
	{
		return CheckComponentViewItems(form, ownerUid, ownerEntity, null);
	}

	public static IEnumerable<ValidationError> CheckComponentViewItems(FormViewItem form, Guid ownerUid, EntityMetadata ownerEntity, Func<Guid, bool> componentFilter)
	{
		_003C_003Ec__DisplayClass5_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass5_0();
		CS_0024_003C_003E8__locals0.componentFilter = componentFilter;
		CS_0024_003C_003E8__locals0.componentFilter = CS_0024_003C_003E8__locals0.componentFilter ?? new Func<Guid, bool>(EmptyFilter);
		List<ValidationError> list = new List<ValidationError>();
		foreach (ComponentViewItem item2 in from c in FindAllComponentViewItems(form)
			where CS_0024_003C_003E8__locals0.componentFilter(c.HeaderUid)
			select c)
		{
			ComponentMetadata componentMetadata = null;
			try
			{
				componentMetadata = MetadataServiceContext.Service.GetMetadata(item2.HeaderUid) as ComponentMetadata;
			}
			catch (TypeNotFoundException)
			{
				if (Locator.GetService<IActorContextService>().TryGet(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3A5D5EF ^ 0x3A52E1D), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-35995181 ^ -36031995), item2.HeaderUid), out var _))
				{
					continue;
				}
			}
			if (componentMetadata == null)
			{
				if (ownerEntity == null)
				{
					throw new MetadataLoadException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4EA5403C ^ 0x4EA5BC28), item2.HeaderUid));
				}
				throw new MetadataLoadException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1998538950 ^ -1998566574), item2.HeaderUid, ownerEntity.Name, ownerEntity.Uid));
			}
			ValidationResult validationResult = CheckSignature(GetCurrentInputs(item2, InterfaceBuilderViewMode.Runtime), componentMetadata);
			if (!validationResult.IsValid)
			{
				ValidationError validationError = new ValidationError();
				validationError.OwnerUid = ownerUid;
				validationError.ElementTypeUid = ValidationElementType.ComponentViewItem;
				validationError.ElementUid = item2.Uid;
				validationError.Message = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1088304168 ^ -1088342234), componentMetadata.DisplayName);
				validationError.InnerErrors = validationResult.Errors;
				ValidationError item = validationError;
				list.Add(item);
			}
		}
		return list;
	}

	public static ValidationResult CheckSignature(ComponentDependency componentDependency, ComponentSignature componentSignature)
	{
		return CheckSignature(componentDependency.Inputs, componentSignature);
	}

	public static ValidationResult CheckSignature(ICollection<InputComputedValue> inputs, ComponentSignature componentSignature)
	{
		List<ValidationError> list = new List<ValidationError>();
		using (IEnumerator<InputComputedValue> enumerator = componentSignature.Inputs.Where((InputComputedValue a) => _003C_003Ec.o3BCjRQGAReZytFEVYnX(_003C_003Ec.BcGa1fQGHID3qZFj7V3H(a), SlotViewItem.TypeUid)).GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				_003C_003Ec__DisplayClass7_0 CS_0024_003C_003E8__locals1 = new _003C_003Ec__DisplayClass7_0();
				CS_0024_003C_003E8__locals1.candidateInput = enumerator.Current;
				bool flag = CS_0024_003C_003E8__locals1.candidateInput.Name.Contains(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-475857671 ^ -475922071));
				string text = CS_0024_003C_003E8__locals1.candidateInput.Name.Replace(flag ? z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1317790512 ^ -1317740224) : z2jc63fLkugS1X8Q9N.tE1kD1vbB(-87337865 ^ -87316015), string.Empty);
				InputComputedValue inputComputedValue = inputs.FirstOrDefault((InputComputedValue q) => _003C_003Ec__DisplayClass7_0.O5qNkbQGrFyxLrjsplip(_003C_003Ec__DisplayClass7_0.a9uJiCQGlYOwhymkNbif(q), _003C_003Ec__DisplayClass7_0.a9uJiCQGlYOwhymkNbif(CS_0024_003C_003E8__locals1.candidateInput)));
				if (inputComputedValue == null)
				{
					if (CS_0024_003C_003E8__locals1.candidateInput.Required)
					{
						if (flag)
						{
							list.Add(new ValidationError
							{
								Message = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1217523399 ^ -1217467261), componentSignature.DisplayName, text)
							});
						}
						else
						{
							list.Add(new ValidationError
							{
								Message = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6DC147B0 ^ 0x6DC1B9CE), componentSignature.DisplayName, text)
							});
						}
					}
					continue;
				}
				if (CS_0024_003C_003E8__locals1.candidateInput.Nullable != inputComputedValue.Nullable && !CS_0024_003C_003E8__locals1.candidateInput.Nullable && inputComputedValue.Nullable)
				{
					list.Add(new ValidationError
					{
						Message = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-787452571 ^ -787443163), componentSignature.DisplayName, text)
					});
				}
				if (!flag && CS_0024_003C_003E8__locals1.candidateInput.RelationType != inputComputedValue.RelationType)
				{
					list.Add(new ValidationError
					{
						Message = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-195614443 ^ -195679999), componentSignature.DisplayName, text)
					});
				}
				if (!flag && CS_0024_003C_003E8__locals1.candidateInput.TypeUid != inputComputedValue.TypeUid)
				{
					list.Add(new ValidationError
					{
						Message = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138958856 ^ -2138893488), componentSignature.DisplayName, text)
					});
				}
				if (flag && inputComputedValue is ActionInputComputedValue actionInputComputedValue && CS_0024_003C_003E8__locals1.candidateInput.TypeUid != actionInputComputedValue.ParameterType.TypeUid)
				{
					list.Add(new ValidationError
					{
						Message = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3B36AB09 ^ 0x3B37AA39), componentSignature.DisplayName, text)
					});
				}
				if (!flag && CS_0024_003C_003E8__locals1.candidateInput.SubTypeUid != inputComputedValue.SubTypeUid)
				{
					list.Add(new ValidationError
					{
						Message = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3A6135BE ^ 0x3A603516), componentSignature.DisplayName, text)
					});
				}
				if (!(inputComputedValue is ActionInputComputedValue actionInputComputedValue2) || !(CS_0024_003C_003E8__locals1.candidateInput is ActionInputComputedValue actionInputComputedValue3))
				{
					continue;
				}
				CompatibilityResult compatibilityResult = actionInputComputedValue2.ReturnType.Compatible(actionInputComputedValue3.ReturnType);
				if (!compatibilityResult.IsValid)
				{
					list.Add(new ValidationError
					{
						Message = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-477139494 ^ -477205408), componentSignature.DisplayName, text)
					});
					list.AddRange(compatibilityResult.Errors.Select(delegate(string error)
					{
						ValidationError validationError2 = new ValidationError();
						_003C_003Ec.YWvl4ZQG7HILrx4VYZyc(validationError2, error);
						return validationError2;
					}));
				}
				CompatibilityResult compatibilityResult2 = actionInputComputedValue2.ParameterType.Compatible(actionInputComputedValue3.ParameterType);
				if (!compatibilityResult2.IsValid)
				{
					list.Add(new ValidationError
					{
						Message = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x10E41EDB ^ 0x10E51CB7), componentSignature.DisplayName, text)
					});
					list.AddRange(compatibilityResult2.Errors.Select(delegate(string error)
					{
						ValidationError validationError = new ValidationError();
						_003C_003Ec.YWvl4ZQG7HILrx4VYZyc(validationError, error);
						return validationError;
					}));
				}
			}
		}
		using (IEnumerator<InputComputedValue> enumerator = inputs.Where((InputComputedValue a) => _003C_003Ec.BcGa1fQGHID3qZFj7V3H(a) == SlotViewItem.TypeUid).GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				_003C_003Ec__DisplayClass7_1 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass7_1();
				CS_0024_003C_003E8__locals0.slot = enumerator.Current;
				if (componentSignature.Inputs.FirstOrDefault(delegate(InputComputedValue s)
				{
					//Discarded unreachable code: IL_002d, IL_003c
					int num = 1;
					int num2 = num;
					while (true)
					{
						switch (num2)
						{
						case 1:
							if (!(_003C_003Ec__DisplayClass7_1.v4EOGbQGLfGqJSjy7vHN(s) == SlotViewItem.TypeUid))
							{
								num2 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
								{
									num2 = 0;
								}
								break;
							}
							goto case 2;
						case 2:
							return _003C_003Ec__DisplayClass7_1.r7wc7BQGstYZqOaWecYP(s.SubTypeUid, _003C_003Ec__DisplayClass7_1.ajVXGvQGUN0eX510132q(CS_0024_003C_003E8__locals0.slot));
						default:
							return false;
						}
					}
				}) == null)
				{
					list.Add(new ValidationError
					{
						Message = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-488881205 ^ -488816427), componentSignature.DisplayName, CS_0024_003C_003E8__locals0.slot.Name)
					});
				}
			}
		}
		return new ValidationResult(list.Count == 0, list);
	}

	public static ValidationResult CheckSignature(ICollection<InputComputedValue> inputs, ComponentMetadata candidateMetadata)
	{
		if (candidateMetadata == null)
		{
			return new ValidationResult(false, new ValidationError
			{
				Message = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1867198571 ^ -1867134075))
			});
		}
		ComponentSignature signature = candidateMetadata.GetSignature();
		return CheckSignature(inputs, signature);
	}

	public static ICollection<InputComputedValue> GetCurrentInputs(ComponentViewItem componentViewItem, InterfaceBuilderViewMode viewMode)
	{
		List<InputComputedValue> list = new List<InputComputedValue>();
		foreach (ComputedValue dynamicProperty in componentViewItem.DynamicProperties)
		{
			if (!(dynamicProperty is InputComputedValue inputComputedValue))
			{
				continue;
			}
			if (viewMode == InterfaceBuilderViewMode.Design)
			{
				list.Add(inputComputedValue);
				continue;
			}
			switch (inputComputedValue.ComputedValueType)
			{
			case ComputedValueType.Input:
				if (inputComputedValue.Value == null || (inputComputedValue.Value is string value && string.IsNullOrWhiteSpace(value)))
				{
					continue;
				}
				break;
			case ComputedValueType.Function:
				if (string.IsNullOrWhiteSpace(inputComputedValue.MethodName))
				{
					continue;
				}
				break;
			case ComputedValueType.CalculateScript:
				if (string.IsNullOrWhiteSpace(inputComputedValue.CalculateScript))
				{
					continue;
				}
				break;
			}
			list.Add(inputComputedValue);
		}
		return list;
	}

	private static IEnumerable<ComponentViewItem> ComponentsFromToolbar(object view)
	{
		if (((FormViewItem)view)?.Toolbar == null)
		{
			return Enumerable.Empty<ComponentViewItem>();
		}
		return ((FormViewItem)view).Toolbar.GetAllItems(ignoreHide: false).OfType<Button>().SelectMany((Button button) => button.RootViewItem?.GetAllItems(ignoreHide: false).OfType<ComponentViewItem>() ?? Enumerable.Empty<ComponentViewItem>());
	}

	private static bool EmptyFilter(Guid _)
	{
		return true;
	}

	internal static bool sc06u9BZWV469fO79xrv()
	{
		return E47vkdBZBmxUeTvFlEYS == null;
	}

	internal static CheckComponentHelper fKKiq1BZogsA1lgLSFne()
	{
		return E47vkdBZBmxUeTvFlEYS;
	}
}
