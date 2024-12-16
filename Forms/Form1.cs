using Microsoft.EntityFrameworkCore;
using System.Windows.Forms;
using EntityFrameworkExample.Models;

namespace EntityFrameworkExample;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        LoadData();
    }

    public void LoadData()
    {
        using (var context = new AppDbContext())
        {
            var data = context.Users.ToList();
            Datagrid.DataSource = data;
        }
    }

    private void Submit_Click(object sender, EventArgs e)
    {
        using (var context = new AppDbContext())
        {
            var newUser = new User()
            {
                Username = Username.Text,
                Email = Email.Text,
                Password = Password.Text
            };
            context.Users.Add(newUser);
            context.SaveChanges();
        }
        LoadData();
    }

    private void Delete_Click(object sender, EventArgs e)
    {
        using (var context = new AppDbContext())
        {
            var username = Username.Text;
            var email = Email.Text;

            var user = context.Users.FirstOrDefault(u => u.Username == username && u.Email == email);
            if (user != null)
            {
                context.Users.Remove(user);
                context.SaveChanges();
                MessageBox.Show(@"User deleted successfully.");
            }
            else
            {
                MessageBox.Show(@"User not found.");

            }
        }
        LoadData();
    }
}