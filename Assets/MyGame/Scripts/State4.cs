public class State4 : ISevenSegmentDisplayState
{
    private static ISevenSegmentDisplayState _state;
    private State4()
    {

    }

    // static Methode 
    public static ISevenSegmentDisplayState GetState()
    {
        if (_state == null)
        {
            _state = new State4();
        }

        return _state;
    }
    public int GetDigit()
    {
        return 4;
    }

    public ISevenSegmentDisplayState CountDown()
    {
        return State3.GetState();
    }

    public ISevenSegmentDisplayState CountUp()
    {
        return State5.GetState();
    }
}
