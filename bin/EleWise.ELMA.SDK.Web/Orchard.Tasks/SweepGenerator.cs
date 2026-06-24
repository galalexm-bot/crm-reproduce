using System;
using System.Timers;
using EleWise.ELMA.Logging;

namespace Orchard.Tasks;

public class SweepGenerator : ISweepGenerator, ISingletonDependency, IDependency, IDisposable
{
	private readonly IWorkContextAccessor _workContextAccessor;

	private readonly Timer _timer;

	public ILogger Logger { get; set; }

	public TimeSpan Interval
	{
		get
		{
			return TimeSpan.FromMilliseconds(_timer.Interval);
		}
		set
		{
			_timer.Interval = value.TotalMilliseconds;
		}
	}

	public SweepGenerator(IWorkContextAccessor workContextAccessor)
	{
		_workContextAccessor = workContextAccessor;
		_timer = new Timer();
		_timer.Elapsed += Elapsed;
		Logger = NullLogger.Instance;
		Interval = TimeSpan.FromMinutes(1.0);
		_timer.Stop();
	}

	public void Activate()
	{
		lock (_timer)
		{
		}
	}

	public void Terminate()
	{
		lock (_timer)
		{
			_timer.Stop();
		}
	}

	private void Elapsed(object sender, ElapsedEventArgs e)
	{
	}

	public void DoWork()
	{
		using IWorkContextScope workContextScope = _workContextAccessor.CreateWorkContextScope();
		workContextScope.Resolve<IBackgroundService>().Sweep();
	}

	public void Dispose()
	{
		_timer.Dispose();
	}
}
