public class State9 : ISevenSegmentDisplayState
{
    private static ISevenSegmentDisplayState _state;
    private State9()
    {

    }

    // static Methode 
    public static ISevenSegmentDisplayState GetState()
    {
        if (_state == null)
        {
            _state = new State9();
        }

        return _state;
    }
    public int GetDigit()
    {
        return 9;
    }

    public ISevenSegmentDisplayState CountDown()
    {
        return State8.GetState();
    }

    public ISevenSegmentDisplayState CountUp()
    {
        return State0.GetState();
    }
}
