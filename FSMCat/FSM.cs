using System;

namespace FSMCat;

public class FSM
{
    private Action _activeState;

    public FSM() {}

    public void Update() => GetCurrentState().Invoke();

    private Action GetCurrentState() => _activeState;

    public string GetStateName() => $"{GetCurrentState().Method.Name}";

    public void SetState(Action state) => _activeState = state;
}