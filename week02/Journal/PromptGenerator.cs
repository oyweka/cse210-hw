using System;
using System.Collections.Generic;
public class PromptGenerator
{
    public List<string> _prompts = new List<string>();
    public PromptGenerator()
    {
        _prompts.Add("What are you thankful for today?");
        _prompts.Add("What blessings did you receive today?");
        _prompts.Add("How many times did you pray today?");
        _prompts.Add("Describe a challenge you faced today.");
        _prompts.Add("What made you smile today?");

    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}