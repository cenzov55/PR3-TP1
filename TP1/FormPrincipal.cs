namespace TP1
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            lstNombres.Items.Add("Enzo Vinella Cuello");
        }

        private void btnEjercicio1_Click(object sender, EventArgs e)
        {
            Form formEjercicio1 = new FormEjercicio1(this);
            formEjercicio1.Show();
            this.Hide();
        }
    }
}
