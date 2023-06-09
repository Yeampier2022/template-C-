public class PromptQuestion
{
    static string[] _promptsQuestion = {

    "How do i hear the voice of the lord?",
    "How can I be thankful today?",
    "What did you learn today?",
    "How can I meet my goal today? ",
    "How can I be better at work?",
    "How can i fulfill my calling as second ward councilor? ",

    };

    public string DisplayPrompt()
    {
        var randomQuestion = new Random();
        int i = randomQuestion.Next(_promptsQuestion.Length);
        string promptPriavte = _promptsQuestion[i];
        return promptPriavte;
    }
}