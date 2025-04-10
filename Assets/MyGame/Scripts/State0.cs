using UnityEditor.PackageManager;

public class State0 : ISevenSegmentDisplayState
{
    // erstelle static Variables
    private static ISevenSegmentDisplayState _state;

    // Konstruktor fuer Objekte vom Typ State0
    private State0()
    {

    }

    // static Methode 
    public static ISevenSegmentDisplayState GetState()
    {
        // Wenn kein Objekt, dann erzeuge Objekt
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
