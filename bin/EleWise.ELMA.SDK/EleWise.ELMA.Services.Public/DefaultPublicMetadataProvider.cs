using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Common;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Services.Public;

[Component(EnableInterceptiors = false)]
internal class DefaultPublicMetadataProvider : IPublicMetadataProvider
{
	private class PublicMetadataInfo : IPublicMetadataInfo
	{
		private object _metadata;

		internal static object x3mJDsQnRFKIVcV1P2GP;

		public Guid Uid => s7uqfTQnXrtaxnF70Xfp(_metadata);

		public Guid GroupUid => Guid.Empty;

		public string Name => ((NamedMetadata)_metadata).Name;

		public string DisplayName => (string)gDi9yAQnTLA89JJ92iVj((NamedMetadata)_metadata);

		public PublicMetadataInfo(IMetadata metadata)
		{
			//Discarded unreachable code: IL_002a, IL_002f, IL_00aa, IL_00b9
			SingletonReader.JJCZtPuTvSt();
			base._002Ector();
			int num = 2;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
			{
				num = 2;
			}
			while (true)
			{
				switch (num)
				{
				default:
					throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x31326106 ^ 0x31322838));
				case 3:
					_metadata = metadata;
					num = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
					{
						num = 0;
					}
					break;
				case 2:
					if (metadata != null)
					{
						num = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
						{
							num = 0;
						}
						break;
					}
					goto default;
				case 1:
					return;
				}
			}
		}

		public IMetadata GetMetadata()
		{
			return MetadataLoader.LoadMetadata(((IMetadata)_metadata).Uid, inherit: true, loadImplementation: false);
		}

		public void ProcessPropertyDescriptor(IPropertyMetadata propMetadata, TypeSerializationItemDescriptor propDescriptor)
		{
		}

		internal static bool VT7ZjDQnq2diIxVr8K9q()
		{
			return x3mJDsQnRFKIVcV1P2GP == null;
		}

		internal static PublicMetadataInfo oSrY6UQnKgFe23OhcKQx()
		{
			return (PublicMetadataInfo)x3mJDsQnRFKIVcV1P2GP;
		}

		internal static Guid s7uqfTQnXrtaxnF70Xfp(object P_0)
		{
			return ((IMetadata)P_0).Uid;
		}

		internal static object gDi9yAQnTLA89JJ92iVj(object P_0)
		{
			return ((NamedMetadata)P_0).DisplayName;
		}
	}

	private IMetadataRuntimeService _metadataRuntimeService;

	private IEnumerable<IPublicMetadataFilter> _filters;

	public DefaultPublicMetadataProvider(IMetadataRuntimeService metadataRuntimeService, IEnumerable<IPublicMetadataFilter> filters)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		if (metadataRuntimeService == null)
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1858887263 ^ -1858944995));
		}
		if (filters == null)
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1751176224 ^ -1751234036));
		}
		_metadataRuntimeService = metadataRuntimeService;
		_filters = filters;
	}

	public IEnumerable<IPublicMetadataInfo> GetMetadataInfoList()
	{
		return (from m in (from m in _metadataRuntimeService.GetMetadataList().Where(FilterMetadata)
				select MetadataLoader.LoadMetadata(_003C_003Ec.JwZXYeQnexBExG2kkVLm(m), inherit: false, loadImplementation: false)).ToArray()
			select new PublicMetadataInfo(m)).ToArray();
	}

	public IEnumerable<IPublicMetadataGroupInfo> GetGroups()
	{
		return new IPublicMetadataGroupInfo[0];
	}

	private bool FilterMetadata<T>(T metadata) where T : IMetadata
	{
		_003C_003Ec__DisplayClass6_0<T> CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass6_0<T>();
		CS_0024_003C_003E8__locals0.metadata = metadata;
		return _filters.All(delegate(IPublicMetadataFilter f)
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (f.Filter == null)
					{
						return false;
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
					{
						num2 = 0;
					}
					break;
				default:
					return f.Filter(CS_0024_003C_003E8__locals0.metadata);
				}
			}
		});
	}
}
