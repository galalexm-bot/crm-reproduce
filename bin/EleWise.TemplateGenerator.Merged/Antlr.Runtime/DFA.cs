using System;
using System.Diagnostics;

namespace Antlr.Runtime;

public class DFA
{
	protected short[] eot;

	protected short[] eof;

	protected char[] min;

	protected char[] max;

	protected short[] accept;

	protected short[] special;

	protected short[][] transition;

	protected int decisionNumber;

	protected BaseRecognizer recognizer;

	public readonly bool debug;

	public virtual string Description => "n/a";

	public SpecialStateTransitionHandler SpecialStateTransition { get; private set; }

	public DFA()
		: this(SpecialStateTransitionDefault)
	{
	}

	public DFA(SpecialStateTransitionHandler specialStateTransition)
	{
		SpecialStateTransition = specialStateTransition ?? new SpecialStateTransitionHandler(SpecialStateTransitionDefault);
	}

	public virtual int Predict(IIntStream input)
	{
		if (debug)
		{
			Console.Error.WriteLine("Enter DFA.predict for decision " + decisionNumber);
		}
		int marker = input.Mark();
		int num = 0;
		try
		{
			char c;
			while (true)
			{
				if (debug)
				{
					Console.Error.WriteLine("DFA " + decisionNumber + " state " + num + " LA(1)=" + (char)input.LA(1) + "(" + input.LA(1) + "), index=" + input.Index);
				}
				int num2 = special[num];
				if (num2 >= 0)
				{
					if (debug)
					{
						Console.Error.WriteLine("DFA " + decisionNumber + " state " + num + " is special state " + num2);
					}
					num = SpecialStateTransition(this, num2, input);
					if (debug)
					{
						Console.Error.WriteLine("DFA " + decisionNumber + " returns from special state " + num2 + " to " + num);
					}
					if (num == -1)
					{
						NoViableAlt(num, input);
						return 0;
					}
					input.Consume();
					continue;
				}
				if (accept[num] >= 1)
				{
					if (debug)
					{
						Console.Error.WriteLine("accept; predict " + accept[num] + " from state " + num);
					}
					return accept[num];
				}
				c = (char)input.LA(1);
				if (c >= min[num] && c <= max[num])
				{
					int num3 = transition[num][c - min[num]];
					if (num3 < 0)
					{
						if (eot[num] < 0)
						{
							NoViableAlt(num, input);
							return 0;
						}
						if (debug)
						{
							Console.Error.WriteLine("EOT transition");
						}
						num = eot[num];
						input.Consume();
					}
					else
					{
						num = num3;
						input.Consume();
					}
				}
				else
				{
					if (eot[num] < 0)
					{
						break;
					}
					if (debug)
					{
						Console.Error.WriteLine("EOT transition");
					}
					num = eot[num];
					input.Consume();
				}
			}
			if (c == '\uffff' && eof[num] >= 0)
			{
				if (debug)
				{
					Console.Error.WriteLine("accept via EOF; predict " + accept[eof[num]] + " from " + eof[num]);
				}
				return accept[eof[num]];
			}
			if (debug)
			{
				Console.Error.WriteLine("min[" + num + "]=" + min[num]);
				Console.Error.WriteLine("max[" + num + "]=" + max[num]);
				Console.Error.WriteLine("eot[" + num + "]=" + eot[num]);
				Console.Error.WriteLine("eof[" + num + "]=" + eof[num]);
				for (int i = 0; i < transition[num].Length; i++)
				{
					Console.Error.Write(transition[num][i] + " ");
				}
				Console.Error.WriteLine();
			}
			NoViableAlt(num, input);
			return 0;
		}
		finally
		{
			input.Rewind(marker);
		}
	}

	protected virtual void NoViableAlt(int s, IIntStream input)
	{
		if (recognizer.state.backtracking > 0)
		{
			recognizer.state.failed = true;
			return;
		}
		NoViableAltException ex = new NoViableAltException(Description, decisionNumber, s, input);
		Error(ex);
		throw ex;
	}

	public virtual void Error(NoViableAltException nvae)
	{
	}

	private static int SpecialStateTransitionDefault(DFA dfa, int s, IIntStream input)
	{
		return -1;
	}

	public static short[] UnpackEncodedString(string encodedString)
	{
		int num = 0;
		for (int i = 0; i < encodedString.Length; i += 2)
		{
			num += encodedString[i];
		}
		short[] array = new short[num];
		int num2 = 0;
		for (int j = 0; j < encodedString.Length; j += 2)
		{
			char c = encodedString[j];
			char c2 = encodedString[j + 1];
			for (int k = 1; k <= c; k++)
			{
				array[num2++] = (short)c2;
			}
		}
		return array;
	}

	public static char[] UnpackEncodedStringToUnsignedChars(string encodedString)
	{
		int num = 0;
		for (int i = 0; i < encodedString.Length; i += 2)
		{
			num += encodedString[i];
		}
		char[] array = new char[num];
		int num2 = 0;
		for (int j = 0; j < encodedString.Length; j += 2)
		{
			char c = encodedString[j];
			char c2 = encodedString[j + 1];
			for (int k = 1; k <= c; k++)
			{
				array[num2++] = c2;
			}
		}
		return array;
	}

	[Conditional("ANTLR_DEBUG")]
	protected virtual void DebugRecognitionException(RecognitionException ex)
	{
		recognizer.DebugListener?.RecognitionException(ex);
	}
}
