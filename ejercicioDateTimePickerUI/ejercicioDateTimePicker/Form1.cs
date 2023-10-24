namespace ejercicioDateTimePicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Verificar que la fecha seleccionada sea para una persona mayor de edad.
        //Creamos el método
        void validarFecha()
        {
            DateTime hoy = DateTime.Today;
            if (TimePickerEdad.Value.Date > hoy)
            {
                MessageBox.Show("Fecha invalida", " Error de Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lblResultado.Text = ("No puedes seleccionar futura");

            }
            else if (TimePickerEdad.Value.Date.AddYears(18) <= hoy)
            {
                MessageBox.Show("Eres mayor de edad", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblResultado.Text = ("Eres mayor de edad");

            }
            else
            {
                MessageBox.Show("Eres menor de edad", " Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lblResultado.Text = ("Eres menor de edad");
            }

            {

            }

        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            validarFecha();

        }
    }
}