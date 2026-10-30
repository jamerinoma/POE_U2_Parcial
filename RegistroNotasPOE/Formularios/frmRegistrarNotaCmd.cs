using Microsoft.Data.SqlClient;
using RegistroNotasPOE.Clases;
using RegistroNotasPOE.Repositorios;

namespace RegistroNotasPOE.Formularios;
public partial class frmRegistrarNotaCmd : Form
{
    private readonly int _id;
    private readonly EstudianteRepositorio _repositorio;
   
    public frmRegistrarNotaCmd()
    {
        InitializeComponent();
        _repositorio = new EstudianteRepositorio();
    }

    public frmRegistrarNotaCmd(Estudiante registro, EstudianteRepositorio repositorio) : this()
    {
        _id = registro.Id; _repositorio = repositorio;
        txtNombre.Text = registro.Nombre;
        txtApellido.Text = registro.Apellido;
        txtCodigo.Text = registro.Codigo;
        txtLaboratorio.Text = registro.Laboratorio.ToString("0.##");
        txtParcial.Text = registro.Parcial.ToString("0.##");
        txtAsistencia.Text = registro.Asistencia.ToString("0.##");
    }
    private void btnGuardar_Click(object? sender, EventArgs e)
    {
        if (!ValidadorNotas.IntentarEstudiante(txtNombre.Text, txtApellido.Text, txtCodigo.Text,
                txtLaboratorio.Text, txtParcial.Text, txtAsistencia.Text, out Estudiante estudiante, out string error))
        { MessageBox.Show(error, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
        try
        {
            estudiante.Id = _id;
            _repositorio.Actualizar(estudiante);
            DialogResult = DialogResult.OK; Close();
        }
        catch (SqlException ex) when (ex.Number is 2601 or 2627)
        { MessageBox.Show("Ese código ya está registrado.", "Código duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        catch (Exception ex)
        { MessageBox.Show(ex.Message, "Error al editar", MessageBoxButtons.OK, MessageBoxIcon.Error); }
    }
    private void nota_KeyPress(object? sender, KeyPressEventArgs e) => ValidadorNotas.SoloDecimal(sender, e);
    private void btnCancelar_Click(object? sender, EventArgs e) { DialogResult = DialogResult.Cancel; Close(); }
}
