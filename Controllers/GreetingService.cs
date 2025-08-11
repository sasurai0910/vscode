public class GreetingService
{
    public string GetGreetingMessage()
    {
        var hour = DateTime.Now.Hour;

        if (hour >= 5 && hour < 12)
            return "おはようございます！";
        else if (hour >= 12 && hour < 18)
            return "こんにちは！";
        else if (hour >= 18 && hour < 22)
            return "こんばんは！";
        else
            return "今日も1日お疲れ様です！";
    }
}
