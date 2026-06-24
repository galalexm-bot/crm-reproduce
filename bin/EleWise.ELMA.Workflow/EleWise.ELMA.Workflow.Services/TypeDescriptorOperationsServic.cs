using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Workflow.ExtensionPoints;
using EleWise.ELMA.Workflow.Models.ConditionTable;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.Services;

[Service]
internal sealed class TypeDescriptorOperationsService : ITypeDescriptorOperationsService
{
	private readonly Dictionary<Guid, IOperation> operations;

	private readonly IEnumerable<ITypeOperations> typeDescriptorOperations;

	private readonly IEnumerable<ITypedValueSerializer> typedValueSerializers;

	private static TypeDescriptorOperationsService rNdVxLMupxnAmu43LOu;

	public TypeDescriptorOperationsService(IEnumerable<IOperation> operations, IEnumerable<ITypeOperations> typeDescriptorOperations, IEnumerable<ITypedValueSerializer> typedValueSerializers)
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		this.operations = new Dictionary<Guid, IOperation>();
		base._002Ector();
		this.operations = operations.ToDictionary((IOperation k) => _003C_003Ec.l2nZsLZGS6YXPs1Q7Tux(k), (IOperation v) => v);
		this.typeDescriptorOperations = typeDescriptorOperations;
		this.typedValueSerializers = typedValueSerializers;
	}

	public bool CheckOperations(ITypeDescriptor descriptor)
	{
		return GetOperationUids(descriptor).Any();
	}

	public IEnumerable<IOperation> GetOperations(ITypeDescriptor descriptor)
	{
		return from uid in GetOperationUids(descriptor)
			select operations.GetValueOrDefault(uid, null) into o
			where o != null
			select o;
	}

	public IOperation GetOperation(ITypeDescriptor descriptor, Guid operationUid)
	{
		//Discarded unreachable code: IL_0069, IL_0078
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (!GetOperationUids(descriptor).Contains(operationUid))
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0fbdcdb2cea84e8d8852886ebe735d8f == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 2:
				return operations.GetValueOrDefault(operationUid, null);
			default:
				return null;
			}
		}
	}

	public IOperation GetOperationByUid(Guid operationUid)
	{
		return operations.GetValueOrDefault(operationUid, null);
	}

	public IEnumerable<IOperation> GetOperations()
	{
		return operations.Values;
	}

	private IEnumerable<Guid> GetOperationUids(ITypeDescriptor descriptor)
	{
		_003C_003Ec__DisplayClass6_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass6_0();
		CS_0024_003C_003E8__locals0.descriptor = descriptor;
		if (CS_0024_003C_003E8__locals0.descriptor == null)
		{
			return Enumerable.Empty<Guid>();
		}
		CS_0024_003C_003E8__locals0.type = typedValueSerializers.FirstOrDefault((ITypedValueSerializer s) => _003C_003Ec__DisplayClass6_0.W92I90ZG40V4xgUqSEVb(s, CS_0024_003C_003E8__locals0.descriptor))?.GetType(CS_0024_003C_003E8__locals0.descriptor);
		return typeDescriptorOperations.Where(delegate(ITypeOperations item)
		{
			//Discarded unreachable code: IL_0041, IL_0050
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return _003C_003Ec__DisplayClass6_0.jX20CmZGzpilOuIuByXZ(item).IsAssignableFrom(CS_0024_003C_003E8__locals0.type);
				case 1:
					return false;
				case 2:
					if (!(_003C_003Ec__DisplayClass6_0.jX20CmZGzpilOuIuByXZ(item) != null))
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b1ab9396b25b43af8f32e24b1948be96 == 0)
						{
							num2 = 1;
						}
						break;
					}
					goto default;
				}
			}
		}).SelectMany((ITypeOperations item) => item.Operations).Distinct();
	}

	internal static bool TFwmKnMDwPgeMgUl6qx()
	{
		return rNdVxLMupxnAmu43LOu == null;
	}

	internal static TypeDescriptorOperationsService S4Lro8MnhuoWS7TGfWq()
	{
		return rNdVxLMupxnAmu43LOu;
	}
}
