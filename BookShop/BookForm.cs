using BookShop.Models;
using BookShop.Classes;
using BookShop.ViewModel;

namespace BookShop;

public partial class BookForm : Form
{

    int bookId = -1;
    string bookImg=String.Empty;
    public BookForm()
    {
        InitializeComponent();
    }

    private async void BookForm_Load(object sender, EventArgs e)
    {
        var books = await new Manage().GetBooks();

        dataGridView1.DataSource = books.Select(b => new BookViewModel()
        {
            Id = b.Id,
            Name = b.Name,
            Writer = b.Writer,
            Publisher = b.Publisher,
            Inventory = b.Inventory,
            Price = b.Price,
            GroupName = new Manage().GetGroup(b.GroupId)
        }).OrderBy(b => b.Name).ToList();

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
        var groupId = groups.FirstOrDefault(g => g.Name == item.ToString()).Id;


        Book book = new Book()
        {
            Name = bookName.Text,
            Writer = bookWriter.Text,
            Publisher = bookPublisher.Text,
            Translator = bookTranslator.Text,
            Summary = bookSummary.Text,
            Price = int.Parse(bookPrice.Text),
            Inventory = int.Parse(bookInventory.Text),
            GroupId = groupId,
            CoverImg = await SaveImage()

        };

        if (btnAdd.Text.Contains("ثبت"))
        {
            var result = await new Manage().AddBook(book);
            MessageBox.Show(result);
        }
        else if (btnAdd.Text.Contains("ویرایش"))
        {
            book.Id = bookId;

            var result = new Manage().EditBook(book);
            MessageBox.Show(result);
        }


    }

    private async Task<string> SaveImage()
    {
        try
        {
            Image img = bookPicture.BackgroundImage;

            if (img != null)
            {
                Random r = new Random();
                string imgName = r.Next(100000, 999999) + ".png";

                string imgPath = "images\\";
                if (!Directory.Exists(imgPath))
                {
                    Directory.CreateDirectory(imgPath);
                }

                img.Save(imgPath + imgName);

                return await Task.FromResult(imgName);
            }

            return String.Empty;
        }
        catch (Exception)
        {

            return String.Empty;
        }

    }

    private void bookPrice_TextChanged(object sender, EventArgs e)
    {

    }

    private async void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        try
        {
            var id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;

            //MessageBox.Show(id.ToString());

            var book = await new Manage().GetBook(id);

            if (book != null)
            {
                bookId = book.Id;
                bookName.Text = book.Name;
                bookWriter.Text = book.Writer;
                bookPublisher.Text = book.Publisher;
                bookSummary.Text = book.Summary;
                bookPrice.Text = book.Price.ToString();
                bookInventory.Text = book.Inventory.ToString();
                bookTranslator.Text = book.Translator;

                comboGroups.SelectedItem = new Manage().GetGroup(book.GroupId);

                if (book.CoverImg!=null)
                {
                    bookPicture.BackgroundImage=
                        Image.FromFile("images\\"+book.CoverImg);

                    bookImg = book.CoverImg;

                }
                else
                {
                    bookPicture.BackgroundImage = null;
                }

                btnAdd.Text = "ویرایش کتاب";
                btnDelete.Visible = true;
            }

        }
        catch (Exception)
        {

            //throw;
        }


    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {

    }

    private void btnAddPicture_Click(object sender, EventArgs e)
    {
        OpenFileDialog openFile = new OpenFileDialog()
        {
            Filter = "Image File(*.jpg; *.jpeg; *.png;)|*.jpg; *.jpeg; *.png"
        };



        if (openFile.ShowDialog() == DialogResult.OK)
        {
            bookPicture.BackgroundImage = new Bitmap(openFile.FileName);
        }

    }

    private async void btnDelete_Click(object sender, EventArgs e)
    {
        if (bookPicture.BackgroundImage!=null)
        {
            bookPicture.BackgroundImage.Dispose();

        }

        var result = await new Manage().DeleteBook(bookId, bookImg);

        MessageBox.Show(result);
    }
}
