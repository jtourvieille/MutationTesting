namespace FizzBuzz.Impl
{
    public class FizzBuzzService
    {
        public string Play(int upperBound)
        {
            return "1";
        }

        #region Hidden
        //public string Play(int upperBound)
        //{
        //    string finalOutput = string.Empty;
        //    for (int i = 1; i <= upperBound; i++)
        //    {
        //        string localOutput = i % 3 == 0 ? "Fizz" : string.Empty;
        //        localOutput += i % 5 == 0 ? "Buzz" : string.Empty;
        //        localOutput += localOutput == string.Empty ? i.ToString() : string.Empty;

        //        finalOutput += localOutput;
        //    }
        //    return finalOutput;
        //}
        #endregion
    }
}
