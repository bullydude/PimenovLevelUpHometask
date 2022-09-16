using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Hometask_8_Observer_pattern
{
    internal class NumbersProcessor
    {
        public delegate void delegate_OnNumbersEntered(int[] number_in);
        public event delegate_OnNumbersEntered? OnNumbersEntered;
        public void CallEvent(int[] arr)
        {
            OnNumbersEntered?.Invoke(arr);
        }
    }
}
