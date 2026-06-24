using System;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.UI.Descriptors;
using EleWise.ELMA.UI.Results;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.UI.Models;

public abstract class FormViewModel<TContext> : IFormViewModel where TContext : IEntity
{
	internal IFormPartDescriptor _descriptor;

	private FormViewItem _view;

	internal static object M6AKpYBoD1WIgBZe5KYZ;

	public string Header
	{
		[CompilerGenerated]
		get
		{
			return _003CHeader_003Ek__BackingField;
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
					_003CHeader_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
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

	public TContext Context { get; private set; }

	public FormViewBuilder<TContext> Form { get; protected set; }

	IEntity IFormViewModel.Context
	{
		get
		{
			return Context;
		}
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
					Context = (TContext)value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
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

	FormViewItem IFormViewModel.View
	{
		get
		{
			return View;
		}
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
					View = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
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

	IFormPartDescriptor IFormViewModel.Descriptor => _descriptor;

	FormResult IFormViewModel.Result => Result;

	protected virtual FormViewItem View
	{
		get
		{
			return _view;
		}
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					_view = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					return;
				default:
					Form = ((value != null) ? new FormViewBuilder<TContext>(value, _descriptor.Metadata.Context, PropertyContainer) : null);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
					{
						num2 = 2;
					}
					break;
				}
			}
		}
	}

	protected FormResult Result
	{
		[CompilerGenerated]
		get
		{
			return _003CResult_003Ek__BackingField;
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
					_003CResult_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
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

	protected IFormPartDescriptor Descriptor => _descriptor;

	protected PropertyViewInfoContainer PropertyContainer { get; }

	public FormViewModel(IFormPartDescriptor descriptor)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		SingletonReader.JJCZtPuTvSt();
		this._002Ector(descriptor, (PropertyViewInfoContainer)null);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public FormViewModel(IFormPartDescriptor descriptor, PropertyViewInfoContainer propertyContainer)
	{
		//Discarded unreachable code: IL_001e
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 5:
				Header = descriptor.FormDescriptor.Metadata.DisplayName;
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
				{
					num2 = 6;
				}
				break;
			case 6:
				Context = (TContext)Activator.CreateInstance(_descriptor.ContextType);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
				{
					num2 = 2;
				}
				break;
			case 3:
				Contract.ArgumentNotNull(descriptor, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2107978722 ^ -2107982124));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				View = ClassSerializationHelper.CloneObjectByXml(descriptor.Metadata.View);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				_descriptor = descriptor;
				num2 = 5;
				break;
			case 0:
				return;
			case 2:
				PropertyContainer = propertyContainer;
				num2 = 4;
				break;
			}
		}
	}

	public FormViewModel(IFormPartDescriptor descriptor, TContext context, FormViewItem view)
	{
		SingletonReader.JJCZtPuTvSt();
		this._002Ector(descriptor, context, view, (PropertyViewInfoContainer)null);
	}

	public FormViewModel(IFormPartDescriptor descriptor, TContext context, FormViewItem view, PropertyViewInfoContainer propertyContainer)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		Contract.ArgumentNotNull(descriptor, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1822890472 ^ -1822911278));
		Contract.ArgumentNotNull(context, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x42643203 ^ 0x42647615));
		Contract.ArgumentNotNull(view, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1146510045 ^ -1146531935));
		_descriptor = descriptor;
		Header = descriptor.FormDescriptor.Metadata.DisplayName;
		Context = context;
		PropertyContainer = propertyContainer;
		View = view;
	}

	internal static bool PpPdIYBotkVCamQG7QKB()
	{
		return M6AKpYBoD1WIgBZe5KYZ == null;
	}

	internal static object MDgOo2BowAw2oHGVt6b6()
	{
		return M6AKpYBoD1WIgBZe5KYZ;
	}
}
