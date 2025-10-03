using SingletonPattern;

class Program
{
  static void Main(string[] args)
  {
    // Get the singleton instance of Logger
    Logger logger = Logger.Instance;
    Logger anotherLoggerReference = Logger.Instance;

    // Log some messages
    logger.Log("Application started.");
    logger.Log("Performing some operations...");
    logger.Log("Application ended.");

    // Verify that both references point to the same instance
    if (ReferenceEquals(logger, anotherLoggerReference))
    {
      logger.Log("Both references point to the same Logger instance.");
      logger.Log($"Instance HashCode: {logger.GetHashCode()}");
      logger.Log($"Another Reference HashCode: {anotherLoggerReference.GetHashCode()}");
    }
    else
    {
      logger.Log("Different instances exist, which should not happen in a singleton.");
      logger.Log($"Instance HashCode: {logger.GetHashCode()}");
      logger.Log($"Another Reference HashCode: {anotherLoggerReference.GetHashCode()}");
    }
  }
}