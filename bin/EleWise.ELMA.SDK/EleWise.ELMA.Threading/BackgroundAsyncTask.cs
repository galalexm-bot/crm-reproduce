using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Threading;

public class BackgroundAsyncTask
{
	private readonly Func<Task> action;

	private readonly Type ownerType;

	private readonly string name;

	private readonly string description;

	private readonly bool useCallSessionOwner;

	private readonly bool handleExceptions;

	private static BackgroundAsyncTask wuN6HKBSmEMQ7UKhKwmA;

	public Exception ExecutionException
	{
		[CompilerGenerated]
		get
		{
			return _003CExecutionException_003Ek__BackingField;
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
					_003CExecutionException_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public BackgroundAsyncTask(Func<Task> action, Type ownerType, string name, string description, bool useCallSessionOwner = true, bool handleExceptions = true)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		Contract.ArgumentNotNull(action, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1317790512 ^ -1317731036));
		this.action = action;
		this.ownerType = ownerType;
		this.name = name;
		this.description = description;
		this.useCallSessionOwner = useCallSessionOwner;
		this.handleExceptions = handleExceptions;
	}

	[AsyncStateMachine(typeof(_003CExecuteAsync_003Ed__11))]
	public Task ExecuteAsync()
	{
		int num = 2;
		int num2 = num;
		_003CExecuteAsync_003Ed__11 stateMachine = default(_003CExecuteAsync_003Ed__11);
		AsyncTaskMethodBuilder _003C_003Et__builder = default(AsyncTaskMethodBuilder);
		while (true)
		{
			switch (num2)
			{
			case 4:
				stateMachine._003C_003E1__state = -1;
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
				{
					num2 = 2;
				}
				break;
			case 5:
				return stateMachine._003C_003Et__builder.Task;
			case 1:
				stateMachine._003C_003Et__builder = QYuHltBSJ5kK3jIg247a();
				num2 = 4;
				break;
			case 3:
				_003C_003Et__builder = stateMachine._003C_003Et__builder;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				_003C_003Et__builder.Start(ref stateMachine);
				num2 = 5;
				break;
			case 2:
				stateMachine._003C_003E4__this = this;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	internal static bool DJVa6qBSyFHo92a3T7sE()
	{
		return wuN6HKBSmEMQ7UKhKwmA == null;
	}

	internal static BackgroundAsyncTask qhh1u7BSMwraSxZF0utx()
	{
		return wuN6HKBSmEMQ7UKhKwmA;
	}

	internal static AsyncTaskMethodBuilder QYuHltBSJ5kK3jIg247a()
	{
		return AsyncTaskMethodBuilder.Create();
	}
}
