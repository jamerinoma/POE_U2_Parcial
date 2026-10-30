namespace RegistroNotasPOE.Formularios;

partial class frmRegistrarNotaCmd
{
    private System.ComponentModel.IContainer? components = null;
    private Label lblTitulo = null!;
    private Label lblNombre = null!;
    private Label lblApellido = null!;
    private Label lblCodigo = null!;
    private Label lblLaboratorio = null!;
    private Label lblParcial = null!;
    private Label lblAsistencia = null!;
    private TextBox txtNombre = null!;
    private TextBox txtApellido = null!;
    private TextBox txtCodigo = null!;
    private TextBox txtLaboratorio = null!;
    private TextBox txtParcial = null!;
    private TextBox txtAsistencia = null!;
    private Button btnGuardar = null!;
    private Button btnCancelar = null!;

    protected override void Dispose(bool disposing)
    {
        if (disposing && components != null) components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        lblTitulo = new Label();
        lblNombre = new Label();
        lblApellido = new Label();
        lblCodigo = new Label();
        lblLaboratorio = new Label();
        lblParcial = new Label();
        lblAsistencia = new Label();
        txtNombre = new TextBox();
        txtApellido = new TextBox();
        txtCodigo = new TextBox();
        txtLaboratorio = new TextBox();
        txtParcial = new TextBox();
        txtAsistencia = new TextBox();
        btnGuardar = new Button();
        btnCancelar = new Button();
        SuspendLayout();

        lblTitulo.AutoSize = true;
        lblTitulo.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
        lblTitulo.Location = new Point(25, 18);
        lblTitulo.Name = "lblTitulo";
        lblTitulo.Size = new Size(236, 31);
        lblTitulo.TabIndex = 0;
        lblTitulo.Text = "EDITAR ESTUDIANTE";

        lblNombre.AutoSize = true;
        lblNombre.Location = new Point(25, 83);
        lblNombre.Name = "lblNombre";
        lblNombre.Size = new Size(59, 19);
        lblNombre.TabIndex = 1;
        lblNombre.Text = "Nombre";

        lblApellido.AutoSize = true;
        lblApellido.Location = new Point(297, 83);
        lblApellido.Name = "lblApellido";
        lblApellido.Size = new Size(58, 19);
        lblApellido.TabIndex = 3;
        lblApellido.Text = "Apellido";

        lblCodigo.AutoSize = true;
        lblCodigo.Location = new Point(25, 166);
        lblCodigo.Name = "lblCodigo";
        lblCodigo.Size = new Size(53, 19);
        lblCodigo.TabIndex = 5;
        lblCodigo.Text = "Código";

        lblLaboratorio.AutoSize = true;
        lblLaboratorio.Location = new Point(297, 166);
        lblLaboratorio.Name = "lblLaboratorio";
        lblLaboratorio.Size = new Size(80, 19);
        lblLaboratorio.TabIndex = 7;
        lblLaboratorio.Text = "Laboratorio";

        lblParcial.AutoSize = true;
        lblParcial.Location = new Point(25, 248);
        lblParcial.Name = "lblParcial";
        lblParcial.Size = new Size(48, 19);
        lblParcial.TabIndex = 9;
        lblParcial.Text = "Parcial";

        lblAsistencia.AutoSize = true;
        lblAsistencia.Location = new Point(297, 248);
        lblAsistencia.Name = "lblAsistencia";
        lblAsistencia.Size = new Size(69, 19);
        lblAsistencia.TabIndex = 11;
        lblAsistencia.Text = "Asistencia";

        txtNombre.Location = new Point(25, 109);
        txtNombre.MaxLength = 100;
        txtNombre.Name = "txtNombre";
        txtNombre.Size = new Size(245, 25);
        txtNombre.TabIndex = 2;
 
        txtApellido.Location = new Point(297, 109);
        txtApellido.MaxLength = 100;
        txtApellido.Name = "txtApellido";
        txtApellido.Size = new Size(245, 25);
        txtApellido.TabIndex = 4;

        txtCodigo.Location = new Point(25, 192);
        txtCodigo.MaxLength = 30;
        txtCodigo.Name = "txtCodigo";
        txtCodigo.Size = new Size(245, 25);
        txtCodigo.TabIndex = 6;

        txtLaboratorio.Location = new Point(297, 192);
        txtLaboratorio.MaxLength = 5;
        txtLaboratorio.Name = "txtLaboratorio";
        txtLaboratorio.Size = new Size(245, 25);
        txtLaboratorio.TabIndex = 8;
        txtLaboratorio.KeyPress += nota_KeyPress;

        txtParcial.Location = new Point(25, 274);
        txtParcial.MaxLength = 5;
        txtParcial.Name = "txtParcial";
        txtParcial.Size = new Size(245, 25);
        txtParcial.TabIndex = 10;
        txtParcial.KeyPress += nota_KeyPress;

        txtAsistencia.Location = new Point(297, 274);
        txtAsistencia.MaxLength = 5;
        txtAsistencia.Name = "txtAsistencia";
        txtAsistencia.Size = new Size(245, 25);
        txtAsistencia.TabIndex = 12;
        txtAsistencia.KeyPress += nota_KeyPress;

        btnGuardar.BackColor = Color.ForestGreen;
        btnGuardar.FlatStyle = FlatStyle.Flat;
        btnGuardar.ForeColor = Color.White;
        btnGuardar.Location = new Point(382, 363);
        btnGuardar.Name = "btnGuardar";
        btnGuardar.Size = new Size(163, 42);
        btnGuardar.TabIndex = 13;
        btnGuardar.Text = "Guardar cambios";
        btnGuardar.UseVisualStyleBackColor = false;
        btnGuardar.Click += btnGuardar_Click;

        btnCancelar.Location = new Point(248, 363);
        btnCancelar.Name = "btnCancelar";
        btnCancelar.Size = new Size(120, 42);
        btnCancelar.TabIndex = 14;
        btnCancelar.Text = "Cancelar";
        btnCancelar.Click += btnCancelar_Click;

        AcceptButton = btnGuardar;
        BackColor = Color.FromArgb(246, 248, 252);
        CancelButton = btnCancelar;
        ClientSize = new Size(570, 440);
        Controls.Add(lblTitulo);
        Controls.Add(lblNombre);
        Controls.Add(txtNombre);
        Controls.Add(lblApellido);
        Controls.Add(txtApellido);
        Controls.Add(lblCodigo);
        Controls.Add(txtCodigo);
        Controls.Add(lblLaboratorio);
        Controls.Add(txtLaboratorio);
        Controls.Add(lblParcial);
        Controls.Add(txtParcial);
        Controls.Add(lblAsistencia);
        Controls.Add(txtAsistencia);
        Controls.Add(btnGuardar);
        Controls.Add(btnCancelar);
        Font = new Font("Segoe UI", 10F);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "frmRegistrarNotaCmd";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Editar Estudiante";
        ResumeLayout(false);
        PerformLayout();
    }
}
