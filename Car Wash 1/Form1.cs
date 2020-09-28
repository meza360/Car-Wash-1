using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Wash_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      

        #region formulario

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Car Wash";
            label1.Font = new Font(FontFamily.GenericSansSerif, 16.0f, FontStyle.Italic);
            button1.Font = new Font(FontFamily.GenericSansSerif, 16.0f, FontStyle.Italic);
            button1.AutoSize = true;
            groupBox1.Text = "Vehiculo";
            groupBox2.Text = "Servicios";
            radioButton1.Text = "Moto";
            radioButton2.Text="Vehiculo convencional";
            radioButton3.Text = "Vehiculo Pesado";

            checkBox1.Text = "Lavado          ";
            checkBox2.Text = "Aspirado        ";
            checkBox3.Text = "Siliconeado     ";
            checkBox4.Text = "Lavado Motor    ";
            checkBox5.Text = "Pinchazo        ";
            checkBox6.Text = "Luces           ";
            checkBox7.Text = "Pulido          ";
            checkBox8.Text = "Cambio de Aceite";
            checkBox9.Text = "Encerado        ";
            checkBox10.Text = "Polarizado     ";
            checkBox11.Text = "Tapiceria      ";
            checkBox12.Text = "Escapes        ";

            button1.Text = "Aceptar";



        }
        #endregion formulario


        #region checkbox

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked==true)
            {
                textBox1.Visible= true;
            }
            else if (checkBox1.Checked==false)
            {
                textBox1.Text = "";
                textBox1.Visible=false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                textBox2.Visible = true;
            }
            else if (checkBox2.Checked == false)
            {
                textBox2.Text = "";
                textBox2.Visible = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                textBox3.Visible = true;
            }
            else if (checkBox3.Checked == false)
            {
                textBox3.Text = "";
                textBox3.Visible = false;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                textBox4.Visible = true;
            }
            else if (checkBox4.Checked == false)
            {
                textBox4.Text = "";
                textBox4.Visible = false;
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                textBox5.Visible = true;
            }
            else if (checkBox5.Checked == false)
            {
                textBox5.Text = "";
                textBox5.Visible = false;
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true)
            {
                textBox6.Visible = true;
            }
            else if (checkBox6.Checked == false)
            {
                textBox6.Text = "";
                textBox6.Visible = false;
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked == true)
            {
                textBox7.Visible = true;
            }
            else if (checkBox7.Checked == false)
            {
                textBox7.Text = "";
                textBox7.Visible = false;
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked == true)
            {
                textBox8.Visible = true;
            }
            else if (checkBox8.Checked == false)
            {
                textBox8.Text = "";
                textBox8.Visible = false;
            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked == true)
            {
                textBox9.Visible = true;
            }
            else if (checkBox9.Checked == false)
            {
                textBox9.Text = "";
                textBox9.Visible = false;
            }
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox10.Checked == true)
            {
                textBox10.Visible = true;
            }
            else if (checkBox10.Checked == false)
            {
                textBox10.Text = "";
                textBox10.Visible = false;
            }
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox11.Checked == true)
            {
                textBox11.Visible = true;
            }
            else if (checkBox11.Checked == false)
            {
                textBox11.Text = "";
                textBox11.Visible = false;
            }
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox12.Checked == true)
            {
                textBox12.Visible = true;
            }
            else if (checkBox12.Checked == false)
            {
                textBox12.Text = "";
                textBox12.Visible = false;
            }
        }
        #endregion checkbox

        //vectores de control
        string [] servicio = new string[15];
        int [] cantidad = new int[15];
        double [] precio = new double[15];
        double [] subtotal = new double[15];

        public void llenado()
        {
            servicio[0] = "Lavado          "; precio[1]= 25.50;
            servicio[1] = "Aspirado        "; precio[2] = 15;
            servicio[2] = "Siliconeado     "; precio[3] = 25;
            servicio[3] = "Lavado Motor    "; precio[4] = 50;
            servicio[4] = "Pinchazo        "; precio[5] = 150;
            servicio[5] = "Luces           "; precio[6] = 45;
            servicio[6] = "Pulido          "; precio[7] = 150;
            servicio[7] = "Cambio de Aceite"; precio[8] = 300;
            servicio[8] = "Encerado        "; precio[9] = 10;
            servicio[9] = "Polarizado      "; precio[10] = 250;
            servicio[10]= "Tapiceria       "; precio[11] = 1500;
            servicio[11]= "Escapes         "; precio[12] = 75;
        
        
        }



        private void button1_Click(object sender, EventArgs e)
        {
            llenado();
            double totala = 0;
            try
            {
                #region radiobutton1
              
                if (radioButton1.Checked==true)
                {
                    

                    //vctor1
                    if (textBox1.Text!="")
                    {
                        int temp = int.Parse(textBox1.Text);
                        cantidad[0]=temp;
                        precio[0] = 15;
                        subtotal[0]=cantidad[0] *precio[0];
                        totala = totala + subtotal[0];
                    }
                    else
                    {
                        int temp = 0;
                        cantidad[0] = temp;
                        precio[0] = 15;
                        subtotal[0] = cantidad[0] * precio[0];
                        totala = totala + subtotal[0];
                    }
                    //vector2
                    if (textBox2.Text != "")
                    {
                        int temp = int.Parse(textBox2.Text);
                        cantidad[1] = temp;
                        precio[1] = 0;
                        subtotal[1] = cantidad[1] * precio[1];
                        totala = totala + subtotal[1];
                    }
                    else
                    {
                        int temp = 0;
                        cantidad[1] = temp;
                        precio[1] = 0;
                        subtotal[1] = cantidad[1] * precio[1];
                        totala = totala + subtotal[1];
                    }
                    //vector 3
                    if (textBox3.Text != "")
                    {
                        int temp = int.Parse(textBox3.Text);
                        cantidad[2] = temp;
                        precio[2] = 15;
                        subtotal[2] = cantidad[2] * precio[2];
                        totala = totala + subtotal[2];
                    }
                    else
                    {
                        int temp = 0;
                        cantidad[2] = temp;
                        precio[2] = 15;
                        subtotal[2] = cantidad[2] * precio[2];
                        totala = totala + subtotal[2];
                    }
                    //vector4

                    if (textBox4.Text != "")
                    {
                        int temp = int.Parse(textBox4.Text);
                        cantidad[3] = temp;
                        precio[3] = 25;
                        subtotal[3] = cantidad[3] * precio[3];
                        totala = totala + subtotal[3];
                    }
                    else
                    {
                        int temp = 0;
                        cantidad[3] = temp;
                        precio[3] = 25;
                        subtotal[3] = cantidad[3] * precio[3];
                        totala = totala + subtotal[3];
                    }
                    //vector5
                    if (textBox5.Text != "")
                    {
                        int temp = int.Parse(textBox5.Text);
                        cantidad[4] = temp;
                        precio[4] = 30;
                        subtotal[4] = cantidad[4] * precio[4];
                        totala = totala + subtotal[4];
                    }
                    else
                    {
                        int temp = 0;
                        cantidad[4] = temp;
                        precio[4] = 30;
                        subtotal[4] = cantidad[4] * precio[4];
                        totala = totala + subtotal[4];
                    }
                    //vector6
                    if (textBox6.Text != "")
                    {
                        int temp = int.Parse(textBox6.Text);
                        cantidad[5] = temp;
                        precio[5] = 30;
                        subtotal[5] = cantidad[5] * precio[5];
                        totala = totala + subtotal[5];
                    }
                    else
                    {
                        int temp = 0;
                        cantidad[5] = temp;
                        precio[5] = 30;
                        subtotal[5] = cantidad[5] * precio[5];
                        totala = totala + subtotal[5];
                    }
                    //vector7
                    if (textBox7.Text != "")
                    {
                        int temp = int.Parse(textBox7.Text);
                        cantidad[6] = temp;
                        precio[6] = 30;
                        subtotal[6] = cantidad[6] * precio[6];
                        totala = totala + subtotal[6];
                    }
                    else
                    {
                        int temp = 0;
                        cantidad[6] = temp;
                        precio[6] = 30;
                        subtotal[6] = cantidad[6] * precio[6];
                        totala = totala + subtotal[6];
                    }
                    //vector8
                    if (textBox8.Text != "")
                    {
                        int temp = int.Parse(textBox8.Text);
                        cantidad[7] = temp;
                        precio[7] = 30;
                        subtotal[7] = cantidad[7] * precio[7];
                        totala = totala + subtotal[7];
                    }
                    else
                    {
                        int temp = 0;
                        cantidad[7] = temp;
                        precio[7] = 30;
                        subtotal[7] = cantidad[7] * precio[7];
                        totala = totala + subtotal[7];
                    }
                    //vector9
                    if (textBox9.Text != "")
                    {
                        int temp = int.Parse(textBox9.Text);
                        cantidad[8] = temp;
                        precio[8] = 30;
                        subtotal[8] = cantidad[8] * precio[8];
                        totala = totala + subtotal[8];
                    }
                    else
                    {
                        int temp = 0;
                        cantidad[8] = temp;
                        precio[8] = 30;
                        subtotal[8] = cantidad[8] * precio[8];
                        totala = totala + subtotal[8];
                    }
                    //vector10
                    if (textBox10.Text != "")
                    {
                        int temp = int.Parse(textBox10.Text);
                        cantidad[9] = temp;
                        precio[9] = 30;
                        subtotal[9] = cantidad[9] * precio[9];
                        totala = totala + subtotal[9];
                    }
                    else
                    {
                        int temp = 0;
                        cantidad[9] = temp;
                        precio[9] = 30;
                        subtotal[9] = cantidad[9] * precio[9];
                        totala = totala + subtotal[9];
                    }
                    //vector11
                    if (textBox11.Text != "")
                    {
                        int temp = int.Parse(textBox11.Text);
                        cantidad[10] = temp;
                        precio[10] = 30;
                        subtotal[10] = cantidad[10] * precio[10];
                        totala = totala + subtotal[10];
                    }
                    else
                    {
                        int temp = 0;
                        cantidad[10] = temp;
                        precio[10] = 30;
                        subtotal[10] = cantidad[10] * precio[10];
                        totala = totala + subtotal[10];
                    }
                    //vector12
                    if (textBox12.Text != "")
                    {
                        int temp = int.Parse(textBox12.Text);
                        cantidad[11] = temp;
                        precio[11] = 30;
                        subtotal[11] = cantidad[11] * precio[11];
                        totala = totala + subtotal[11];
                    }
                    else
                    {
                        int temp = 0;
                        cantidad[11] = temp;
                        precio[11] = 30;
                        subtotal[11] = cantidad[11] * precio[11];
                        totala = totala + subtotal[11];
                    }

                   
                }
                #endregion radiobutton1

                #region radiobutton2

                else if (radioButton2.Checked == true)
                {
                    if (radioButton1.Checked == true)
                    {
                        //vector1
                        if (textBox1.Text != "")
                        {
                            int temp = int.Parse(textBox1.Text);
                            cantidad[0] = temp;
                            subtotal[0] = cantidad[0] * precio[0];
                            totala = totala + subtotal[0];
                        }
                        else
                        {
                            int temp = 0;
                            cantidad[0] = temp;
                            subtotal[0] = cantidad[0] * precio[0];
                            totala = totala + subtotal[0];
                        }
                        //vector2
                        if (textBox2.Text != "")
                        {
                            int temp = int.Parse(textBox2.Text);
                            cantidad[1] = temp;
                            subtotal[1] = cantidad[1] * precio[1];
                            totala = totala + subtotal[1];
                        }
                        else
                        {
                            int temp = 0;
                            cantidad[1] = temp;
                            subtotal[1]= cantidad[1] * precio[1];
                            totala = totala + subtotal[1];
                        }
                        //vector3
                        if (textBox3.Text != "")
                        {
                            int temp = int.Parse(textBox3.Text);
                            cantidad[2] = temp;
                            subtotal[2] = cantidad[2] * precio[2];
                            totala = totala + subtotal[2];
                        }
                        else
                        {
                            int temp = 0;
                            cantidad[2] = temp;
                            subtotal[2] = cantidad[2] * precio[2];
                            totala = totala + subtotal[2];
                        }
                        //vector4
                        if (textBox4.Text != "")
                        {
                            int temp = int.Parse(textBox4.Text);
                            cantidad[3] = temp;
                            subtotal[3] = cantidad[3] * precio[3];
                            totala = totala + subtotal[3];
                        }
                        else
                        {
                            int temp = 0;
                            cantidad[3] = temp;
                            subtotal[3] = cantidad[3] * precio[3];
                            totala = totala + subtotal[3];
                        }
                        //vector5
                        if (textBox5.Text != "")
                        {
                            int temp = int.Parse(textBox5.Text);
                            cantidad[4] = temp;
                            subtotal[4] = cantidad[4] * precio[4];
                            totala = totala + subtotal[4];
                        }
                        else
                        {
                            int temp = 0;
                            cantidad[4] = temp;
                            subtotal[4] = cantidad[4] * precio[4];
                            totala = totala + subtotal[4];
                        }
                        //vector6
                        if (textBox6.Text != "")
                        {
                            int temp = int.Parse(textBox6.Text);
                            cantidad[5] = temp;
                            subtotal[5] = cantidad[5] * precio[5];
                            totala = totala + subtotal[5];
                        }
                        else
                        {
                            int temp = 0;
                            cantidad[5] = temp;
                            subtotal[5] = cantidad[5] * precio[5];
                            totala = totala + subtotal[5];
                        }
                        //vector7
                        if (textBox7.Text != "")
                        {
                            int temp = int.Parse(textBox7.Text);
                            cantidad[6] = temp;
                            subtotal[6] = cantidad[6] * precio[6];
                            totala = totala + subtotal[6];
                        }
                        else
                        {
                            int temp = 0;
                            cantidad[6] = temp;
                            subtotal[6] = cantidad[6] * precio[6];
                            totala = totala + subtotal[6];
                        }
                        //vector8
                        if (textBox8.Text != "")
                        {
                            int temp = int.Parse(textBox8.Text);
                            cantidad[7] = temp;
                            subtotal[7] = cantidad[7] * precio[7];
                            totala = totala + subtotal[7];
                        }
                        else
                        {
                            int temp = 0;
                            cantidad[7] = temp;
                            subtotal[7] = cantidad[7] * precio[7];
                            totala = totala + subtotal[7];
                        }
                        //vector9
                        if (textBox9.Text != "")
                        {
                            int temp = int.Parse(textBox9.Text);
                            cantidad[8] = temp;
                            subtotal[8] = cantidad[8] * precio[8];
                            totala = totala + subtotal[8];
                        }
                        else
                        {
                            int temp = 0;
                            cantidad[8] = temp;
                            subtotal[8] = cantidad[8] * precio[8];
                            totala = totala + subtotal[8];
                        }
                        //vector10
                        if (textBox10.Text != "")
                        {
                            int temp = int.Parse(textBox10.Text);
                            cantidad[9] = temp;
                            subtotal[9] = cantidad[9] * precio[9];
                            totala = totala + subtotal[9];
                        }
                        else
                        {
                            int temp = 0;
                            cantidad[9] = temp;
                            subtotal[9] = cantidad[9] * precio[9];
                            totala = totala + subtotal[9];
                        }
                        //vector11
                        if (textBox11.Text != "")
                        {
                            int temp = int.Parse(textBox11.Text);
                            cantidad[10] = temp;
                            subtotal[10] = cantidad[10] * precio[10];
                            totala = totala + subtotal[10];
                        }
                        else
                        {
                            int temp = 0;
                            cantidad[10] = temp;
                            subtotal[10] = cantidad[10] * precio[10];
                            totala = totala + subtotal[10];
                        }
                        //vector12
                        if (textBox12.Text != "")
                        {
                            int temp = int.Parse(textBox12.Text);
                            cantidad[11] = temp;
                            subtotal[11] = cantidad[11] * precio[11];
                            totala = totala + subtotal[11];
                        }
                        else
                        {
                            int temp = 0;
                            cantidad[11] = temp;
                            subtotal[11] = cantidad[11] * precio[11];
                            totala = totala + subtotal[11];
                        }
                  


                    }
                }
                #endregion radiobutton2

                #region radiobutton3

                else if (radioButton3.Checked == true)
                {
                    //vector1
                    if (textBox1.Text != "")
                    {
                        int temp = int.Parse(textBox1.Text);
                        cantidad[0] = temp;
                        subtotal[0] = cantidad[0] * precio[0];
                        totala = totala + subtotal[0];
                    }
                    else
                    {
                        int temp = 0;
                        cantidad[0] = temp;
                        subtotal[0] = cantidad[0] * precio[0];
                        totala = totala + subtotal[0];
                    }








                }

                #endregion radiobutton3

                 Factura BACO5 = new Factura();
                 BACO5.listBox1.Items.Add("Nombre:");
                 BACO5.listBox1.Items.Add("Nit:");
                
                 listBox1.Items.Add(cantidad + " " + servicio + "  ");



                    MessageBox.Show("Total a pagar es" + totala);

                    for (int i = 0; i <= 11; i++)
                    {
                        if (cantidad[i] > 0)
                        {
                            listBox1.Items.Add(cantidad[i] + "\t" + servicio[i] + "\t" + precio[i] + "\t" + totala);
                        }
                    }

                    BACO5.listBox1.Items.Add("el total  pagar es:" + totala);
                    BACO5.listBox1.Visible = true;
                    BACO5.ShowDialog();

            }




            catch
            {
                MessageBox.Show("");
            
            }





        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.Visible = false;
        }


        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.Visible = true;
        }


        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

       
    }
}
