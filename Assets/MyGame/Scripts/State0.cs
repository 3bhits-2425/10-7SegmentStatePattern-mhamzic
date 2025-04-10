using UnityEditor.PackageManager;

public class State0 : ISevenSegmentDisplayState
{
    private static ISevenSegmentDisplayState _state;
    private State0()
    {

    }

    // static Methode 
    public static ISevenSegmentDisplayState GetState()
    {
        if (_state == null)
        {
            _state = new State0();
        }

        return _state;
    }

    public int GetDigit() {
        return 0; 
    }

    public ISevenSegmentDisplayState CountDown()
    {
        return State9.GetState();
    }

    public ISevenSegmentDisplayState CountUp()
    {
        return State1.GetState();
    }
}
