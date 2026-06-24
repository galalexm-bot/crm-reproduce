using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using EleWise.ELMA.API;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.CodeGeneration.PublicApi;

public class PublicApiPropertyClassNode : IPublicApiNode
{
	protected readonly string fieldName;

	protected readonly bool hideProperty;

	protected readonly bool obsoleteProperty;

	protected readonly string obsoleteMessage;

	internal static PublicApiPropertyClassNode QNhPYqhAwiVTWGaul8pL;

	public string ParentPath
	{
		[CompilerGenerated]
		get
		{
			return _003CParentPath_003Ek__BackingField;
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
				case 1:
					_003CParentPath_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	public string Path => ParentPath + (string)p1fvPBhAAi8NON3e6ToY(0x57A5235E ^ 0x57A5399A) + PropertyName;

	public string ClassName
	{
		[CompilerGenerated]
		get
		{
			return _003CClassName_003Ek__BackingField;
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
				case 1:
					_003CClassName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	public string PropertyName
	{
		[CompilerGenerated]
		get
		{
			return _003CPropertyName_003Ek__BackingField;
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
					_003CPropertyName_003Ek__BackingField = value;
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

	public virtual string Description
	{
		[CompilerGenerated]
		get
		{
			return _003CDescription_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					_003CDescription_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	public virtual string Remarks
	{
		[CompilerGenerated]
		get
		{
			return _003CRemarks_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					_003CRemarks_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	public virtual string Code
	{
		[CompilerGenerated]
		get
		{
			return _003CCode_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
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
					_003CCode_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	internal EntityMetadata EntityMetadata { get; }

	public PublicApiPropertyClassNode(string parentPath, string className, string propertyName)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		Pg8fVfhAH6rs6QkTsWd5();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
		{
			num = 3;
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				PropertyName = propertyName;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
				{
					num = 0;
				}
				break;
			case 3:
				ParentPath = parentPath;
				num = 5;
				break;
			case 5:
				ClassName = className;
				num = 2;
				break;
			case 1:
				((PublicApiCodeGenerator)q75kndhA7JvbQStDZ0ua()).AddPropertyClassNode(ClassName, Path);
				num = 4;
				break;
			case 4:
				return;
			default:
				fieldName = (string)p1fvPBhAAi8NON3e6ToY(-643786247 ^ -643622053) + propertyName;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
				{
					num = 1;
				}
				break;
			}
		}
	}

	public PublicApiPropertyClassNode(string parentPath, string className, string propertyName, bool hideProperty)
	{
		//Discarded unreachable code: IL_002d, IL_0032
		SingletonReader.JJCZtPuTvSt();
		this._002Ector(parentPath, className, propertyName);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
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
			this.hideProperty = hideProperty;
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
			{
				num = 1;
			}
		}
	}

	public PublicApiPropertyClassNode(string parentPath, string className, string propertyName, string obsoleteMessage)
	{
		//Discarded unreachable code: IL_002e, IL_0033
		Pg8fVfhAH6rs6QkTsWd5();
		this._002Ector(parentPath, className, propertyName, hideProperty: true);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				obsoleteProperty = true;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
				{
					num = 0;
				}
				break;
			case 1:
				this.obsoleteMessage = obsoleteMessage;
				num = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
				{
					num = 2;
				}
				break;
			case 2:
				return;
			}
		}
	}

	protected PublicApiPropertyClassNode(string parentPath, string className, string propertyName, string typeName, bool hideProperty, bool registerPath = true)
	{
		//Discarded unreachable code: IL_002f, IL_0034, IL_00a7, IL_00b6
		Pg8fVfhAH6rs6QkTsWd5();
		this._002Ector(parentPath, className, propertyName, hideProperty);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			case 3:
				return;
			default:
				if (!registerPath)
				{
					num = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
					{
						num = 3;
					}
					continue;
				}
				break;
			case 2:
				break;
			}
			Y8xSJrhAxObGQQJbY2Wq(q75kndhA7JvbQStDZ0ua(), typeName, Path, hideProperty);
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
			{
				num = 1;
			}
		}
	}

	private PublicApiPropertyClassNode(string parentPath, string className, string propertyName, string typeName, string obsoleteMessage)
	{
		//Discarded unreachable code: IL_002f, IL_0034
		SingletonReader.JJCZtPuTvSt();
		this._002Ector(parentPath, className, propertyName, obsoleteMessage);
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				Y8xSJrhAxObGQQJbY2Wq(q75kndhA7JvbQStDZ0ua(), typeName, Path, true);
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	private static string GetPropertyName(Type type)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (YPf3xlhAmAF8tglVSdnv(faRicRhA0hWGbOJ8YYys(type), 0) != 'I')
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
					{
						num2 = 0;
					}
					break;
				}
				return (string)syx2LbhAy16p4NyPOe4S(faRicRhA0hWGbOJ8YYys(type), 1);
			default:
				return (string)faRicRhA0hWGbOJ8YYys(type);
			case 2:
				if (type.IsInterface)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			}
		}
	}

	private static string GetPropertyName(object metadata)
	{
		return (string)D81e8ZhAMHCTLm3j6ZEL(metadata);
	}

	internal static string GetTypeName(Type type)
	{
		int num = 2;
		int num2 = num;
		object obj;
		while (true)
		{
			switch (num2)
			{
			case 3:
				obj = type.FullName;
				if (obj == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			case 1:
				if (YPf3xlhAmAF8tglVSdnv(type.Name, 0) != 'I')
				{
					num2 = 3;
					continue;
				}
				obj = NvLjQZhAJjRR4op9xZjm(type.Namespace, p1fvPBhAAi8NON3e6ToY(0x637E299B ^ 0x637E335F), syx2LbhAy16p4NyPOe4S(faRicRhA0hWGbOJ8YYys(type), 1));
				break;
			case 2:
				if (type.IsInterface)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto case 3;
			default:
				return (string)NvLjQZhAJjRR4op9xZjm(type.Namespace, p1fvPBhAAi8NON3e6ToY(-1217523399 ^ -1217524739), faRicRhA0hWGbOJ8YYys(type));
			}
			break;
		}
		return (string)obj;
	}

	internal static string GetTypeName(EntityMetadata metadata)
	{
		//Discarded unreachable code: IL_0086, IL_0095
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return (string)NvLjQZhAJjRR4op9xZjm(yRFvDChA9qXDdLRF1i3b(metadata), p1fvPBhAAi8NON3e6ToY(0x92F12D5 ^ 0x92F0811), D81e8ZhAMHCTLm3j6ZEL(metadata));
			case 1:
				return (string)D81e8ZhAMHCTLm3j6ZEL(metadata);
			case 2:
				if (AyRPIPhAdkegK0SWEVQy(yRFvDChA9qXDdLRF1i3b(metadata)))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			}
		}
	}

	public PublicApiPropertyClassNode(string parentPath, string className, Type type)
	{
		//Discarded unreachable code: IL_0035, IL_003a
		Pg8fVfhAH6rs6QkTsWd5();
		this._002Ector(parentPath, className, (string)oYxyRVhAlpoOCoGEQZKm(type), type);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public PublicApiPropertyClassNode(string parentPath, string className, Type type, bool hideProperty)
	{
		//Discarded unreachable code: IL_0036, IL_003b
		SingletonReader.JJCZtPuTvSt();
		this._002Ector(parentPath, className, (string)oYxyRVhAlpoOCoGEQZKm(type), type, hideProperty);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public PublicApiPropertyClassNode(string parentPath, string className, string propertyName, Type type, bool hideProperty = false, bool registerPath = true)
	{
		//Discarded unreachable code: IL_0038, IL_003d
		SingletonReader.JJCZtPuTvSt();
		this._002Ector(parentPath, className, propertyName, (string)aDO1EShArdZTh9XGZ0Gu(type), hideProperty, registerPath);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				EntityMetadata = MetadataLoader.LoadMetadata(type) as EntityMetadata;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public PublicApiPropertyClassNode(string parentPath, string className, Type type, string obsoleteMessage)
	{
		//Discarded unreachable code: IL_003a, IL_003f
		Pg8fVfhAH6rs6QkTsWd5();
		this._002Ector(parentPath, className, (string)oYxyRVhAlpoOCoGEQZKm(type), (string)aDO1EShArdZTh9XGZ0Gu(type), obsoleteMessage);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
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
			EntityMetadata = MetadataLoader.LoadMetadata(type) as EntityMetadata;
			num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
			{
				num = 1;
			}
		}
	}

	public PublicApiPropertyClassNode(string parentPath, string className, EntityMetadata metadata)
	{
		//Discarded unreachable code: IL_0033, IL_0038
		Pg8fVfhAH6rs6QkTsWd5();
		this._002Ector(parentPath, className, GetPropertyName(metadata), metadata);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public PublicApiPropertyClassNode(string parentPath, string className, EntityMetadata metadata, bool hideProperty, bool registerPath = true)
	{
		//Discarded unreachable code: IL_003c, IL_0041
		Pg8fVfhAH6rs6QkTsWd5();
		this._002Ector(parentPath, className, (string)dntLdehAgFUpGCQ29twp(metadata), (string)cQuWGMhA5Yct8OIKWKBS(metadata), hideProperty, registerPath);
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				EntityMetadata = metadata;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public PublicApiPropertyClassNode(string parentPath, string className, string propertyName, EntityMetadata metadata)
	{
		//Discarded unreachable code: IL_0036, IL_003b
		Pg8fVfhAH6rs6QkTsWd5();
		this._002Ector(parentPath, className, propertyName, (string)cQuWGMhA5Yct8OIKWKBS(metadata), hideProperty: false);
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				EntityMetadata = metadata;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public PublicApiPropertyClassNode(string parentPath, string className, string propertyName, EntityMetadata metadata, bool hideProperty, bool registerPath = true)
	{
		//Discarded unreachable code: IL_0038, IL_003d
		SingletonReader.JJCZtPuTvSt();
		this._002Ector(parentPath, className, propertyName, GetTypeName(metadata), hideProperty, registerPath);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
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
			EntityMetadata = metadata;
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
			{
				num = 1;
			}
		}
	}

	public IEnumerable<ISyntaxNode> Generate(IDictionary<string, IEnumerable<IPublicApiNode>> tree)
	{
		ISyntaxNode syntaxNode = PropertyResultClass(tree);
		if (syntaxNode != null)
		{
			return Property(tree).Concat(syntaxNode);
		}
		return Enumerable.Empty<ISyntaxNode>();
	}

	[IteratorStateMachine(typeof(_003CProperty_003Ed__51))]
	protected virtual IEnumerable<ISyntaxNode> Property(IDictionary<string, IEnumerable<IPublicApiNode>> tree)
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CProperty_003Ed__51(-2)
		{
			_003C_003E4__this = this
		};
	}

	protected virtual ISyntaxNode PropertyResultClass(IDictionary<string, IEnumerable<IPublicApiNode>> tree)
	{
		_003C_003Ec__DisplayClass52_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass52_0();
		CS_0024_003C_003E8__locals0.tree = tree;
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		return PublicApiCodeGenerator.Current.UseHiddenProperty(hideProperty, delegate
		{
			int num = 1;
			int num2 = num;
			ISyntaxNode[] array = default(ISyntaxNode[]);
			while (true)
			{
				switch (num2)
				{
				default:
					if (array.Length == 0)
					{
						return null;
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
					{
						num2 = 2;
					}
					break;
				case 2:
					return CS_0024_003C_003E8__locals0._003C_003E4__this.ClassName.ClassDeclaration(Accessibility.Public, DeclarationModifiers.None, null, null, array).MakeClassHide();
				case 1:
					array = CS_0024_003C_003E8__locals0.tree[CS_0024_003C_003E8__locals0._003C_003E4__this.Path].SelectMany((IPublicApiNode n) => n.Generate(CS_0024_003C_003E8__locals0.tree)).ToArray();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		});
	}

	internal static void Pg8fVfhAH6rs6QkTsWd5()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object p1fvPBhAAi8NON3e6ToY(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object q75kndhA7JvbQStDZ0ua()
	{
		return PublicApiCodeGenerator.Current;
	}

	internal static bool xXDUZOhA4UySXTnGBwrP()
	{
		return QNhPYqhAwiVTWGaul8pL == null;
	}

	internal static PublicApiPropertyClassNode YNnTvuhA68TUbQtFBoIC()
	{
		return QNhPYqhAwiVTWGaul8pL;
	}

	internal static void Y8xSJrhAxObGQQJbY2Wq(object P_0, object P_1, object P_2, bool hidden)
	{
		((PublicApiCodeGenerator)P_0).AddPropertyTypeNode((string)P_1, (string)P_2, hidden);
	}

	internal static object faRicRhA0hWGbOJ8YYys(object P_0)
	{
		return ((MemberInfo)P_0).Name;
	}

	internal static char YPf3xlhAmAF8tglVSdnv(object P_0, int P_1)
	{
		return ((string)P_0)[P_1];
	}

	internal static object syx2LbhAy16p4NyPOe4S(object P_0, int P_1)
	{
		return ((string)P_0).Substring(P_1);
	}

	internal static object D81e8ZhAMHCTLm3j6ZEL(object P_0)
	{
		return ((NamedMetadata)P_0).Name;
	}

	internal static object NvLjQZhAJjRR4op9xZjm(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	internal static object yRFvDChA9qXDdLRF1i3b(object P_0)
	{
		return ((ClassMetadata)P_0).Namespace;
	}

	internal static bool AyRPIPhAdkegK0SWEVQy(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object oYxyRVhAlpoOCoGEQZKm(Type type)
	{
		return GetPropertyName(type);
	}

	internal static object aDO1EShArdZTh9XGZ0Gu(Type type)
	{
		return GetTypeName(type);
	}

	internal static object dntLdehAgFUpGCQ29twp(object P_0)
	{
		return GetPropertyName(P_0);
	}

	internal static object cQuWGMhA5Yct8OIKWKBS(object P_0)
	{
		return GetTypeName((EntityMetadata)P_0);
	}
}
