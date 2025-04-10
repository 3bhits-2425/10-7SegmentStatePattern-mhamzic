public class State0 : ISevenSegmentDisplayState
{

    public int GetDigit() {
        return 0; 
    }

    public ISevenSegmentDisplayState CountDown()
    {
        return new State9();
    }

    public ISevenSegmentDisplayState CountUp()
    {
        return new State1();
    }
}
