using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MineSweeper
{
    public partial class ConfigurationForm : Form
    {
        private int[] sizes = { 40, 50, 60, 70, 80, 90, 100, 120, 140 };
        private List<int> availableSize;
        public int BombCount = 1;
        public int Height = 800, Width = 800;
        public int Size;

        public ConfigurationForm()
        {
            InitializeComponent();
            GetAvailableSize();
            SizeComboBox.SelectedIndex = 0;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            Size = int.Parse(SizeComboBox.Text);
            this.Close();
        }

        private void HeightTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Height = int.Parse(HeightTextBox.Text);
                if (Height <= sizes[0])
                {
                    throw new Exception();
                }
                GetAvailableSize();
            }
            catch
            {
                HeightTextBox.Text = 800.ToString();
            }
        }

        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Width = int.Parse(WidthTextBox.Text);
                if (Width <= sizes[0])
                {
                    throw new Exception();
                }
                GetAvailableSize();
            }
            catch
            {
                WidthTextBox.Text = 800.ToString();
            }
        }

        private void BombCountNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            BombCount = (int)BombCountNumericUpDown.Value;
            if (IsAvailableBombNum())
            {

            }
        }

        private void GetAvailableSize()
        {
            availableSize = new List<int>();

            foreach(int size in sizes)
            {
                if((Height % size == 0) && (Width % size == 0))
                {
                    availableSize.Add(size);
                }
            }
            UpdateSizeComboBox();
        }

        private void UpdateSizeComboBox()
        {
            SizeComboBox.Items.Clear();
            foreach(int size in availableSize)
            {
                SizeComboBox.Items.Add(size.ToString());
            }
            //SizeComboBox.SelectedIndex = 0;
        }

        private bool IsAvailableBombNum()
        {
            return BombCount < Height * Width ? true : false;
        }
    }
}
