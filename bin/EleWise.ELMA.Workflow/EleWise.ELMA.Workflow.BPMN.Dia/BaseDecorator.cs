using System;
using System.Collections;
using j3AmrhgkCleVTGdEwA;
using Nevron.Diagram;
using Nevron.Dom;
using Nevron.GraphicsCore;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Shapes.Decorators;

[Serializable]
public abstract class BaseDecorator : PaintableDecorator
{
	internal ArrayList paths;

	internal DecoratorPosition position;

	internal float width;

	internal float height;

	internal float paddingX;

	internal float paddingY;

	private bool needRedefine;

	private NRectangleF? lastShapeBounds;

	private NMatrix2DF? lastTransform;

	private int lastPositionDecoratorsCount;

	private static BaseDecorator rfeLfKOEVaGAI4qyUX6I;

	public DecoratorPosition Position
	{
		get
		{
			return position;
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
					position = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bd84f42638494cb6b4427f8e13ec59af != 0)
					{
						num2 = 0;
					}
					break;
				default:
					needRedefine = true;
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f870ea690334e7ab7599d275d195e9a == 0)
					{
						num2 = 2;
					}
					break;
				case 2:
					return;
				}
			}
		}
	}

	public virtual float Width
	{
		get
		{
			return width;
		}
		set
		{
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					needRedefine = true;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7ed81ca3cf804abbade4684f28f485d1 == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					width = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5537a063960e465db83a04e35eea441b != 0)
					{
						num2 = 1;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	public virtual float Height
	{
		get
		{
			return height;
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
					needRedefine = true;
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d843b0b7f23e489fb6d586d64b0a634a != 0)
					{
						num2 = 2;
					}
					break;
				case 1:
					height = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_fb347e2c5dba4e0ca4d47098be7fd10c == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					return;
				}
			}
		}
	}

	public virtual float PaddingX
	{
		get
		{
			return paddingX;
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
					needRedefine = true;
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_fb347e2c5dba4e0ca4d47098be7fd10c == 0)
					{
						num2 = 1;
					}
					break;
				case 2:
					return;
				case 1:
					paddingX = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ba57b850b1d34fd9bce66a583e71dc16 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public virtual float PaddingY
	{
		get
		{
			return paddingY;
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
					paddingY = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3f8a84e2cb374827a50ba2cbcf11cf48 == 0)
					{
						num2 = 0;
					}
					break;
				default:
					needRedefine = true;
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5816b3723c134946ad9294172266312e != 0)
					{
						num2 = 2;
					}
					break;
				case 2:
					return;
				}
			}
		}
	}

	protected ArrayList Paths => paths;

	public BaseDecorator()
	{
		//Discarded unreachable code: IL_002b, IL_0030
		iFjeGWOE7JSmBE4sgm7O();
		this._002Ector(DecoratorPosition.Center);
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6d48f3b4557a49578bf7f5ef0517e0be != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public BaseDecorator(DecoratorPosition position)
	{
		//Discarded unreachable code: IL_007a, IL_007f
		iFjeGWOE7JSmBE4sgm7O();
		paths = new ArrayList();
		width = 16f;
		height = 16f;
		paddingX = 4f;
		paddingY = 4f;
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d7a51cf2841b436998bf3f4157fb2c9a == 0)
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
				this.position = position;
				num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0262725a60774e44a84fd2b93b79ee8a != 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public override void Paint(NPaintContext context)
	{
		//Discarded unreachable code: IL_00e1, IL_0199, IL_01a7, IL_023a, IL_0297, IL_0350, IL_035f, IL_03a8, IL_03b7, IL_03c2, IL_046d, IL_04ba, IL_04c9
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0434: Unknown result type (might be due to invalid IL or missing references)
		//IL_043b: Expected O, but got Unknown
		int num = 12;
		bool flag = default(bool);
		NShape val = default(NShape);
		bool selected = default(bool);
		NRectangleF bounds = default(NRectangleF);
		IEnumerator enumerator = default(IEnumerator);
		NPathPrimitive primitive = default(NPathPrimitive);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 21:
					flag = sdsRGYOEwYehL8pvmWOv(context, val);
					num2 = 9;
					continue;
				case 16:
					return;
				case 6:
				case 14:
					if (!JLDDsrOESIIRiwW019Xh(((lI11lIII)context).Device))
					{
						num2 = 22;
						continue;
					}
					break;
				case 4:
					selected = cCtGdZOE4YSv9c3XpT3I(context, val);
					num2 = 13;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a2041b18ca1f4a5cb8e5060163bfdb57 == 0)
					{
						num2 = 9;
					}
					continue;
				case 11:
					if (val == null)
					{
						return;
					}
					num2 = 18;
					continue;
				case 1:
					break;
				case 5:
					lastShapeBounds = x48ALQOEoxmM3SaQF807(val);
					num2 = 2;
					continue;
				case 20:
				case 22:
					selected = false;
					num2 = 21;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e4c570270f54493d8f3f4763a72f63f7 != 0)
					{
						num2 = 5;
					}
					continue;
				case 7:
					JnP77pOEx74yv3VqpE2j(this, bounds);
					num2 = 6;
					continue;
				case 3:
					bounds = nkTjxgOENicBs23XUqhR(this);
					num2 = 7;
					continue;
				case 2:
					lastTransform = IB7RjYOEFEBPwgwX5bn8(val);
					num2 = 15;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f236c3d0fade492db73e8204df65377d != 0)
					{
						num2 = 8;
					}
					continue;
				case 8:
					try
					{
						while (true)
						{
							int num5;
							if (!TY40LwOEa9P0G6cK73RR(enumerator))
							{
								num5 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5c45a6e5a4614bfba7591d8a1c7ced1d == 0)
								{
									num5 = 0;
								}
								goto IL_01ab;
							}
							goto IL_01e7;
							IL_01e7:
							((NPathPrimitive)LGF442OEIxtY1iCkSdYl(enumerator)).Dispose();
							num5 = 1;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bb19f93c0a774f6cbdada859bba83212 == 0)
							{
								num5 = 0;
							}
							goto IL_01ab;
							IL_01ab:
							switch (num5)
							{
							case 1:
								continue;
							case 2:
								goto IL_01e7;
							case 0:
								break;
							}
							break;
						}
					}
					finally
					{
						IDisposable disposable = enumerator as IDisposable;
						int num6 = 2;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5d3bc916b5664717ac60544de077bd16 != 0)
						{
							num6 = 2;
						}
						while (true)
						{
							switch (num6)
							{
							case 1:
								DPdPpYOEr7jbNXYxsO9s(disposable);
								num6 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_db8eb3e90ad546d4b05544ab6326a49f != 0)
								{
									num6 = 0;
								}
								continue;
							case 2:
								if (disposable != null)
								{
									num6 = 1;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6dd19c81ff5e41fb8db9b50574437301 == 0)
									{
										num6 = 1;
									}
									continue;
								}
								break;
							case 0:
								break;
							}
							break;
						}
					}
					goto case 10;
				case 13:
					enumerator = paths.GetEnumerator();
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d87d9a74c9e14f96a288cc3620965fe0 == 0)
					{
						num2 = 0;
					}
					continue;
				case 18:
					if (!NeedRedefine())
					{
						num2 = 14;
						continue;
					}
					goto case 5;
				case 10:
					NB3bdcOEeG7cct5gQDJg(paths);
					num2 = 3;
					continue;
				case 12:
					val = (NShape)BMMTAGOE2JctC9sagaZS(this);
					num2 = 5;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d843b0b7f23e489fb6d586d64b0a634a != 0)
					{
						num2 = 11;
					}
					continue;
				case 15:
					needRedefine = false;
					num2 = 17;
					continue;
				case 19:
					hrCM6wOEEECSBXq0rff3(((lI11lIII)context).Device, this);
					num2 = 20;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b74fcd91509d46c3a9661cffb0465df0 != 0)
					{
						num2 = 14;
					}
					continue;
				case 17:
					enumerator = (IEnumerator)Cpuu36OEiABBJWXUvBZG(paths);
					num2 = 8;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a680afde07ce4ae5b71c411a1f75109b != 0)
					{
						num2 = 8;
					}
					continue;
				case 9:
					if (!flag)
					{
						num2 = 4;
						continue;
					}
					goto case 13;
				default:
					try
					{
						while (true)
						{
							int num3;
							if (!TY40LwOEa9P0G6cK73RR(enumerator))
							{
								num3 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f8ecc99a1f4a4b6abc73e9b50261ea83 != 0)
								{
									num3 = 0;
								}
								goto IL_03c6;
							}
							goto IL_042d;
							IL_042d:
							primitive = (NPathPrimitive)LGF442OEIxtY1iCkSdYl(enumerator);
							num3 = 3;
							goto IL_03c6;
							IL_03c6:
							while (true)
							{
								switch (num3)
								{
								default:
									return;
								case 0:
									return;
								case 3:
									PaintPath(context, (NModel)(object)primitive, flag, selected);
									num3 = 2;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a9be7e056b4e4b6e863b634c418144f1 == 0)
									{
										num3 = 0;
									}
									continue;
								case 2:
									break;
								case 1:
									goto IL_042d;
								}
								break;
							}
						}
					}
					finally
					{
						IDisposable disposable = enumerator as IDisposable;
						int num4 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_805f3361d2ba4dac8da4174f89314253 != 0)
						{
							num4 = 0;
						}
						while (true)
						{
							switch (num4)
							{
							default:
								disposable.Dispose();
								num4 = 2;
								continue;
							case 1:
								if (disposable != null)
								{
									num4 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e8c2dcf6eb644089ebbe42243c60e95 != 0)
									{
										num4 = 0;
									}
									continue;
								}
								break;
							case 2:
								break;
							}
							break;
						}
					}
				}
				break;
			}
			vk9uJVOEhrHZ4tJRToHN(((lI11lIII)context).Device, lxiTJHOE1PxfUpbbKV6g(this));
			num = 19;
		}
	}

	public void RecreatePaths(NRectangleF bounds)
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				CreatePaths(bounds);
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1c37d4e24e094858975336738e156495 == 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				paths.Clear();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c559093b7320494babd70d164a6df42d == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			}
		}
	}

	protected void AddPath(NPathPrimitive path)
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
				paths.Add(path);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d42a29e78d4a45518985de3631ade50c != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	protected virtual bool NeedRedefine()
	{
		return NeedRedefine(processPositionDecorators: true);
	}

	internal bool NeedRedefine(bool processPositionDecorators)
	{
		//Discarded unreachable code: IL_00c4, IL_00d3, IL_00e3, IL_018b, IL_01de, IL_01e8, IL_0234, IL_0243, IL_02fa, IL_0343, IL_03a0, IL_03af, IL_03bf
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		int num = 5;
		int num4 = default(int);
		NShape val = default(NShape);
		bool flag = default(bool);
		IEnumerator enumerator = default(IEnumerator);
		BaseDecorator baseDecorator = default(BaseDecorator);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 15:
					return num4 != lastPositionDecoratorsCount;
				case 1:
					return true;
				case 16:
					if (lastShapeBounds.HasValue)
					{
						num2 = 9;
						continue;
					}
					goto case 7;
				case 3:
					return true;
				case 4:
					if (val != null)
					{
						num2 = 2;
						continue;
					}
					goto IL_0070;
				case 10:
					if (flag)
					{
						num2 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2d2252621ae43ad8d38af812176c290 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 15;
				case 14:
					if (!lastTransform.HasValue)
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2d2252621ae43ad8d38af812176c290 != 0)
						{
							num2 = 7;
						}
						continue;
					}
					goto case 11;
				case 9:
					if (lIIJySOEzu9II2XhUc9V(lastShapeBounds.Value, x48ALQOEoxmM3SaQF807(val)))
					{
						num2 = 8;
						continue;
					}
					goto case 14;
				default:
					num4 = 0;
					num = 12;
					break;
				case 11:
					if (!WG6iVHOwKwJMO5vexaTW(lastTransform.Value, IB7RjYOEFEBPwgwX5bn8(val)))
					{
						if (processPositionDecorators)
						{
							num2 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_69cb4a76addb44f28bb765f059e441c7 != 0)
							{
								num2 = 0;
							}
							continue;
						}
						goto IL_0070;
					}
					goto case 7;
				case 2:
					if (!needRedefine)
					{
						num2 = 16;
						continue;
					}
					goto case 7;
				case 5:
					val = (NShape)BMMTAGOE2JctC9sagaZS(this);
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_61395ebf330446ac8ce99b55ee3acfa9 != 0)
					{
						num2 = 4;
					}
					continue;
				case 12:
					flag = false;
					num = 13;
					break;
				case 6:
					try
					{
						while (true)
						{
							int num3;
							if (!TY40LwOEa9P0G6cK73RR(enumerator))
							{
								num3 = 2;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_639c11c7bb65456db9f29c9c42f28bf7 != 0)
								{
									num3 = 0;
								}
								goto IL_01ec;
							}
							goto IL_0274;
							IL_0274:
							baseDecorator = LGF442OEIxtY1iCkSdYl(enumerator) as BaseDecorator;
							num3 = 1;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f276fa9c20d4dd889000f50d886a41e != 0)
							{
								num3 = 1;
							}
							goto IL_01ec;
							IL_01ec:
							while (true)
							{
								switch (num3)
								{
								case 1:
									if (baseDecorator == null)
									{
										num3 = 7;
										continue;
									}
									goto case 8;
								case 4:
								case 7:
									break;
								case 3:
									goto IL_0274;
								case 8:
									if (baseDecorator.Position == Position)
									{
										num3 = 9;
										continue;
									}
									break;
								case 5:
									flag = true;
									num3 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae2bde9e5844c638021cdb56fc01122 == 0)
									{
										num3 = 0;
									}
									continue;
								default:
									num4++;
									num3 = 4;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_978f838cc41a4debb9700ede4b63f820 == 0)
									{
										num3 = 2;
									}
									continue;
								case 9:
									if (!YfVxudOwv08sUUIeDiqZ(baseDecorator, false))
									{
										num3 = 6;
										continue;
									}
									goto case 5;
								case 2:
									goto end_IL_024e;
								}
								break;
							}
							continue;
							end_IL_024e:
							break;
						}
					}
					finally
					{
						IDisposable disposable = enumerator as IDisposable;
						int num5 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_545887e65739480a965b7ddfab7d0632 != 0)
						{
							num5 = 0;
						}
						while (true)
						{
							switch (num5)
							{
							default:
								if (disposable != null)
								{
									num5 = 2;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c559093b7320494babd70d164a6df42d == 0)
									{
										num5 = 2;
									}
									continue;
								}
								break;
							case 2:
								DPdPpYOEr7jbNXYxsO9s(disposable);
								num5 = 1;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3ab79470996d472f815915b21f45aac1 != 0)
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
					goto case 10;
				case 13:
					enumerator = (IEnumerator)pTYcW4OwZm8kpvUeKy9d(c5VIRWOwOt3m3xZgkYqa(val));
					num2 = 6;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f30401a2cff84771be092252e934fede == 0)
					{
						num2 = 5;
					}
					continue;
				case 7:
				case 8:
					{
						num2 = 3;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a27e75af798c48d692c4325f43aa9e6b == 0)
						{
							num2 = 2;
						}
						continue;
					}
					IL_0070:
					return false;
				}
				break;
			}
		}
	}

	protected abstract void CreatePaths(NRectangleF bounds);

	protected virtual NRectangleF GetModelBounds()
	{
		//Discarded unreachable code: IL_0152, IL_0161, IL_0194, IL_01a3, IL_01b4, IL_03a3, IL_03c6, IL_0403, IL_0412, IL_0458, IL_0467, IL_05b6
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_0420: Unknown result type (might be due to invalid IL or missing references)
		//IL_0433: Unknown result type (might be due to invalid IL or missing references)
		//IL_0476: Unknown result type (might be due to invalid IL or missing references)
		//IL_047b: Unknown result type (might be due to invalid IL or missing references)
		//IL_047f: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_0616: Unknown result type (might be due to invalid IL or missing references)
		int num = 9;
		bool flag = default(bool);
		NPointF val = default(NPointF);
		NShape val2 = default(NShape);
		DecoratorPosition decoratorPosition = default(DecoratorPosition);
		float num4 = default(float);
		int num5 = default(int);
		IEnumerator enumerator = default(IEnumerator);
		float num9 = default(float);
		BaseDecorator baseDecorator = default(BaseDecorator);
		int num3 = default(int);
		float num6 = default(float);
		float num7 = default(float);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				NRectangleF val3;
				switch (num2)
				{
				case 13:
					flag = false;
					num2 = 5;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c7fe5d092d804f7e91041fb2338cec1a != 0)
					{
						num2 = 2;
					}
					continue;
				default:
					((NPointF)(ref val))._002Ector(pTwElqOwy5yLo7N1XW2g(val2).X - L0dcGJOw8malS8wBFvTi(this) / 2f, ((NModel)val2).get_StartPoint().Y - Height / 2f);
					num2 = 24;
					continue;
				case 14:
					switch (decoratorPosition)
					{
					case DecoratorPosition.StartModelPoint:
						break;
					default:
						goto IL_00f9;
					case DecoratorPosition.TopLeft:
						goto IL_041c;
					case DecoratorPosition.BottomCenter:
						goto IL_0572;
					}
					goto default;
				case 23:
					num4 = 0f;
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_abfb511163674a3eae959fd60da8f319 != 0)
					{
						num2 = 0;
					}
					continue;
				case 7:
					num5 = 0;
					num = 23;
					break;
				case 5:
					enumerator = ((NDiagramElementCollection)c5VIRWOwOt3m3xZgkYqa(val2)).GetEnumerator();
					num2 = 25;
					continue;
				case 9:
					val2 = (NShape)BMMTAGOE2JctC9sagaZS(this);
					num2 = 8;
					continue;
				case 22:
					num9 = 0f;
					num2 = 16;
					continue;
				case 25:
					try
					{
						while (true)
						{
							int num11;
							if (!enumerator.MoveNext())
							{
								num11 = 9;
								goto IL_01c2;
							}
							goto IL_032d;
							IL_01c2:
							while (true)
							{
								switch (num11)
								{
								case 12:
									flag = true;
									num11 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_32f3e755437f4eacb85c8a0d536f83ea == 0)
									{
										num11 = 0;
									}
									continue;
								case 2:
									if (baseDecorator == this)
									{
										num11 = 12;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7d23dbc0284240b99ff34f0f55f345f6 != 0)
										{
											num11 = 8;
										}
										continue;
									}
									goto default;
								case 8:
									num3++;
									num11 = 4;
									continue;
								default:
									if (baseDecorator != null)
									{
										num11 = 7;
										continue;
									}
									break;
								case 3:
									num4 += L0dcGJOw8malS8wBFvTi(baseDecorator);
									num11 = 10;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6782172e84504a7baf3163b8f6b2a916 != 0)
									{
										num11 = 1;
									}
									continue;
								case 4:
									num9 += L0dcGJOw8malS8wBFvTi(baseDecorator);
									num11 = 6;
									continue;
								case 1:
									break;
								case 7:
									if (CY20fiOwY87PHlA5RkaC(baseDecorator) == Position)
									{
										int num12 = 13;
										num11 = num12;
										continue;
									}
									break;
								case 13:
									if (!flag)
									{
										num11 = 8;
										continue;
									}
									goto case 11;
								case 11:
									num5++;
									num11 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7ed81ca3cf804abbade4684f28f485d1 == 0)
									{
										num11 = 3;
									}
									continue;
								case 6:
									num6 += s7qD9BOws3ObfOa5Mof0(baseDecorator);
									num11 = 6;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1de08766357542bdb81146373079f817 != 0)
									{
										num11 = 11;
									}
									continue;
								case 5:
									goto IL_032d;
								case 10:
									num7 += s7qD9BOws3ObfOa5Mof0(baseDecorator);
									num11 = 1;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4459fbe344a947429d197733d274ef68 == 0)
									{
										num11 = 0;
									}
									continue;
								case 9:
									goto end_IL_02a0;
								}
								break;
							}
							continue;
							IL_032d:
							baseDecorator = LGF442OEIxtY1iCkSdYl(enumerator) as BaseDecorator;
							num11 = 2;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9570b4a70465495fba22c942f586465a == 0)
							{
								num11 = 2;
							}
							goto IL_01c2;
							continue;
							end_IL_02a0:
							break;
						}
					}
					finally
					{
						IDisposable disposable = enumerator as IDisposable;
						int num13 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_be442748c2c44d33a71dd83576ab2ba4 != 0)
						{
							num13 = 0;
						}
						while (true)
						{
							switch (num13)
							{
							case 3:
								goto end_IL_03a7;
							default:
								if (disposable == null)
								{
									num13 = 3;
									continue;
								}
								break;
							case 2:
								break;
							case 1:
								goto end_IL_03a7;
							}
							DPdPpYOEr7jbNXYxsO9s(disposable);
							num13 = 1;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bf623f11574746d6bf3837b66460c576 == 0)
							{
								num13 = 0;
							}
							continue;
							end_IL_03a7:
							break;
						}
					}
					goto case 3;
				case 15:
					goto IL_041c;
				case 12:
				{
					val3 = h2BiBsOwlHewlwDKWL6e(val2);
					float num10 = ((NRectangleF)(ref val3)).get_Center().X - num4 / 2f + num9 + 4f * (float)num3;
					val3 = ((NModel)val2).get_Bounds();
					((NPointF)(ref val))._002Ector(num10, ((NRectangleF)(ref val3)).get_Bottom() - s7qD9BOws3ObfOa5Mof0(this) - MQ55FgOw0WJQQAbZLMKD(this));
					num2 = 21;
					continue;
				}
				case 17:
				case 20:
				{
					val3 = h2BiBsOwlHewlwDKWL6e(val2);
					float num8 = ((NRectangleF)(ref val3)).get_Center().X - L0dcGJOw8malS8wBFvTi(this) / 2f;
					val3 = h2BiBsOwlHewlwDKWL6e(val2);
					((NPointF)(ref val))._002Ector(num8, ((NRectangleF)(ref val3)).get_Center().Y - s7qD9BOws3ObfOa5Mof0(this) / 2f);
					num = 11;
					break;
				}
				case 1:
					num7 = 0f;
					num2 = 15;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_61395ebf330446ac8ce99b55ee3acfa9 != 0)
					{
						num2 = 22;
					}
					continue;
				case 19:
					decoratorPosition = Position;
					num = 14;
					break;
				case 3:
					lastPositionDecoratorsCount = num5;
					num = 19;
					break;
				case 10:
					goto IL_0572;
				case 8:
					if (val2 != null)
					{
						num2 = 15;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cfe7a0ffe67e4fea8e329ae6574ed2ca == 0)
						{
							num2 = 18;
						}
						continue;
					}
					goto case 2;
				case 6:
				case 11:
				case 21:
				case 24:
					return new NRectangleF(val, new NSizeF(L0dcGJOw8malS8wBFvTi(this), s7qD9BOws3ObfOa5Mof0(this)));
				case 16:
					num6 = 0f;
					num2 = 13;
					continue;
				case 2:
					return NRectangleF.Empty;
				case 18:
					if (position == DecoratorPosition.Custom)
					{
						num2 = 4;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58f735bab6d046fe96f749ec2e269a96 == 0)
						{
							num2 = 1;
						}
					}
					else
					{
						num3 = 0;
						num2 = 7;
					}
					continue;
				case 4:
					{
						return NRectangleF.Empty;
					}
					IL_0572:
					num4 += 4f * (float)(num5 - 1);
					num = 12;
					break;
					IL_041c:
					((NPointF)(ref val))._002Ector(((NModel)val2).get_Bounds().X + m6wDB1OwJNS4sNByiOBf(this), h2BiBsOwlHewlwDKWL6e(val2).Y + MQ55FgOw0WJQQAbZLMKD(this));
					num2 = 6;
					continue;
					IL_00f9:
					num2 = 20;
					continue;
				}
				break;
			}
		}
	}

	internal static void iFjeGWOE7JSmBE4sgm7O()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static bool BxfvaDOEAq53JE3opWM3()
	{
		return rfeLfKOEVaGAI4qyUX6I == null;
	}

	internal static BaseDecorator TQUCTqOEGdvyV2TA1XVE()
	{
		return rfeLfKOEVaGAI4qyUX6I;
	}

	internal static object BMMTAGOE2JctC9sagaZS(object P_0)
	{
		return ((NDecorator)P_0).get_Shape();
	}

	internal static NRectangleF x48ALQOEoxmM3SaQF807(object P_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((NModel)P_0).get_ModelBounds();
	}

	internal static NMatrix2DF IB7RjYOEFEBPwgwX5bn8(object P_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((NTransformableElement)P_0).get_Transform();
	}

	internal static object Cpuu36OEiABBJWXUvBZG(object P_0)
	{
		return ((ArrayList)P_0).GetEnumerator();
	}

	internal static object LGF442OEIxtY1iCkSdYl(object P_0)
	{
		return ((IEnumerator)P_0).Current;
	}

	internal static bool TY40LwOEa9P0G6cK73RR(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void DPdPpYOEr7jbNXYxsO9s(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static void NB3bdcOEeG7cct5gQDJg(object P_0)
	{
		((ArrayList)P_0).Clear();
	}

	internal static NRectangleF nkTjxgOENicBs23XUqhR(object P_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((BaseDecorator)P_0).GetModelBounds();
	}

	internal static void JnP77pOEx74yv3VqpE2j(object P_0, NRectangleF bounds)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((BaseDecorator)P_0).CreatePaths(bounds);
	}

	internal static bool JLDDsrOESIIRiwW019Xh(object P_0)
	{
		return ((INDevice)P_0).get_RequiresInteractivity();
	}

	internal static object lxiTJHOE1PxfUpbbKV6g(object P_0)
	{
		return ((NStyleComposerElement)P_0).ComposeInteractivityStyle();
	}

	internal static void vk9uJVOEhrHZ4tJRToHN(object P_0, object P_1)
	{
		((INDevice)P_0).ActivateInteractivityStyle((NInteractivityStyle)P_1);
	}

	internal static void hrCM6wOEEECSBXq0rff3(object P_0, object P_1)
	{
		((INDevice)P_0).ActivateElement((INElement)P_1);
	}

	internal static bool sdsRGYOEwYehL8pvmWOv(object P_0, object P_1)
	{
		return ((NPaintContext)P_0).MustDisplayNodeAsHighlighted((INNode)P_1);
	}

	internal static bool cCtGdZOE4YSv9c3XpT3I(object P_0, object P_1)
	{
		return ((NPaintContext)P_0).MustDisplayNodeAsSelected((INNode)P_1);
	}

	internal static bool lIIJySOEzu9II2XhUc9V(NRectangleF P_0, NRectangleF P_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		return P_0 != P_1;
	}

	internal static bool WG6iVHOwKwJMO5vexaTW(NMatrix2DF P_0, NMatrix2DF P_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		return P_0 != P_1;
	}

	internal static object c5VIRWOwOt3m3xZgkYqa(object P_0)
	{
		return ((NShape)P_0).get_Decorators();
	}

	internal static object pTYcW4OwZm8kpvUeKy9d(object P_0)
	{
		return ((NDiagramElementCollection)P_0).GetEnumerator();
	}

	internal static bool YfVxudOwv08sUUIeDiqZ(object P_0, bool processPositionDecorators)
	{
		return ((BaseDecorator)P_0).NeedRedefine(processPositionDecorators);
	}

	internal static DecoratorPosition CY20fiOwY87PHlA5RkaC(object P_0)
	{
		return ((BaseDecorator)P_0).Position;
	}

	internal static float L0dcGJOw8malS8wBFvTi(object P_0)
	{
		return ((BaseDecorator)P_0).Width;
	}

	internal static float s7qD9BOws3ObfOa5Mof0(object P_0)
	{
		return ((BaseDecorator)P_0).Height;
	}

	internal static float m6wDB1OwJNS4sNByiOBf(object P_0)
	{
		return ((BaseDecorator)P_0).PaddingX;
	}

	internal static NRectangleF h2BiBsOwlHewlwDKWL6e(object P_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((NModel)P_0).get_Bounds();
	}

	internal static float MQ55FgOw0WJQQAbZLMKD(object P_0)
	{
		return ((BaseDecorator)P_0).PaddingY;
	}

	internal static NPointF pTwElqOwy5yLo7N1XW2g(object P_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((NModel)P_0).get_StartPoint();
	}
}
