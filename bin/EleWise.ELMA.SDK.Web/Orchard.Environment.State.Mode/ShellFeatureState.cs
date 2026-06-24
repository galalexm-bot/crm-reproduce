namespace Orchard.Environment.State.Models;

public class ShellFeatureState
{
	public enum State
	{
		Undefined,
		Rising,
		Up,
		Falling,
		Down
	}

	public string Name { get; set; }

	public State InstallState { get; set; }

	public State EnableState { get; set; }

	public bool IsInstalled => InstallState == State.Up;

	public bool IsEnabled => EnableState == State.Up;

	public bool IsDisabled
	{
		get
		{
			if (EnableState != State.Down)
			{
				return EnableState == State.Undefined;
			}
			return true;
		}
	}
}
