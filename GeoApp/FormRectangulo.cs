using System;
using System.Drawing;
using System.Windows.Forms;
using GeoApp.Models; 

namespace GeoApp
{
    public class FormRectangulo : Form
    {
       
        private TextBox txtBase;
        private TextBox txtAltura;
        private Button btnCalcular;

        public FormRectangulo()
        {
           
            this.Text = "Área del Rectángulo";
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
                try 
                {
                    double baseRect = double.Parse(txtBase.Text);
                    double alturaRect = double.Parse(txtAltura.Text);

                    double resultado = Calculadora.AreaRectangulo(baseRect, alturaRect);

                    MessageBox.Show("El área es: " + resultado);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Por favor ingresa números válidos.");
                }
            };
        }
    }
}