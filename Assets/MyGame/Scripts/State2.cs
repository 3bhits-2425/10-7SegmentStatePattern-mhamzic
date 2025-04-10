
public class State2 : ISevenSegmentDisplayState
{
    private static ISevenSegmentDisplayState _state;
    private State2()
    {

    }

    // static Methode 
    public static ISevenSegmentDisplayState GetState()
    {
        if (_state == null)
        {
            _state = new State2();
        }

        return _state;
    }
    public int GetDigit()
    {
        return 2;
    }

    public ISevenSegmentDisplayState CountDown()
    {
        return State1.GetState();
    }

    public ISevenSegmentDisplayState CountUp()
    {
        return State3.GetState();
    }
}
