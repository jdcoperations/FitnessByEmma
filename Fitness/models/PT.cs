using System;
using System.Collections.Generic;
using System.Text;

namespace Fitness.models
{
    class PT : IWorkOutInterface

    {
        public string GetDescription()
        {
            return @"Personal training is available with flexible days and times with evenings and early mornings available

I have a small converted studio available at my home or I can come to you, exercise sessions last up-to an hour, programs are tailored around your fitness levels and goal, plus any injuries or medical issues you may have

Weigh-ins and measurements are checked around every 6-8 weeks

Inductions must be organised to arrange the first session and contracts must be signed to cover the instructor, sessions are booked and paid for in a  4 week block";
        }

        public string GetId()
        {
            return "PT";
        }

        public string GetName()
        {
            return "Personal Training";
        }

        public string GetVideoURL()
        {
            return @"<iframe width='100%' height='95%' src='https://www.youtube.com/embed/uwdf2OiOMHE' frameborder='0' allow='accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture' allowfullscreen></iframe>";
        }
    }
}
