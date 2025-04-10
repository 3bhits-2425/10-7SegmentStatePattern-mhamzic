public class State8 : ISevenSegmentDisplayState
{
    private static ISevenSegmentDisplayState _state;
    private State8()
    {

    }

    // static Methode 
    public static ISevenSegmentDisplayState GetState()
    {
        if (_state == null)
        {
            _state = new State8();
        }

        return _state;
    }
    public int GetDigit()
    {
        return 8;
    }

    public ISevenSegmentDisplayState CountDown()
    {
        return State7.GetState();
    }

    public ISevenSegmentDisplayState CountUp()
    {
        return State9.GetState();
    }
}
