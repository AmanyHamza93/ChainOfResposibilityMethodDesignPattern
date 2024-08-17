using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResposibilityMethodDesignPattern
{
    public class ZeroProcessor : Processor
    {
        public ZeroProcessor(Processor nextProcessor) : base(nextProcessor)
        {
        }

        public override void Process(Number request)
        {
            if (request.GetNumber() == 0)
            {
                Console.WriteLine($" ZeroProcessor: {request.GetNumber()}");
            }
            else
            {
                base.Process(request);
            }
        }
    }
}
