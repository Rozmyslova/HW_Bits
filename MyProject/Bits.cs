internal class Bits: IBits
{
    private readonly int size = 0;
    public bool GetBit(int index)
    {
        return this[index];
    }
    public void SetBit(bool value, int index)
    {
        this[index] = value;
    }
    public long Value {get; private set; } = 0;

    public Bits(long value)
    {
        this.Value = value;
        size = sizeof(long);
    }
    
    public static explicit operator long(Bits b) => (long)b.Value;
    public static implicit operator Bits(long b) => new Bits(b);

    public static explicit operator int(Bits b) => (int)b.Value;
    public static implicit operator Bits(int b) => new Bits(b);

    public static explicit operator byte(Bits b) => (byte)b.Value;
    public static implicit operator Bits(byte b) => new Bits(b);

    public bool this[int index]
    {
        get
        {
            if (index > 63 || index < 0)
                return false;
            return ((Value >> index) & 1) == 1;
        }
        set
        {
            if (index > 63 || index < 0)
                return;
            if (value == true)
                Value = (long)
                    (Value | (1 << index));
            else
            {
                var mask = (long)
                    (1 << index);
                mask = ~mask;
                Value &= (long)
                    (Value & mask);
            }
        }
    }
}