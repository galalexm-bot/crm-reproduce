using System;
using System.IO;
using System.Reflection;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Runtime.Db;

[Component(EnableInterceptiors = false)]
[DeveloperApi(DeveloperApiType.ExtensionPoint)]
public abstract class DbStructureExtension : IDbStructureExtension
{
	private DbStructure structure;

	private ITransformationProvider transformationProvider;

	private static DbStructureExtension CCTXBQWIrxvpyNxyGeO1;

	public abstract Guid ProviderUid { get; }

	public virtual DbStructure Structure
	{
		get
		{
			//Discarded unreachable code: IL_005a, IL_0079, IL_0107, IL_016b, IL_01c4, IL_01fc, IL_020b, IL_0222, IL_0231, IL_0240
			int num = 3;
			int num2 = num;
			Stream stream = default(Stream);
			StreamReader streamReader = default(StreamReader);
			while (true)
			{
				switch (num2)
				{
				case 5:
					try
					{
						if (stream == null)
						{
							goto IL_0087;
						}
						int num3 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
						{
							num3 = 1;
						}
						while (true)
						{
							switch (num3)
							{
							case 2:
								break;
							case 1:
								streamReader = new StreamReader(stream);
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
								{
									num3 = 0;
								}
								continue;
							default:
								try
								{
									string xml = (string)gHM0LSWIUTthtTBWPMtA(streamReader);
									int num4 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
									{
										num4 = 1;
									}
									while (true)
									{
										switch (num4)
										{
										case 1:
											structure = new DbStructure(xml, this);
											num4 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
											{
												num4 = 0;
											}
											continue;
										case 0:
											break;
										}
										break;
									}
								}
								finally
								{
									if (streamReader != null)
									{
										int num5 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
										{
											num5 = 0;
										}
										while (true)
										{
											switch (num5)
											{
											default:
												DwfLs1WIsPRH1entNwvC(streamReader);
												num5 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
												{
													num5 = 1;
												}
												continue;
											case 1:
												break;
											}
											break;
										}
									}
								}
								goto end_IL_005e;
							}
							goto IL_0087;
							continue;
							end_IL_005e:
							break;
						}
						goto end_IL_0039;
						IL_0087:
						throw new InvalidOperationException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1998538950 ^ -1998494310), ResourceFileName, ((Assembly)jeeZr1WIYKs2HvYN5yR5(this)).FullName));
						end_IL_0039:;
					}
					finally
					{
						if (stream != null)
						{
							int num6 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
							{
								num6 = 1;
							}
							while (true)
							{
								switch (num6)
								{
								case 1:
									((IDisposable)stream).Dispose();
									num6 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
									{
										num6 = 0;
									}
									continue;
								case 0:
									break;
								}
								break;
							}
						}
					}
					goto case 1;
				case 1:
				case 2:
					return structure;
				case 3:
					if (structure != null)
					{
						num2 = 2;
						break;
					}
					goto default;
				case 6:
					return null;
				case 4:
					stream = (Stream)cwdo93WILXibA7ysdnSP(jeeZr1WIYKs2HvYN5yR5(this), Qqb4VOWIjJMoYRT83vDp(this));
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
					{
						num2 = 5;
					}
					break;
				default:
					if (Qqb4VOWIjJMoYRT83vDp(this) != null)
					{
						num2 = 4;
						break;
					}
					goto case 6;
				}
			}
		}
	}

	public virtual Version Version => GetType().Assembly.GetName().Version;

	public virtual Type Parent => null;

	public virtual Type[] References => null;

	protected virtual Assembly Assembly => BsTvcIWIcnrRaWup1KDR(this).Assembly;

	protected virtual string ResourceFileName => (string)SrGjffWVFYhsIMOEts9h(BsTvcIWIcnrRaWup1KDR(this).FullName, Idw2SaWIzaseMCaOree1(-1921202237 ^ -1921234547));

	protected ITransformationProvider Transformation
	{
		get
		{
			int num = 1;
			int num2 = num;
			ITransformationProvider obj;
			ITransformationProvider transformationProvider = default(ITransformationProvider);
			while (true)
			{
				switch (num2)
				{
				case 1:
					obj = this.transformationProvider;
					if (obj == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				default:
					transformationProvider = (this.transformationProvider = Locator.GetService<ITransformationProvider>());
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
					{
						num2 = 2;
					}
					continue;
				case 2:
					obj = transformationProvider;
					break;
				}
				break;
			}
			return obj;
		}
	}

	protected DbStructureExtension()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		Xq5ksuWVBjxxjDftu2Pa();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object Qqb4VOWIjJMoYRT83vDp(object P_0)
	{
		return ((DbStructureExtension)P_0).ResourceFileName;
	}

	internal static object jeeZr1WIYKs2HvYN5yR5(object P_0)
	{
		return ((DbStructureExtension)P_0).Assembly;
	}

	internal static object cwdo93WILXibA7ysdnSP(object P_0, object P_1)
	{
		return ((Assembly)P_0).GetManifestResourceStream((string)P_1);
	}

	internal static object gHM0LSWIUTthtTBWPMtA(object P_0)
	{
		return ((TextReader)P_0).ReadToEnd();
	}

	internal static void DwfLs1WIsPRH1entNwvC(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static bool H89oFiWIgFFVRq7e31Pt()
	{
		return CCTXBQWIrxvpyNxyGeO1 == null;
	}

	internal static DbStructureExtension nlN6VOWI56n1IkaqNtsB()
	{
		return CCTXBQWIrxvpyNxyGeO1;
	}

	internal static Type BsTvcIWIcnrRaWup1KDR(object P_0)
	{
		return P_0.GetType();
	}

	internal static object Idw2SaWIzaseMCaOree1(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object SrGjffWVFYhsIMOEts9h(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static void Xq5ksuWVBjxxjDftu2Pa()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
