partial class SimpleView
{
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Label lblAuthor;
    private System.Windows.Forms.Label lblGenre;
    private System.Windows.Forms.Label lblTotalPages;
    private System.Windows.Forms.Label lblPagesRead;
    private System.Windows.Forms.Label lblTotalInSeries;
    private System.Windows.Forms.TextBox txtTitle;
    private System.Windows.Forms.TextBox txtAuthor;
    private System.Windows.Forms.TextBox txtGenre;
    private System.Windows.Forms.TextBox txtTotalPages;
    private System.Windows.Forms.TextBox txtPagesRead;
    private System.Windows.Forms.CheckBox chkInSeries;
    private System.Windows.Forms.TextBox txtTotalInSeries;
    private System.Windows.Forms.Button btnSave;

    //All the Visuals and functions for those visuals for adding, editing and deleteing a single book
    private void InitializeComponent()
    {
        // Initialize labels
        this.lblTitle = new System.Windows.Forms.Label();
        this.lblAuthor = new System.Windows.Forms.Label();
        this.lblGenre = new System.Windows.Forms.Label();
        this.lblTotalPages = new System.Windows.Forms.Label();
        this.lblPagesRead = new System.Windows.Forms.Label();
        this.lblTotalInSeries = new System.Windows.Forms.Label();

        // Initialize TextBoxes and other controls
        this.txtTitle = new System.Windows.Forms.TextBox();
        this.txtAuthor = new System.Windows.Forms.TextBox();
        this.txtGenre = new System.Windows.Forms.TextBox();
        this.txtTotalPages = new System.Windows.Forms.TextBox();
        this.txtPagesRead = new System.Windows.Forms.TextBox();
        this.chkInSeries = new System.Windows.Forms.CheckBox();
        this.txtTotalInSeries = new System.Windows.Forms.TextBox();
        this.btnSave = new System.Windows.Forms.Button();

        // Labels setup
        this.lblTitle.Text = "Title";
        this.lblTitle.Location = new System.Drawing.Point(12, 12);
        this.lblAuthor.Text = "Author";
        this.lblAuthor.Location = new System.Drawing.Point(12, 50);
        this.lblGenre.Text = "Genre";
        this.lblGenre.Location = new System.Drawing.Point(12, 88);
        this.lblPagesRead.Text = "Pages Read";
        this.lblPagesRead.Location = new System.Drawing.Point(12, 126); 
        this.lblTotalPages.Text = "Total Pages";
        this.lblTotalPages.Location = new System.Drawing.Point(12, 164);
        this.lblTotalInSeries.Text = "Total in Series";
        this.lblTotalInSeries.Location = new System.Drawing.Point(12, 240);

        // TextBoxes setup
        this.txtTitle.Location = new System.Drawing.Point(120, 12);
        this.txtTitle.Size = new System.Drawing.Size(200, 20);

        this.txtAuthor.Location = new System.Drawing.Point(120, 50);
        this.txtAuthor.Size = new System.Drawing.Size(200, 20);

        this.txtGenre.Location = new System.Drawing.Point(120, 88);
        this.txtGenre.Size = new System.Drawing.Size(200, 20);

        this.txtPagesRead.Location = new System.Drawing.Point(120, 126);
        this.txtPagesRead.Size = new System.Drawing.Size(200, 20);

        this.txtTotalPages.Location = new System.Drawing.Point(120, 164);
        this.txtTotalPages.Size = new System.Drawing.Size(200, 20);

        this.chkInSeries.Location = new System.Drawing.Point(12, 202);
        this.chkInSeries.Text = "In Series";

        this.txtTotalInSeries.Location = new System.Drawing.Point(120, 240);
        this.txtTotalInSeries.Size = new System.Drawing.Size(200, 20);

        // Save button setup
        this.btnSave.Location = new System.Drawing.Point(12, 280);
        this.btnSave.Text = "Save";
        this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

        // Form setup
        this.ClientSize = new System.Drawing.Size(350, 320);
        this.Controls.Add(this.lblTitle);
        this.Controls.Add(this.txtTitle);
        this.Controls.Add(this.lblAuthor);
        this.Controls.Add(this.txtAuthor);
        this.Controls.Add(this.lblGenre);
        this.Controls.Add(this.txtGenre);
        this.Controls.Add(this.lblTotalPages);
        this.Controls.Add(this.txtTotalPages);
        this.Controls.Add(this.lblPagesRead);
        this.Controls.Add(this.txtPagesRead);
        this.Controls.Add(this.chkInSeries);
        this.Controls.Add(this.lblTotalInSeries);
        this.Controls.Add(this.txtTotalInSeries);
        this.Controls.Add(this.btnSave);
        this.Name = "SimpleView";
        this.Text = "Add/Edit Book";
    }
}
