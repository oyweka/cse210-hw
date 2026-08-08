//I ensured that the Eternal Quest was more engaging by adding levels where 
// players move through different levels as they earn points by completing their goals. 
using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        goalManager.Start();
    }
}