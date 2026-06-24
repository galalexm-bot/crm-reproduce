using System;
using System.Runtime.InteropServices;
using System.Timers;

namespace EleWise.ELMA.Packaging.Logging;

public class ExternalWindowLogger : ILogger, IDisposable
{
	private Timer _timer;

	private ILogger _baseLogger;

	private IntPtr _hwnd;

	private string _lastMessage;

	private string _lastDisplayedMessage;

	public ExternalWindowLogger(ILogger baseLogger, IntPtr hwnd)
	{
		if (baseLogger == null)
		{
			throw new ArgumentNullException("baseLogger");
		}
		_baseLogger = baseLogger;
		_hwnd = hwnd;
		_timer = new Timer();
		_timer.Interval = 1000.0;
		_timer.Elapsed += _timer_Elapsed;
		_timer.Start();
	}

	~ExternalWindowLogger()
	{
		Dispose();
	}

	public void Dispose()
	{
		DisplayMessage();
		lock (this)
		{
			if (_timer != null)
			{
				try
				{
					_timer.Dispose();
				}
				catch
				{
				}
				_timer = null;
			}
		}
	}

	public bool IsEnabled(LogLevel level)
	{
		return _baseLogger.IsEnabled(level);
	}

	public void Log(LogLevel level, Exception exception, string format, params object[] args)
	{
		if (level != LogLevel.Debug && level != LogLevel.Trace && level != 0)
		{
			_lastMessage = ((args != null) ? string.Format(format, args) : format);
		}
	}

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern bool SetWindowText(IntPtr hwnd, string lpString);

	[DllImport("user32.dll")]
	private static extern bool InvalidateRgn(IntPtr hWnd, IntPtr hRgn, bool bErase);

	private void _timer_Elapsed(object sender, ElapsedEventArgs e)
	{
		DisplayMessage();
	}

	private void DisplayMessage()
	{
		lock (this)
		{
			if (_lastMessage != null && _lastMessage != _lastDisplayedMessage)
			{
				try
				{
					_lastDisplayedMessage = _lastMessage;
					SetWindowText(_hwnd, _lastMessage);
					InvalidateRgn(_hwnd, IntPtr.Zero, bErase: true);
					return;
				}
				catch
				{
					return;
				}
			}
		}
	}
}
