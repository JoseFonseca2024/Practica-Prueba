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

            //Variables promedios por estudiante

            double[] PromediosEstudiantes = new double[3];

            //Calcular promedios por estudiantes

            for (int i = 0; i < calificaciones.GetLength(0); i++)
            {
                double sumaEstudiante = 0;

                for (int j = 0; j < calificaciones.GetLength(1); j++)
                {
                    sumaEstudiante += calificaciones[i, j];
                }

                PromediosEstudiantes [i] = sumaEstudiante / calificaciones.GetLength (1);

            }

            //Calcular promedios por examenes

            double[] promediosExamenes = new double[3];

            for (int j = 0; j < calificaciones.GetLength(1); j++)
            {

                double sumaexamen = 0;

                for (int i = 0; i < calificaciones.GetLength(0); i++)
                {
                    sumaexamen += calificaciones[i, j];
                }

                promediosExamenes[j] = sumaexamen / calificaciones.GetLength (0);
            }

                //Mostrarpromedios en Listbox

                listPromediosEst.Items.Clear();

                for (int i = 0; i < PromediosEstudiantes.Length; i++)
                {
                    listPromediosEst.Items.Add($"Promedio del estudiante {i + 1} : {PromediosEstudiantes[i]:0.00}");
                }

            // Mostrar promedios por exámenes (columnas) en ListBox
            listPromediosEx.Items.Clear();

            for (int j = 0; j < promediosExamenes.Length; j++)
            {
                listPromediosEx.Items.Add($"Promedio del examen {j + 1}: {promediosExamenes[j]:0.00}");
            }

        }
    }
}
