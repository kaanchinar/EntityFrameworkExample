namespace EntityFrameworkExample;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        Datagrid = new DataGridView();
        label1 = new Label();
        label2 = new Label();
        label3 = new Label();
        Username = new TextBox();
        Email = new TextBox();
        Password = new TextBox();
        Submit = new Button();
        Delete = new Button();
        ((System.ComponentModel.ISupportInitialize)Datagrid).BeginInit();
        SuspendLayout();
        // 
        // Datagrid
        // 
        Datagrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        Datagrid.Dock = DockStyle.Right;
        Datagrid.Location = new Point(386, 0);
        Datagrid.Name = "Datagrid";
        Datagrid.Size = new Size(414, 450);
        Datagrid.TabIndex = 5;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(32, 61);
        label1.Name = "label1";
        label1.Size = new Size(60, 15);
        label1.TabIndex = 6;
        label1.Text = "Username";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(56, 90);
        label2.Name = "label2";
        label2.Size = new Size(36, 15);
        label2.TabIndex = 7;
        label2.Text = "Email";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(35, 119);
        label3.Name = "label3";
        label3.Size = new Size(57, 15);
        label3.TabIndex = 8;
        label3.Text = "Password";
        // 
        // Username
        // 
        Username.Location = new Point(98, 53);
        Username.Name = "Username";
        Username.PlaceholderText = "Username";
        Username.Size = new Size(218, 23);
        Username.TabIndex = 9;
        // 
        // Email
        // 
        Email.Location = new Point(98, 82);
        Email.Name = "Email";
        Email.PlaceholderText = "Email";
        Email.Size = new Size(218, 23);
        Email.TabIndex = 10;
        // 
        // Password
        // 
        Password.Location = new Point(98, 111);
        Password.Name = "Password";
        Password.PasswordChar = '*';
        Password.PlaceholderText = "Password";
        Password.Size = new Size(218, 23);
        Password.TabIndex = 11;
        // 
        // Submit
        // 
        Submit.Location = new Point(146, 140);
        Submit.Name = "Submit";
        Submit.Size = new Size(113, 37);
        Submit.TabIndex = 12;
        Submit.Text = "Add User";
        Submit.UseVisualStyleBackColor = true;
        Submit.Click += Submit_Click;
        // 
        // Delete
        // 
        Delete.Location = new Point(146, 183);
        Delete.Name = "Delete";
        Delete.Size = new Size(113, 37);
        Delete.TabIndex = 13;
        Delete.Text = "Delete User";
        Delete.UseVisualStyleBackColor = true;
        Delete.Click += Delete_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(Delete);
        Controls.Add(Submit);
        Controls.Add(Password);
        Controls.Add(Email);
        Controls.Add(Username);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(Datagrid);
        Name = "Form1";
        Text = "Form1";
        ((System.ComponentModel.ISupportInitialize)Datagrid).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private DataGridView Datagrid;
    private Label label1;
    private Label label2;
    private Label label3;
    private TextBox Username;
    private TextBox Email;
    private TextBox Password;
    private Button Submit;
    private Button Delete;
}