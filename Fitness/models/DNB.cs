using System;
using System.Collections.Generic;
using System.Text;

namespace Fitness
{
    class DNB : IWorkOutInterface
    {
        public string GetDescription()
        {
            return @"A combat, cardio, HIIT training workout to Drum N Bass with disco lights
& glowsticks… don`t forget the countdown.";
        }

        public string GetId()
        {
            return "DNB";
        }

        public string GetName()
        {
            return "Drum'N'Base";
        }

        public string GetVideoURL()
        {
            return @"<iframe width='100%' height='95%' src='https://www.youtube.com/embed/4phDoqsGVbQ' frameborder='0' allow='accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture' allowfullscreen></iframe>";
        }
    }
}
