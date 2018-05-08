using System;
using System.Collections.Generic;
using System.Linq;
using TheBookCave.Data.EntityModels;
using TheBookCave.Models.ViewModels;
using TheBookCave.Repositories;

namespace TheBookCave.Services
{
    public class CartService {
        
        private BookRepo _bookRepo;
        private PromoCodesRepo _promoCodesRepo;
        private ConvertService _convertService;
        public CartService(){
            _bookRepo = new BookRepo();
            _promoCodesRepo = new PromoCodesRepo();
            _convertService = new ConvertService();
        }
        public List<ChartListViewModel> getBooksInCart(string cookie) {
            var books = new List<ChartListViewModel>();
            if(cookie == null || cookie == "") {
                return new List<ChartListViewModel>();
            }
            var cookieContent = getCookiecontent(cookie);
            var id = cookieContent[0];
            var quantity = cookieContent[1];
            for(var i = 0; i < id.Count; i++) {
                var book = _bookRepo.getBook(id[i]);
                if(book.Count  != 0) {
                    var eBook = _convertService.bookListViewToEntity(book);
                    books.Add(new ChartListViewModel { Book = eBook.First(), Quantity = quantity[i] });
                }
                else {
                    Console.WriteLine("Book with id '" + id[i] + "' was not found!");
                }
            }
            return books;
        }

        private List<List<int>> getCookiecontent(string cookie) {
            var unpacked = new List<List<int>>();
            var id = new List<int>();
            var quant = new List<int>();
            var cookieItems = cookie.Split('.');
            foreach(var ci in cookieItems) {
                var content = ci.Split('-').Select(Int32.Parse).ToList();
                Console.WriteLine(content[0]);
                Console.WriteLine(content[1]);
                id.Add(content[0]);
                quant.Add(content[1]);
            }
            unpacked.Add(id);
            unpacked.Add(quant);
            return unpacked;
        }
        private List<int> getCartBookQuantity(string cookie) {
            return cookie.Split('.').Select(Int32.Parse).ToList();
        }
       /* public bool validatePromoCode(int promoCode){
            var promoCodes = _promoCodesRepo.getAllPromoCode();
            /*if(promoCodes.Contains(promoCode)){
                return true;
            }
            else {
                return false;
            }
            return false;
        }*/
        public bool addBookToCart(int bid) {
            var book = _bookRepo.getBook(bid);
            if(book.Count == 0) {
                return false;
            }
            var convertBook = _convertService.bookListViewToEntity(book).First();
            var orderItem = new OrderItem { Book = convertBook, Quantity = 1, Discount = convertBook.Discount, OrderId = -1 };
            return true;
        }
        public void removeFromCart(int bid) {
            // AJAX?
        }
        public void updateQuantity(int bid, int quantity){
            // TODO
        }
    }
}