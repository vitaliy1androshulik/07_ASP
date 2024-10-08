﻿using AutoMapper;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Http;

namespace _03_SecondHomeWorkViewModel.Services
{
    public class CartService : ICartService
    {
        private readonly HttpContext httpContext;
        private readonly IMapper mapper;
        private readonly ShopDbContext context;

        public CartService(IHttpContextAccessor contextAccessor, IMapper mapper, ShopDbContext context)
        {
            httpContext = contextAccessor.HttpContext!;
            this.mapper = mapper;
            this.context = context;
        }

        public List<ProductDto> GetProducts()
        {
            var ids = httpContext.Session.Get<List<int>>("cart_items") ?? new();

            var products = context.Products.Include(x => x.Category).Where(x => ids.Contains(x.Id)).ToList();

            return mapper.Map<List<ProductDto>>(products);
        }

        public int GetCount()
        {
            // зчитуємо наявні елементи в корзині
            var ids = httpContext.Session.Get<List<int>>("cart_items");

            // якщо елементів немає, тоді створюємо порожній список
            if (ids == null) return 0;

            return ids.Count;
        }

        public void Add(int id)
        {
            // зчитуємо наявні елементи в корзині
            var ids = httpContext.Session.Get<List<int>>("cart_items");

            // якщо елементів немає, тоді створюємо порожній список
            if (ids == null) ids = new();
            // додаємо новий елемент
            ids.Add(id);

            // зберігаємо оновлений список корзини в cookies
            httpContext.Session.Set("cart_items", ids);
        }

        public void Remove(int id)
        {
            // зчитуємо наявні елементи в корзині
            var ids = httpContext.Session.Get<List<int>>("cart_items");

            // якщо елементів немає, тоді створюємо порожній список
            if (ids == null) return; // TODO: throw exception

            // додаємо новий елемент
            ids.Remove(id);

            // зберігаємо оновлений список корзини в cookies
            httpContext.Session.Set("cart_items", ids);
        }
    }
}
