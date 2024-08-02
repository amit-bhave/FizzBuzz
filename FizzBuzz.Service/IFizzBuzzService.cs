using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FizzBuzz.Models;

namespace FizzBuzz.Service
{
    public interface IFizzBuzzService
    {
        List<FizzBuzzResult> GetFizzBuzzResults();
    }
}
