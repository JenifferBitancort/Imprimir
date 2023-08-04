using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace _29___Imprimir
{
    public partial class Form1 : Form
    {

        int x;
        int y;
        int largura;
        int altura;
        int num_linhas;
        int pagina;
        int num_paginas;

        public Form1()
        {
            InitializeComponent();
            pagina = 0;
            num_paginas = 0;
        }

        private void buttonImprimir_Click(object sender, EventArgs e)
        {
            largura = printDocument1.DefaultPageSettings.Bounds.Width;             
            altura = printDocument1.DefaultPageSettings.Bounds.Height;              
            x = 50;
            y = 50;
            num_linhas = 0;

            printDocument1.Print();   
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {


            //Título
            string titulo = "Título da página";
            Font letraTituloi = new Font("Verdana", 24, FontStyle.Bold, GraphicsUnit.Point);    
            Brush pincelTitulo = new SolidBrush(Color.Red);                                   
            Rectangle areaTitulo = new Rectangle(x + 50, y + 50, largura - 100, 100);          
            //Formatação do título para centralizar
            StringFormat formatoTitulo = new StringFormat();
            formatoTitulo.Alignment = StringAlignment.Center;
            formatoTitulo.LineAlignment = StringAlignment.Center;

            //Texto
            Font letra = new Font("Arial", 18, FontStyle.Bold, GraphicsUnit.Point);             
            Brush pincel = new SolidBrush(Color.Black);                                         


            List<string> linhas = new List<string>()
            {
                "Alguns minutos de estudo por dia valem a pena",
                "Alguns minutos de estudo por dia valem a pena",
                "Alguns minutos de estudo por dia valem a pena",
                "Alguns minutos de estudo por dia valem a pena",
                "Alguns minutos de estudo por dia valem a pena",
                "Alguns minutos de estudo por dia valem a pena",
                "Alguns minutos de estudo por dia valem a pena",
                "Alguns minutos de estudo por dia valem a pena",
                "Alguns minutos de estudo por dia valem a pena",
                "Alguns minutos de estudo por dia valem a pena",
                "Alguns minutos de estudo por dia valem a pena",
                "Alguns minutos de estudo por dia valem a pena",
                "Alguns minutos de estudo por dia valem a pena",
                "Alguns minutos de estudo por dia valem a pena",
                "Alguns minutos de estudo por dia valem a pena",
                "Alguns minutos de estudo por dia valem a pena",
                "Alguns minutos de estudo por dia valem a pena",
                "Alguns minutos de estudo por dia valem a pena",
                "Alguns minutos de estudo por dia valem a pena",
                "Alguns minutos de estudo por dia valem a pena",
                "Alguns minutos de estudo por dia valem a pena",
                "Alguns minutos de estudo por dia valem a pena",
                "Alguns minutos de estudo por dia valem a pena",
                "Alguns minutos de estudo por dia valem a pena",
                "Alguns minutos de estudo por dia valem a pena",
                "Alguns minutos de estudo por dia valem a pena",
                "Alguns minutos de estudo por dia valem a pena",
                "Alguns minutos de estudo por dia valem a pena",
                "Alguns minutos de estudo por dia valem a pena",
                "Alguns minutos de estudo por dia valem a pena",
                "Alguns minutos de estudo por dia valem a pena",
                "Alguns minutos de estudo por dia valem a pena",
                "Alguns minutos de estudo por dia valem a pena",
                "Alguns minutos de estudo por dia valem a pena",
                "Alguns minutos de estudo por dia valem a pena",
                "Alguns minutos de estudo por dia valem a pena",
                "Alguns minutos de estudo por dia valem a pena",
                "Alguns minutos de estudo por dia valem a pena",
                "Alguns minutos de estudo por dia valem a pena",
                "Alguns minutos de estudo por dia valem a pena",
                "Alguns minutos de estudo por dia valem a pena",
                "Alguns minutos de estudo por dia valem a pena",
                "Alguns minutos de estudo por dia valem a pena",
                "Alguns minutos de estudo por dia valem a pena",
                "Alguns minutos de estudo por dia valem a pena",
                "Alguns minutos de estudo por dia valem a pena",
                "Alguns minutos de estudo por dia valem a pena",
                "Alguns minutos de estudo por dia valem a pena",
                "Alguns minutos de estudo por dia valem a pena",
                "Alguns minutos de estudo por dia valem a pena",
                "Alguns minutos de estudo por dia valem a pena",
                "Alguns minutos de estudo por dia valem a pena",
                "Alguns minutos de estudo por dia valem a pena",
                "Alguns minutos de estudo por dia valem a pena",
                "Alguns minutos de estudo por dia valem a pena",
                "Alguns minutos de estudo por dia valem a pena",
                "Alguns minutos de estudo por dia valem a pena",
                "Alguns minutos de estudo por dia valem a pena",
                "Alguns minutos de estudo por dia valem a pena",
                "Alguns minutos de estudo por dia valem a pena",
                "Alguns minutos de estudo por dia valem a pena",
                "Alguns minutos de estudo por dia valem a pena",
                "Alguns minutos de estudo por dia valem a pena",
                "Alguns minutos de estudo por dia valem a pena",
                "Alguns minutos de estudo por dia valem a pena",
                "Alguns minutos de estudo por dia valem a pena",
                "Alguns minutos de estudo por dia valem a pena",
                "Alguns minutos de estudo por dia valem a pena",
                "Alguns minutos de estudo por dia valem a pena",
                "Alguns minutos de estudo por dia valem a pena",
                "Alguns minutos de estudo por dia valem a pena",
                "Alguns minutos de estudo por dia valem a pena",
                "Alguns minutos de estudo por dia valem a pena",
                "Alguns minutos de estudo por dia valem a pena",
                "Alguns minutos de estudo por dia valem a pena",
                "Alguns minutos de estudo por dia valem a pena",
                "Alguns minutos de estudo por dia valem a pena",
                "Alguns minutos de estudo por dia valem a pena",
                "Alguns minutos de estudo por dia valem a pena",
                "Alguns minutos de estudo por dia valem a pena",
                "Alguns minutos de estudo por dia valem a pena",
                "Alguns minutos de estudo por dia valem a pena",
                "Alguns minutos de estudo por dia valem a pena",
                "Alguns minutos de estudo por dia valem a pena",
                "Alguns minutos de estudo por dia valem a pena",
                "Alguns minutos de estudo por dia valem a pena",
                "Alguns minutos de estudo por dia valem a pena",
                "Alguns minutos de estudo por dia valem a pena",
                "Alguns minutos de estudo por dia valem a pena",
                "Alguns minutos de estudo por dia valem a pena",
                "Alguns minutos de estudo por dia valem a pena",
                "Alguns minutos de estudo por dia valem a pena",
                "Alguns minutos de estudo por dia valem a pena",
                "Alguns minutos de estudo por dia valem a pena",
                "Alguns minutos de estudo por dia valem a pena",
                "Alguns minutos de estudo por dia valem a pena",
                "Alguns minutos de estudo por dia valem a pena",
                "Alguns minutos de estudo por dia valem a pena",
                "Alguns minutos de estudo por dia valem a pena",
                "Alguns minutos de estudo por dia valem a pena",

            };

            while (num_linhas < linhas.Count)       
            {
                if (num_linhas == 0)   
                {
                    //Dados para impressão do título
                    e.Graphics.DrawString(titulo, letraTituloi, pincelTitulo, areaTitulo);      
                    y += 150;
                }

                //Dados para impressão do texto
                e.Graphics.DrawString(linhas[num_linhas], letra, pincel, new Point(x, y));          
                y += 30;
                num_linhas++;

                if (y >= altura - 50)
                {
                    //Mudar de página
                    y = 50;
                    e.HasMorePages = true;      
                    num_paginas++;
                    break;
                }

            }


        }

        private void buttonVisualizar_Click(object sender, EventArgs e)
        {
            largura = printDocument1.DefaultPageSettings.Bounds.Width;             
            altura = printDocument1.DefaultPageSettings.Bounds.Height;              
            x = 50;
            y = 50;
            num_linhas = 0;

            printPreviewControl1.Document = printDocument1;
        }

        private void buttonAnterior_Click(object sender, EventArgs e)
        {
            if (pagina > 0)
            {
                printPreviewControl1.StartPage = --pagina;
            }
        }

        private void buttonProx_Click(object sender, EventArgs e)
        {
            if (pagina < num_paginas)
            {
                printPreviewControl1.StartPage = ++pagina;
            }

        }

        private void buttonVisualizPad_Click(object sender, EventArgs e)
        {

            largura = printDocument1.DefaultPageSettings.Bounds.Width;              
            altura = printDocument1.DefaultPageSettings.Bounds.Height;              
            x = 50;
            y = 50;
            num_linhas = 0; 
            
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
    }
}
