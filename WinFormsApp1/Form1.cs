namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            //Declaración de Matriz

            double[,] calificaciones = new double[3, 3];

            //Obtener calificaciones desde los TextBoxes

            calificaciones[0,0] = Convert.ToDouble(texboxEst1_1.Text);
            calificaciones[0,1] = Convert.ToDouble(texboxEst1_2.Text);
            calificaciones[0,2] = Convert.ToDouble(texboxEst1_3.Text);

            calificaciones[1,0] = Convert.ToDouble(texboxEst2_1.Text); 
            calificaciones[1,1] = Convert.ToDouble(texboxEst2_2.Text);
            calificaciones[1,2] = Convert.ToDouble(texboxEst2_3.Text);

            calificaciones[2,0] = Convert.ToDouble(texboxEst3_1.Text);
            calificaciones[2,1] = Convert.ToDouble(texboxEst3_2.Text);
            calificaciones[2,2] = Convert.ToDouble(texboxEst3_3.Text);

            //Variables promedios

            double[] PromediosEstudiantes = new double[3];



        }
    }
}
