public class PromptGenerator
{
    private List<string> prompts = new List<string>
  {
      "What was the best part of your day?",
      "What are you grateful for today?",
      "Describe a challenge you faced and how you overcame it.",
      "What is something new you learned today?",
      "How did you help someone today?",
      "Who was the most interesting person I interacted with today?",
      "How did I see the hand of the Lord in my life today?",
      "What was the strongest emotion I felt today?",
      "If I had one thing I could do over today, what would it be?",
  };
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(prompts.Count);
        return prompts[index];
    }
}