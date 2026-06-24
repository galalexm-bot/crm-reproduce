using System;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.ExportHelper;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Common.Services;

[Service]
public class BlobStore : EntityManager<IBlobStoreHolder, long>, IBLOBStore
{
	public const int MaxSmallDataLength = 1024;

	private bool? ignoreSmallData;

	private static readonly string RegionName = "EleWise.ELMA.Common.Services.BlobStore";

	protected bool IgnoreSmallData
	{
		get
		{
			if (ignoreSmallData.HasValue)
			{
				return ignoreSmallData.Value;
			}
			ignoreSmallData = Locator.GetServiceNotNull<ITransformationProvider>().Uid == new Guid("{CBA7F033-EB9D-4795-88ED-778C9162E547}") || Locator.GetServiceNotNull<ITransformationProvider>().Uid == new Guid("{9B1803BE-F66E-4F59-B687-1654BA9735C9}");
			return ignoreSmallData.Value;
		}
	}

	[Transaction]
	public virtual void Save(string key, byte[] value)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		ValueTaskAwaiter awaiter = SaveInternal(key, value).GetAwaiter();
		((ValueTaskAwaiter)(ref awaiter)).GetResult();
	}

	[AsyncStateMachine(typeof(_003CSaveInternal_003Ed__6))]
	private System.Threading.Tasks.ValueTask SaveInternal(string key, byte[] value, bool isAsync = false, CancellationToken cancellationToken = default(CancellationToken))
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		_003CSaveInternal_003Ed__6 _003CSaveInternal_003Ed__ = default(_003CSaveInternal_003Ed__6);
		_003CSaveInternal_003Ed__._003C_003E4__this = this;
		_003CSaveInternal_003Ed__.key = key;
		_003CSaveInternal_003Ed__.value = value;
		_003CSaveInternal_003Ed__.isAsync = isAsync;
		_003CSaveInternal_003Ed__._003C_003Et__builder = AsyncValueTaskMethodBuilder.Create();
		_003CSaveInternal_003Ed__._003C_003E1__state = -1;
		AsyncValueTaskMethodBuilder _003C_003Et__builder = _003CSaveInternal_003Ed__._003C_003Et__builder;
		((AsyncValueTaskMethodBuilder)(ref _003C_003Et__builder)).Start<_003CSaveInternal_003Ed__6>(ref _003CSaveInternal_003Ed__);
		return ((AsyncValueTaskMethodBuilder)(ref _003CSaveInternal_003Ed__._003C_003Et__builder)).get_Task();
	}

	public virtual byte[] LoadOrNull(string key)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		return LoadOrNullInternal(key).GetAwaiter().GetResult();
	}

	[AsyncStateMachine(typeof(_003CLoadOrNullInternal_003Ed__8))]
	private System.Threading.Tasks.ValueTask<byte[]> LoadOrNullInternal(string key, bool isAsync = false, CancellationToken cancellationToken = default(CancellationToken))
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		_003CLoadOrNullInternal_003Ed__8 _003CLoadOrNullInternal_003Ed__ = default(_003CLoadOrNullInternal_003Ed__8);
		_003CLoadOrNullInternal_003Ed__._003C_003E4__this = this;
		_003CLoadOrNullInternal_003Ed__.key = key;
		_003CLoadOrNullInternal_003Ed__.isAsync = isAsync;
		_003CLoadOrNullInternal_003Ed__._003C_003Et__builder = AsyncValueTaskMethodBuilder<byte[]>.Create();
		_003CLoadOrNullInternal_003Ed__._003C_003E1__state = -1;
		AsyncValueTaskMethodBuilder<byte[]> _003C_003Et__builder = _003CLoadOrNullInternal_003Ed__._003C_003Et__builder;
		_003C_003Et__builder.Start<_003CLoadOrNullInternal_003Ed__8>(ref _003CLoadOrNullInternal_003Ed__);
		return _003CLoadOrNullInternal_003Ed__._003C_003Et__builder.get_Task();
	}

	[Transaction]
	public virtual void Remove(string key)
	{
		((AbstractNHEntityManager<IBlobStoreHolder, long>)this).Find((Expression<Func<IBlobStoreHolder, bool>>)((IBlobStoreHolder b) => b.Key == key)).ForEach(Delete);
	}

	public override ExportRuleList ExportRules()
	{
		Type parentType = InterfaceActivator.TypeOf<IBlobStoreHolder>();
		return new ExportRuleList
		{
			new ExportRule
			{
				ParentType = parentType,
				PropertyName = "BigData",
				ExportRuleType = ExportRuleType.Export
			},
			new ExportRule
			{
				ParentType = parentType,
				PropertyName = "Key",
				ExportRuleType = ExportRuleType.Export
			},
			new ExportRule
			{
				ParentType = parentType,
				PropertyName = "SmallData",
				ExportRuleType = ExportRuleType.Export
			},
			new ExportRule
			{
				ParentType = parentType,
				PropertyName = "Uid",
				ExportRuleType = ExportRuleType.Export
			}
		};
	}
}
