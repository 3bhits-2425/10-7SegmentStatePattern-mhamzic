public class State7 : ISevenSegmentDisplayState
{
    private static ISevenSegmentDisplayState _state;
    private State7()
    {

    }

    // static Methode 
    public static ISevenSegmentDisplayState GetState()
    {
        if (_state == null)
        {
            _state = new State7();
        }

        return _state;
    }
    public int GetDigit()
    {
        return 7;
    }

    public ISevenSegmentDisplayState CountDown()
    {
        return State6.GetState();
    }

    public ISevenSegmentDisplayState CountUp()
    {
        return State8.GetState();
    }
}
