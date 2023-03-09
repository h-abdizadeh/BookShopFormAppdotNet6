using BookShop.Models;
using BookShop.Classes;
using BookShop.ViewModel;

namespace BookShop;

public partial class BookForm : Form
{
    public BookForm()
    {
        InitializeComponent();
    }

    private async void BookForm_Load(object sender, EventArgs e)
    {
        var books= await new Manage().GetBooks();

        dataGridView1.DataSource =books.Select(b=>new BookViewModel()
        {
            Id = b.Id,
            Name = b.Name,
            Writer=b.Writer,
            Publisher=b.Publisher,
            Inventory=b.Inventory,
            Price=b.Price,
            GroupName=new Manage().GetGroup(b.GroupId)
        }).OrderBy(b=>b.Name).ToList();

        dataGridView1.Columns[0].HeaderText = "ردیف";
        dataGridView1.Columns[1].HeaderText = "نام کتاب";
        dataGridView1.Columns[2].HeaderText = "نویسنده";
        dataGridView1.Columns[3].HeaderText = "انتشارات";
        dataGridView1.Columns[4].HeaderText = "موجودی";
        dataGridView1.Columns[5].HeaderText = "قیمت";
        dataGridView1.Columns[6].HeaderText = "گروه";


        List<Group> groups = new Manage().GetGroups();

        comboGroups.Items.Clear();

        comboGroups.Items.AddRange(groups.Select(g => g.Name).ToArray());
    }

    private async void btnAdd_Click(object sender, EventArgs e)
    {
        var item = comboGroups.SelectedItem;
        var groups = new Manage().GetGroups();
        var groupId= groups.FirstOrDefault(g => g.Name == item.ToString()).Id;


        Book book = new Book()
        {
            Name = bookName.Text,
            Writer = bookWriter.Text,
            Publisher = bookPublisher.Text,
            Translator = bookTranslator.Text,
            Summary = bookSummary.Text,
            Price = int.Parse(bookPrice.Text),
            Inventory = int.Parse(bookInventory.Text),
            GroupId=groupId
            
        };

        var result=await new Manage().AddBook(book);
        MessageBox.Show(result);
    }

    private void bookPrice_TextChanged(object sender, EventArgs e)
    {
        
    }
}
