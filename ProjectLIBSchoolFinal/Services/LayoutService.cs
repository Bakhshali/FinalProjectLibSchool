using LIBSchool_FinalProjectBackEnd.DAL;
using LIBSchool_FinalProjectBackEnd.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LIBSchool_FinalProjectBackEnd.Service
{
    public class LayoutService
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;

        public LayoutService(AppDbContext context,UserManager<AppUser>userManager )
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task<List<Setting>> GetDatas()
        {
            List<Setting> settings = await _context.Settings.ToListAsync();
            return settings;
        }

        public async Task<List<Category>> GetCategories()
        {
            List<Category> categories = await _context.Categories.ToListAsync();
            return categories;
        }

        public async Task<List<Course>> GetCourse()
        {
            List<Course> courses = await _context.Courses.ToListAsync();
            return courses;
        }

        public async Task<List<Branch>> GetBranches()
        {
            List<Branch> branches = await _context.Branches.ToListAsync();
            return branches;
        }

        public async Task<List<BasketItem>> GetBasket(string username)
        {
            List<BasketItem> basketItems = await _context.BasketItems.Include(c=>c.AppUser).Include(c=>c.Course.Discount).Where(c=>c.AppUser.UserName==username).ToListAsync();
            return basketItems;           
        }

        public async Task<List<WishlistItem>> GetWishlist(string username)
        {
            List<WishlistItem> wishlistItems = await _context.Wishlists.Include(c => c.AppUser).Include(c => c.Course.Discount).Where(c => c.AppUser.UserName == username).ToListAsync();
            return wishlistItems;
        }

        public async Task<List<Comment>> GetComment(string username)
        {
            List<Comment> comments = await _context.Comments.Include(c => c.AppUser).Where(c => c.AppUser.UserName == username).ToListAsync();
            return comments;
        }


        public async Task<List<Order>> GetOrder(string username)
        {
            List<Order> orders = await _context.Orders.Include(c => c.AppUser).Where(c => c.AppUser.UserName == username).ToListAsync();
            return orders;
        }

    }
}
