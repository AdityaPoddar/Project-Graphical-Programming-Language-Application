using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace ASE_Shape_Programming_language
{
    public partial class ShapeProgrammingLanguage : Form
    {
        string cmd;
        SetValue holdValue;
        CommandParser cmdParser;

        Bitmap displayBitmap = new Bitmap(492, 495);//bitmap to draw that will be displayed in the picture box

        Bitmap cursorBitmap = new Bitmap(492, 495);// bitmap for displaying the cursour on the picture box

        ArrayList storeFile;// Arraylist to storeFile the file name 
        public ShapeProgrammingLanguage()
        {
            InitializeComponent();
            holdValue = new SetValue(Graphics.FromImage(displayBitmap), figure);//passing the graphics value to set in the paint class so that it known where to draw
            cmdParser = new CommandParser(holdValue);//class for handling the drawing, pass the drawing surface to it
            holdValue.DrawCursor(Graphics.FromImage(cursorBitmap));//providing the cursour image so that it is visible
            holdValue.SetRunBtn(button);//making the paint class acknowledge the execute button 
            holdValue.SetTextBox(output);//making the paint class acknowledge the textbox which displays errors 
        }

        private void cmd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !command.Text.Equals(""))//checking if the key pressed is entere and the text box is not empty
            {
                cmd = command.Text.ToLower().Trim();

                if (cmd.Equals("run"))
                {
                    button.PerformClick();
                }
               else if (cmd.Equals("clear"))
                {
                    holdValue.Clear();
                    Refresh();
                }
                else if (cmd.Equals("reset"))
                {
                    instruction.Text = "";
                    holdValue.Reset();
                    Refresh();
                }
                else
                {
                    output.Text = "The command given is invalid.";
                }

                if (cmdParser.errors.Count != 0)//if condition that checks the count is not equal to zero of the arraylist form complie class which is inherited by the commandparser class
                {
                    foreach (var item in cmdParser.errors)//running a loop for all the objects coantined inside the arraylist
                        output.Text += item.ToString();//displaying the error message in the consodle textbox
                }
                Refresh();  //signify that display needs updating

                cmdParser.ClearErrors();//calling the ClearError method of the complie class which is inherited by the commandparser class to empty the arraylist from its values

            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if (command.Text.ToLower().Trim().Equals("run"))
            {
                output.Text = " ";
                string instructions = instruction.Text;
                cmdParser.Validate(instructions);
            }
            else if (command.Text.ToLower().Trim().Equals("clear"))
            {
                holdValue.Clear();
                Refresh();
            }
            else if (command.Text.ToLower().Trim().Equals("reset"))
            {
                instruction.Text = "";
                holdValue.Reset();
                Refresh();
            }

            else
            {
                output.Text = "The command given is invalid.";
            }


            if (cmdParser.errors.Count != 0)//if condition that checks the count is not equal to zero of the arraylist form complie class which is inherited by the commandparser class
            {
                foreach (var item in cmdParser.errors)//running a loop for all the objects coantined inside the arraylist
                    output.Text += item.ToString();//displaying the error message in the consodle textbox
            }
            Refresh();  //signify that display needs updating

            cmdParser.ClearErrors();//calling the ClearError method of the complie class which is inherited by the commandparser class to empty the arraylist from its values

        }

        private void fig_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics; //get graphics context where the shapes are to be created

            holdValue.DrawCursor(Graphics.FromImage(cursorBitmap));//creating the red dot that is seen on the picturebox

            g.DrawImageUnscaled(displayBitmap, 0, 0);
            g.DrawImageUnscaled(cursorBitmap, 0, 0);
            cursorBitmap.MakeTransparent();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            instruction.Text = "";//restting the value of cmdtext to be empty

            storeFile = new FileLoadAndWrite().LoadFile();//assigning the file value to the arraylist

            foreach (string s in storeFile) //running the loop unitl the lenght of the arraylist 
            {
                instruction.Text += s +"\n"; //print text present inside the file on cmdText textbox
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FileLoadAndWrite().WriteFile(instruction.Text);//creating a new file with the name that the user provided where all the text present inside the cmdText box is present
        }
      

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
