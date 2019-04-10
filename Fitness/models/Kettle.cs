using System;
using System.Collections.Generic;
using System.Text;

namespace Fitness
{
    class Kettle : IWorkOutInterface
    {
        public string GetDescription()
        {
            return @"It uses the specially formulated B.S.M. method… our own secret formula to maximising calorie burn destroying fat super quick! It gets results fast, melts fat redefining your abs. It increases lean, toned muscle for a more sculpted
appearance> It’s the ALL-over body transform fat loss and toning program.

It’s already a proven success, it’s safe, fun and effective, and covers all levels of fitness from beginner to advanced.";
        }

        public string GetId()
        {
            return "KET";
        }

        public string GetName()
        {
            return "Kettlercise";
        }

        public string GetVideoURL()
        {
            return @"<iframe width='100%' height='95%' src='https://www.youtube.com/embed/zeV5_cAFGDw' frameborder='0' allow='accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture' allowfullscreen></iframe>";
        }
    }
}
