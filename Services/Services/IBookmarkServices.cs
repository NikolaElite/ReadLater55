using Entity;
using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface IBookmarkServices
    {
        public List<Bookmark> GetBookmarks();
        public Task<Bookmark> GetBookmark(int id);
        public Task<bool> DeleteBookmark(int id);
        public Task<bool> insertBookmark(Bookmark bookmark);
        public Task<bool> updateBookmark(Bookmark bookmark);
    }
}
