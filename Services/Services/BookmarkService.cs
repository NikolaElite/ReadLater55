using Data;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class BookmarkService : IBookmarkServices
    {
        private ReadLaterDataContext _ReadLaterDataContext;

        public BookmarkService(ReadLaterDataContext readLaterDataContext)
        {
            _ReadLaterDataContext = readLaterDataContext;
        }
        public async Task<bool> DeleteBookmark(int id)
        {
            var item = await _ReadLaterDataContext.Bookmark.FindAsync(id);
            var result = _ReadLaterDataContext.Bookmark.Remove(item);
            await _ReadLaterDataContext.SaveChangesAsync();

            if (result != null)
                return true;
            return false;
        }

        public async Task<Bookmark> GetBookmark(int id)
        {
            var result = await _ReadLaterDataContext.Bookmark.FindAsync(id);
            return result;

        }

        public List<Bookmark> GetBookmarks()
        {
            return _ReadLaterDataContext.Bookmark.ToList();
        }

        public async Task<bool> insertBookmark(Bookmark bookmark)
        {
            var result = await _ReadLaterDataContext.Bookmark.AddAsync(bookmark);
            await _ReadLaterDataContext.SaveChangesAsync();

            if (result != null)
                return true;

            return false;
        }

        public async Task<bool> updateBookmark(Bookmark bookmark)
        {
            var item = _ReadLaterDataContext.Bookmark.Update(bookmark);
            await _ReadLaterDataContext.SaveChangesAsync();

            if (item != null)
                return true;

            return false;



        }
    }
}
