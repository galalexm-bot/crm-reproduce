using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using EleWise.ELMA.IO;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Memory;

public static class MemoryStreamExtensions
{
	private sealed class NoCloseMemoryStream : MemoryStream
	{
		private readonly object memoryStream;

		internal static object cmo2MBQRp20vRRBXA9WH;

		public override bool CanRead => IaBWihQRtKJ9oAjI5gYP(memoryStream);

		public override bool CanSeek => ((Stream)memoryStream).CanSeek;

		public override bool CanWrite => ((Stream)memoryStream).CanWrite;

		public override int Capacity
		{
			get
			{
				return eVcOAoQRwbYUlFqvIMlK(memoryStream);
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
						((MemoryStream)memoryStream).Capacity = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
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

		public override long Length => Uk05cvQR4LXYyKbMA6Nn(memoryStream);

		public override long Position
		{
			get
			{
				return zKqXO4QR6hP1YAFuS2RT(memoryStream);
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
					case 0:
						return;
					case 1:
						((Stream)memoryStream).Position = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public override bool CanTimeout => Qk199lQRHRkEaxmjPsEX(memoryStream);

		public override int ReadTimeout
		{
			get
			{
				return eOVswLQRAXun0m1jaFSg(memoryStream);
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
					case 0:
						return;
					case 1:
						xCR2HKQR7VR6pmYgplq2(memoryStream, value);
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public override int WriteTimeout
		{
			get
			{
				return OiUnuhQRxtugJYIJ98Y8(memoryStream);
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
					case 0:
						return;
					case 1:
						Ki6o6TQR00cbXq4VxZhc(memoryStream, value);
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public NoCloseMemoryStream(MemoryStream memoryStream)
		{
			//Discarded unreachable code: IL_002a, IL_002f
			SingletonReader.JJCZtPuTvSt();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
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
				this.memoryStream = memoryStream;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
				{
					num = 0;
				}
			}
		}

		public override void Flush()
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
					XCh1hHQRmdpbvvGf2UQ9(memoryStream);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}

		public override Task FlushAsync(CancellationToken cancellationToken)
		{
			return (Task)x1YdSuQRyynTxcuy4uxF(memoryStream, cancellationToken);
		}

		public override byte[] GetBuffer()
		{
			return ((MemoryStream)memoryStream).GetBuffer();
		}

		public override bool TryGetBuffer(out ArraySegment<byte> buffer)
		{
			return ((MemoryStream)memoryStream).TryGetBuffer(out buffer);
		}

		public override int Read(byte[] buffer, int offset, int count)
		{
			return arTTIiQRMskjSATd1FtP(memoryStream, buffer, offset, count);
		}

		public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			return ((Stream)memoryStream).ReadAsync(buffer, offset, count, cancellationToken);
		}

		public override int ReadByte()
		{
			return xRVjLqQRJ41ompXrEL6k(memoryStream);
		}

		public override Task CopyToAsync(Stream destination, int bufferSize, CancellationToken cancellationToken)
		{
			return (Task)RqxcDoQR9B7LS7FBArbW(memoryStream, destination, bufferSize, cancellationToken);
		}

		public override long Seek(long offset, SeekOrigin loc)
		{
			return rf6VxUQRdhJS4yS4X8j8(memoryStream, offset, loc);
		}

		public override void SetLength(long value)
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
					NScDFhQRliSLicJDLXgD(memoryStream, value);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}

		public override byte[] ToArray()
		{
			return ((MemoryStream)memoryStream).ToArray();
		}

		public override void Write(byte[] buffer, int offset, int count)
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
					CIakDyQRrpaNIIfb5XBg(memoryStream, buffer, offset, count);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}

		public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			return ((Stream)memoryStream).WriteAsync(buffer, offset, count, cancellationToken);
		}

		public override void WriteByte(byte value)
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
					yMUNFgQRg7Rx0lRlTVTP(memoryStream, value);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}

		public override void WriteTo(Stream stream)
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
					((MemoryStream)memoryStream).WriteTo(stream);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}

		public override void Close()
		{
		}

		public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
		{
			return ((Stream)memoryStream).BeginRead(buffer, offset, count, callback, state);
		}

