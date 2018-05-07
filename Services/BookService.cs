using System.Collections.Generic;
using TheBookCave.Models.ViewModels;
using TheBookCave.Repositories;
using System.Linq;

namespace TheBookCave.Services {
    public class BookService {
        private BookRepo _bookRepo;
        private UserGradeRepo _userGradeRepo;
        private GenreRepo _genreRepo;
        private AuthorRepo _authorRepo;
        private PublisherRepo _publisherRepo;

        public BookService() {
            _bookRepo = new BookRepo();
            _userGradeRepo = new UserGradeRepo();
            _genreRepo = new GenreRepo();
            _authorRepo = new AuthorRepo();
            _publisherRepo = new PublisherRepo();
        }

        public List<BookListViewModel> getAllBooks() {
            var books = _bookRepo.getAllBooks();

            return books;
        }

        public List<BookListViewModel> getBook(int bid) {
            var book = _bookRepo.getBook(bid);
            return book;
        }
        public List<UserReviewListViewModel> getBookReviews(int bid) { 
            var reviews = _userGradeRepo.getAllReviewsBook(bid);
            
            return reviews;
        }
        public void addBookReview() {
            //var review = _userGradeRepo.CreateReview(userReview)
        }
        public void updateTotalGrade(int bid) {
            //TODO
        }

        public List<BookDetailedListViewModel> getBookList() {
            var books = _bookRepo.getAllBooks();
            var authors = _authorRepo.getAllAuthors();
            var publishers = _publisherRepo.getAllPublishers();
            var genres = _genreRepo.getAllGenres();
            var joined =    (from b in books
                            join a in authors
                            on b.AuthorId equals a.AuthorId
                            join p in publishers
                            on b.PublisherId equals p.Id
                            join g in genres
                            on b.GenreId equals g.Id
                            select new BookDetailedListViewModel { 
                                Id = b.Id,
                                Name = b.Name,
                                Price = b.Price,
                                Picture = b.Picture,
                                Grade = b.Grade,
                                DetailsEN = b.DetailsEN,
                                DetailsIS = b.DetailsIS,
                                Discount = b.Discount,
                                Pages = b.Pages,
                                Quantity = b.Quantity,
                                Published = b.Published,
                                Genre = g.GenreEN,
                                Author = a.Name,
                                Publisher = p.Name
                             }).ToList();
            return joined;
        }
        public List<BookDetailedListViewModel> getDetailedBook(int id) {
            var books = getBookList();
            List<BookDetailedListViewModel> detailedBook = books.Where(b => b.Id == id).ToList();
            if (detailedBook.Count == 0) {
                return null;
            }
            return detailedBook;
        }
        
        public List<BookDetailedListViewModel> getTop10Books() {
            var books = getBookList();
            List<BookDetailedListViewModel> topBooks = books.OrderByDescending(s => s.Grade).Select(x => x).Take(10).ToList();
            return topBooks;
        }

        public List<BookDetailedListViewModel> getNewestBooks(int n) {
            var books = getBookList();
            List<BookDetailedListViewModel> newestBooks = books.OrderByDescending(x => x.Id).Select(x => x).Take(n).ToList();
            return newestBooks;
        }

        public List<BookListViewModel> getBooksByGenre(string genre) {
            /* Sækja öll genre og finna rétta til að fá ID
            var genres = _genreRepo.GetAllGenre();
            int genreId = genre.id
            Senda id inní book repo til að finna allar bækur inní því genre
             var books = _bookRepo.GetAllBooks();
            where genreId == books.genreId*/
            return null;
        }
        public List<BookListViewModel> getBooksByAuthor(string author) {
            /* Sækja alla authors og finna rétta til að fá ID
            var authors = _authorRepo.GetAllAuthor();
            int authorId = author.id
            Senda id inní book repo til að finna allar bækur frá þeim author
             var books = _bookRepo.GetAllBooks();
            where authorId == books.authorId*/
            return null;
        }
        public List<BookListViewModel> getBooksWithSearch(string param) {
            /* Tekur param og ber saman við heiti eða author, hugsanlega genre? */
            return null;
        }
        public List<BookListViewModel> getBooksWithAdvSearch(string param1, string param2, string param3, string param4, string param5) {
            /* tekur marga param og leitar út frá því */
            return null;
        }
    }
}
