namespace WebApp.Code
{
    public class RandomNum
    {
        public static int GetNum(int min, int max)
        {
            Random r = new Random();
            return r.Next(min, max);
        }
    }
}
