using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt3.HSV
{
    class LabFilter : IFilter
    {
        private HSVForm mainForm;

        public LabFilter(HSVForm form)
        {
            this.mainForm = form;
        }

        public string Label1 => "L";

        public string Label2 => "a";

        public string Label3 => "b";

        public override string ToString() => "Lab";

        public bool PropertiesEnabled => true;

        public (Color, Color, Color) FilterColor(Color color)
        {
            return (default, default, default);
        }
    }
}