		public override int EndRead(IAsyncResult asyncResult)
		{
			return ye3xFvQR5aYnlP1NEcBW(memoryStream, asyncResult);
		}

		public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
		{
			return (IAsyncResult)cLvvL9QRjdH56ZFMA4mv(memoryStream, buffer, offset, count, callback, state);
		}

		public override void EndWrite(IAsyncResult asyncResult)
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
					eVApOpQRYCLv8GTc6dHe(memoryStream, asyncResult);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		public override object InitializeLifetimeService()
		{
			return mCKXwTQRLYEZhcoDhhRA(memoryStream);
		}

		public override ObjRef CreateObjRef(Type requestedType)
		{
			return (ObjRef)QWiqurQRUHrgtjhV4OsF(memoryStream, requestedType);
		}

		public override string ToString()
		{
			return memoryStream.ToString();
		}

		public override bool Equals(object obj)
		{
			return memoryStream.Equals(obj);
		}

		public override int GetHashCode()
		{
			return memoryStream.GetHashCode();
		}

		protected override void Dispose(bool disposing)
		{
		}

		internal static bool O5TbPMQRa0Z8JkBF2RM5()
		{
			return cmo2MBQRp20vRRBXA9WH == null;
		}

		internal static NoCloseMemoryStream eiGttUQRDaCofBOf1Slj()
		{
			return (NoCloseMemoryStream)cmo2MBQRp20vRRBXA9WH;
		}

		internal static bool IaBWihQRtKJ9oAjI5gYP(object P_0)
		{
			return ((Stream)P_0).CanRead;
		}

		internal static int eVcOAoQRwbYUlFqvIMlK(object P_0)
		{
			return ((MemoryStream)P_0).Capacity;
		}

		internal static long Uk05cvQR4LXYyKbMA6Nn(object P_0)
		{
			return ((Stream)P_0).Length;
		}

		internal static long zKqXO4QR6hP1YAFuS2RT(object P_0)
		{
			return ((Stream)P_0).Position;
		}

		internal static bool Qk199lQRHRkEaxmjPsEX(object P_0)
		{
			return ((Stream)P_0).CanTimeout;
		}

		internal static int eOVswLQRAXun0m1jaFSg(object P_0)
		{
			return ((Stream)P_0).ReadTimeout;
		}

		internal static void xCR2HKQR7VR6pmYgplq2(object P_0, int P_1)
		{
			((Stream)P_0).ReadTimeout = P_1;
		}

		internal static int OiUnuhQRxtugJYIJ98Y8(object P_0)
		{
			return ((Stream)P_0).WriteTimeout;
		}

		internal static void Ki6o6TQR00cbXq4VxZhc(object P_0, int P_1)
		{
			((Stream)P_0).WriteTimeout = P_1;
		}

		internal static void XCh1hHQRmdpbvvGf2UQ9(object P_0)
		{
			((Stream)P_0).Flush();
		}

		internal static object x1YdSuQRyynTxcuy4uxF(object P_0, CancellationToken P_1)
		{
			return ((Stream)P_0).FlushAsync(P_1);
		}

		internal static int arTTIiQRMskjSATd1FtP(object P_0, object P_1, int P_2, int P_3)
		{
			return ((Stream)P_0).Read((byte[])P_1, P_2, P_3);
		}

		internal static int xRVjLqQRJ41ompXrEL6k(object P_0)
		{
			return ((Stream)P_0).ReadByte();
		}

		internal static object RqxcDoQR9B7LS7FBArbW(object P_0, object P_1, int P_2, CancellationToken P_3)
		{
			return ((Stream)P_0).CopyToAsync((Stream)P_1, P_2, P_3);
		}

		internal static long rf6VxUQRdhJS4yS4X8j8(object P_0, long P_1, SeekOrigin P_2)
		{
			return ((Stream)P_0).Seek(P_1, P_2);
		}

		internal static void NScDFhQRliSLicJDLXgD(object P_0, long P_1)
		{
			((Stream)P_0).SetLength(P_1);
		}

		internal static void CIakDyQRrpaNIIfb5XBg(object P_0, object P_1, int P_2, int P_3)
		{
			((Stream)P_0).Write((byte[])P_1, P_2, P_3);
		}

