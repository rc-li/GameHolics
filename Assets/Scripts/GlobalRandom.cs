using System;
public class GlobalRandom
{
    private static Random random = new Random();

    public static Random getInstance()
    {
        return random;
    }
}
