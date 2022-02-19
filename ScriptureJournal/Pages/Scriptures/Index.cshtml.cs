using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ScriptureJournal.Data;
using ScriptureJournal.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ScriptureJournal.Pages.Scriptures
{
    public class IndexModel : PageModel
    {
        private readonly ScriptureJournal.Data.ScriptureJournalContext _context;

        public IndexModel(ScriptureJournal.Data.ScriptureJournalContext context)
        {
            _context = context;
        }

        public IList<Scripture> Scripture { get;set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public SelectList Books { get; set; }
        public string ScriptureBooks { get; set; }


        public async Task OnGetAsync()
        {
            // Use LINQ to get list of genres.
            IQueryable<string> bookQuery = from m in _context.Scripture
                                            orderby m.Book
                                            select m.Book;

            var scriptures = from m in _context.Scripture
                         select m;

            if (!string.IsNullOrEmpty(SearchString))
            {
                scriptures = scriptures.Where(s => s.Book.Contains(SearchString));
            }

            if (!string.IsNullOrEmpty(ScriptureBooks))
            {
                scriptures = scriptures.Where(x => x.Book == ScriptureBooks);
            }

            Scripture = await _context.Scripture.ToListAsync();
            Books = new SelectList(await bookQuery.Distinct().ToListAsync());
        }
    }
}
