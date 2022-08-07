using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace ASE_Shape_Programming_language
{
    class CommandParser
    {
        public ArrayList errors = new ArrayList();

        SetValue holdValue;

        ShapeFactory factory;// factor object for creating shape 

        Shape shape;// shape cobject to store individual shape

        int lineNumber = 0;// Stores Index of the line.

        public CommandParser(SetValue holdValue)//constructor that sets the SetValue class object 
        {
            this.holdValue = holdValue;//setting the graphics of where the shape should be made



            factory = new ShapeFactory();//object for creating shapes

        }

        public void Validate(String text)// Method that checks multiLine command
        {
            String line = text.ToLower().Trim();

            string[] cmd = line.Split(new string[] { "\n", "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < cmd.Length; i++)
            {

                this.lineNumber = i;
                lineNumber++;
                try
                {
                    String[] split = cmd[i].Split(' '); //splitting the single line 

                    if (split.Length == 2)
                    {
                        //command and parameters from te command line 
                        String Command = split[0];

                        //getting shape 
                        shape = factory.getShape(Command);

                        //stores parameters or other command like colors and on/off for pen
                        string[] parameters = split[1].Split(',');

                        //checks if the command parsed as returned a shape or not
                        if (shape != null)
                        {
                            try
                            {

                                if (Command.Equals("circle") || Command.Equals("square"))
                                {
                                    int radius = Int32.Parse(parameters[0]);
                                    shape.set(holdValue.colour, holdValue.xPos, holdValue.yPos, radius);
                                }
                                else if (parameters.Length == 2)
                                {
                                    int param1 = Int32.Parse(parameters[0]);

                                    int param2 = Int32.Parse(parameters[1]);

                                    shape.set(holdValue.colour, holdValue.xPos, holdValue.yPos, param1, param2);
                                }

                                shape.draw(holdValue.g, holdValue.fill);

                            }
                            catch (FormatException)
                            {

                                throw new InvalidParameterException();
                            }
                            catch (IndexOutOfRangeException)
                            {
                                throw new InvalidParameterException();
                            }

                        }
                        else if (Command.Equals("drawto") == true)
                        {
                            Console.WriteLine(parameters[0] + " " + parameters[1]);
                            try
                            {
                                int param1 = Int32.Parse(parameters[0]);

                                int param2 = Int32.Parse(parameters[1]);

                                holdValue.Drawto(param1, param2);
                            }
                            catch (FormatException)
                            {
                                throw new InvalidParameterException();

                            }

                        }
                        else if (Command.Equals("moveto") == true)
                        {
                            try
                            {
                                int param1 = Int32.Parse(parameters[0]);

                                int param2 = Int32.Parse(parameters[1]);

                                holdValue.Moveto(param1, param2);
                            }
                            catch (FormatException)
                            {
                                throw new InvalidParameterException();

                            }
                        }
                        else if (Command.Equals("fill") == true)
                        {
                            parameters[0] = parameters[0].ToLower().Trim();

                            if (parameters[0].Equals("on") == true)
                            {
                                holdValue.fill = true;
                            }

                            else if (parameters[0].Equals("off") == true)
                            {
                                holdValue.fill = false;
                            }

                            else throw new InvalidParameterException();

                        }
                        else if (Command.Equals("pen") == true)
                        {
                            parameters[0] = parameters[0].ToLower().Trim();

                            if (parameters[0].Equals("red")) { holdValue.SetBrushAndPenColor("red"); }
                            else if (parameters[0].Equals("green")) { holdValue.SetBrushAndPenColor("green"); }
                            else if (parameters[0].Equals("blue")) { holdValue.SetBrushAndPenColor("blue"); }
                            else if (parameters[0].Equals("yellow")) { holdValue.SetBrushAndPenColor("yellow"); }
                            else if (parameters[0].Equals("lime")) { holdValue.SetBrushAndPenColor("lime"); }
                            else if (parameters[0].Equals("gold")) { holdValue.SetBrushAndPenColor("gold"); }
                            else if (parameters[0].Equals("cyan")) { holdValue.SetBrushAndPenColor("cyan"); }
                            else if (parameters[0].Equals("tomato")) { holdValue.SetBrushAndPenColor("tomato"); }
                            else if (parameters[0].Equals("black")) { holdValue.SetBrushAndPenColor("black"); }
                            else throw new InvalidParameterException();
                        }
                        else
                        {
                            //different error display for different textbox inputs.
                            if (lineNumber != 0)
                            {
                                errors.Add("Invalid command and parameter given at line: " + lineNumber + "\r\n");
                            }

                            else
                                errors.Add("Invalid command and parameter given." + "\r\n");
                        }

                    }

                    else if (split.Length > 2)
                    {

                        throw new InvalidCommandException("Invalid command");
                    }

                    //only for textcommands
                    if (lineNumber != 0) holdValue.InvokeDelegate();


                }
                catch (InvalidCommandException a)
                {

                    errors.Add("Invalid command at line : " + lineNumber + "\r\n");
                    Console.WriteLine(a);
                    holdValue.InvokeDelegate();
                }
                catch (InvalidParameterException)
                {
                    errors.Add("Parameter given for the command is invalid at: " + lineNumber + "\r\n");
                    holdValue.InvokeDelegate();
                }
                catch (IndexOutOfRangeException e)
                {
                    Console.WriteLine(e);
                    holdValue.InvokeDelegate();
                }
            }



        }

        public ArrayList getErrors()
        {
            return errors;
        }

        public int getErrorCount()
        {
            return errors.Count;
        }
        public void ClearErrors()
        {
            errors.Clear();
        }
    }
}
