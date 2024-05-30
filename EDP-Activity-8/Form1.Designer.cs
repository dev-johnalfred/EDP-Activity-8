namespace EDP_Activity_8
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.Button btnFetchBooks;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.TextBox txtPublisherID;
        private System.Windows.Forms.TextBox txtPublicationYear;
        private System.Windows.Forms.TextBox txtCategoryID;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.Label lblPublisherID;
        private System.Windows.Forms.Label lblPublicationYear;
        private System.Windows.Forms.Label lblCategoryID;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dgvBooks = new DataGridView();
            btnFetchBooks = new Button();
            btnAddBook = new Button();
            txtTitle = new TextBox();
            txtISBN = new TextBox();
            txtPublisherID = new TextBox();
            txtPublicationYear = new TextBox();
            txtCategoryID = new TextBox();
            lblTitle = new Label();
            lblISBN = new Label();
            lblPublisherID = new Label();
            lblPublicationYear = new Label();
            lblCategoryID = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
            SuspendLayout();
            // 
            // dgvBooks
            // 
            dgvBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBooks.Location = new Point(12, 12);
            dgvBooks.Name = "dgvBooks";
            dgvBooks.RowHeadersWidth = 51;
            dgvBooks.Size = new Size(760, 200);
            dgvBooks.TabIndex = 0;
            // 
            // btnFetchBooks
            // 
            btnFetchBooks.Location = new Point(12, 218);
            btnFetchBooks.Name = "btnFetchBooks";
            btnFetchBooks.Size = new Size(109, 36);
            btnFetchBooks.TabIndex = 1;
            btnFetchBooks.Text = "Fetch Books";
            btnFetchBooks.UseVisualStyleBackColor = true;
            btnFetchBooks.Click += btnFetchBooks_Click;
            // 
            // btnAddBook
            // 
            btnAddBook.Location = new Point(549, 717);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(102, 35);
            btnAddBook.TabIndex = 2;
            btnAddBook.Text = "Add Book";
            btnAddBook.UseVisualStyleBackColor = true;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(140, 305);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(511, 27);
            txtTitle.TabIndex = 3;
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(140, 382);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(511, 27);
            txtISBN.TabIndex = 4;
            // 
            // txtPublisherID
            // 
            txtPublisherID.Location = new Point(140, 663);
            txtPublisherID.Name = "txtPublisherID";
            txtPublisherID.Size = new Size(511, 27);
            txtPublisherID.TabIndex = 5;
            // 
            // txtPublicationYear
            // 
            txtPublicationYear.Location = new Point(140, 562);
            txtPublicationYear.Name = "txtPublicationYear";
            txtPublicationYear.Size = new Size(511, 27);
            txtPublicationYear.TabIndex = 6;
            // 
            // txtCategoryID
            // 
            txtCategoryID.Location = new Point(140, 466);
            txtCategoryID.Name = "txtCategoryID";
            txtCategoryID.Size = new Size(511, 27);
            txtCategoryID.TabIndex = 7;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(140, 282);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(41, 20);
            lblTitle.TabIndex = 8;
            lblTitle.Text = "Title:";
            // 
            // lblISBN
            // 
            lblISBN.AutoSize = true;
            lblISBN.Location = new Point(140, 359);
            lblISBN.Name = "lblISBN";
            lblISBN.Size = new Size(44, 20);
            lblISBN.TabIndex = 9;
            lblISBN.Text = "ISBN:";
            // 
            // lblPublisherID
            // 
            lblPublisherID.AutoSize = true;
            lblPublisherID.Location = new Point(140, 629);
            lblPublisherID.Name = "lblPublisherID";
            lblPublisherID.Size = new Size(91, 20);
            lblPublisherID.TabIndex = 10;
            lblPublisherID.Text = "Publisher ID:";
            // 
            // lblPublicationYear
            // 
            lblPublicationYear.AutoSize = true;
            lblPublicationYear.Location = new Point(140, 531);
            lblPublicationYear.Name = "lblPublicationYear";
            lblPublicationYear.Size = new Size(118, 20);
            lblPublicationYear.TabIndex = 11;
            lblPublicationYear.Text = "Publication Year:";
            // 
            // lblCategoryID
            // 
            lblCategoryID.AutoSize = true;
            lblCategoryID.Location = new Point(140, 439);
            lblCategoryID.Name = "lblCategoryID";
            lblCategoryID.Size = new Size(91, 20);
            lblCategoryID.TabIndex = 12;
            lblCategoryID.Text = "Category ID:";
            // 
            // Form1
            // 
            ClientSize = new Size(784, 776);
            Controls.Add(lblCategoryID);
            Controls.Add(lblPublicationYear);
            Controls.Add(lblPublisherID);
            Controls.Add(lblISBN);
            Controls.Add(lblTitle);
            Controls.Add(txtCategoryID);
            Controls.Add(txtPublicationYear);
            Controls.Add(txtPublisherID);
            Controls.Add(txtISBN);
            Controls.Add(txtTitle);
            Controls.Add(btnAddBook);
            Controls.Add(btnFetchBooks);
            Controls.Add(dgvBooks);
            Name = "Form1";
            Text = "Library Management";
            ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
