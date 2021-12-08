using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
     class Adapt : IVeiw
    {
        private readonly LivePhoto photo;
        public Adapt(LivePhoto livephoto)
        {
            this.photo = livephoto;
        }
        public void VeiwPhoto()
        {
            Console.WriteLine("Showing a still image, the video will be saved as a different file");
        }
    }
}
