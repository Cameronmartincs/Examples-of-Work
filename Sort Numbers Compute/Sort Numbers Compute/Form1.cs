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
 * CSC180
 * HW9
 * This program takes numbers computes average and sorts them using a form app
 */
namespace SortNumbers
{

    public partial class Sorting : Form
    {
        public int n = 0;                                                       //global variable that keeps track of the amount of numbers
        public Sorting()
        {
            InitializeComponent();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            lstEntered.Items.Add(txtInput.Text);
            n++;
            txtInput.Clear();
            txtInput.Focus();                                                   ///clears and focus on txtinput
            txtCount.Text = Convert.ToString(n);                                //keeps track of how many numbers

        }

        private void btnAverage_Click(object sender, EventArgs e)
        {
            int total = 0;
            int[] array = new int[n];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(lstEntered.Items[i]);                                //puts the numbers in an array
                total += array[i];
            }
            int avg = total / n;
            lblAverage.Text = Convert.ToString(avg);                                            //conputes average and puts into label box
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            int[] array = new int[n];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(lstEntered.Items[i]);                                //puts numbers into array

            }

            Sort(array);                                                                        //sorts array

            for (int j = 0; j < array.Length; j++)
            {
                lstSorted.Items.Add(Convert.ToString(array[j]));                                //puts numbers into sorted list box
            }
        }


        public static void Sort(int[] sortedArray)
        {
            for (int pass = 1; pass < sortedArray.Length; pass++)
            {
                for (int i = 0; i < sortedArray.Length - 1; i++)   
                {
                    if (sortedArray[i] > sortedArray[i + 1])      
                        Swap(ref sortedArray[i], ref sortedArray[i + 1]);                       //compares the ref number in the array and swaps
                }
            }
        }
        static void Swap(ref int a, ref int b)                                                  //swaps the ref numbers using temp variable
        {
            int tmp = a;
            a = b;
            b = tmp;
        }

    }
}