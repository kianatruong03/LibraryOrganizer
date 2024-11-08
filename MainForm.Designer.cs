partial class MainForm
{
    private System.Windows.Forms.DataGridView dataGridViewBooks;
    private System.Windows.Forms.Button btnAdd;
    private System.Windows.Forms.Button btnEdit;
    private System.Windows.Forms.Button btnDelete;
    private System.Windows.Forms.TextBox txtFilterGenre;
    private System.Windows.Forms.TextBox txtFilterAuthor;
    private System.Windows.Forms.TextBox txtFilterTitle;
    private System.Windows.Forms.Label lblFilterGenre;
    private System.Windows.Forms.Label lblFilterAuthor;
    private System.Windows.Forms.Label lblFilterTitle;

    //All the cordinate for the lunction and layout of the table for books
    private void InitializeComponent()
    {
        this.dataGridViewBooks = new System.Windows.Forms.DataGridView();
        this.btnAdd = new System.Windows.Forms.Button();
        this.btnEdit = new System.Windows.Forms.Button();
        this.btnDelete = new System.Windows.Forms.Button();
        this.txtFilterGenre = new System.Windows.Forms.TextBox();
        this.txtFilterAuthor = new System.Windows.Forms.TextBox();
        this.txtFilterTitle = new System.Windows.Forms.TextBox();
        this.lblFilterGenre = new System.Windows.Forms.Label();
        this.lblFilterAuthor = new System.Windows.Forms.Label();
        this.lblFilterTitle = new System.Windows.Forms.Label();

        // dataGridViewBooks
        this.dataGridViewBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dataGridViewBooks.Location = new System.Drawing.Point(12, 90);
        this.dataGridViewBooks.Name = "dataGridViewBooks";
        this.dataGridViewBooks.Size = new System.Drawing.Size(560, 300);
        this.dataGridViewBooks.TabIndex = 0;

        // Add button
        this.btnAdd.Location = new System.Drawing.Point(12, 400);
        this.btnAdd.Name = "btnAdd";
        this.btnAdd.Size = new System.Drawing.Size(75, 23);
        this.btnAdd.TabIndex = 1;
        this.btnAdd.Text = "Add";
        this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

        // Edit button
        this.btnEdit.Location = new System.Drawing.Point(100, 400);
        this.btnEdit.Name = "btnEdit";
        this.btnEdit.Size = new System.Drawing.Size(75, 23);
        this.btnEdit.TabIndex = 2;
        this.btnEdit.Text = "Edit";
        this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);

        // Delete button
        this.btnDelete.Location = new System.Drawing.Point(190, 400);
        this.btnDelete.Name = "btnDelete";
        this.btnDelete.Size = new System.Drawing.Size(75, 23);
        this.btnDelete.TabIndex = 3;
        this.btnDelete.Text = "Delete";
        this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

        // Input FilterGenre
        this.txtFilterGenre.Location = new System.Drawing.Point(100, 64);
        this.txtFilterGenre.Name = "txtFilterGenre";
        this.txtFilterGenre.Size = new System.Drawing.Size(150, 20);
        this.txtFilterGenre.TabIndex = 4;
        this.txtFilterGenre.TextChanged += new System.EventHandler(this.txtFilterGenre_TextChanged);

        // Input FilterAuthor
        this.txtFilterAuthor.Location = new System.Drawing.Point(100, 38);
        this.txtFilterAuthor.Name = "txtFilterAuthor";
        this.txtFilterAuthor.Size = new System.Drawing.Size(150, 20);
        this.txtFilterAuthor.TabIndex = 5;
        this.txtFilterAuthor.TextChanged += new System.EventHandler(this.txtFilterAuthor_TextChanged);

        // Input FilterTitle
        this.txtFilterTitle.Location = new System.Drawing.Point(100, 12);
        this.txtFilterTitle.Name = "txtFilterTitle";
        this.txtFilterTitle.Size = new System.Drawing.Size(150, 20);
        this.txtFilterTitle.TabIndex = 6;
        this.txtFilterTitle.TextChanged += new System.EventHandler(this.txtFilterTitle_TextChanged);

        // Label FilterGenre
        this.lblFilterGenre.Location = new System.Drawing.Point(12, 64);
        this.lblFilterGenre.Name = "lblFilterGenre";
        this.lblFilterGenre.Size = new System.Drawing.Size(82, 20);
        this.lblFilterGenre.Text = "Filter by Genre:";

        // label FilterAuthor
        this.lblFilterAuthor.Location = new System.Drawing.Point(12, 38);
        this.lblFilterAuthor.Name = "lblFilterAuthor";
        this.lblFilterAuthor.Size = new System.Drawing.Size(82, 20);
        this.lblFilterAuthor.Text = "Filter by Author:";

        // Label FilterTitle
        this.lblFilterTitle.Location = new System.Drawing.Point(12, 12);
        this.lblFilterTitle.Name = "lblFilterTitle";
        this.lblFilterTitle.Size = new System.Drawing.Size(82, 20);
        this.lblFilterTitle.Text = "Filter by Title:";

        // MainForm
        this.ClientSize = new System.Drawing.Size(584, 441);
        this.Controls.Add(this.lblFilterGenre);
        this.Controls.Add(this.txtFilterGenre);
        this.Controls.Add(this.lblFilterAuthor);
        this.Controls.Add(this.txtFilterAuthor);
        this.Controls.Add(this.lblFilterTitle);
        this.Controls.Add(this.txtFilterTitle);
        this.Controls.Add(this.btnDelete);
        this.Controls.Add(this.btnEdit);
        this.Controls.Add(this.btnAdd);
        this.Controls.Add(this.dataGridViewBooks);
        this.Name = "MainForm";
        this.Text = "Library Organizer";

        ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();
    }
}
