//Grading ID: A5196
//Program Number: Program 4
//Due Date: 25 April 2017
//Course Section: CIS 199-01
//This program stores and retrieves package data for the user, also updating origin and destination.
//It does so by creating a class for the packages, and each package is stored as an object, instance of that class.
//
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program4
{
    public partial class Program4Form : Form
    {
        //List to hold the package objects of the packages that the user creates
        private List<GroundPackage> packageList = new List<GroundPackage>();
        //Constant to hold the U of L zip for setting destination and origin to it.
        private const int UOFL_ZIP = 40292;

        //Precondition: none
        //Postcondition: form constructed
        public Program4Form()
        {
            InitializeComponent();
        }


        //Event handler for when user clicks button to add a package.
        //Precondition:Button Clicked
        //Postcondition: User's package, if valid, will be added to the list
        private void addPackageButton_Click(object sender, EventArgs e)
        {
            int originZip;//Variable to hold the Origin Zip Code
            int destZip; //Variable to hold the Destination Zip Code
            double length; //Variable to hold the Length of the Package
            double width; //Variable to hold the width of the package.
            double height; //Variable to hold the height of the package
            double weight;  //Variable to hold the weight of the package

            //If that calls the Package Validator method.
            //if the package is valid, all variables are filled and package added to list.
            if (PacakgeValidator(out originZip, out destZip, out length, out width, out height, out weight))
            {
                //Creates a new GroundPackage obhect with user's details.
                GroundPackage userPackage = new GroundPackage(originZip, destZip, length, width, height, weight);
                //Adds the prices of the user's package to the listbox
                packageListBox.Items.Add(userPackage.CalcCost().ToString("C"));
                //Adds the package to the GroundPackage objects list
                packageList.Add(userPackage);
                //clears the text boxes
                originTextBox.Clear(); 
                originTextBox.Clear();
                destinationTextBox.Clear();
                lengthTextBox.Clear();
                widthTextBox.Clear();
                heightTextBox.Clear();
                weightTextBox.Clear();
            }
        }

        //Event handler for when package details button is pressed.
        //Precondition:Button Pressed
        //Postcondition: package details presented in listbox.
        private void packageDetailsButton_Click(object sender, EventArgs e)
        {
            //if statement that checks if package is selected, by calling that method.
            if(PackageSelected())
            {
                int index = packageListBox.SelectedIndex; //Var to hold the location of package in list box.
                MessageBox.Show(packageList[index].ToString());//Gets package of same position in list.
            }
        }

        //Event handler for when send to UofL button is pressed.
        private void sendToUOfLButton_Click(object sender, EventArgs e)
        {
            //again calls method to see if a package is selected
            //Precondition:Button Pressed
            //Postcondition: Package destination zip updated to UofL's, price updated.
            if (PackageSelected())
            {
                int index = packageListBox.SelectedIndex;//var to hold selected package location
                packageList[index].DestinationZip = UOFL_ZIP;//Updates selected packages destination zip
                //Recalculates cost for the listbox entry.
                packageListBox.Items[index] = packageList[index].CalcCost().ToString("c");
                //displays a messagebox to inform the user.
                MessageBox.Show("Package Reset, Sending to U of L!");
            }
        }

        //Event handler to cover when send from u of L button pushed.
        //Precondition:Button Pressed
        //Postcondition: package origin zip updated to U of L zip.
        private void sendFromUOfLButton_Click(object sender, EventArgs e)
        {
            if (PackageSelected())
            {
                int index = packageListBox.SelectedIndex;//Holds selected location
                packageList[index].OriginZip = UOFL_ZIP;//Updates selected packages origin zip
                //Updates prices for new origin zip
                packageListBox.Items[index] = packageList[index].CalcCost().ToString("c");
                //displays message box to inform user.
                MessageBox.Show("Package Reset, Sending From U of L!");
            }
        }

        //Method that validates user input for the package.
        //Precondition: none
        //Postcondition: if all entered data is valid, out parameters are given values and a true is returned.
        //otherwise a false is returned
        private bool PacakgeValidator(out int originZip, out int destZip, out double length, out double width, out double height, out double weight)
        {
            bool isValid = false;//Boolean T/F of validity, Assume user has error to start.
            string errorList = "";//Creates a list of errors, initially blank.
            //Tries to parse all text boxes, either assigning a value or adding an error to list.
            if(!int.TryParse(originTextBox.Text, out originZip))//Checks origin
            {
                errorList += "Invalid Origin Zip Code!\n";
            }
            if (!int.TryParse(destinationTextBox.Text, out destZip))//checks destination
            {
                errorList += "Invalid Destination Zip Code!\n";
            }
            if (!double.TryParse(lengthTextBox.Text, out length))//checks length
            {
                errorList += "Invalid Length Entered!\n";
            }
            if (!double.TryParse(widthTextBox.Text, out width))//checks width
            {
                errorList += "Invalid Width Entered!\n";
            }
            if (!double.TryParse(heightTextBox.Text, out height))//checks height
            {
                errorList += "Invalid Height Entered!\n";
            }
            if (!double.TryParse(weightTextBox.Text, out weight))//checks weight
            {
                errorList += "Invalid Weight Entered!";
            }

            //If error list is still empty, sets the isvalid boolean to true
            if(errorList == "")
            {
                isValid = true;
            }
            //otherwise the full list of errors is displayed.
            else
            {
                MessageBox.Show(errorList);
            }

            return isValid;
        }

        //Method that checks if the user has selected a package.
        //Precondition: none
        //Postcondition: returns a true/false of whether a package is selected
        private bool PackageSelected()
        {
            if(packageListBox.SelectedIndex > -1)
            {
                return true;
            }
            else
            {
                MessageBox.Show("No Package Selected!");
                return false;
            }
        }
    }
}
