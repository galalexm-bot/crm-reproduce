using System;
using System.Runtime.CompilerServices;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.UI.Metadata;
using EleWise.ELMA.UI.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.UI.Descriptors;

public class PageDescriptor : FormDescriptor
{
	[Component]
	public class Info : IFormDescriptorInfo
	{
		private static Info kkBHOlfgcUWFPbba07Sq;

		public Type MetadataType => mGEV8If5BTh3vwh5m4Dj(typeof(PageMetadata).TypeHandle);

		public Type DescriptorType => typeof(PageDescriptor);

		public Info()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			lq94oEf5W3OobG1BGAW4();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static Type mGEV8If5BTh3vwh5m4Dj(RuntimeTypeHandle P_0)
		{
			return Type.GetTypeFromHandle(P_0);
		}

		internal static void lq94oEf5W3OobG1BGAW4()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static bool y2qYolfgzks6MGwpgCtL()
		{
			return kkBHOlfgcUWFPbba07Sq == null;
		}

		internal static Info QKWHrof5FU1v9gbO0gbN()
		{
			return kkBHOlfgcUWFPbba07Sq;
		}
	}

	private static PageDescriptor jTrjRaJEMdTxuFAevUE;

	public PageContentDescriptor Content
	{
		[CompilerGenerated]
		get
		{
			return _003CContent_003Ek__BackingField;
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
					_003CContent_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
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

	public PageDescriptor(IFormMetadataItem item)
	{
		//Discarded unreachable code: IL_002b, IL_0030
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(item);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
		{
			num = 0;
		}
		PageMetadata pageMetadata = default(PageMetadata);
		while (true)
		{
			switch (num)
			{
			case 3:
				Content = new PageContentDescriptor(this, pageMetadata.Content);
				num = 2;
				continue;
			case 1:
				pageMetadata = (PageMetadata)MqMIQKJ8dwm1je9CcIy(item);
				num = 3;
				continue;
			case 2:
				return;
			}
			XV9Jv8JvoFyd75bw3fT(item.Metadata is PageMetadata, asy0RgJCx0k5rtK19cO(-643786247 ^ -643811917));
			num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
			{
				num = 1;
			}
		}
	}

	internal static object asy0RgJCx0k5rtK19cO(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void XV9Jv8JvoFyd75bw3fT(bool condition, object P_1)
	{
		Contract.CheckArgument(condition, (string)P_1);
	}

	internal static object MqMIQKJ8dwm1je9CcIy(object P_0)
	{
		return ((IFormMetadataItem)P_0).Metadata;
	}

	internal static bool C3MOpUJfj4oLjT2nc3H()
	{
		return jTrjRaJEMdTxuFAevUE == null;
	}

	internal static PageDescriptor MJCjZqJQxHewg4DvQ3i()
	{
		return jTrjRaJEMdTxuFAevUE;
	}
}
