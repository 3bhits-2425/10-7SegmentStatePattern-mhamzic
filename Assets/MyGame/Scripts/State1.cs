
public class State1 : ISevenSegmentDisplayState
{
    private static ISevenSegmentDisplayState _state;
    private State1()
    {

    }

    // static Methode 
    public static ISevenSegmentDisplayState GetState()
    {
        if (_state == null)
        {
            _state = new State1();
        }

        return _state;
    }

    public int GetDigit()
    {
        return 1;
    }

    public ISevenSegmentDisplayState CountDown()
    {
        // vor Singleton: return new State0();
        return State0.GetState();
    }

    public ISevenSegmentDisplayState CountUp()
    {
        return State2.GetState();
    }
}
