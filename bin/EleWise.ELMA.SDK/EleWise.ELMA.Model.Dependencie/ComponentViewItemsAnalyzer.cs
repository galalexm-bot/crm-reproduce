using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Scripts.Models;
using EleWise.ELMA.UI.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Dependencies.Analyzers;

internal sealed class ComponentViewItemsAnalyzer : BaseViewItemAnalyzer<ComponentViewItem>
{
	internal static ComponentViewItemsAnalyzer AeOANWhRgaiYJfcPwdbC;

	protected override DependencyAnalysisResult ProcessViewItems(IEnumerable<ComponentViewItem> viewItems, ClassMetadata contextMetadata, IMetadata metadata, DependencyServiceOptions options)
	{
		Guid moduleUid = contextMetadata.ModuleUid;
		Dictionary<Guid, EnumDependency> dictionary = new Dictionary<Guid, EnumDependency>();
		Dictionary<Guid, EntityDependency> dictionary2 = new Dictionary<Guid, EntityDependency>();
		Dictionary<Guid, DataClassDependency> dictionary3 = new Dictionary<Guid, DataClassDependency>();
		List<ComponentDependency> list = new List<ComponentDependency>();
		Dictionary<Guid, FunctionDependency> dictionary4 = new Dictionary<Guid, FunctionDependency>();
		foreach (ComponentViewItem viewItem in viewItems)
		{
			if (!(MetadataServiceContext.Service.GetMetadata(viewItem.HeaderUid) is ComponentMetadata componentMetadata))
			{
				throw new MetadataLoadException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2107978722 ^ -2108061488), viewItem.HeaderUid));
			}
			if (DependencyServiceHelper.SkipDependency(componentMetadata, moduleUid, options))
			{
				continue;
			}
			List<InputComputedValue> list2 = viewItem.DynamicProperties.OfType<InputComputedValue>().ToList();
			foreach (InputComputedValue item in list2)
			{
				switch (item.ComputedValueType)
				{
				case ComputedValueType.Input:
					if (item.Value == null)
					{
						continue;
					}
					break;
				case ComputedValueType.Function:
					if (string.IsNullOrWhiteSpace(item.MethodName))
					{
						continue;
					}
					break;
				case ComputedValueType.CalculateScript:
					if (string.IsNullOrWhiteSpace(item.CalculateScript))
					{
						continue;
					}
					break;
				}
				if (!DependencyServiceHelper.IsAction(item.TypeUid) || !(item is ActionInputComputedValue actionInputComputedValue))
				{
					continue;
				}
				DependencyServiceHelper.AnalyseTypeSignature(actionInputComputedValue.ReturnType, dictionary3, dictionary2, dictionary, moduleUid, options);
				DependencyServiceHelper.AnalyseTypeSignature(actionInputComputedValue.ParameterType, dictionary3, dictionary2, dictionary, moduleUid, options);
				if (item.Value is ActionValue actionValue && actionValue.CodeType == CodeType.GlobalFunction)
				{
					Guid functionHeaderUid = actionValue.FunctionHeaderUid;
					if (!(MetadataServiceContext.Service.GetMetadata(functionHeaderUid) is FunctionMetadata functionMetadata))
					{
						throw new MetadataLoadException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1867198571 ^ -1867088869), functionHeaderUid));
					}
					if (!DependencyServiceHelper.SkipDependency(functionMetadata, moduleUid, options))
					{
						DependencyServiceHelper.AddFunctionDependency(dictionary4, functionMetadata);
					}
				}
			}
			List<InputComputedValue> list3 = new List<InputComputedValue>();
			if (viewItem.Items.Count > 0)
			{
				list3.AddRange((from s in viewItem.Items.OfType<SlotViewItem>()
					where s.Items.Any()
					select s).Select(delegate(SlotViewItem s)
				{
					InputComputedValue inputComputedValue = new InputComputedValue();
					_003C_003Ec.kcFQXRvbW6EF64YjQitb(inputComputedValue, _003C_003Ec.Dej9ZVvbBQMCF0qyiWS6(_003C_003Ec.KiCVamvozxoulfd9kUS3(0x463A0F3C ^ 0x463FB236), _003C_003Ec.hZLAPSvbFNPFRrjQm2CQ(s)));
					_003C_003Ec.nKytEyvbo7be9Z6ElpVC(inputComputedValue, SlotViewItem.TypeUid);
					_003C_003Ec.iKbZfnvbhAkibSuvKP1I(inputComputedValue, _003C_003Ec.uswgE6vbb4jEagPqIK4b(s));
					return inputComputedValue;
				}));
			}
			ComponentDependency dependency = componentMetadata.GetDependency(viewItem);
			dependency.Inputs.AddRange(list2);
			dependency.Inputs.AddRange(list3);
			list.Add(dependency);
		}
		return new DependencyAnalysisResult
		{
			EnumDependencies = dictionary.Values.ToList(),
			EntityDependencies = dictionary2.Values.ToList(),
			DataClassDependencies = dictionary3.Values.ToList(),
			FunctionDependencies = dictionary4.Values.ToList(),
			ComponentDependencies = list
		};
	}

	public ComponentViewItemsAnalyzer()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool U5ngWLhR57FrBndN733r()
	{
		return AeOANWhRgaiYJfcPwdbC == null;
	}

	internal static ComponentViewItemsAnalyzer h1w7DLhRj4me55Wk47Bd()
	{
		return AeOANWhRgaiYJfcPwdbC;
	}
}
