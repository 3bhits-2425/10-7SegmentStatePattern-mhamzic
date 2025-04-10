

using UnityEditor.PackageManager;

public interface ISevenSegmentDisplayState 
{
    private static ISevenSegmentDisplayState _state; 
    // get the Number for the current state 
    public int GetDigit();

    // switch to the next state 
    // count down 
    public ISevenSegmentDisplayState CountDown();
    public static extern ISevenSegmentDisplayState GetState();
    // count up 
    public ISevenSegmentDisplayState CountUp();

}
