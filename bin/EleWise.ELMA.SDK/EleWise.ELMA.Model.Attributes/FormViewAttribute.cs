using System;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Attributes;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = true)]
public class FormViewAttribute : Attribute
{
	private readonly string serializedView;

	private FormView view;

	private static FormViewAttribute G6Af4Lov3MWRGE2nTKfa;

	public FormView View
	{
		get
		{
			int num = 1;
			int num2 = num;
			FormView formView = default(FormView);
			FormView formView2;
			while (true)
			{
				switch (num2)
				{
				default:
					formView = (view = DeserializeView(serializedView));
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
					{
						num2 = 2;
					}
					continue;
				case 1:
					formView2 = view;
					if (formView2 == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				case 2:
					formView2 = formView;
					break;
				}
				break;
			}
			return formView2;
		}
	}

	public FormViewAttribute(string serializedView)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		C98602ovDyhco5ykGllb();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
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
				this.serializedView = serializedView;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	private FormView DeserializeView(string serializedView)
	{
		//Discarded unreachable code: IL_0048, IL_0070, IL_00e7, IL_00f6, IL_0127, IL_014b, IL_015a
		FormView formView = default(FormView);
		switch (1)
		{
		case 1:
			try
			{
				formView = ClassSerializationHelper.DeserializeObjectByXml<FormView>(serializedView);
				int num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
				{
					num = 0;
				}
				return num switch
				{
					0 => formView, 
					_ => formView, 
				};
			}
			catch (InvalidOperationException ex)
			{
				Exception ex2 = (Exception)XXThmRovtuBCJOZOPXx2(ex);
				int num2 = 6;
				while (true)
				{
					switch (num2)
					{
					default:
						if (((string)T5Ciweovw5qGTqLeiGCC(ex2)).StartsWith(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-889460160 ^ -889605388), StringComparison.InvariantCulture))
						{
							num2 = 4;
							break;
						}
						goto case 3;
					case 1:
						if (!(ex2 is InvalidOperationException))
						{
							num2 = 5;
							break;
						}
						goto default;
					case 6:
						if (ex2 != null)
						{
							num2 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
							{
								num2 = 1;
							}
							break;
						}
						goto case 3;
					case 4:
						formView = ClassSerializationHelper.DeserializeObjectByXml<FormViewItem>(serializedView);
						num2 = 2;
						break;
					case 3:
					case 5:
						throw;
					case 2:
						return formView;
					}
				}
			}
		default:
			return formView;
		}
	}

	internal static void C98602ovDyhco5ykGllb()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool F9yE7qovpFeQPLO2pSJX()
	{
		return G6Af4Lov3MWRGE2nTKfa == null;
	}

	internal static FormViewAttribute danb9Qova3QsUwGMFlr1()
	{
		return G6Af4Lov3MWRGE2nTKfa;
	}

	internal static object XXThmRovtuBCJOZOPXx2(object P_0)
	{
		return ((Exception)P_0).InnerException;
	}

	internal static object T5Ciweovw5qGTqLeiGCC(object P_0)
	{
		return ((Exception)P_0).Message;
	}
}
