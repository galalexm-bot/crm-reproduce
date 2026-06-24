using System;

namespace EleWise.ELMA.Packaging.Logging;

public class OperationStatusLogger : ILogger
{
	private ILogger _baseLogger;

	private PackagingHelper _helper;

	private DateTime? _lastWrite;

	public TimeSpan Interval { get; set; }

	public OperationStatusLogger(ILogger baseLogger, PackagingHelper helper)
	{
		if (baseLogger == null)
		{
			throw new ArgumentNullException("baseLogger");
		}
		_baseLogger = baseLogger;
		_helper = helper;
		Interval = TimeSpan.FromSeconds(1.0);
	}

	public bool IsEnabled(LogLevel level)
	{
		return _baseLogger.IsEnabled(level);
	}

	public void Log(LogLevel level, Exception exception, string format, params object[] args)
	{
		if (_lastWrite.HasValue && DateTime.Now - _lastWrite.Value < Interval)
		{
			return;
		}
		_lastWrite = DateTime.Now;
		string message = ((args != null) ? string.Format(format, args) : format);
		try
		{
			PackageOperationStatusType type = ((level != LogLevel.Error && level != LogLevel.Fatal) ? PackageOperationStatusType.InProgress : PackageOperationStatusType.Error);
			_helper.SaveOperationStatus(new PackageOperationStatus
			{
				Type = type,
				Message = message
			});
		}
		catch
		{
		}
	}
}
