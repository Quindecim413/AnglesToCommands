using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnglesToCommands
{
    public partial class Charts : Form
    {
        public Charts()
        {
            InitializeComponent();
        }

        public void Update(Vector3 gravityVec)
        {
            try
            {
                chart1.Series["x"].Points.Add(gravityVec.X);
                chart1.Series["y"].Points.Add(gravityVec.Y);
                chart1.Series["z"].Points.Add(gravityVec.Z);
                while (chart1.Series["x"].Points.Count > numericUpDownMaxPoints.Value)
                {
                    chart1.Series["x"].Points.RemoveAt(0);
                    chart1.Series["y"].Points.RemoveAt(0);
                    chart1.Series["z"].Points.RemoveAt(0);
                }
                chart1.ResetAutoValues();
            }
            catch { }
        }
    }
}
