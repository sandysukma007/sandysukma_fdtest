using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Primitives;
using Moq;
using Xunit;
using sandysukma_fdtest.Controllers;
using sandysukma_fdtest.Data; // atau namespace context kamu
using sandysukma_fdtest.Models;

namespace sandysukma_fdtest.Tests
{
    public class BookControllerTests
    {
        [Fact]
        public async Task Create_ValidBook_RedirectsToIndex()
        {
            
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase(databaseName: "TestDb2")
                .Options;

            using var context = new AppDbContext(options);
            var controller = new BookController(context);

            
            var tempData = new TempDataDictionary(new DefaultHttpContext(), Mock.Of<ITempDataProvider>());
            controller.TempData = tempData;

            // Mock FormCollection
            var form = new FormCollection(new Dictionary<string, StringValues>
            {
                { "Title", "Test Book" },
                { "Author", "John Doe" },
                { "Description", "Desc" },
                { "Rating", "5" }
            });

            // Mock file
            var fileMock = new Mock<IFormFile>();
            var content = "Fake image content";
            var fileName = "test.jpg";
            var ms = new MemoryStream();
            var writer = new StreamWriter(ms);
            writer.Write(content);
            writer.Flush();
            ms.Position = 0;

            fileMock.Setup(_ => _.OpenReadStream()).Returns(ms);
            fileMock.Setup(_ => _.FileName).Returns(fileName);
            fileMock.Setup(_ => _.Length).Returns(ms.Length);
            var formFile = fileMock.Object;

            
            var result = await controller.Create(form, formFile);

            
            var redirect = Assert.IsType<RedirectToActionResult>(result);
            Assert.Equal("Index", redirect.ActionName);
        }

        [Fact]
        
        public async Task Edit_ValidBook_UpdatesSuccessfully()
        {
            
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase(databaseName: "EditBookTestDb")
                .Options;

            using var context = new AppDbContext(options);
            var book = new Book { Title = "Old Title", Author = "Author A", Rating = 3 };
            context.Books.Add(book);
            await context.SaveChangesAsync();

            var controller = new BookController(context);

            
            var tempData = new TempDataDictionary(new DefaultHttpContext(), Mock.Of<ITempDataProvider>());
            controller.TempData = tempData;

            var form = new FormCollection(new Dictionary<string, StringValues>
    {
        { "Title", "Updated Title" },
        { "Author", "Author A" },
        { "Description", "New Desc" },
        { "Rating", "5" }
    });

            
            var result = await controller.Edit(book.Id, form, null);

            
            var updatedBook = await context.Books.FindAsync(book.Id);
            Assert.Equal("Updated Title", updatedBook.Title);
            Assert.Equal(5, updatedBook.Rating);
        }
        [Fact]
        public async Task Delete_ExistingBook_RemovesBook()
        {
            
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase(databaseName: "DeleteBookTestDb")
                .Options;

            using var context = new AppDbContext(options);
            var book = new Book { Title = "Delete Me", Author = "Author B" };
            context.Books.Add(book);
            await context.SaveChangesAsync();

            var controller = new BookController(context);

            
            var tempData = new TempDataDictionary(new DefaultHttpContext(), Mock.Of<ITempDataProvider>());
            controller.TempData = tempData;

            
            var result = await controller.DeleteConfirmed(book.Id);

            
            var deleted = await context.Books.FindAsync(book.Id);
            Assert.Null(deleted);
        }

        [Fact]
        public async Task Get_Details_ReturnsBook()
        {
            
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase(databaseName: "DetailsBookTestDb")
                .Options;

            using var context = new AppDbContext(options);
            var book = new Book { Title = "Detail Book", Author = "Author C" };
            context.Books.Add(book);
            await context.SaveChangesAsync();

            var controller = new BookController(context);

            
            var tempData = new TempDataDictionary(new DefaultHttpContext(), Mock.Of<ITempDataProvider>());
            controller.TempData = tempData;

            
            var result = controller.Details(book.Id);


            
            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsType<Book>(viewResult.Model);
            Assert.Equal("Detail Book", model.Title);
        }

    }
}
