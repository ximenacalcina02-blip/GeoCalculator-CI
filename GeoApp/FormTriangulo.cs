using System;
using System.Drawing;
using System.Windows.Forms;
using GeoApp.Models;

namespace GeoApp
{
    public class FormTriangulo : Form
    {
        private TextBox txtBase;
        private TextBox txtAltura;
        private Button btnCalcular;

        public FormTriangulo()
        {
            this.Text = "Área del Triángulo";
            this.Size = new Size(300, 200);

            this.Controls.Add(new Label { Text = "Base:", Location = new Point(20, 20) });
            txtBase = new TextBox { Location = new Point(100, 20) };
            this.Controls.Add(txtBase);

            this.Controls.Add(new Label { Text = "Altura:", Location = new Point(20, 50) });
            txtAltura = new TextBox { Location = new Point(100, 50) };
            this.Controls.Add(txtAltura);

            btnCalcular = new Button { Text = "Calcular", Location = new Point(100, 80) };
            this.Controls.Add(btnCalcular);

            btnCalcular.Click += (s, e) => {
                try {
                    double b = double.Parse(txtBase.Text);
                    double h = double.Parse(txtAltura.Text);
                    double res = Calculadora.AreaTriangulo(b, h);
                    MessageBox.Show("El área del triángulo es: " + res);
                }
                catch {
                    MessageBox.Show("Por favor, ingresa valores numéricos.");
                }
            };
        }
    }
}