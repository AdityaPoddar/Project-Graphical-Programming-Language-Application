using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;
using System.Windows.Forms;

namespace ASE_Shape_Programming_language
{
    class FileLoadAndWrite
    {
        ArrayList filecontent;
        string filePath;

        /// <summary>
        /// Opens the Loadfile dialogbox and loads the file
        /// </summary>
        /// <returns>File contents as an arraylist.</returns>
        public ArrayList LoadFile()
        {
            using (OpenFileDialog openfileDialog = new OpenFileDialog())
            {


                filecontent = new ArrayList();

                openfileDialog.InitialDirectory = "E:\\lvl6\\software projects\\gpl-project\\GPL_APP\\test_file";
                openfileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openfileDialog.FilterIndex = 2;
                openfileDialog.RestoreDirectory = true;

                if (openfileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openfileDialog.FileName;
                }
            }
            try
            {
                using (StreamReader s = File.OpenText(filePath))
                {
                    do
                    {

                        string line = s.ReadLine();
                        if (line == null) break;
                        filecontent.Add(line);
                        // Note, we could have used
                        // textBox1 += s.ReadToEnd();
                    } while (true);

                }


            }
            catch (FileNotFoundException)
            {

            }
            catch (IOException ie)
            {

            }
            catch (Exception) { }
            return filecontent;
        }

        /// <summary>
        /// Opens save dialog box and writes the content onto the file.
        /// </summary>
        /// <param name="text">String of content to be written on the file.</param>
        public void WriteFile(String text)
        {
            using (SaveFileDialog savefileDialog = new SaveFileDialog())
            {

                savefileDialog.InitialDirectory = "E:\\lvl6\\software projects\\gpl-project\\GPL_APP\\test_file";
                savefileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                savefileDialog.Title = "Save an Image File";
                savefileDialog.ShowDialog();

                if (savefileDialog.FileName != "")
                {
                    //Get the path of specified file
                    filePath = Path.GetFullPath(savefileDialog.FileName);
                    Console.WriteLine(filePath);
                    savefileDialog.Dispose();
                }
            }

            try
            {

                using (StreamWriter s = File.CreateText(filePath))
                {
                    s.WriteLine(text);

                }
                // Note, we could have used
                // textBox1 += s.ReadToEnd();
            }
            catch (IOException ie)
            {

            }
            catch (Exception i)
            {

            }
        }
    }
}
