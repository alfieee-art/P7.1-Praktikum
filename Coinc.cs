using System;

public class Coin : ICollectible
{
    public void Collect() => Console.WriteLine("+10 koin!");
}