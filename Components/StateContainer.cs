namespace BlazorWasm.Components;

public class StateContainer
{
    private ApplicationVM _x;

    public ApplicationVM Application
    {
        get => _x;
        set
        {
            _x = value;
            NotifyStateChanged();
        }
    }

    public event Action? OnChange;

    private void NotifyStateChanged() => OnChange?.Invoke();
}