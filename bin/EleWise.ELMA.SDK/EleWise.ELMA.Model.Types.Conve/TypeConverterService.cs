using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Types.Convertors;

[Service]
internal sealed class TypeConverterService : ITypeConverterService
{
	private ConcurrentDictionary<Guid, IEnumerable<Guid>> cachedTargetSelections;

	private readonly IEnumerable<ITypeConvertor> typeConverters;

	internal static TypeConverterService NwDKufo5MEFxUjyFMEOj;

	public TypeConverterService(IEnumerable<ITypeConvertor> typeConverters)
	{
		SingletonReader.JJCZtPuTvSt();
		cachedTargetSelections = new ConcurrentDictionary<Guid, IEnumerable<Guid>>();
		base._002Ector();
		this.typeConverters = typeConverters;
	}

	public bool CanConvert(Guid sourceTypeUid, Guid targetTypeUid)
	{
		return GetConvertFromTypeUids(targetTypeUid).Contains(sourceTypeUid);
	}

	public ITypeConvertor GetConverterToTargetType(Guid targetTypeUid)
	{
		int num = 1;
		int num2 = num;
		_003C_003Ec__DisplayClass4_0 _003C_003Ec__DisplayClass4_ = default(_003C_003Ec__DisplayClass4_0);
		while (true)
		{
			switch (num2)
			{
			default:
				_003C_003Ec__DisplayClass4_.targetTypeUid = targetTypeUid;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				_003C_003Ec__DisplayClass4_ = new _003C_003Ec__DisplayClass4_0();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return (from res in (from tc in typeConverters
						from uid in tc.TargetTypeUids
						select new { tc, uid }).Where(_003C_003Ec__DisplayClass4_._003CGetConverterToTargetType_003Eb__2)
					select res.tc).FirstOrDefault();
			}
		}
	}

	private IEnumerable<Guid> GetConvertFromTypeUids(Guid targetTypeUid)
	{
		return cachedTargetSelections.GetOrAdd(targetTypeUid, delegate(Guid guid)
		{
			_003C_003Ec__DisplayClass5_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass5_0();
			CS_0024_003C_003E8__locals0.guid = guid;
			return (from tc in typeConverters
				from uid in tc.TargetTypeUids
				select new { tc, uid } into res
				where res.uid == CS_0024_003C_003E8__locals0.guid
				select res).SelectMany(res => res.tc.SourceTypeUids).Distinct().ToList();
		});
	}

	internal static bool rTxf7po5JW1c0TRoN1x2()
	{
		return NwDKufo5MEFxUjyFMEOj == null;
	}

	internal static TypeConverterService UrwRcfo59LLWtPr4MF7L()
	{
		return NwDKufo5MEFxUjyFMEOj;
	}
}
