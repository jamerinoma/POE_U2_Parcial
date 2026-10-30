using Microsoft.Data.SqlClient;
using RegistroNotasPOE.Clases;
using RegistroNotasPOE.Repositorios;

namespace RegistroNotasPOE.Formularios;

public partial class frmRegistrarNota : Form
{
    private readonly EstudianteRepositorio _repositorio = new();
    public frmRegistrarNota() { InitializeComponent(); }

    private void frmRegistrarNota_Load(object? sender, EventArgs e)
    {
        Limpiar();
        CargarRegistros();
    }

    private void Limpiar()
    {
        txtNombre.Clear(); txtApellido.Clear(); txtCodigo.Clear();
        txtLaboratorio.Clear(); txtParcial.Clear(); txtAsistencia.Clear();
        lblPromedio.Text = "Nota final: —";
        txtNombre.Focus();
    }

    private void CargarRegistros()
    {
        try
        {
            dgvRegistro.DataSource = null;
            dgvRegistro.DataSource = _repositorio.Listar();
            if (dgvRegistro.Columns["Id"] is { } id) id.Visible = false;
            if (dgvRegistro.Columns["NotaFinal"] is { } final) final.HeaderText = "Nota final";
            dgvRegistro.ClearSelection();
        }
        catch (Exception ex) { MostrarError("No se pudieron cargar los registros", ex); }
    }

    private void btnAgregar_Click(object? sender, EventArgs e)
    {
        if (!ValidadorNotas.IntentarEstudiante(txtNombre.Text, txtApellido.Text, txtCodigo.Text,
                txtLaboratorio.Text, txtParcial.Text, txtAsistencia.Text, out Estudiante estudiante, out string error))
        { MessageBox.Show(error, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
        try
        {
            _repositorio.Agregar(estudiante);
            MessageBox.Show($"Estudiante guardado. Nota final: {estudiante.NotaFinal:0.00}", "Registro exitoso",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            Limpiar(); CargarRegistros();
        }
        catch (SqlException ex) when (ex.Number is 2601 or 2627)
        { MessageBox.Show("El código del estudiante ya está registrado.", "Código duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        catch (Exception ex) { MostrarError("No fue posible guardar el estudiante", ex); }
    }

    private void dgvRegistro_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || dgvRegistro.Rows[e.RowIndex].DataBoundItem is not Estudiante actual) return;
        using var dialogo = new frmRegistrarNotaCmd(actual, _repositorio);
        if (dialogo.ShowDialog(this) == DialogResult.OK) CargarRegistros();
    }

    private void nota_KeyPress(object? sender, KeyPressEventArgs e) => ValidadorNotas.SoloDecimal(sender, e);

    private void nota_TextChanged(object? sender, EventArgs e)
    {
        if (ValidadorNotas.IntentarNota(txtLaboratorio.Text, "Laboratorio", out decimal l, out _) &&
            ValidadorNotas.IntentarNota(txtParcial.Text, "Parcial", out decimal p, out _) &&
            ValidadorNotas.IntentarNota(txtAsistencia.Text, "Asistencia", out decimal a, out _))
            lblPromedio.Text = $"Nota final: {ValidadorNotas.CalcularNotaFinal(l, p, a):0.00}";
        else lblPromedio.Text = "Nota final: —";
    }

    private static void MostrarError(string contexto, Exception ex) =>
        MessageBox.Show($"{contexto}.\n\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

}
