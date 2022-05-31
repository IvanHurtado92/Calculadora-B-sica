using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Examen_2_Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            nums2.Text = "";
        }
        public int i = 0, ultiboton = 0,ultiboton2 = 0, fin = 0,fact=0,sum=0,por = 0,original=0;
        public string dato = "";
        public static double[] elementos = new double[15];
        public static double valor=0;

        private void button1_Click(object sender, EventArgs e)
        {
            nums.Text += '1';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nums.Text += '2';
        }

        private void button3_Click(object sender, EventArgs e)
        {
            nums.Text += '3';
        }

        private void button4_Click(object sender, EventArgs e)
        {
            nums.Text += '4';
        }

        private void button5_Click(object sender, EventArgs e)
        {
            nums.Text += '5';
        }

        private void button6_Click(object sender, EventArgs e)
        {
            nums.Text += '6';
        }

        private void button7_Click(object sender, EventArgs e)
        {
            nums.Text += '7';
        }

        private void button8_Click(object sender, EventArgs e)
        {
            nums.Text += '8';
        }

        private void button9_Click(object sender, EventArgs e)
        {
            nums.Text += '9';
        }

        private void button10_Click(object sender, EventArgs e)
        {
            nums.Text += '0';
        }

        private void button11_Click(object sender, EventArgs e)
        {
            nums.Text += '.';
        }

        private void button13_Click(object sender, EventArgs e) //Boton despejar
        {
            nums.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)  //Boton despejar Todo (reiniciar)
        {
            nums2.Text = "";
            i = ultiboton = ultiboton2 = fin = sum = fact = por = 0; 
            Array.Clear(elementos, 0, elementos.Length);
            nums.Text = "";
        }

        private void button16_Click(object sender, EventArgs e) //Boton suma
        {   
            
            if(nums.Text == "")
            {
                MensajeError();
            }
            else
            {
                ultiboton2 = 1;
                dato = "+";
                elementos[i] = Convert.ToDouble(nums.Text);
                if (i == 0 || fact == 1 || sum == 1 || por == 1)
                {
                    nums2.Text = nums.Text + '+';
                    fact = 0;
                    sum = 0;
                    por = 0;
                }
                else
                {
                    operaciones();
                }
                i++;
                nums.Text = "";
                
                ultiboton = 1;
            }
        }

        private void button14_Click(object sender, EventArgs e) //boton resta
        {
            if (nums.Text == "")
            {
                MensajeError();
            }
            else
            {
                
                ultiboton2 = 2;
                dato = "-";
                elementos[i] = Convert.ToDouble(nums.Text);
                if (i == 0 || fact == 1 || sum == 1 || por == 1)
                {
                    nums2.Text = nums.Text + '-';
                    fact = 0;
                    sum = 0;
                    por = 0;
                }
                else
                {
                    operaciones();
                }
                i++;
                nums.Text = "";
                ultiboton = 2;
            }
        }

        private void button17_Click(object sender, EventArgs e) //boton multi
        {
            if (nums.Text == "")
            {
                MensajeError();
            }
            else
            {
                
                ultiboton2 = 3;
                dato = "*";
                elementos[i] = Convert.ToDouble(nums.Text);

                if (i == 0 || fact == 1 || sum == 1 || por == 1)
                {
                    nums2.Text = nums.Text + '*';
                    fact = 0;
                    sum = 0;
                    por = 0;
                }
                else
                {
                    operaciones();
                }
                i++;
                nums.Text = "";
                ultiboton = 3;
            }
        }

        private void button15_Click(object sender, EventArgs e) //boton divi
        {
            if (nums.Text == "")
            {
                MensajeError();
            }
            else
            {
                
                ultiboton2 = 4;
                dato = "/";
                elementos[i] = Convert.ToDouble(nums.Text);

                if (i == 0 || fact == 1 || sum == 1 || por == 1)
                {
                    nums2.Text = nums.Text + '/';
                    fact = 0;
                    sum = 0;
                    por = 0;
                }
                else
                {
                    operaciones();
                }
                i++;
                nums.Text = "";
                ultiboton = 4;
            }
        }

        private void button18_Click(object sender, EventArgs e) //boton porcentaje
        {
            if (nums.Text == "")
            {
                MensajeError();
            }
            else
            {
                ultiboton = 5;
                dato = "%";
                elementos[i] = Convert.ToDouble(nums.Text);

                if (i == 0 || fact == 1 || sum == 1 || por == 1)
                {
                    nums2.Text = nums.Text + '%';
                    fact = 0;
                    sum = 0;
                    por = 0;
                }
                else
                {
                    operaciones();
                }
            }
        }

        private void button20_Click(object sender, EventArgs e) //boton potencia
        {
            
            if (nums.Text == "")
            {
                MensajeError();
            }
            else
            {
                ultiboton = 6;
                ultiboton2 = 6;
                dato = "^";
                elementos[i] = Convert.ToDouble(nums.Text);

                if (i == 0 || fact == 1 || sum == 1 || por == 1)
                {
                    nums2.Text = nums.Text + '^';
                    fact = 0;
                    sum = 0;
                    por = 0;
                }
                else
                {
                    operaciones();
                }
                i++;
                nums.Text = "";
                
            }
        }

        private void button22_Click(object sender, EventArgs e) //boton sumatoria
        {

            if (nums.Text == "")
            {
                MensajeError();
            }
            else
            {
                dato = "Σ";
                sum = 1;
                elementos[i] = Convert.ToDouble(nums.Text);
                int ola = original = Convert.ToInt32(elementos[i]), res = 0;

                for (int j = 1; j <= ola; j++)
                {
                    res += j;
                }

                elementos[i] = Convert.ToDouble(res);

                if (i == 0)
                {
                    nums2.Text = dato + elementos[i];
                    nums.Text = Convert.ToString(elementos[i]);
                }
                else
                {
                    operaciones();
                }
                //nums2.Text = "";
            }
        }

        private void button21_Click(object sender, EventArgs e) //boton factorial
        {
            if (nums.Text == "")
            {
                MensajeError();
            }
            else
            {
                fact = 1;
                dato = "!";
                elementos[i] = Convert.ToDouble(nums.Text);
                int ola = original = Convert.ToInt32(elementos[i]);

                for (int j = ola - 1; j >= 1; j--)
                {
                    ola = ola * j;
                }

                elementos[i] = Convert.ToDouble(ola);

                if (i == 0)
                {
                    nums2.Text = original + dato;
                    nums.Text = Convert.ToString(elementos[i]);
                }
                else
                {
                    operaciones();
                }
            }
        }

        private void button19_Click(object sender, EventArgs e) //configurar para que reinicie todo
        {
            if (i < 1)
            {
                MessageBox.Show("Agrega un elemento más para usar este botón!!");
            }
            else
            {
                fin = 1;
                elementos[i] = Convert.ToDouble(nums.Text);
                nums2.Text = elementos[i-1] + dato + elementos[i];
                operaciones();
                i = fact = por = sum = 0;
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void operaciones()
        {
            switch (ultiboton)
            {
                case 1:
                    elementos[i] += elementos[i - 1];
                    if (fin == 0 && fact == 0 && sum == 0)
                    {
                        nums2.Text = Convert.ToString(elementos[i]) + dato;
                    }
                    else if(fact == 1 || sum == 1)
                    {
                        nums.Text = Convert.ToString(elementos[i]);
                        nums2.Text = Convert.ToString(elementos[i - 1]) + " + " + dato + Convert.ToString(original);

                    }
                    else
                        nums.Text = Convert.ToString(elementos[i]);
                        fin = 0;
                    break;

                case 2:
                    elementos[i] = (elementos[i-1] - elementos[i]);
                    if (fin == 0 && fact == 0 && sum == 0)
                    {
                        nums2.Text = Convert.ToString(elementos[i]) + dato;
                    }
                    else if (fact == 1 || sum == 1)
                    {
                        nums.Text = Convert.ToString(elementos[i]);
                        nums2.Text = Convert.ToString(elementos[i - 1]) + " - " + dato + Convert.ToString(original);
                    }
                    else
                        nums.Text = Convert.ToString(elementos[i]);
                    break;

                case 3:
                    elementos[i] *= elementos[i - 1];
                    if (fin == 0 && fact == 0 && sum == 0)
                    {
                        nums2.Text = Convert.ToString(elementos[i]) + dato;
                    }
                    else if (fact == 1 || sum == 1)
                    {
                        nums.Text = Convert.ToString(elementos[i]);
                        nums2.Text = Convert.ToString(elementos[i - 1]) + " * " + dato + Convert.ToString(original);

                    }
                    else
                        nums.Text = Convert.ToString(elementos[i]);
                    break;

                case 4:
                    elementos[i] = elementos[i-1] / elementos[i];
                    if (fin == 0 && fact == 0 && sum == 0)
                    {
                        nums2.Text = Convert.ToString(elementos[i]) + dato;
                    }
                    else if (fact == 1 || sum == 1)
                    {
                        nums.Text = Convert.ToString(elementos[i]);
                        nums2.Text = Convert.ToString(elementos[i - 1]) + " / " + dato + Convert.ToString(original);

                    }
                    else
                        nums.Text = Convert.ToString(elementos[i]);
                    break;

                case 5: //porcentaje 
                    
                    switch (ultiboton2)
                    {   
                        case 1:
                            elementos[i] = elementos[i - 1] + (elementos[i - 1] * (elementos[i] / 100));
                            ultiboton2 = 0;
                            por = 1;
                            break;

                        case 2:
                            elementos[i] = elementos[i - 1] - (elementos[i - 1] * (elementos[i] / 100));
                            ultiboton2 = 0;
                            por = 1;
                            break;

                        case 3:
                            elementos[i] = elementos[i-1] * (elementos[i] / 100);
                            ultiboton2 = 0;
                            por = 1;
                            break;

                        case 4:
                            elementos[i] = elementos[i - 1] * (100 / elementos[i]);
                            ultiboton2 = 0;
                            por = 1;
                            break;

                    }
                    
                    nums.Text = Convert.ToString(elementos[i]);
                    nums2.Text = "";
                    break;

                case 6: //potencia
                    int r = Convert.ToInt32(elementos[i]);
                    int g = Convert.ToInt32(elementos[i-1]);
                    int res = 1;

                    for (int j = 0; j < r; j++)
                    {
                        res *= g;
                    }
                    elementos[i] = res;
                    if (fin == 0 && fact == 0)
                    {
                        nums2.Text = Convert.ToString(elementos[i]) + dato;
                    }
                    else if (fact == 1)
                    {
                        nums.Text = Convert.ToString(elementos[i]);
                        nums2.Text = "";
                    }
                    else if (sum == 1)
                    {
                        nums.Text = Convert.ToString(elementos[i]);
                        nums2.Text = Convert.ToString(elementos[i - 1]) + "+" + dato + Convert.ToString(original);
                    }
                    else
                        nums.Text = Convert.ToString(elementos[i]);
                    break;
            }
        }

        public void MensajeError()
        {
            MessageBox.Show("Ingresa un dato y vuelve a intentar!!");
        }
    }
}
