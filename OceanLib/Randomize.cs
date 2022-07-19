using System;

namespace OceanLib
{
    public class Randomize
    {
        #region [Variables]

        readonly Random rnd = new Random((int)DateTime.Now.Ticks);

        public int randomNumber;

        #endregion

        #region [Method]

        public int RandomNumber(int maxValue)
        {
            randomNumber = rnd.Next(0, maxValue);

            return randomNumber;
        }

        #endregion
    }
}
