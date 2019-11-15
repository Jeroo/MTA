using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.CertMTA
{
    public delegate void SampleDelegate();

    public class SampleClass
    {
      


    }


    public interface ISampleEvents
    {
        event SampleDelegate SampleEvent;

        void Invoke();
    }
}
