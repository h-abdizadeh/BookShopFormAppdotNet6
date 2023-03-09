using BookShop.Classes;
using BookShop.Models;
using BookShop.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShop;

public partial class GroupForm : Form
{
    public GroupForm()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(groupName.Text.Trim()))
        {
            Group group = new Group()
            {
                Name = groupName.Text,
                Des = groupDes.Text
            };

            Manage manage = new Manage();

            var result = manage.AddGroup(group);

            MessageBox.Show(result);

            var groups = manage.GetGroups();
            dataGridView1.DataSource = groups;
        }
    }

    private void GroupForm_Load(object sender, EventArgs e)
    {
        var groups = new Manage().GetGroups();

        if (groups != null)
        {
            dataGridView1.DataSource = groups.Select(g => new GroupViewModel()
            {
                Id = g.Id,
                Name = g.Name,
                Des = g.Des
            }).ToList();

            dataGridView1.Columns[0].HeaderText = "ردیف";
            dataGridView1.Columns[1].HeaderText = "گروه";
            dataGridView1.Columns[2].HeaderText = "خلاصه";
        }

    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {
        //if (textBox1.Text.Length>=3)
        //{
            dataGridView1.DataSource = new Manage().GroupSearch(textBox1.Text);
        //}
    }
}
