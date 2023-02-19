namespace ErgasiaAleph
{
    partial class Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Name = new System.Windows.Forms.Label();
            this.Surname = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.Phone = new System.Windows.Forms.Label();
            this.Adress = new System.Windows.Forms.Label();
            this.DateofBirth = new System.Windows.Forms.Label();
            this.Request = new System.Windows.Forms.Label();
            this.DateTimeofRequest = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.NewRequest = new System.Windows.Forms.Button();
            this.ShowAllRequests = new System.Windows.Forms.Button();
            this.DeleteEntry = new System.Windows.Forms.Button();
            this.ModifyEntry = new System.Windows.Forms.Button();
            this.SearchRequest = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(36, 35);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(50, 16);
            this.Name.TabIndex = 0;
            this.Name.Text = "Όνομα:";
            // 
            // Surname
            // 
            this.Surname.AutoSize = true;
            this.Surname.Location = new System.Drawing.Point(36, 80);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(64, 16);
            this.Surname.TabIndex = 1;
            this.Surname.Text = "Επώνυμο:";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(36, 122);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(48, 16);
            this.Email.TabIndex = 2;
            this.Email.Text = "E-mail:";
            // 
            // Phone
            // 
            this.Phone.AutoSize = true;
            this.Phone.Location = new System.Drawing.Point(36, 169);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(73, 16);
            this.Phone.TabIndex = 3;
            this.Phone.Text = "Τηλέφωνο:";
            // 
            // Adress
            // 
            this.Adress.AutoSize = true;
            this.Adress.Location = new System.Drawing.Point(36, 220);
            this.Adress.Name = "Adress";
            this.Adress.Size = new System.Drawing.Size(72, 16);
            this.Adress.TabIndex = 4;
            this.Adress.Text = "Διεύθυνση:";
            // 
            // DateofBirth
            // 
            this.DateofBirth.AutoSize = true;
            this.DateofBirth.Location = new System.Drawing.Point(36, 267);
            this.DateofBirth.Name = "DateofBirth";
            this.DateofBirth.Size = new System.Drawing.Size(142, 16);
            this.DateofBirth.TabIndex = 5;
            this.DateofBirth.Text = "Ημερομηνία Γέννησης:";
            // 
            // Request
            // 
            this.Request.AutoSize = true;
            this.Request.Location = new System.Drawing.Point(36, 315);
            this.Request.Name = "Request";
            this.Request.Size = new System.Drawing.Size(50, 16);
            this.Request.TabIndex = 6;
            this.Request.Text = "Αίτημα:";
            // 
            // DateTimeofRequest
            // 
            this.DateTimeofRequest.AutoSize = true;
            this.DateTimeofRequest.Location = new System.Drawing.Point(36, 362);
            this.DateTimeofRequest.Name = "DateTimeofRequest";
            this.DateTimeofRequest.Size = new System.Drawing.Size(174, 16);
            this.DateTimeofRequest.TabIndex = 7;
            this.DateTimeofRequest.Text = "Ημερομηνία/Ώρα αιτήματος:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.69922F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.50391F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Controls.Add(this.NewRequest, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ShowAllRequests, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.DeleteEntry, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.ModifyEntry, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.SearchRequest, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.Clear, 5, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(39, 416);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1115, 50);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // NewRequest
            // 
            this.NewRequest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NewRequest.Location = new System.Drawing.Point(3, 3);
            this.NewRequest.Name = "NewRequest";
            this.NewRequest.Size = new System.Drawing.Size(180, 44);
            this.NewRequest.TabIndex = 0;
            this.NewRequest.Text = "Εισαγωγή Νέου Αιτήματος";
            this.NewRequest.UseVisualStyleBackColor = true;
            this.NewRequest.Click += new System.EventHandler(this.NewRequest_Click);
            // 
            // ShowAllRequests
            // 
            this.ShowAllRequests.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ShowAllRequests.Location = new System.Drawing.Point(189, 3);
            this.ShowAllRequests.Name = "ShowAllRequests";
            this.ShowAllRequests.Size = new System.Drawing.Size(180, 44);
            this.ShowAllRequests.TabIndex = 1;
            this.ShowAllRequests.Text = "Προβολή Όλων Των Αιτημάτων";
            this.ShowAllRequests.UseVisualStyleBackColor = true;
            this.ShowAllRequests.Click += new System.EventHandler(this.ShowAllRequests_Click);
            // 
            // DeleteEntry
            // 
            this.DeleteEntry.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteEntry.Location = new System.Drawing.Point(375, 3);
            this.DeleteEntry.Name = "DeleteEntry";
            this.DeleteEntry.Size = new System.Drawing.Size(180, 44);
            this.DeleteEntry.TabIndex = 2;
            this.DeleteEntry.Text = "Διαγραφή Εγγραγής";
            this.DeleteEntry.UseVisualStyleBackColor = true;
            this.DeleteEntry.Click += new System.EventHandler(this.DeleteEntry_Click);
            // 
            // ModifyEntry
            // 
            this.ModifyEntry.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ModifyEntry.Location = new System.Drawing.Point(561, 3);
            this.ModifyEntry.Name = "ModifyEntry";
            this.ModifyEntry.Size = new System.Drawing.Size(178, 44);
            this.ModifyEntry.TabIndex = 3;
            this.ModifyEntry.Text = "Τροποποίηση Εγγραφής";
            this.ModifyEntry.UseVisualStyleBackColor = true;
            this.ModifyEntry.Click += new System.EventHandler(this.ModifyEntry_Click);
            // 
            // SearchRequest
            // 
            this.SearchRequest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchRequest.Location = new System.Drawing.Point(745, 3);
            this.SearchRequest.Name = "SearchRequest";
            this.SearchRequest.Size = new System.Drawing.Size(180, 44);
            this.SearchRequest.TabIndex = 4;
            this.SearchRequest.Text = "Αναζήτηση Αιτήματος";
            this.SearchRequest.UseVisualStyleBackColor = true;
            this.SearchRequest.Click += new System.EventHandler(this.SearchRequest_Click);
            // 
            // Clear
            // 
            this.Clear.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Clear.Location = new System.Drawing.Point(931, 3);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(181, 44);
            this.Clear.TabIndex = 5;
            this.Clear.Text = "Καθαρισμός";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(262, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(892, 22);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox5.Location = new System.Drawing.Point(262, 220);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(892, 22);
            this.textBox5.TabIndex = 10;
            // 
            // textBox6
            // 
            this.textBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox6.Location = new System.Drawing.Point(262, 267);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(892, 22);
            this.textBox6.TabIndex = 11;
            // 
            // textBox8
            // 
            this.textBox8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox8.Location = new System.Drawing.Point(262, 362);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(892, 22);
            this.textBox8.TabIndex = 12;
            // 
            // textBox4
            // 
            this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox4.Location = new System.Drawing.Point(262, 169);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(892, 22);
            this.textBox4.TabIndex = 13;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.Location = new System.Drawing.Point(262, 122);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(892, 22);
            this.textBox3.TabIndex = 14;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(262, 80);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(892, 22);
            this.textBox2.TabIndex = 15;
            // 
            // textBox7
            // 
            this.textBox7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox7.Location = new System.Drawing.Point(262, 315);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(892, 22);
            this.textBox7.TabIndex = 16;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(39, 532);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1112, 103);
            this.dataGridView1.TabIndex = 17;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 647);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.DateTimeofRequest);
            this.Controls.Add(this.Request);
            this.Controls.Add(this.DateofBirth);
            this.Controls.Add(this.Adress);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Surname);
            this.Controls.Add(this.Name);
            this.MinimumSize = new System.Drawing.Size(1230, 694);
            this.Text = "Form";
            this.Text = "Κέντρο Εξυπηρέτησης Πολιτών";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label Surname;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label Phone;
        private System.Windows.Forms.Label Adress;
        private System.Windows.Forms.Label DateofBirth;
        private System.Windows.Forms.Label Request;
        private System.Windows.Forms.Label DateTimeofRequest;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button NewRequest;
        private System.Windows.Forms.Button ShowAllRequests;
        private System.Windows.Forms.Button DeleteEntry;
        private System.Windows.Forms.Button ModifyEntry;
        private System.Windows.Forms.Button SearchRequest;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

