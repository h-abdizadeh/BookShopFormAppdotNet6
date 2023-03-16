using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookShop.Models;
using Microsoft.EntityFrameworkCore;

namespace BookShop.Classes;

public class Manage
{
    private DatabaseContext _context=new DatabaseContext();

    //////////////////////////// manage groups ////////////////////////

    public string AddGroup(Group group)
    {
        try
        {
            _context.Groups.Add(group);
            _context.SaveChanges();

            return "ثبت موفق";
        }
        catch (Exception e)
        {
            return e.Message;
        }
    }

    public List<Group> GetGroups()
    {
        var groups = _context.Groups.ToList();

        return groups;
    }

    public List<Group> GroupSearch(string search)
    {
        var groups = _context.Groups
                      .Where(g =>g.Name.Contains(search) ||
                                 g.Des.Contains(search))
                      .ToList();

        return groups;
    }


    public string GetGroup(int id)
    {
        return _context.Groups.Find(id).Name;
    }

    //////////////////////////// manage books ////////////////////////
    
    public async Task<string> AddBook (Book book)
    {
        try
        {
           await _context.Books.AddAsync(book);
           await _context.SaveChangesAsync();

            return "ثبت موفق";
        }
        catch (Exception e)
        {

            return e.Message;
        }
    }

    public async Task<List<Book>> GetBooks()
    {
        List<Book> books = await _context.Books.ToListAsync();

        return books;
    }


    public async Task<Book> GetBook(int id)
    {
        return await _context.Books.FindAsync(id);
    }

    public string EditBook(Book book)
    {
        try
        {
            _context.Update(book);
            _context.SaveChanges();

            return "ثبت موفق تغییرات";
        }
        catch (Exception error)
        {

            return error.Message;
        }


    }

    public async Task<string> DeleteBook(int id,string coverImg)
    {
        try
        {
            var book = await _context.Books.FindAsync(id);
            if (book != null)
            {
                _context.Books.Remove(book);

                string imgPath = "images\\" + coverImg;
                if (File.Exists(imgPath))
                {
                    File.Delete(imgPath);
                }
                await _context.SaveChangesAsync();

                return "حذف موفق";
            }

            return "رکورد نامعتبر";
        }
        catch (Exception error)
        {

            return error.Message;
        }
       
    }
}
