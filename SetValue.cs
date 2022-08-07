using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace ASE_Shape_Programming_language
{
    class SetValue
    {
        public delegate void RefereshFigureDelegate();

        public delegate void ButtonDelegate(bool value);

        public delegate void CommandDelegate(StringBuilder text);
        PictureBox display;
        Button runBtn;
        TextBox errorBox;

        public Graphics g;

        public SolidBrush Brush;

        public int xPos, yPos;

        public Color colour;

        public bool fill = false;




        public SetValue(Graphics g, PictureBox display)
        {

            this.g = g;
            xPos = yPos = 210;
            colour = Color.Black;
            Brush = new SolidBrush(colour);
            this.display = display;
        }


        public void InvokeDelegate()
        {
            try
            {
                display.Invoke(new RefereshFigureDelegate(RefereshDisplay));
            }
            catch (InvalidOperationException)
            {

            }

        }

        public void InvokeConsoleDelegate(StringBuilder text)
        {
            try
            {
                runBtn.Invoke(new CommandDelegate(WriteErrors), text);
            }
            catch (InvalidOperationException)
            {

            }

        }

        public void InvokeBtnDelegate(bool value)
        {
            try
            {
                runBtn.Invoke(new ButtonDelegate(BtnStatus), value);
            }
            catch (InvalidOperationException)
            {

            }

        }
        public void RefereshDisplay()
        {
            display.Invalidate();
        }
        public void WriteErrors(StringBuilder errors)
        {
            this.errorBox.Text = errors.ToString();
        }
        public void BtnStatus(bool value)
        {
            runBtn.Enabled = value;
        }

        public void SetRunBtn(Button btn)
        {
            this.runBtn = btn;
        }
        public void SetTextBox(TextBox textbox)
        {
            this.errorBox = textbox;
        }

        public void SetBrushAndPenColor(String colorName)
        {
            this.colour = Color.FromName(colorName);
            Brush.Color = colour;

        }

        public void Drawto(int x, int y)
        {
            g.DrawLine(new Pen(colour), xPos, yPos, x, y);
            xPos = x;
            yPos = y;
        }

        public void Moveto(int x, int y)
        {
            xPos = x;
            yPos = x;
        }

        public void Clear()
        {
            g.Clear(Color.Transparent);

        }

        public void Reset()
        {
            xPos = yPos = 210;
            fill = false;
            colour = Color.Black;
            g.Clear(Color.Transparent);
        }

        public void DrawCursor(Graphics g)
        {
            SolidBrush brush = new SolidBrush(Color.Red);


            g.Clear(Color.Transparent);
            g.FillEllipse(brush, xPos - 2, yPos - 2, 4 * 4, 4 * 4);
        }


    }
}
