namespace WebApp.Code
{
    public class GetIdNum
    {
        public int[] GetID(int min, int max, int[] oldNum)
        {
            bool NotSame = true;
            int[] num = new int[2];
            while (NotSame == true)
            {
                num[0] = RandomNum.GetNum(min, max);
                num[1] = RandomNum.GetNum(min, max);
                foreach (int i in oldNum)
                {
                    if (num[0] == i) { break; }
                    else if (num[1] == i) { break; }
                }
                if (num[0] != num[1])
                {
                    NotSame = false;
                }
            }
            return num;
        }
    }
}
