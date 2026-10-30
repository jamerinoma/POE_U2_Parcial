namespace RegistroNotasPOE.Formularios;

partial class frmRegistrarNota
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
    private Label lblPromedio = null!;
    private Label lblAyuda = null!;
    private Button btnAgregar = null!;
    private DataGridView dgvRegistro = null!;

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
        lblPromedio = new Label();
        lblAyuda = new Label();
        btnAgregar = new Button();
        dgvRegistro = new DataGridView();
        label1 = new Label();
        ((System.ComponentModel.ISupportInitialize)dgvRegistro).BeginInit();
        SuspendLayout();

        lblTitulo.AutoSize = true;
        lblTitulo.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
        lblTitulo.ForeColor = Color.FromArgb(31, 48, 81);
        lblTitulo.Location = new Point(26, 20);
        lblTitulo.Name = "lblTitulo";
        lblTitulo.Size = new Size(282, 37);
        lblTitulo.TabIndex = 0;
        lblTitulo.Text = "REGISTRO DE NOTAS";

        lblNombre.AutoSize = true;
        lblNombre.ForeColor = Color.FromArgb(45, 55, 72);
        lblNombre.Location = new Point(30, 79);
        lblNombre.Name = "lblNombre";
        lblNombre.Size = new Size(59, 19);
        lblNombre.TabIndex = 2;
        lblNombre.Text = "Nombre";

        lblApellido.AutoSize = true;
        lblApellido.ForeColor = Color.FromArgb(45, 55, 72);
        lblApellido.Location = new Point(370, 79);
        lblApellido.Name = "lblApellido";
        lblApellido.Size = new Size(58, 19);
        lblApellido.TabIndex = 4;
        lblApellido.Text = "Apellido";

        lblCodigo.AutoSize = true;
        lblCodigo.ForeColor = Color.FromArgb(45, 55, 72);
        lblCodigo.Location = new Point(710, 79);
        lblCodigo.Name = "lblCodigo";
        lblCodigo.Size = new Size(53, 19);
        lblCodigo.TabIndex = 6;
        lblCodigo.Text = "Código";
 
        lblLaboratorio.AutoSize = true;
        lblLaboratorio.ForeColor = Color.FromArgb(45, 55, 72);
        lblLaboratorio.Location = new Point(30, 161);
        lblLaboratorio.Name = "lblLaboratorio";
        lblLaboratorio.Size = new Size(154, 19);
        lblLaboratorio.TabIndex = 8;
        lblLaboratorio.Text = "Laboratorio (0–10) 50%";

        lblParcial.AutoSize = true;
        lblParcial.ForeColor = Color.FromArgb(45, 55, 72);
        lblParcial.Location = new Point(370, 161);
        lblParcial.Name = "lblParcial";
        lblParcial.Size = new Size(122, 19);
        lblParcial.TabIndex = 10;
        lblParcial.Text = "Parcial (0–10) 40%";

        lblAsistencia.AutoSize = true;
        lblAsistencia.ForeColor = Color.FromArgb(45, 55, 72);
        lblAsistencia.Location = new Point(710, 161);
        lblAsistencia.Name = "lblAsistencia";
        lblAsistencia.Size = new Size(143, 19);
        lblAsistencia.TabIndex = 12;
        lblAsistencia.Text = "Asistencia (0–10) 10%";

        txtNombre.Font = new Font("Segoe UI", 11F);
        txtNombre.Location = new Point(30, 104);
        txtNombre.MaxLength = 100;
        txtNombre.Name = "txtNombre";
        txtNombre.Size = new Size(294, 27);
        txtNombre.TabIndex = 3;

        txtApellido.Font = new Font("Segoe UI", 11F);
        txtApellido.Location = new Point(370, 104);
        txtApellido.MaxLength = 100;
        txtApellido.Name = "txtApellido";
        txtApellido.Size = new Size(294, 27);
        txtApellido.TabIndex = 5;
 
        txtCodigo.Font = new Font("Segoe UI", 11F);
        txtCodigo.Location = new Point(710, 104);
        txtCodigo.MaxLength = 30;
        txtCodigo.Name = "txtCodigo";
        txtCodigo.Size = new Size(294, 27);
        txtCodigo.TabIndex = 7;

        txtLaboratorio.Font = new Font("Segoe UI", 11F);
        txtLaboratorio.Location = new Point(30, 186);
        txtLaboratorio.MaxLength = 5;
        txtLaboratorio.Name = "txtLaboratorio";
        txtLaboratorio.Size = new Size(294, 27);
        txtLaboratorio.TabIndex = 9;
        txtLaboratorio.TextChanged += nota_TextChanged;
        txtLaboratorio.KeyPress += nota_KeyPress;

        txtParcial.Font = new Font("Segoe UI", 11F);
        txtParcial.Location = new Point(370, 186);
        txtParcial.MaxLength = 5;
        txtParcial.Name = "txtParcial";
        txtParcial.Size = new Size(294, 27);
        txtParcial.TabIndex = 11;
        txtParcial.TextChanged += nota_TextChanged;
        txtParcial.KeyPress += nota_KeyPress;

        txtAsistencia.Font = new Font("Segoe UI", 11F);
        txtAsistencia.Location = new Point(710, 186);
        txtAsistencia.MaxLength = 5;
        txtAsistencia.Name = "txtAsistencia";
        txtAsistencia.Size = new Size(294, 27);
        txtAsistencia.TabIndex = 13;
        txtAsistencia.TextChanged += nota_TextChanged;
        txtAsistencia.KeyPress += nota_KeyPress;

        lblPromedio.AutoSize = true;
        lblPromedio.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
        lblPromedio.ForeColor = Color.FromArgb(25, 85, 130);
        lblPromedio.Location = new Point(30, 229);
        lblPromedio.Name = "lblPromedio";
        lblPromedio.Size = new Size(102, 25);
        lblPromedio.TabIndex = 14;
        lblPromedio.Text = "Nota final:";

        lblAyuda.AutoSize = true;
        lblAyuda.ForeColor = Color.DimGray;
        lblAyuda.Location = new Point(30, 349);
        lblAyuda.Name = "lblAyuda";
        lblAyuda.Size = new Size(223, 19);
        lblAyuda.TabIndex = 16;
        lblAyuda.Text = "Doble clic sobre una fila para editar";

        btnAgregar.BackColor = Color.ForestGreen;
        btnAgregar.Cursor = Cursors.Hand;
        btnAgregar.FlatAppearance.BorderSize = 0;
        btnAgregar.FlatStyle = FlatStyle.Flat;
        btnAgregar.ForeColor = Color.White;
        btnAgregar.Location = new Point(30, 274);
        btnAgregar.Name = "btnAgregar";
        btnAgregar.Size = new Size(164, 42);
        btnAgregar.TabIndex = 15;
        btnAgregar.Text = "Agregar";
        btnAgregar.UseVisualStyleBackColor = false;
        btnAgregar.Click += btnAgregar_Click;

        dgvRegistro.AllowUserToAddRows = false;
        dgvRegistro.AllowUserToDeleteRows = false;
        dgvRegistro.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        dgvRegistro.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvRegistro.BackgroundColor = Color.White;
        dgvRegistro.BorderStyle = BorderStyle.None;
        dgvRegistro.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvRegistro.Location = new Point(30, 382);
        dgvRegistro.MultiSelect = false;
        dgvRegistro.Name = "dgvRegistro";
        dgvRegistro.ReadOnly = true;
        dgvRegistro.RowHeadersVisible = false;
        dgvRegistro.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvRegistro.Size = new Size(974, 265);
        dgvRegistro.TabIndex = 17;
        dgvRegistro.CellDoubleClick += dgvRegistro_CellDoubleClick;

        label1.AutoSize = true;
        label1.ForeColor = Color.DimGray;
        label1.Location = new Point(30, 330);
        label1.Name = "label1";
        label1.Size = new Size(134, 19);
        label1.TabIndex = 16;
        label1.Text = "Registros guardados";

        BackColor = Color.FromArgb(244, 247, 251);
        ClientSize = new Size(1040, 690);
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
        Controls.Add(lblPromedio);
        Controls.Add(btnAgregar);
        Controls.Add(label1);
        Controls.Add(lblAyuda);
        Controls.Add(dgvRegistro);
        Font = new Font("Segoe UI", 10F);
        MinimumSize = new Size(940, 620);
        Name = "frmRegistrarNota";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Crear Estudiante";
        Load += frmRegistrarNota_Load;
        ((System.ComponentModel.ISupportInitialize)dgvRegistro).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private Label label1;
}
