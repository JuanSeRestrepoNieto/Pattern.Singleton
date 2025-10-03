namespace SingletonPattern
{
  public sealed class Logger
  {
    private static Logger? _instance;
    private static readonly object _lock = new object();

    // Private constructor to prevent instantiation from outside
    private Logger() { }

    public static Logger Instance
    {
      get
      {
        if (_instance == null)
        {
          lock (_lock)
          {
            if (_instance == null)
            {
              _instance = new Logger();
            }
          }
        }
        return _instance;
      }
    }

    public void Log(string message)
    {
      // Simple log to console for demonstration purposes
      Console.WriteLine($"{DateTime.Now}: {message}");
    }
  }
}