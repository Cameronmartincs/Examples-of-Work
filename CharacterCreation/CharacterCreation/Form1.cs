using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/*
 CSC 200
 Create-A-Char
 This program creates a character based on the choices made by the user
 It takes those choices and put a 1 in the spot that that choice is assigned to
 It then will create an object and assign values when you press the create buton
 It will then display the information, a picture corresponding to the race chosen,
 and give a decription that is specific to the choices
 This code can expand by using the same strageties used
 I do not take credit for the pictures, they were found on google images and will not be used for commercial use.
 They will only be used for this project */
namespace CharacterCreation
{
     
    public partial class Form1 : Form
    {   //each array holds a 1 for whichever choice is possible, the array names correspond to the group of choices respectively
        int[] weapons = new int [3];
        int[] chars = new int [3];
        int[] race = new int[3];
        int[] gender = new int[2];

        //Holds the value of the location in the array that corresponds to the selection
        //example sword is given location 0 in weapons array, if chosed weaponselection will be zero
        int weaponselection = 0;
        int charsselection = 0;
        int raceselection = 0;
        int genderselection = 0;
        
       
        public Form1()
        {
            InitializeComponent();
            
        }

        

     

       
        /*These are the weapon selection button when selected it will 
         -change the value in the array corresponding to that selection
         -reset the other values to zero (menu purposes)
         -and change the color of the button*/
        private void btnSword_Click(object sender, EventArgs e)
        {
            weapons[0] = 1;
            weaponselection = changeArray(weapons);
            Changecolor(btnSword, btnDagger, btnBow);
        }

        private void btnDagger_Click(object sender, EventArgs e)
        {
            weapons[1] = 1;
            weaponselection = changeArray(weapons);
            Changecolor(btnDagger, btnSword, btnBow);
        }

        private void btnBow_Click(object sender, EventArgs e)
        {
            weapons[2] = 1;
            weaponselection = changeArray(weapons);
            Changecolor(btnBow, btnDagger, btnSword);
        }



        /*These are the class selection button when selected it will 
        -change the value in the array corresponding to that selection
        -reset the other values to zero (menu purposes)
        -and change the color of the button*/
        private void btnWarrior_Click(object sender, EventArgs e)
        {
            chars[0] = 1;
            charsselection = changeArray(chars);
            Changecolor(btnWarrior, btnRogue, btnHunter);
        }

        private void btnRogue_Click(object sender, EventArgs e)
        {
            chars[1] = 1;
            charsselection = changeArray(chars);
            Changecolor(btnRogue, btnWarrior, btnHunter);
        }

        private void btnHunter_Click(object sender, EventArgs e)
        {
            chars[2] = 1;
            charsselection = changeArray(chars);
            Changecolor(btnHunter, btnWarrior, btnRogue);
        }




        /*These are the Race selection button when selected it will 
        -change the value in the array corresponding to that selection
        -reset the other values to zero (menu purposes)
        -and change the color of the button*/
        private void btnHuman_Click(object sender, EventArgs e)
        {
            race[0] = 1;
            raceselection = changeArray(race);
            Changecolor(btnHuman, btnElf, btnDwarf);
        }

        private void btnElf_Click(object sender, EventArgs e)
        {
            race[1] = 1;
            raceselection = changeArray(race);
            Changecolor(btnElf, btnHuman,  btnDwarf);
        }

        private void btnDwarf_Click(object sender, EventArgs e)
        {
            race[2] = 1;
            raceselection = changeArray(race);
            Changecolor( btnDwarf, btnHuman, btnElf);
        }



        /*These are the Gender selection button when selected it will 
        -change the value in the array corresponding to that selection
        -reset the other values to zero (menu purposes)
        -and change the color of the button*/
        private void btnMale_Click(object sender, EventArgs e)
        {
            gender[0] = 1;
            genderselection = changeArray(gender);
            Changecolor(btnMale, btnFemale);
        }

