using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace assignment
{
    public class ValidateCode
    {   
        public string[] valid(String text)
        {
            string[] rPoint = { };

            string[] sText = text.Split(',', ' ');
            try                                     //try block
            {
                if (sText[0].ToUpper() == "MOVETO") // converts aplhabets to uppercase and condition is checked
                {
                    if (sText.Length == 3)
                    {
                        int x = Convert.ToInt32(sText[1]);// converts string value to integer and stores into variable
                        int y = Convert.ToInt32(sText[2]);
                        string xPoint = Convert.ToString(x);
                        string yPoint = Convert.ToString(y);
                        string[] sPoint = { "moveTo", xPoint, yPoint };// stores in array
                        rPoint = sPoint;
                    }
                    else
                    {
                        string[] sPoint = { "1", "1" };
                        rPoint = sPoint;
                        MessageBox.Show("Invalid Commmand");// displays message box
                  
                    }
                }
                if (sText[0].ToUpper() == "DRAWTO")
                {
                    if (sText.Length == 3)
                    {
                        int x = Convert.ToInt32(sText[1]);
                        int y = Convert.ToInt32(sText[2]);
                        string xPoint = Convert.ToString(x);
                        string yPoint = Convert.ToString(y);
                        string[] sPoint = { "drawTo", xPoint, yPoint };
                        rPoint = sPoint;
                    }
                    else
                    {
                        string[] sPoint = { "1", "1" };
                        rPoint = sPoint;
                        MessageBox.Show("Invalid Commmand");// displays message box
                    }
                }

                if (sText[0].ToUpper() == "RECTANGLE")
                {
                    if (sText.Length == 3 )
                    {
                        int x = Convert.ToInt32(sText[1]);
                        int y = Convert.ToInt32(sText[2]);
                        string xPoint = Convert.ToString(x);
                        string yPoint = Convert.ToString(y);
                        string[] sPoint = { "rectangle", xPoint, yPoint };
                        rPoint = sPoint;
                    }
                    else
                    {
                        string[] sPoint = { "1", "1" };
                        rPoint = sPoint;
                        MessageBox.Show("Invalid Commmand");// displays message box
                    }
                }
                if (sText[0].ToUpper() == "TRIANGLE")
                {
                    if (sText.Length == 4)
                    {
                        int x = Convert.ToInt32(sText[1]);
                        int y = Convert.ToInt32(sText[2]);
                        int z = Convert.ToInt32(sText[3]);
                        String xPoint = Convert.ToString(x);
                        String yPoint = Convert.ToString(y);
                        String zPoint = Convert.ToString(z);
                        string[] sPoint = { "triangle", xPoint, yPoint, zPoint };
                        rPoint = sPoint;
                    }
                    else
                    {
                        string[] sPoint = { "1", "1" };
                        rPoint = sPoint;
                        MessageBox.Show("Invalid Commmand");// displays message box
                    }
                }
                if (sText[0].ToUpper() == "CIRCLE")
                {
                    if (sText.Length == 2)
                    {
                        int x = Convert.ToInt32(sText[1]);
                        String xPoint = Convert.ToString(x * 2);
                        string[] sPoint = { "circle", xPoint };
                        rPoint = sPoint;
                    }
                    else
                    {
                        string[] sPoint = { "1","1"};
                        rPoint = sPoint;
                        MessageBox.Show("Invalid Commmand");// displays message box
                    }
                }
            }
            catch (FormatException e) // catches incorrect format in code
            {
                string[] sPoint = { "1","1" };
                rPoint = sPoint;
                MessageBox.Show(e.Message);

            }
            catch(IndexOutOfRangeException o)
            {

            }
            return rPoint;
        }

    }
    
}