		internal static void yMUNFgQRg7Rx0lRlTVTP(object P_0, byte P_1)
		{
			((Stream)P_0).WriteByte(P_1);
		}

		internal static int ye3xFvQR5aYnlP1NEcBW(object P_0, object P_1)
		{
			return ((Stream)P_0).EndRead((IAsyncResult)P_1);
		}

		internal static object cLvvL9QRjdH56ZFMA4mv(object P_0, object P_1, int P_2, int P_3, object P_4, object P_5)
		{
			return ((Stream)P_0).BeginWrite((byte[])P_1, P_2, P_3, (AsyncCallback)P_4, P_5);
		}

		internal static void eVApOpQRYCLv8GTc6dHe(object P_0, object P_1)
		{
			((Stream)P_0).EndWrite((IAsyncResult)P_1);
		}

		internal static object mCKXwTQRLYEZhcoDhhRA(object P_0)
		{
			return ((MarshalByRefObject)P_0).InitializeLifetimeService();
		}

		internal static object QWiqurQRUHrgtjhV4OsF(object P_0, Type P_1)
		{
			return ((MarshalByRefObject)P_0).CreateObjRef(P_1);
		}
	}

	private sealed class MultipleReadingMemoryStream : MemoryStream
	{
		private readonly object memoryStream;

		private static readonly AsyncLocal<long> asyncLocalPosition;

		private readonly object semaphore;

		private static object n1tKm7QRsJxoC2YUplyQ;

		public override bool CanRead => sutriAQqF2g3mhBaLUOW(memoryStream);

		public override bool CanSeek => DpQGobQqBUnyrDedqNRx(memoryStream);

		public override bool CanWrite => false;

