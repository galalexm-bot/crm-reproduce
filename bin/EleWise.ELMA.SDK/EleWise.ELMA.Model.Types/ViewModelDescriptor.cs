using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.DataClasses;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Types;

[Component(Order = int.MaxValue)]
public sealed class ViewModelDescriptor : DataClassDescriptor
{
	private new static readonly Guid UID;

	private IEnumerable<IViewModelDescriptorExtension> handlers;

	private static ViewModelDescriptor xfHTJro4xu2r1eGDtpey;

	private IEnumerable<IViewModelDescriptorExtension> Handlers => handlers ?? (handlers = Locator.GetServiceNotNull<IEnumerable<IViewModelDescriptorExtension>>());

	public override Guid Uid => UID;

	public override string Name => (string)RNs8TFo4y5e6Nph7wXVk(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-35995181 ^ -36127897));

	public override bool Visible => false;

	internal override DataClass.ValueContainer GetValueContainer(string typeRef)
	{
		int num = 4;
		IViewModelDescriptorExtension viewModelDescriptorExtension = default(IViewModelDescriptorExtension);
		_003C_003Ec__DisplayClass11_0 _003C_003Ec__DisplayClass11_ = default(_003C_003Ec__DisplayClass11_0);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					viewModelDescriptorExtension = Handlers.FirstOrDefault(_003C_003Ec__DisplayClass11_._003CGetValueContainer_003Eb__0);
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
					{
						num2 = 2;
					}
					continue;
				case 5:
					return base.GetValueContainer(_003C_003Ec__DisplayClass11_.typeRef);
				case 2:
					if (viewModelDescriptorExtension == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
						{
							num2 = 0;
						}
					}
					else
					{
						if (viewModelDescriptorExtension.GetMetadata(_003C_003Ec__DisplayClass11_.typeRef) is EntityMetadata entityMetadata)
						{
							return DataClass.ValueContainer.CreateViewModelValueContainer(entityMetadata);
						}
						num2 = 5;
					}
					continue;
				case 4:
					break;
				case 3:
					_003C_003Ec__DisplayClass11_.typeRef = typeRef;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
					{
						num2 = 1;
					}
					continue;
				default:
					return base.GetValueContainer(_003C_003Ec__DisplayClass11_.typeRef);
				}
				break;
			}
			_003C_003Ec__DisplayClass11_ = new _003C_003Ec__DisplayClass11_0();
			num = 3;
		}
	}

	public ViewModelDescriptor()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		fdevoCo4MuOkPIPvVAF1();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static ViewModelDescriptor()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				SingletonReader.JJCZtPuTvSt();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				UID = new Guid((string)npEY1Po4JOD0kYpI0j46(0x1A33FE36 ^ 0x1A3184DC));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				return;
			}
		}
	}

	internal static object RNs8TFo4y5e6Nph7wXVk(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static bool lcCKdLo408AKnnKxedUu()
	{
		return xfHTJro4xu2r1eGDtpey == null;
	}

	internal static ViewModelDescriptor laqv9Xo4mbbH6P4ZNHkw()
	{
		return xfHTJro4xu2r1eGDtpey;
	}

	internal static void fdevoCo4MuOkPIPvVAF1()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object npEY1Po4JOD0kYpI0j46(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}
}
