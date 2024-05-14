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
    public partial class AnglesDrawer : Form
    {
        public AnglesDrawer()
        {
            InitializeComponent();
        }


        Vector3 lastGravityVec = new Vector3(0, 0, 1);
        Vector3 baseVec = new Vector3(0, 0, -1);
        public void Update(Vector3 currentGravityVec,
            Vector3 vecForward, Vector3 vecBackward, Vector3 vecLeft, Vector3 vecRight,
            CommandState forwardState, CommandState backwardState, CommandState leftState, CommandState rightState,
            double angleThreshold)
        {
            lastGravityVec = Vector3.Normalize(currentGravityVec);

            Vector3 gVec = new Vector3(0, 0, -1);
            Vector3 rotationVec = Vector3.Cross(gVec, baseVec);
            if (rotationVec.Length() != 0)
                rotationVec = Vector3.Normalize(rotationVec);
            double angleBetween = AngleBetweenVectors(baseVec, gVec, rotationVec);
            
            Quaternion rotation = Quaternion.CreateFromAxisAngle(rotationVec, (float)angleBetween);

            Quaternion orientationRotation = Quaternion.CreateFromAxisAngle(gVec,
                (float)(trackBarRotationAngle.Value / 180.0 * Math.PI));

            rotation = Quaternion.Concatenate(rotation, orientationRotation);

            Vector3 cursorVec = Vector3.Transform(currentGravityVec, rotation);
            
            Vector3 forwardDir = Vector3.Transform(vecForward, rotation);
            Vector3 backwardDir = Vector3.Transform(vecBackward, rotation);
            Vector3 leftDir = Vector3.Transform(vecLeft, rotation);
            Vector3 rightDir = Vector3.Transform(vecRight, rotation);

            PointF forwardOnPlane = GetProjection(forwardDir);
            PointF backwardOnPlane = GetProjection(backwardDir);
            PointF leftOnPlane = GetProjection(leftDir);
            PointF rightOnPlane = GetProjection(rightDir);

            

            Bitmap m = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            using (var g = Graphics.FromImage(m))
            {
                DrawGravityArea(g, currentGravityVec, angleThreshold);
                DrawCommandOnPlane(g, 6, forwardState, forwardOnPlane);
                DrawCommandOnPlane(g, 7, backwardState, backwardOnPlane);
                DrawCommandOnPlane(g, 9, leftState, leftOnPlane);
                DrawCommandOnPlane(g, 8, rightState, rightOnPlane);

                DrawAngleBorder(g, 30);
                DrawAngleBorder(g, 45);
                DrawAngleBorder(g, 90);
                DrawAngleBorder(g, 135);
                DrawAngleBorder(g, 180);
            }

            pictureBox1.Image = m;
            pictureBox1.Invalidate();
        }

        /*
         public void Update(Vector3 currentGravityVec,
            Vector3 vecForward, Vector3 vecBackward, Vector3 vecLeft, Vector3 vecRight,
            CommandState forwardState, CommandState backwardState, CommandState leftState, CommandState rightState,
            double angleThreshold)
        {
            lastGravityVec = Vector3.Normalize(currentGravityVec);

            Vector3 sVec = new Vector3(0, 0, -1);
            Vector3 rotationVec = Vector3.Cross(sVec, baseVec);
            double angleBetween = AngleBetweenVectors(baseVec, sVec, rotationVec);
            var t = angleBetween / Math.PI * 180;
            Quaternion rotation = Quaternion.CreateFromAxisAngle(rotationVec, (float)angleBetween);

            Quaternion orientationRotation = Quaternion.CreateFromAxisAngle(sVec,
                (float)(trackBarRotationAngle.Value / 180.0 * Math.PI));

            rotation = Quaternion.Concatenate(rotation, orientationRotation);

            Vector3 gravityDir = Vector3.Transform(currentGravityVec, rotation);
            Vector3 forwardDir = Vector3.Transform(vecForward, rotation);
            Vector3 backwardDir = Vector3.Transform(vecBackward, rotation);
            Vector3 leftDir = Vector3.Transform(vecLeft, rotation);
            Vector3 rightDir = Vector3.Transform(vecRight, rotation);

            PointF forwardOnPlane = GetProjection(forwardDir);
            PointF backwardOnPlane = GetProjection(backwardDir);
            PointF leftOnPlane = GetProjection(leftDir);
            PointF rightOnPlane = GetProjection(rightDir);

            

            Bitmap m = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            using (var g = Graphics.FromImage(m))
            {
                DrawGravityArea(g, gravityDir, angleThreshold);
                DrawCommandOnPlane(g, 1, forwardState, forwardOnPlane);
                DrawCommandOnPlane(g, 2, backwardState, backwardOnPlane);
                DrawCommandOnPlane(g, 3, leftState, leftOnPlane);
                DrawCommandOnPlane(g, 4, rightState, rightOnPlane);

                DrawAngleBorder(g, 30);
                DrawAngleBorder(g, 45);
                DrawAngleBorder(g, 90);
                DrawAngleBorder(g, 135);
                DrawAngleBorder(g, 180);
            }

            pictureBox1.Image = m;
            pictureBox1.Invalidate();
        }
         */

        private double GetAngleRadius(double angle)
        {
            angle = angle / 180 * Math.PI;
            double x = Math.Sin(angle);
            double z = -Math.Cos(angle);
            Vector3 vec = new Vector3((float)x, 0, (float)z);

            var proj = GetProjection(vec);
            if (float.IsNaN(proj.X))
                return 2;
            return Math.Sqrt(proj.X * proj.X + proj.Y + proj.Y);
        }

        private void DrawAngleBorder(Graphics g, double angle)
        {
            float radius = (float)GetAngleRadius(angle);
            var size = pictureBox1.Size;
            PointF center = new PointF(size.Width / 2, size.Height / 2);

            float factor = Math.Min(size.Width, size.Height) * 0.95f / 4 * (float)Zoom;
            radius *= factor;
            g.DrawEllipse(angleBorderPen, (float)(center.X - radius), (float)(center.Y - radius), 
                radius * 2, radius * 2);

            TextRenderer.DrawText(g, Math.Round(angle).ToString(), Font, 
                new Rectangle(-10 + (int)center.X, (int)(center.Y - radius) - 10, 20, 20),
                Color.Black,
              TextFormatFlags.HorizontalCenter |
              TextFormatFlags.VerticalCenter |
              TextFormatFlags.GlyphOverhangPadding);
        }

        private void DrawGravityArea(Graphics g, Vector3 gravityDir, double angleThreshold)
        {
            int numPoints = 50;

            Vector3 perp = Vector3.Normalize(new Vector3(gravityDir.X, gravityDir.Y + 0.5f, gravityDir.Z));
            perp = Vector3.Normalize(Vector3.Cross(perp, gravityDir));

            Quaternion gravityRotation = Quaternion.CreateFromAxisAngle(perp, (float)(angleThreshold / 180 * Math.PI));
            Vector3 gravityRotated = Vector3.Normalize(Vector3.Transform(gravityDir, gravityRotation));
            gravityRotation = Quaternion.CreateFromAxisAngle(gravityDir, (float)(2 * Math.PI / numPoints));
            PointF[] locations = new PointF[numPoints];

            for (int i = 0; i < numPoints; i++)
            {
                locations[i] = GetProjection(gravityRotated);
                gravityRotated = Vector3.Normalize(Vector3.Transform(gravityRotated, gravityRotation));
            }

            var size = pictureBox1.Size;
            PointF center = new PointF(size.Width / 2, size.Height / 2);

            float factor = Math.Min(size.Width, size.Height) * 0.95f / 4 * (float)Zoom;
            g.FillClosedCurve(gravityVecBrush, locations.Select(el=>new PointF(el.X * factor + center.X, el.Y * factor + center.Y)).ToArray());
        }

        private void DrawCommandOnPlane(Graphics g, int commandCode, CommandState state, PointF coordinatesProjection)
        {
            if (float.IsNaN(coordinatesProjection.X) || float.IsInfinity(coordinatesProjection.Y))
                return;

            var size = pictureBox1.Size;

            PointF center = new PointF(size.Width / 2, size.Height / 2);

            float factor = Math.Min(size.Width, size.Height) * 0.95f / 4 * (float)Zoom;
            PointF pointOnPicture = new PointF(coordinatesProjection.X * factor, coordinatesProjection.Y * factor);
            pointOnPicture = new PointF(pointOnPicture.X + center.X, pointOnPicture.Y + center.Y);

            RectangleF rec = new RectangleF(
                pointOnPicture.X - pointRadius, pointOnPicture.Y - pointRadius,
                pointRadius * 2, pointRadius * 2);

            switch (state)
            {
                case CommandState.InProgress:
                    g.FillEllipse(inProgressBrush, rec);
                    break;
                case CommandState.NotSelected:
                    g.FillEllipse(notSelectedBrush, rec);
                    break;
                case CommandState.Selected:
                    g.FillEllipse(selectedBrush, rec);
                    break;
                case CommandState.Unclear:
                    g.FillEllipse(unclearBrush, rec);
                    break;
            }
            TextRenderer.DrawText(g, commandCode.ToString(), Font, new Rectangle((int)rec.X, (int)rec.Y, (int)rec.Width, (int)rec.Height), 
                Color.Black,
              TextFormatFlags.HorizontalCenter |
              TextFormatFlags.VerticalCenter |
              TextFormatFlags.GlyphOverhangPadding);

        }

        Brush inProgressBrush = new SolidBrush(Color.Yellow);
        Brush notSelectedBrush = new SolidBrush(Color.AntiqueWhite);
        Brush selectedBrush = new SolidBrush(Color.Green);
        Brush unclearBrush = new SolidBrush(Color.LightGray);

        float pointRadius = 10;

        Brush gravityVecBrush = new SolidBrush(Color.Blue);

        Pen angleBorderPen = new Pen(Color.Gray);

        private PointF GetProjection(Vector3 vec)
        {
            if(vec.Z == 1)
            {
                return new PointF(float.NaN, float.NaN);
            }
            bool flipX = checkBoxFlipCoordinates.Checked;
            if (flipX)
                return new PointF(-(float)(Math.Sqrt(2 / (1 - vec.Z)) * vec.X), (float)(Math.Sqrt(2 / (1 - vec.Z)) * vec.Y));
            else
                return new PointF((float)(Math.Sqrt(2 / (1 - vec.Z)) * vec.X), (float)(Math.Sqrt(2 / (1 - vec.Z)) * vec.Y));
        }

        public static float AngleBetweenVectors(Vector3 v1, Vector3 v2, Vector3 up)
        {
            var cross = Vector3.Cross(v1, v2);
            var dot = Vector3.Dot(v1, v2);

            var angle = Math.Atan2(cross.Length(), dot);

            var test = Vector3.Dot(up, cross);
            if (test < 0.0) angle = -angle;
            return (float)angle;
        }

        private void buttonFixCenter_Click(object sender, EventArgs e)
        {
            baseVec = lastGravityVec;
        }

        private void trackBarZoom_Scroll(object sender, EventArgs e)
        {
            textBoxZoom.Text = Zoom.ToString();
        }
        private double Zoom
        {
            get
            {
                return trackBarZoom.Value / 10.0;
            }
        }

        private void trackBarRotationAngle_Scroll(object sender, EventArgs e)
        {
            textBoxRotationAngle.Text = trackBarRotationAngle.Value.ToString();
        }
    }
}