		public override int Capacity
		{
			get
			{
				return YegFwMQqWehZXAVRrgKG(memoryStream);
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		public override long Length => BCf4cLQqoJXMJ7FSlnRG(memoryStream);

		public override long Position
		{
			get
			{
				return asyncLocalPosition.Value;
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
					case 0:
						return;
					case 1:
						asyncLocalPosition.Value = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public override bool CanTimeout => dOLj0iQqbbYZoFuZ03dL(memoryStream);

		public override int ReadTimeout
		{
			get
			{
				return CwIyt1QqhuZNc11uLCZ8(memoryStream);
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
					case 0:
						return;
					case 1:
						eFhiNEQqGv4penf1uRKZ(memoryStream, value);
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public override int WriteTimeout
		{
			get
			{
				return zbHVE8QqEHgTJPiYrvTR(memoryStream);
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		public MultipleReadingMemoryStream(MemoryStream memoryStream)
		{
			//Discarded unreachable code: IL_003c, IL_0041
			SingletonReader.JJCZtPuTvSt();
			semaphore = new SemaphoreSlim(1, 1);
			base._002Ector();
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
				case 1:
					this.memoryStream = memoryStream;
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
					{
						num = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}

		public override void Flush()
		{
			throw new NotImplementedException();
		}

		public override Task FlushAsync(CancellationToken cancellationToken)
		{
			throw new NotImplementedException();
		}

		public override byte[] GetBuffer()
		{
			return (byte[])EQPW8QQqfZ5aDL2PyJbK(memoryStream);
		}

		public override bool TryGetBuffer(out ArraySegment<byte> buffer)
		{
			return ((MemoryStream)memoryStream).TryGetBuffer(out buffer);
		}

		public override int Read(byte[] buffer, int offset, int count)
		{
			//Discarded unreachable code: IL_004a, IL_00e5, IL_00f8, IL_0107
			int result = default(int);
			switch (1)
			{
			case 1:
				try
				{
					f7VBRHQqQPZ1cwDgLlQr(semaphore);
					int num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
					{
						num = 0;
					}
					while (true)
					{
						switch (num)
						{
						case 1:
						{
							int num2 = EUwXZ4Qq81dXExT6yQ2j(memoryStream, buffer, offset, count);
							Position = dAqq7oQqCtV6Y6DeW0s2(memoryStream);
							result = num2;
							num = 2;
							continue;
						}
						case 2:
							return result;
						}
						He1CCgQqvPsvO1fHd1mI(memoryStream, dAqq7oQqCtV6Y6DeW0s2(this));
						num = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
						{
							num = 1;
						}
					}
				}
				finally
				{
					((SemaphoreSlim)semaphore).Release();
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					case 0:
						break;
					}
				}
			default:
				return result;
			}
		}

		[AsyncStateMachine(typeof(_003CReadAsync_003Ed__31))]
		public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			_003CReadAsync_003Ed__31 stateMachine = default(_003CReadAsync_003Ed__31);
			stateMachine._003C_003E4__this = this;
			stateMachine.buffer = buffer;
			stateMachine.offset = offset;
			stateMachine.count = count;
			stateMachine.cancellationToken = cancellationToken;
			stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<int>.Create();
			stateMachine._003C_003E1__state = -1;
			AsyncTaskMethodBuilder<int> _003C_003Et__builder = stateMachine._003C_003Et__builder;
			_003C_003Et__builder.Start(ref stateMachine);
			return stateMachine._003C_003Et__builder.Task;
		}

		public override int ReadByte()
		{
			//Discarded unreachable code: IL_003d, IL_00e5, IL_00f8, IL_0107
			int result = default(int);
			switch (1)
			{
			default:
				return result;
			case 1:
				try
				{
					f7VBRHQqQPZ1cwDgLlQr(semaphore);
					int num = 2;
					while (true)
					{
						switch (num)
						{
						default:
							return result;
						case 0:
							return result;
						case 1:
						{
							int num2 = ((Stream)memoryStream).ReadByte();
							He1CCgQqvPsvO1fHd1mI(this, dAqq7oQqCtV6Y6DeW0s2(memoryStream));
							result = num2;
							num = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
							{
								num = 0;
							}
							break;
						}
						case 2:
							He1CCgQqvPsvO1fHd1mI(memoryStream, dAqq7oQqCtV6Y6DeW0s2(this));
							num = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
							{
								num = 1;
							}
							break;
						}
					}
				}
				finally
				{
					A7uFiPQqZ6ukpNFAVSII(semaphore);
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					case 0:
						break;
					}
				}
			}
		}

		[AsyncStateMachine(typeof(_003CCopyToAsync_003Ed__33))]
		public override Task CopyToAsync(Stream destination, int bufferSize, CancellationToken cancellationToken)
		{
			int num = 4;
			int num2 = num;
			_003CCopyToAsync_003Ed__33 stateMachine = default(_003CCopyToAsync_003Ed__33);
			AsyncTaskMethodBuilder _003C_003Et__builder = default(AsyncTaskMethodBuilder);
			while (true)
			{
				switch (num2)
				{
				case 5:
					return stateMachine._003C_003Et__builder.Task;
				case 4:
					stateMachine._003C_003E4__this = this;
					num2 = 3;
					break;
				case 2:
					stateMachine._003C_003E1__state = -1;
					num2 = 7;
					break;
				case 8:
					stateMachine._003C_003Et__builder = nk4vocQqu1x8eqR9jxKK();
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
					{
						num2 = 1;
					}
					break;
				case 6:
					_003C_003Et__builder.Start(ref stateMachine);
					num2 = 5;
					break;
				default:
					stateMachine.bufferSize = bufferSize;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
					{
						num2 = 1;
					}
					break;
				case 7:
					_003C_003Et__builder = stateMachine._003C_003Et__builder;
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
					{
						num2 = 6;
					}
					break;
				case 3:
					stateMachine.destination = destination;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
					{
						num2 = 0;
					}
					break;
				case 1:
					stateMachine.cancellationToken = cancellationToken;
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
					{
						num2 = 8;
					}
					break;
				}
			}
		}

		public override long Seek(long offset, SeekOrigin loc)
		{
			//Discarded unreachable code: IL_004a, IL_00e4, IL_00f7, IL_0106
			long result = default(long);
			switch (1)
			{
			case 1:
				try
				{
					f7VBRHQqQPZ1cwDgLlQr(semaphore);
					int num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
					{
						num = 0;
					}
					while (true)
					{
						switch (num)
						{
						case 2:
						{
							long num2 = lG21r1QqIF4LAieE80jw(memoryStream, offset, loc);
							He1CCgQqvPsvO1fHd1mI(this, dAqq7oQqCtV6Y6DeW0s2(memoryStream));
							result = num2;
							num = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
							{
								num = 1;
							}
							break;
						}
						default:
							((Stream)memoryStream).Position = Position;
							num = 2;
							break;
						case 1:
							return result;
						}
					}
				}
				finally
				{
					((SemaphoreSlim)semaphore).Release();
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					case 0:
						break;
					}
				}
			default:
				return result;
			}
		}

		public override void SetLength(long value)
		{
			throw new NotImplementedException();
		}

		public override byte[] ToArray()
		{
			return (byte[])rZp78qQqVG5n8ortMlQR(memoryStream);
		}

		public override void Write(byte[] buffer, int offset, int count)
		{
			throw new NotImplementedException();
		}

		public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			throw new NotImplementedException();
		}

		public override void WriteByte(byte value)
		{
			throw new NotImplementedException();
		}

		public override void WriteTo(Stream stream)
		{
			throw new NotImplementedException();
		}

		public override void Close()
		{
		}

		public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
		{
			return (IAsyncResult)JiJnmAQqSJn2Af07Fj58(memoryStream, buffer, offset, count, callback, state);
		}

		public override int EndRead(IAsyncResult asyncResult)
		{
			return dxr3q7QqiyJJreE1WKmv(memoryStream, asyncResult);
		}

		public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
		{
			throw new NotImplementedException();
		}

		public override void EndWrite(IAsyncResult asyncResult)
		{
			throw new NotImplementedException();
		}

		public override object InitializeLifetimeService()
		{
			return YeilTsQqRGEU1JCFNJ1M(memoryStream);
		}

		public override ObjRef CreateObjRef(Type requestedType)
		{
			return ((MarshalByRefObject)memoryStream).CreateObjRef(requestedType);
		}

		public override string ToString()
		{
			return memoryStream.ToString();
		}

		public override bool Equals(object obj)
		{
			return memoryStream.Equals(obj);
		}

		public override int GetHashCode()
		{
			return memoryStream.GetHashCode();
		}

		protected override void Dispose(bool disposing)
		{
		}

		static MultipleReadingMemoryStream()
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
					asyncLocalPosition = new AsyncLocal<long>();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				case 2:
					KLCR6DQqqos8rAQVUAxX();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
					{
						num2 = 1;
					}
					break;
				}
			}
		}

		internal static bool vFWyetQRcjiuATAhV88t()
		{
			return n1tKm7QRsJxoC2YUplyQ == null;
		}

		internal static MultipleReadingMemoryStream d9F0V8QRzTxImd2ZAvuf()
		{
			return (MultipleReadingMemoryStream)n1tKm7QRsJxoC2YUplyQ;
		}

		internal static bool sutriAQqF2g3mhBaLUOW(object P_0)
		{
			return ((Stream)P_0).CanRead;
		}

		internal static bool DpQGobQqBUnyrDedqNRx(object P_0)
		{
			return ((Stream)P_0).CanSeek;
		}

		internal static int YegFwMQqWehZXAVRrgKG(object P_0)
		{
			return ((MemoryStream)P_0).Capacity;
		}

		internal static long BCf4cLQqoJXMJ7FSlnRG(object P_0)
		{
			return ((Stream)P_0).Length;
		}

		internal static bool dOLj0iQqbbYZoFuZ03dL(object P_0)
		{
			return ((Stream)P_0).CanTimeout;
		}

		internal static int CwIyt1QqhuZNc11uLCZ8(object P_0)
		{
			return ((Stream)P_0).ReadTimeout;
		}

		internal static void eFhiNEQqGv4penf1uRKZ(object P_0, int P_1)
		{
			((Stream)P_0).ReadTimeout = P_1;
		}

		internal static int zbHVE8QqEHgTJPiYrvTR(object P_0)
		{
			return ((Stream)P_0).WriteTimeout;
		}

		internal static object EQPW8QQqfZ5aDL2PyJbK(object P_0)
		{
			return ((MemoryStream)P_0).GetBuffer();
		}

		internal static void f7VBRHQqQPZ1cwDgLlQr(object P_0)
		{
			((SemaphoreSlim)P_0).Wait();
		}

		internal static long dAqq7oQqCtV6Y6DeW0s2(object P_0)
		{
			return ((Stream)P_0).Position;
		}

		internal static void He1CCgQqvPsvO1fHd1mI(object P_0, long P_1)
		{
			((Stream)P_0).Position = P_1;
		}

		internal static int EUwXZ4Qq81dXExT6yQ2j(object P_0, object P_1, int P_2, int P_3)
		{
			return ((Stream)P_0).Read((byte[])P_1, P_2, P_3);
		}

		internal static int A7uFiPQqZ6ukpNFAVSII(object P_0)
		{
			return ((SemaphoreSlim)P_0).Release();
		}

		internal static AsyncTaskMethodBuilder nk4vocQqu1x8eqR9jxKK()
		{
			return AsyncTaskMethodBuilder.Create();
		}

		internal static long lG21r1QqIF4LAieE80jw(object P_0, long P_1, SeekOrigin P_2)
		{
			return ((Stream)P_0).Seek(P_1, P_2);
		}

		internal static object rZp78qQqVG5n8ortMlQR(object P_0)
		{
			return ((MemoryStream)P_0).ToArray();
		}

		internal static object JiJnmAQqSJn2Af07Fj58(object P_0, object P_1, int P_2, int P_3, object P_4, object P_5)
		{
			return ((Stream)P_0).BeginRead((byte[])P_1, P_2, P_3, (AsyncCallback)P_4, P_5);
		}

		internal static int dxr3q7QqiyJJreE1WKmv(object P_0, object P_1)
		{
			return ((Stream)P_0).EndRead((IAsyncResult)P_1);
		}

		internal static object YeilTsQqRGEU1JCFNJ1M(object P_0)
		{
			return ((MarshalByRefObject)P_0).InitializeLifetimeService();
		}

		internal static void KLCR6DQqqos8rAQVUAxX()
		{
			SingletonReader.JJCZtPuTvSt();
		}
	}