        private void btnFemale_Click(object sender, EventArgs e)
        {
            gender[1] = 1;
            genderselection = changeArray(gender);
            Changecolor(btnFemale, btnMale);
        }








        private void btnCreate_Click(object sender, EventArgs e)
        {
            //chreate the object and assign the name
            Form2 f = new Form2();
            Char mychar = new Char();
            mychar.Name = txtName.Text;


            //This switch decides which weapon type is made and sets that property to myChar
            switch (weaponselection)
            {
                case 1:
                    f.Label1 = "Sword";
                    mychar.Type = "takes a sword in hand. ";
                    break;
                case 2:
                    f.Label1 = "Dagger";
                    mychar.Type = "takes a dagger in hand. ";
                    break;
                case 3:
                    f.Label1 = "Bow";
                    mychar.Type = "takes a Bow in hand. ";
                    break;
                default:
                    break;
            }


            //This switch decides which role is selected and sets the property to myChar
            switch (charsselection)
            {
                case 1:
                    f.Label2 = "Warrior";
                    mychar.Role = "chosen to be a warrior. ";
                    break;
                case 2:
                    f.Label2 = "Rogue";
                    mychar.Role = "chosen to be a rogue. ";
                    break;
                case 3:
                    f.Label2 = "Hunter";
                    mychar.Role = "chosen to be a hunter. ";
                    break;
                default:
                    break;
            }


            //This switch decides which race is selected and sets the property to myChar
            switch (raceselection)
            {
                case 1:
                    f.Label3 = "Human";
                    mychar.Race = "From earth. ";
                    f.Image2 = CharacterCreation.Properties.Resources.Human;
                    break;
                case 2:
                    f.Label3 = "Elf";
                    mychar.Race = "From the lands of Gongoria.";
                    f.Image2 = CharacterCreation.Properties.Resources.Elf;
                    break;
                case 3:
                    f.Label3 = "Dwarf";
                    mychar.Race = "Risen from the depths of the Ashe Mines.";
                    f.Image2 = CharacterCreation.Properties.Resources.Dwarf;
                    break;
                default:
                    break;
            }



            //This switch decides which gender is selected and sets the property to myChar
            switch (genderselection)
            {
                case 1:
                    f.Label4 = "Male";
                    mychar.Gender = "He ";
                    break;
                case 2:
                    f.Label4 = "Female";
                    mychar.Gender = "She ";
                    break;
                default:
                    break;
            }
            //Set the label in other form a name and the textbox a decription
            f.Label5 = mychar.Name;
            f.TxtBio = (mychar.Name + ", " + mychar.Role + mychar.Race + mychar.Gender + mychar.Type);
            f.Show();
        }


    

        //These two methods are used strictly for UI, The change the color of the button backgrounds when clicked,
        //It will then set the others in the group to default color
        public void Changecolor(Button a, Button b, Button c)
        {
            if (a.BackColor == System.Drawing.SystemColors.Control)
            {
                a.BackColor = System.Drawing.SystemColors.ActiveCaption;
                b.BackColor = System.Drawing.SystemColors.Control;
                c.BackColor = System.Drawing.SystemColors.Control;
            }
            else
                a.BackColor = System.Drawing.SystemColors.Control;
        }
        public void Changecolor(Button a, Button b)
        {
            if (a.BackColor == System.Drawing.SystemColors.Control)
            {
                a.BackColor = System.Drawing.SystemColors.ActiveCaption;
                b.BackColor = System.Drawing.SystemColors.Control;
            }
            else
                a.BackColor = System.Drawing.SystemColors.Control;
        }


        //This methods iterates through the arrays finds the location that is set to 1 by the buttons 
        //It then gives that location to menu and sets the array to zero
        //This allows continue use of the program without error
        public int changeArray(int[] myarray)
        {
            int i = 0;
            int menu = 0;
            while(i < myarray.Length)
            {
                
                if (myarray[i] == 1)
                {
                    menu = i;
                    myarray[i] = 0;
                }
                i++;
            }
            return menu + 1;
        }

        

        

        

        
    }
}
