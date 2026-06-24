using System;
using System.Activities;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.Services;

internal class WorkflowExecutingContextWrapper : IWorkflowExecutingContext, IDisposable
{
	private readonly WorkflowExecutingContext context;

	internal static WorkflowExecutingContextWrapper Ev6uBs7fBCkEsfLbS9Q;

	public WorkflowApplication Application => (WorkflowApplication)NBgxXd7REPGrBcxtTxl(context);

	public IWorkflowInstance Instance => (IWorkflowInstance)j0JHbD76Tjy72E00fdY(context);

	public bool IsTerminated => HmdOyS7qrqpWmZtEBFo(context);

	public WorkflowExecutingContextWrapper(WorkflowExecutingContext context)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		wwlaZB7ji5m9XeoJYRw();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b876fa7b083748c8abf8c4b192a11078 != 0)
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
				this.context = context;
				num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cfe7a0ffe67e4fea8e329ae6574ed2ca == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public void Dispose()
	{
	}

	public void ResumeBookmark(string bookmarkName, object value)
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
				I4tP7k73FAIYirJeJur(context, bookmarkName, value);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6d48f3b4557a49578bf7f5ef0517e0be != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public void ResumeBookmark(Guid bookmarkUid, object value)
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
				yBLPr47TKNT7eG3OqP2(context, bookmarkUid, value);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f276fa9c20d4dd889000f50d886a41e == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public void Run()
	{
		throw new InvalidOperationException();
	}

	public void Terminate(string reason)
	{
		int num = 3;
		_003C_003Ec__DisplayClass12_0 _003C_003Ec__DisplayClass12_ = default(_003C_003Ec__DisplayClass12_0);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					bHYgqO7pFtq8aAgfNmg(context, new Action(_003C_003Ec__DisplayClass12_._003CTerminate_003Eb__0));
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_61395ebf330446ac8ce99b55ee3acfa9 == 0)
					{
						num2 = 0;
					}
					continue;
				case 3:
					break;
				case 1:
					return;
				case 5:
					_003C_003Ec__DisplayClass12_.reason = reason;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_dcdfd019631e458b9cb5fa34a16a2fe1 == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					_003C_003Ec__DisplayClass12_._003C_003E4__this = this;
					num2 = 5;
					continue;
				default:
					vvrVib7Qj4gE8Z71eCj(context, true);
					num2 = 4;
					continue;
				}
				break;
			}
			_003C_003Ec__DisplayClass12_ = new _003C_003Ec__DisplayClass12_0();
			num = 2;
		}
	}

	internal static void wwlaZB7ji5m9XeoJYRw()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static bool EAWo5K791EpIevutch3()
	{
		return Ev6uBs7fBCkEsfLbS9Q == null;
	}

	internal static WorkflowExecutingContextWrapper j4MdrJ7WFQQP8KoYx0L()
	{
		return Ev6uBs7fBCkEsfLbS9Q;
	}

	internal static object NBgxXd7REPGrBcxtTxl(object P_0)
	{
		return ((WorkflowExecutingContext)P_0).Application;
	}

	internal static object j0JHbD76Tjy72E00fdY(object P_0)
	{
		return ((WorkflowExecutingContext)P_0).Instance;
	}

	internal static bool HmdOyS7qrqpWmZtEBFo(object P_0)
	{
		return ((WorkflowExecutingContext)P_0).IsTerminated;
	}

	internal static void I4tP7k73FAIYirJeJur(object P_0, object P_1, object P_2)
	{
		((WorkflowExecutingContext)P_0).ResumeBookmark((string)P_1, P_2);
	}

	internal static void yBLPr47TKNT7eG3OqP2(object P_0, Guid bookmarkUid, object P_2)
	{
		((WorkflowExecutingContext)P_0).ResumeBookmark(bookmarkUid, P_2);
	}

	internal static void vvrVib7Qj4gE8Z71eCj(object P_0, bool value)
	{
		((WorkflowExecutingContext)P_0).IsTerminated = value;
	}

	internal static void bHYgqO7pFtq8aAgfNmg(object P_0, object P_1)
	{
		((WorkflowExecutingContext)P_0).EnqueueAction((Action)P_1);
	}
}
