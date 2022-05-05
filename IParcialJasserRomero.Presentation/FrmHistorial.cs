using IParcialJasserRomero.AppCore.Interfaces;
using IParcialJasserRomero.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IParcialJasserRomero.Presentation
{
    public partial class FrmHistorial : Form
    {
        public IWeatherService weatherService { get; set; }
        public FrmHistorial()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                dataGridView1.DataSource = null;

                if (string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    dataGridView1.DataSource = weatherService.ReadDTOs();
                    return;
                }
                dataGridView1.DataSource = GetListOfNames(weatherService.ReadDTOs(), textBox1.Text);
                textBox1.Clear();
            }
        }

        private List<WeatherDTO> GetListOfNames(List<WeatherDTO> dtos, string nombre)
        {
            return dtos.Where(x => x.Name == nombre).Select(x => x).ToList();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
