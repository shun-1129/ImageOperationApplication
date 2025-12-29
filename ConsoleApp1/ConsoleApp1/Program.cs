using NLog;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main ( string[] args )
        {
            Logger logger = LogManager.GetCurrentClassLogger();

            logger.Info ( "Application started." );

            for ( int i = 0 ; i < 100 ; i++ )
            {
                logger.Error ( $"Processing item {i}" );
            }

            Console.WriteLine ( "Hello, World!" );
        }
    }
}
