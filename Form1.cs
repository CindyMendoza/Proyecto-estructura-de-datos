namespace ColaTransferenciasBancarias
{
    public partial class Form1 : Form
    {
        private ColaTransferencias cola = new ColaTransferencias();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text) ||
                string.IsNullOrWhiteSpace(txtOrigen.Text) ||
                string.IsNullOrWhiteSpace(txtDestino.Text) ||
                !decimal.TryParse(txtMonto.Text, out decimal monto) ||
                monto <= 0)
            {
                MessageBox.Show("Completa todos los campos y escribe un monto mayor que cero.");
                return;
            }

            Transferencia transferencia = new Transferencia(
                txtId.Text.Trim(),
                txtOrigen.Text.Trim(),
                txtDestino.Text.Trim(),
                monto
            );

            cola.Encolar(transferencia);

            ActualizarLista();

            txtId.Clear();
            txtOrigen.Clear();
            txtDestino.Clear();
            txtMonto.Clear();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            Transferencia transferencia = cola.Desencolar();

            if (transferencia == null)
            {
                MessageBox.Show("No hay transferencias pendientes.");
                return;
            }

            ActualizarLista();

            MessageBox.Show($"Transferencia procesada: {transferencia.Id}");
        }

        private void ActualizarLista()
        {
            lstTransferencias.Items.Clear();

            foreach (Transferencia transferencia in cola.ObtenerTodas())
            {
                lstTransferencias.Items.Add(transferencia);
            }

            lblCantidad.Text = $"Pendientes: {cola.Cantidad}";
        }
    }
}
