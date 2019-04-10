using System;
using System.Collections.Generic;
using System.Text;

namespace Fitness
{
    class LBT : IWorkOutInterface
    {
        public string GetDescription()
        {
            return @"This class is a great way to target those hard to work areas using resistance bands at different strengths to challenge each area.";
        }

        public string GetId()
        {
            return "LBT";
        }

        public string GetName()
        {
            return "Legs, Bums & Tums";
        }

        public string GetVideoURL()
        {
            return @"<iframe width='100%' height='95%' src='https://www.youtube.com/embed/zeV5_cAFGDw' frameborder='0' allow='accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture' allowfullscreen></iframe>";
        }
    }
}
