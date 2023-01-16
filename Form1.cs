using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tema_3___Reprezentarea_grafica_a_datelor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // crearea unui array de date
            int[] data = { 1, 2, 3, 4, 5 };

            // setare marimea si locatia chart-ului
            int x = 50;
            int y = 50;
            int width = 300;
            int height = 200;

            // desenare chart
            Paint += new PaintEventHandler((sender, e) =>
            {
                // calcularea latimii fiecarai coloane
                int barWidth = width / data.Length;

                // desenare coloane
                for (int i = 0; i < data.Length; i++)
                {
                    // calcularea lungimii fiecarai coloane
                    int barHeight = data[i] * 20;

                    // desenare coloane
                    e.Graphics.FillRectangle(Brushes.Blue, x + (i * barWidth), y + (height - barHeight), barWidth - 10, barHeight);
                }
            });
        }
    }
}
