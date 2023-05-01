using System.Collections.Generic;
using UnityEngine;

namespace Core
{
    public class RandomNumberGenerator : MonoBehaviour
    {
        private int _min;
        private int _max;
        private int _lastNumber;
        
        public void SetMinMaxRange(int min, int max)
        {
            _min = max;
            _max = max;
        }

        public int GetRandom()
        {
            return Random.Range(_min, _max);
        }

        public int GetUniqueRandom()
        {
            int randomNumber;
            var counter = 0;

            do
            {
                randomNumber = Random.Range(_min, _max);
                counter++;
            } while (randomNumber == _lastNumber || counter < 100);

            return randomNumber;
        }
    }
}