	internal static MemoryStreamExtensions VEA5S1BexftnL2DSP5lV;

	public static MemoryStream AsNoClose(this MemoryStream memoryStream)
	{
		//Discarded unreachable code: IL_005b, IL_006a
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return memoryStream;
			default:
				return new NoCloseMemoryStream(memoryStream);
			case 1:
				if (!(memoryStream is NoCloseMemoryStream))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			}
		}
	}

	public static MemoryStream AsReadOnly(this MemoryStream memoryStream)
	{
		//Discarded unreachable code: IL_0052, IL_0061
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (!(memoryStream is MultipleReadingMemoryStream))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			default:
				return memoryStream;
			case 1:
				return new MultipleReadingMemoryStream(memoryStream);
			}
		}
	}

	public static string AsString(this MemoryStream memoryStream, Encoding encoding)
	{
		//Discarded unreachable code: IL_00a9, IL_00b8
		int num = 3;
		int num2 = num;
		NativeMemoryStream nativeMemoryStream = default(NativeMemoryStream);
		while (true)
		{
			switch (num2)
			{
			case 2:
				XLBDCPBeMfO4OqLpDDAg(encoding, WEjkkkBeyVImbamepCcu(0x4A1640F ^ 0x4A05A85));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				XLBDCPBeMfO4OqLpDDAg(memoryStream, WEjkkkBeyVImbamepCcu(-87337865 ^ -87397863));
				num2 = 2;
				break;
			case 1:
				return (string)rOxKuiBeJrwxIHgYYSbX(nativeMemoryStream, encoding);
			case 4:
				return encoding.GetString((byte[])gjaxuxBe9gXbBVDBgkSU(memoryStream), 0, (int)memoryStream.Length);
			default:
				if ((nativeMemoryStream = memoryStream as NativeMemoryStream) == null)
				{
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 1;
			}
		}
	}

	public static int GetContentHashCode(this MemoryStream memoryStream)
	{
		//Discarded unreachable code: IL_0062, IL_0096, IL_0151, IL_0160, IL_0198
		int num = 10;
		int num2 = num;
		int num3 = default(int);
		int num4 = default(int);
		ArraySegment<byte> buffer = default(ArraySegment<byte>);
		NativeMemoryStream nativeMemoryStream = default(NativeMemoryStream);
		while (true)
		{
			switch (num2)
			{
			case 5:
				return num3;
			case 7:
				return 1;
			case 6:
			case 8:
				if (num4 < buffer.Count)
				{
					num2 = 13;
					continue;
				}
				goto case 5;
			case 4:
				num4 = 0;
				num2 = 6;
				continue;
			default:
				num4++;
				num2 = 8;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
				{
					num2 = 2;
				}
				continue;
			case 2:
				num3 += buffer.Array[buffer.Offset + num4];
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
				{
					num2 = 0;
				}
				continue;
			case 10:
				XLBDCPBeMfO4OqLpDDAg(memoryStream, WEjkkkBeyVImbamepCcu(-1459557599 ^ -1459497649));
				num2 = 9;
				continue;
			case 12:
				return cqeSeCBedblOl1DHlHLZ(nativeMemoryStream);
			case 14:
				if (memoryStream.TryGetBuffer(out buffer))
				{
					num2 = 11;
					continue;
				}
				goto case 7;
			case 11:
				if (buffer.Array == null)
				{
					num2 = 7;
					continue;
				}
				break;
			case 9:
				if ((nativeMemoryStream = memoryStream as NativeMemoryStream) == null)
				{
					num2 = 14;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
					{
						num2 = 1;
					}
					continue;
				}
				goto case 12;
			case 1:
			case 13:
				num3 *= 31;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
				{
					num2 = 2;
				}
				continue;
			case 3:
				break;
			}
			num3 = 1;
			num2 = 4;
		}
	}

	public static MemoryStream CloneMemoryStream(this MemoryStream originalMemoryStream)
	{
		int num = 5;
		int num2 = num;
		MemoryStream memoryStream = default(MemoryStream);
		while (true)
		{
			switch (num2)
			{
			case 5:
				if (originalMemoryStream != null)
				{
					num2 = 4;
					break;
				}
				return null;
			case 6:
				tYb9e5Be5BTtNjYdeeDl(originalMemoryStream, memoryStream);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				PfKi3HBegS83KtaF6MDY(memoryStream, 0L, SeekOrigin.Begin);
				num2 = 3;
				break;
			default:
				PfKi3HBegS83KtaF6MDY(originalMemoryStream, 0L, SeekOrigin.Begin);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
				{
					num2 = 2;
				}
				break;
			case 3:
				return memoryStream;
			case 4:
				memoryStream = (MemoryStream)FsuLujBerLEblBfx3Qmv((int)wKxvwuBelNc2RryNrM9p(originalMemoryStream));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				PfKi3HBegS83KtaF6MDY(originalMemoryStream, 0L, SeekOrigin.Begin);
				num2 = 6;
				break;
			}
		}
	}

	internal static bool cAkMRrBe0M0ltEDpcEfY()
	{
		return VEA5S1BexftnL2DSP5lV == null;
	}

	internal static MemoryStreamExtensions TEUppdBemKlCHl0pCCeD()
	{
		return VEA5S1BexftnL2DSP5lV;
	}

	internal static object WEjkkkBeyVImbamepCcu(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void XLBDCPBeMfO4OqLpDDAg(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static object rOxKuiBeJrwxIHgYYSbX(object P_0, object P_1)
	{
		return ((NativeMemoryStream)P_0).AsString((Encoding)P_1);
	}

	internal static object gjaxuxBe9gXbBVDBgkSU(object P_0)
	{
		return ((MemoryStream)P_0).GetBuffer();
	}

	internal static int cqeSeCBedblOl1DHlHLZ(object P_0)
	{
		return ((NativeMemoryStream)P_0).GetContentHashCode();
	}

	internal static long wKxvwuBelNc2RryNrM9p(object P_0)
	{
		return ((Stream)P_0).Length;
	}

	internal static object FsuLujBerLEblBfx3Qmv(int requiredSize)
	{
		return MemoryHelper.GetMemoryStream(requiredSize);
	}

	internal static long PfKi3HBegS83KtaF6MDY(object P_0, long P_1, SeekOrigin P_2)
	{
		return ((Stream)P_0).Seek(P_1, P_2);
	}

	internal static void tYb9e5Be5BTtNjYdeeDl(object P_0, object P_1)
	{
		((Stream)P_0).CopyTo((Stream)P_1);
	}
}
