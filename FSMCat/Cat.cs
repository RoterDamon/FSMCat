namespace FSMCat;

public class Cat
{
    private int _tired;
    private int _hungry;
    private int _poop;
    private bool _food;
    private FSM _brain = new FSM();

    public Cat(int tired, int hungry, int poop)
    {
        _tired = tired;
        _hungry = hungry;
        _poop = poop;
        _brain.SetState(Start);
    }

    public void Update() => _brain.Update();

    public string GetState() => _brain.GetStateName();

    private void Start()
    {
        if (_tired < 7)
            _brain.SetState(Sleep);
        else if (_poop >= 100)
            _brain.SetState(Poop);
        else if (_tired >= 7 && _hungry >= 5)
            _brain.SetState(Play);
        else
            _brain.SetState(GoToKitchen);
    }

    private void GoToKitchen()
    {
        _tired--;
        if (_food)
            _brain.SetState(Eat);
        else
            _brain.SetState(Search);
    }

    private void Search()
    {
        _tired--;
        _hungry--;
        _brain.SetState(Meow);
    }

    private void Meow()
    {
        if (_hungry < 3)
        {
            _tired--;
            _food = true;
            _brain.SetState(GoToKitchen);
        }
        else
        {
            _brain.SetState(Start);
        }
    }

    private void Eat()
    {
        _poop += 20;
        _tired--;
        _hungry = 10;
        _food = false;
        _brain.SetState(Start);
    }

    private void Play()
    {
        _tired -= 2;
        _hungry--;
        if (_hungry < 5)
            _brain.SetState(GoToKitchen);
        else if (_tired < 7)
            _brain.SetState(Sleep);
    }

    private void Poop()
    {
        _poop = 0;
        _tired--;
        _brain.SetState(Start);
    }

    private void Sleep()
    {
        _tired = 20;
        _hungry -= 3;
        _brain.SetState(Start);
    }
}